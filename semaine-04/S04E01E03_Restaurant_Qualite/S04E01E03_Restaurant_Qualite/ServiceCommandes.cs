namespace Restaurant.Qualite;

public class ServiceCommandes
{
    private Commande? m_derniereCommande;
    private readonly INotificationCommande m_notificationCommande;
    public ServiceCommandes(INotificationCommande notificationCommande)
    {
        if (notificationCommande is null)
            throw new ArgumentNullException("INotificationCommande can't be null");

        m_notificationCommande = notificationCommande;
    }
    public Commande Creer(int numero, decimal sousTotal, Client client)
    {
        decimal taxe = sousTotal * 0.14975m;
        Commande commande = new(numero, sousTotal, taxe, client);
        m_derniereCommande = commande;

        m_notificationCommande.NotifierCreation(
            commande.Numero,
            commande.Client.Profil.Coordonnees.Courriel);

        return commande;
    }

    public Commande? ObtenirDerniereCommande()
    {
        return m_derniereCommande;
    }
}
