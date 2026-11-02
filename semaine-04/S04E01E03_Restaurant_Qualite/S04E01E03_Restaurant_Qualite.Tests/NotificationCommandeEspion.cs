using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Qualite.Tests
{
    class NotificationCommandeEspion:INotificationCommande
    {
        public int m_commande { get; set; }
        public string m_courriel { get; set; }
        public int nombreAppels { get; set; }
        public void NotifierCreation(int numeroComande,string courriel )
        {
            m_commande = numeroComande;
            m_courriel = courriel;
            nombreAppels++;
        }


    }
}
