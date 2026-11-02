using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Qualite.Tests
{
    public class RestaurantTests
    {
        [Fact]
        public void Creer_AvecEspionManuel_NotifieAvecNumeroEtCourrielCorrects()
        {
            NotificationCommandeEspion espion = new NotificationCommandeEspion();
            ServiceCommandes service = new ServiceCommandes(espion);
            Client client = new Client("AAA");

            var commande = service.Creer(1, 100m, client);

            Assert.Equal(commande.Numero, espion.m_commande);
            Assert.Equal("test@example.com", espion.m_courriel);
            Assert.Equal(1, espion.nombreAppels);
        }

        [Fact]
        public void Creer_AvecMock_NotifieAvecNumeroEtCourrielCorrects()
        {
            var mockNotification = new Mock<INotificationCommande>();
            var service = new ServiceCommandes(mockNotification.Object);
            var client = new Client("AAA");

            var commande = service.Creer(1, 100m, client);

            mockNotification.Verify(
                n => n.NotifierCreation(
                    It.Is<int>(numero => numero == commande.Numero),
                    It.Is<string>(courriel => courriel == "AAA")),
                Times.Once);
        }
    }
}
