using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Livraison
{
    public interface ICalculateurFraisLivraison
    {
        decimal Calculer(decimal sousTotal, double distanceKm);
    }
}
