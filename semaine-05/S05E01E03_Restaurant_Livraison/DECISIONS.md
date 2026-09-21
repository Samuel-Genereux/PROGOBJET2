# Décisions

## Exercice 1 — Tell, Don't Ask

Tell, don't ask dit qu'il faut pas faire plusieurs get et prendre des données de la classe pour faire notre algorithme hors de notre classe,
il faut demander directement a la classe son résultat

## Exercice 2 — OCP, LSP, ISP et composition
L'interface IcalculateurFraisLivraison avait un méthode ObtenirDescription() qui ne lui servait pas et n'avait pas rapport dans cette classe,
selon le principe ISP, il faut pas mélanger les utlités d'une interface, cette méthode appartient au terminal. Pour le OCP, nous avons une preuve de 
ce principe dans notre code, on as ajoutés CalculateurFraisPrioritaire sans toucher au autres classes liés, donc notre code respecte ce principe.
Pour le LSP, nous passons ICalculateurFraisLivraison a toute les sous-classes, sans causer de problèmes. Nous passons les dépendances via le constructeur,
donc nous avons pas besoin  de faire hériter nos classes entres elles.

## Exercice 3 — Strategy

À compléter.
