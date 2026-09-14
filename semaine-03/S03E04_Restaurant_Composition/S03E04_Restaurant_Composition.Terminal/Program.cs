using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;                 // J'ai du rechercher en ligne quoi mettre comme using, car je ne pouvais pas juste
                                                    // utiliser IHost comme dans les diapo, j'avais une erreur, il n'était pas écrit dans 
                                                    // les diapos.
using Restaurant.Application;
using Restaurant.Infrastructure;

bool modeManuel = false;

foreach (string argument in args)
{
    if (argument == "--manuel")
    {
        modeManuel = true;
    }
}

if (modeManuel)
{
    AssemblageManuel();
}
else
{
    AssemblageAvecCOnteneur(args);
}

static void AssemblageManuel()
{
    IDepotCommandes depotCommandes = new DepotCommandesMemoire();
    INotificationCommande notificationCommande = new NotificationConsole();

    CreerCommande creerCommande = new CreerCommande(depotCommandes, notificationCommande);

    creerCommande.Executer(1);
}

static void AssemblageAvecCOnteneur(string[] args)
{
    HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

    builder.Services.AddScoped<IDepotCommandes, DepotCommandesMemoire>();
    builder.Services.AddScoped<INotificationCommande, NotificationConsole>();
    builder.Services.AddScoped<CreerCommande>();

    IHost host = builder.Build();

    IServiceScope scope = host.Services.CreateScope();

    CreerCommande creerCommande = scope.ServiceProvider.GetRequiredService<CreerCommande>();

    creerCommande.Executer(1);
}