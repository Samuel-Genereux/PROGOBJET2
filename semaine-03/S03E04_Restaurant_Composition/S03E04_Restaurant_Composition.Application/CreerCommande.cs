using Restaurant.Domaine;

namespace Restaurant.Application;

public sealed class CreerCommande
{
    private  IDepotCommandes m_depotCommandes;
    private  INotificationCommande m_notificationCommande;

    public CreerCommande(IDepotCommandes depotCommandes, INotificationCommande notificationCommande)
    {
        if (depotCommandes is null)
            throw new ArgumentNullException("depotCommandes can't be null");
        if (notificationCommande is null)
            throw new ArgumentNullException("notificationCommande can't be null");

        m_depotCommandes = depotCommandes;
        m_notificationCommande = notificationCommande;
    }
    public void Executer(int numeroCommande)
    {
        Commande commande = new(numeroCommande);
        m_depotCommandes.Ajouter(commande);
        m_notificationCommande.NotifierCreation(numeroCommande);
    }
}
