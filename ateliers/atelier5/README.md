# Héritage

Cet atelier vous permettra d'appliquer les notions d'héritage vues en classe et de pratiquer la syntaxe C# pour la
dérivation de classes.

Il d'une évaluation sommative notée sur 10.

## Mise en situation

Dans le cadre du dernier atelier, vous avez modélisé et implémenté un mini logiciel simulant un système solaire. Il a du
paraitre évident à plusieurs que la plupart des objets présents dans notre système solaire partageaient des similitudes
importantes.

Maintenant que vous connaissez les notions d'héritage, une solution plus élégante devrait s'offrir à vous.

Vous devez donc modifier votre précédent atelier afin d'incorporer la notion d'héritage dans votre système.

### Nouvelle données membres

- Les soleils et les planètes possèdent un cœur exprimé par son rayon
- Les soleils possèdent une couronne exprimée par son rayon

### Nouvelle classe

Galaxy

- Un nom
- Un type
- Des systèmes solaires

### Structure interne

Vous devez conservez deux structures internes sur votre univers:

- Une arborescence permettant de naviguer l'univers par système solaire, planètes, etc.
- Un index plat contenant tous les objets en ordre de création

### Nouvelle méthode

- Afficher chaque objets un par un à partir de l'index en utilisant le format
  suivant:`NOM: LuneSoleilOuPlanete: SUPERFICIE=nombre: COEUR=nombre:
  COURONNE=nombre`

> NOTE: Le cœur et la couronne devrait seulement être affichés au
> besoin. *winkwink*
