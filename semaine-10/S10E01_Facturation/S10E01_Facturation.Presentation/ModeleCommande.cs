using Commandes.Application;

namespace Commandes.Presentation;

// Adaptateur du modèle manipulé par la présentation; aucune règle métier ici.
// Usage synchrone, sur un seul fil d'exécution.
public sealed class ModeleCommande
{
    private readonly ServiceCommandes m_commandes;
    private readonly ServiceFacturation m_facturation;
    private readonly IJournalIncidents m_journal;
    private readonly List<IObservateurCommande> m_observateurs = new();

    public ModeleCommande(ServiceCommandes commandes, ServiceFacturation facturation,
        IJournalIncidents journal)
    {
        ArgumentNullException.ThrowIfNull(commandes);
        ArgumentNullException.ThrowIfNull(facturation);
        ArgumentNullException.ThrowIfNull(journal);
        m_commandes = commandes;
        m_facturation = facturation;
        m_journal = journal;
    }

    public EtatCommandeDto Consulter()
    {
        return new EtatCommandeDto(m_commandes.Consulter(), m_facturation.Consulter());
    }

    public IReadOnlyCollection<ProduitDto> ConsulterProduits()
    {
        return m_commandes.ConsulterProduits();
    }
  
    // À implanter : contrat détaillé dans l'énoncé.
    public IDisposable Attacher(IObservateurCommande observateur)
    {
        ArgumentNullException.ThrowIfNull(observateur);
      
        m_observateurs.Add(observateur);
        return new AbonnementCommande(m_observateurs, observateur);
    }

    public Result<CommandeDto> Nouvelle(int numero)
    {
        Result<CommandeDto> resultat = m_commandes.Creer(numero);
        if (resultat.EstSucces)
        {
            Publier();
        }

        return resultat;
    }

    public Result<CommandeDto> Ajouter(int numeroProduit, int quantite)
    {
        Result<CommandeDto> resultat = m_commandes.AjouterProduit(numeroProduit, quantite);
        if (resultat.EstSucces)
        {
            Publier();
        }

        return resultat;
    }

    public Result<CommandeDto> Enregistrer()
    {
        Result<CommandeDto> resultat = m_commandes.Enregistrer();
        if (resultat.EstSucces)
        {
            Publier();
        }

        return resultat;
    }

    public void Publier()
    {
        EtatCommandeDto etat = Consulter();
        IObservateurCommande[] observateurs = m_observateurs.ToArray();
        foreach (IObservateurCommande observateur in observateurs)
        {
            observateur.Actualiser(etat);
        }
    }
}
