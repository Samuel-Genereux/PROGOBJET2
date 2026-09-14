using Restaurant.Application;
using Restaurant.Domaine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Tests
{
    public class DepotCommandesEspion : IDepotCommandes
    {
        public Commande CommandeAjoute;

        public void Ajouter(Commande commande)
        {
            CommandeAjoute = commande;
        }
    }
}
