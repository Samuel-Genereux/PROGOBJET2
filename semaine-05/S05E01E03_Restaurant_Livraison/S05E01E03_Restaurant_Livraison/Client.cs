namespace Restaurant.Livraison;

public class Client
{
    private string Statut { get; }
    private int PointsFidelite { get; }

    public Client(string statut, int pointsFidelite)
    {
        Statut = statut;
        PointsFidelite = pointsFidelite;
    }
    public bool estPrioritaire()
    {
        if(Statut == "Or" || PointsFidelite >=1000)
        {
            return true;
        }

        return false;
    }
}
