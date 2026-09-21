using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Livraison;

public class CalculateurFraisPrioritaire : ICalculateurFraisLivraison
{
    public decimal Calculer(decimal sousTotal, double distanceKm)
    {
        return 2m + (decimal)distanceKm;
    }
}
