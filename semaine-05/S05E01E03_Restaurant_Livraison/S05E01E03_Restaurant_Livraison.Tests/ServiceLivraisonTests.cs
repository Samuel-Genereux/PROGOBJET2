using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Livraison.Tests
{
    public class ServiceLivraisonTests
    {
        [Theory]
        [InlineData("Or", 0, true)] 
        [InlineData("Argent", 500, false)]  
        [InlineData("Bronze", 999, false)] 
        public void EstPrioritaire_RetourneResultatAttendu(string statut, int points, bool resultatAttendu)
        {
            Client client = new Client(statut, points);

            bool resultat = client.estPrioritaire();

            Assert.Equal(resultatAttendu, resultat);
        }
    }
}
