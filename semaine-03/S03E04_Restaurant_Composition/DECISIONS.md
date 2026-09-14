# Décisions

## Cycle de vie choisi

J'ai mis AddScoped pour IDepotCommandes, INotificationCommande et CreerCommande.

J'ai choisi Scoped parce que chaque fois qu'on crée une commande, ça compte comme
une seule opération. Scoped garde les mêmes objets pendant cette opération, mais
va en recréer des nouveaux la prochaine fois.

Singleton aurait gardé les mêmes objets pour tout le programme, ça n'avait pas
vraiment rapport ici. Transient lui aurait recréé des objets à chaque fois, ce qui
est pas vraiment bien pour le cas ici.
## Historique Git

Collez ici la sortie de `git log --oneline --graph --decorate --all`.
