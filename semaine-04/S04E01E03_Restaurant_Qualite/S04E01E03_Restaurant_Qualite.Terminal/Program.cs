using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Restaurant.Qualite;


bool manuel = false;

foreach(string arguments in args)
{
    if(arguments == "--manuel")
    {
        manuel = true;
    }
}

if(manuel)
{
    AssemblageAvecConteneur(args);
}
else
{
    AssemblageManuel();
}

static void AssemblageManuel()
{
    Client client = new("client@exemple.ca");
    INotificationCommande notificationCommande = new NotificationConsole();
    ServiceCommandes service = new(notificationCommande);
    Commande commande = service.Creer(1001, 40m, client);


    Console.Out.WriteLine($"Total : {commande.SousTotal + commande.Taxe:C}");
}


static void AssemblageAvecConteneur(string[] args)
{
    HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

    builder.Services.AddScoped<Client>();
    builder.Services.AddScoped<INotificationCommande, NotificationConsole>();
    builder.Services.AddScoped<Commande>();

    using var host = builder.Build();

    using (var scope = host.Services.CreateScope())
    {
        ServiceCommandes creerCommande = scope.ServiceProvider.GetRequiredService<ServiceCommandes>();
        creerCommande.Creer(1001,40m,new Client("client@exemple.ca"));
    }
    
}