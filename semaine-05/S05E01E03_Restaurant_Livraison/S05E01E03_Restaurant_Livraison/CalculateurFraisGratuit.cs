namespace Restaurant.Livraison;

public class CalculateurFraisGratuit : ICalculateurFraisLivraison
{
    private readonly ICalculateurFraisLivraison _calculateurFrais;

    public CalculateurFraisGratuit(ICalculateurFraisLivraison calculateurStandard)
    {
        if(calculateurStandard is null)
            throw new ArgumentNullException("Interface can't be null");

        _calculateurFrais = calculateurStandard;
    }

    public decimal Calculer(decimal sousTotal, double distanceKm)
    {
        if (sousTotal >= 50m)
        {
            return 0m;
        }
        else
        {
            return _calculateurFrais.Calculer(sousTotal, distanceKm);
        }
    }
}
