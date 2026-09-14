using Restaurant.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Tests
{
    public class NotificationCommandeEspion : INotificationCommande
    {
        public int numeroNotifie;

        public void NotifierCreation(int numeroCommande)
        {
            numeroNotifie = numeroCommande;
        }
    }
}
