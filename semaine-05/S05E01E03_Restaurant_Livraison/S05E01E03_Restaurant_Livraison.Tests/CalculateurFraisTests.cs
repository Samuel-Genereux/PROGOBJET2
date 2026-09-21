using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Livraison.Tests
{
    public class CalculateurFraisTests
    {
        public static TheoryData<ICalculateurFraisLivraison, decimal, double, decimal> Calculateurs()
        {
            ICalculateurFraisLivraison standard = new CalculateurFraisStandard();
            ICalculateurFraisLivraison gratuit = new CalculateurFraisGratuit(standard);
            ICalculateurFraisLivraison prioritaire = new CalculateurFraisPrioritaire();

            TheoryData<ICalculateurFraisLivraison, decimal, double, decimal> cas = new TheoryData<ICalculateurFraisLivraison, decimal, double, decimal>();

            cas.Add(standard, 20m, 4.0, 7m);
            cas.Add(gratuit, 20m, 4.0, 7m);
            cas.Add(gratuit, 50m, 4.0, 0m);
            cas.Add(prioritaire, 20m, 4.0, 6m);

            return cas;
        }

        [Theory]
        [MemberData("Calculateurs")]
        public void Calculer_RetourneFraisAttendus(ICalculateurFraisLivraison calculateur, decimal sousTotal, double distanceKm, decimal fraisAttendus)
        {
            decimal frais = calculateur.Calculer(sousTotal, distanceKm);

            Assert.Equal(fraisAttendus, frais);
        }
    }
}
