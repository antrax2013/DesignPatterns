# Les design patterns
L'objectif de ce repository est de proposer une implémentation modernisée des différents design patterns. 
Les design patterns sont un ensemble de façon d'implémenter une soulution validée et reconnue comment étant la bonne approche 
pour répondre à un besoin classique et récurrent du développement objet.

Il y a 3 catégories de design patterns :
- les patterns de création
- les patterns de comportementaux
- les patterns de structure


## 1. Création
L'objectif de cette catégorie est d'instancier pour nous des objets.

### 1.1. Singleton
Le singleton est un pattern dont l'objectif est de n'avoir qu'une seule et même instance d'un objet et qu'il gère lui même son cycle de vie. Ce pattern est décrié voir obsolète pour plusieurs raisons.
- il ne respecte pas le principe SRP de SOLID (cf. [repos SOLID](https://github.com/antrax2013/Solid))
- avec les containers natifs de dépendances, on peut spécifier que l'instance est un singleton et donc autant passer par là que de réinventer la roue.

### 1.2. Factory
La fabrique est un pattern dont l'objectif est de créer, pour nous, en fonction d'une logique une instance d'une classe.