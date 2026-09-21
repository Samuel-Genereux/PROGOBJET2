namespace Restaurant.Livraison;

public class CalculateurFraisStandard: ICalculateurFraisLivraison
{
        public decimal Calculer(decimal sousTotal, double distanceKm)
        {
            return 4m + (decimal)distanceKm * 0.75m;
        }

}
