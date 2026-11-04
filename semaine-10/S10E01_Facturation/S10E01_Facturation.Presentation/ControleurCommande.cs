using Commandes.Application;

namespace Commandes.Presentation;

public sealed class ControleurCommande : IDisposable
{
    private readonly ModeleCommande m_modele;
    private readonly IVueCommande m_vue;
    private readonly IJournalIncidents m_journal;
    private IDisposable m_abonnement;

    public ControleurCommande(ModeleCommande modele, IVueCommande vue, IJournalIncidents journal)
    {
        ArgumentNullException.ThrowIfNull(modele);
        ArgumentNullException.ThrowIfNull(vue);
        ArgumentNullException.ThrowIfNull(journal);
        // À compléter : collaborateurs, abonnement et affichage initial.
        m_modele = modele;
        m_vue = vue;
        m_journal = journal;
        m_vue.Actualiser(m_modele.Consulter());
        m_abonnement = m_modele.Attacher(m_vue);
    }

    public void Nouvelle(int numero)
    {
        Result<CommandeDto> resultat = m_modele.Nouvelle(numero);
        if (!resultat.EstSucces)
        {
            m_vue.PresenterRefus(resultat.MessageErreur);
        }
    }

    public void Ajouter(int numeroProduit, int quantite)
    {
        Result<CommandeDto> resultat = m_modele.Ajouter(numeroProduit, quantite);
        if (!resultat.EstSucces)
        {
            m_vue.PresenterRefus(resultat.MessageErreur);
        }
    }

    public void Enregistrer()
    {
        Result<CommandeDto> resultat = m_modele.Enregistrer();
        if (!resultat.EstSucces)
        {
            m_vue.PresenterRefus(resultat.MessageErreur);
        }
    }

    public void Dispose()
    {
        if (m_abonnement is not null)
        {
            m_abonnement.Dispose();
            m_abonnement = null;
        }
    }
}
