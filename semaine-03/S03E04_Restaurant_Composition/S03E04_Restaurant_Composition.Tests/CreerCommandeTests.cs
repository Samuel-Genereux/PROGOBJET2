using Restaurant.Application;
using Restaurant.Tests;
using System;
using System.Collections.Generic;
using System.Text;

public class CreerCommandeTests
{
    [Fact]
    public void Executer_NumeroValide_AjoutEtNotificationValide()
    {
        // Arranger
        DepotCommandesEspion depotCommande = new DepotCommandesEspion();
        NotificationCommandeEspion notificationCommande = new NotificationCommandeEspion();
        CreerCommande creerCommande = new(depotCommande, notificationCommande);

        // Agir
        creerCommande.Executer(42);

        // Auditer
        Assert.Equal(42, depotCommande.CommandeAjoute.Numero);
        Assert.Equal(42, notificationCommande.numeroNotifie);
    }
}
