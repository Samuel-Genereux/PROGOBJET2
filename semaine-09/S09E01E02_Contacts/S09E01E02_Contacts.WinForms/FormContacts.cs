using System.Text.Json;
using Contacts.Application;

namespace Contacts.WinForms;

public partial class FormContacts : Form
{
    private readonly CreerContact? m_creation;
    private readonly ConsulterContacts? m_consultation;
    private readonly IJournalIncidents? m_journal;

    public FormContacts()
    {
        InitializeComponent();
        dgvContacts.AutoGenerateColumns = false;
    }

    public FormContacts(CreerContact creation, ConsulterContacts consultation, IJournalIncidents journal) : this()
    {
        ArgumentNullException.ThrowIfNull(creation);
        ArgumentNullException.ThrowIfNull(consultation);
        ArgumentNullException.ThrowIfNull(journal);
        m_creation = creation;
        m_consultation = consultation;
        m_journal = journal;
    }

    private CreerContact Creation
    {
        get
        {
            if (m_creation == null)
            {
                throw new InvalidOperationException("Le lancement doit injecter le cas d'utilisation.");
            }

            return m_creation;
        }
    }

    private ConsulterContacts Consultation
    {
        get
        {
            if (m_consultation == null)
            {
                throw new InvalidOperationException("Le lancement doit injecter la consultation.");
            }

            return m_consultation;
        }
    }

    private void FormContacts_Load(object? sender, EventArgs e)
    {
        // E2-L : charger tous les contacts au début de l'exercice 2. Rien à ajouter en E1.
        AfficherContacts(Consultation.ObtenirTous());
    }

    private void bCreer_Click(object? sender, EventArgs e)
    {
        try
        {
            // E1-C : construire DemandeCreationContact, appeler Creation.Executer et traiter le résultat.
            DemandeCreationContact demande = new DemandeCreationContact(tbNom.Text, tbCourriel.Text);
            Result<ContactDto> resultat = Creation.Executer(demande);

            if (!resultat.EstSucces)
            {
                AfficherMessage(resultat.MessageErreur);


            }
            AfficherMessage("Compte créé" + resultat.Valeur.Nom);


            // E2-C : après succès, effacer la saisie, vider la recherche et actualiser la liste.
            string nom = resultat.Valeur.Nom;
            EffacerSaisie();
            tbMotClef.Text = "";
            AfficherMessage("Contact créé: " + nom);
            ActualiserListe();
        }
        catch (UnauthorizedAccessException exception)
        {
            SignalerIncident("créer contact", exception);
        }
        catch (JsonException exception)
        {
            SignalerIncident("créer contact", exception);
        }
        catch (InvalidDataException exception)
        {
            SignalerIncident("créer contact", exception);
        }
        catch (IOException exception)
        {
            SignalerIncident("créer contact", exception);
        }
    }

    private void bEffacer_Click(object? sender, EventArgs e)
    {
        EffacerSaisie();
        AfficherMessage(string.Empty);
    }

    private void EffacerSaisie()
    {
        // E1-E : effacer les deux champs et redonner le focus au nom.
        tbNom.Text = "";
        tbCourriel.Text = "";

        tbNom.Focus();

    }

    private void AfficherMessage(string message)
    {
        // E1-M : afficher message dans lEtat.
        lEtat.Text = message;
    }

    private void bRechercher_Click(object? sender, EventArgs e)
    {
        try
        {
            // E2-S : appeler Consultation.Rechercher avec le mot-clef puis AfficherContacts.
            AfficherContacts(Consultation.Rechercher(tbMotClef.Text));
        }
        catch (UnauthorizedAccessException exception)
        {
            SignalerIncident("rechercher contacts", exception);
        }
        catch (JsonException exception)
        {
            SignalerIncident("rechercher contacts", exception);
        }
        catch (InvalidDataException exception)
        {
            SignalerIncident("rechercher contacts", exception);
        }
        catch (IOException exception)
        {
            SignalerIncident("rechercher contacts", exception);
        }
    }

    private void bTous_Click(object? sender, EventArgs e)
    {
        try
        {
            // E2-T : vider tbMotClef puis afficher Consultation.ObtenirTous().
            tbMotClef.Text = "";
            AfficherContacts(Consultation.ObtenirTous());
        }
        catch (UnauthorizedAccessException exception)
        {
            SignalerIncident("lister contacts", exception);
        }
        catch (JsonException exception)
        {
            SignalerIncident("lister contacts", exception);
        }
        catch (InvalidDataException exception)
        {
            SignalerIncident("lister contacts", exception);
        }
        catch (IOException exception)
        {
            SignalerIncident("lister contacts", exception);
        }
    }

    private void AfficherContacts(IReadOnlyCollection<ContactDto> contacts)
    {
        // E2-A : alimenter dgvContacts depuis les DTO, afficher le nombre de résultats dans lNombre.

        dgvContacts.DataSource = contacts.ToArray();

        if (contacts.Count == 0)
        {
            lNombre.Text = "Aucun résultat";
        }
        else
        {
            lNombre.Text = contacts.Count + " Contact(s)";
        }
    }

    private void SignalerIncident(string operation, Exception exception)
    {
        m_journal?.Consigner(operation, exception);
        AfficherMessage("Opération impossible pour le moment. Réessayez après correction de l'incident.");
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void lTitre_Click(object sender, EventArgs e)
    {

    }

    private void bCreer_Click_1(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void ActualiserListe()
    {
        AfficherContacts(Consultation.ObtenirTous());
    }
}
