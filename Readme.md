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

### 1.3. Prototype
Le prototype est un pattern dont l'objectif est de créer des nouveaux objets à partir d'objet existant sans les rendre dépendants de leur classe source.
Pour moi, le clone est un clone "profond" (deep clone) où chacune de ses propriétes est une autre différente de la propritété mère dont elle est issue.

### 1.4. Builder
Le builder est un pattern dont l'objectif est de créer de nouveaux objets. Il est doté d'un directeur qui va réaliser étape par étape la construction de l'objet en fonction d'un "mode opératoire" que l'on va lui fournir.
Habituellement, on aime chainer les étapes mais ce n'est pas obligatoire.

## 2. Structure

### 2.1. Adapter
L'adaptater, ou adaptateur en français, est un pattern dont l'objectif est de transformer un objet en un autre pour que celui-ci soit compatbile avec les besoins de ton projet. 

### 2.2. Bridge
Le bridge, ou pont, est un pattern dont l'objectif est de représenter des variantes. L'idée étant de séparer des concepts différents, mais complémentaires, et de les combiner dynamiquement, permettant ainsi de réprésenter les différentes vairantes.

### 2.3. Composite
Le composite est un pattern dont l'objectif est de répresenter une hiérarchie d'objets. L'idée étant de traiter de la même façon un objet simple et un objet complexe composé d'autres objets.

# Webographie
[refactoring.guru](https://refactoring.guru/design-patterns)