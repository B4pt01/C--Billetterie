# Application de Billetterie pour Événements

Cette application console permet de gérer des événements, des clients et des réservations de billets pour différents types de places (standard, gold, VIP). Elle permet de créer des événements, des clients et de gérer la réservation de billets tout en vérifiant la disponibilité des places.

## Fonctionnalités principales

1. **Gestion des Clients** : Créer un client avec ses informations (nom, prénom, adresse, âge, numéro de téléphone).
2. **Gestion des Événements** : Créer des événements avec un lieu, une date et un nombre de places disponibles.
3. **Réservation de Billets** : Les clients peuvent réserver des billets pour les événements selon le type de place (standard, gold, VIP).
4. **Affichage des Billets pour un Événement** : Voir la liste des billets réservés pour un événement.
5. **Affichage des Événements** : Voir la liste des événements créé
6. **Gestion des erreurs** : Si un élément (client ou événement) n'est pas trouvé, une exception personnalisée `NotFoundException` est levée et traitée.

## Installation et Lancement

### Prérequis

- **.NET SDK** : Assurez-vous d'avoir le SDK .NET installé. Vous pouvez le télécharger à partir du site officiel : [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

### Étapes d'installation

1.  **Cloner le dépôt**

    Clonez ce projet depuis le dépôt GitHub ou téléchargez-le manuellement :

    git clone https://github.com/ton-compte/tpbilletterie.git

2.  **Accéder au dossier du projet**

    Allez dans le dossier cloné :

    `cd TpBilletterie`

3.  **Restaurer les dépendances (si nécessaire)**

    Si des dépendances externes sont utilisées, vous pouvez exécuter cette commande pour les restaurer :

    `dotnet restore`

4.  **Exécuter le projet**

    Pour exécuter le projet, utilisez la commande suivante dans le répertoire principal :

    `dotnet run`

#### Organisation du Projet

**L'application est organisée de la manière suivante :**

```plaintext
TpBilletterie/
│
├── Classes/
│   ├── Adresse.cs         # Classe Adresse (rue, ville)
│   ├── Lieu.cs            # Classe Lieu (hérite d'Adresse, capacité)
│   ├── Client.cs          # Classe Client (nom, prénom, adresse, etc.)
│   ├── Evenement.cs       # Classe Evenement (nom, lieu, date, etc.)
│   ├── Billet.cs          # Classe Billet (numéro de place, client, type de place)
│
├── Exceptions/
│   └── NotFoundException.cs  # Exception personnalisée si un élément n'est pas trouvé
│
├── Program.cs            # Point d'entrée avec l'IHM console
├── C#-Billetterie.sln     # Fichier solution .NET
└── README.md             # Ce fichier explicatif
```

##### Fonctionnalités de l'IHM

**L'interface est simple et en mode console. Vous pourrez :**

- Créer un client : En entrant les informations de base (nom, prénom, adresse, âge, etc.).
- Créer un événement : En fournissant le nom de l'événement, la capacité du lieu et la date.
- Réserver un billet : Un client peut réserver un billet pour un événement s'il reste des places disponibles.
- Afficher les billets d'un événement : Voir la liste des billets pour un événement donné.

**Exemple d'utilisation**

1. Lancer l'application : `dotnet run`

2. Créer un client :
   - Entrez les informations du client.
3. Créer un événement :
   - Entrez les détails de l'événement (nom, lieu, capacité, etc.).
4. Réserver un billet :
   - Sélectionnez un client et un événement pour réserver un billet.
5. Afficher les billets d'un événement :
   - Vous pourrez voir la liste des clients ayant réservé pour un événement donné.

**Gestion des erreurs**

Si vous essayez d'accéder à un client ou à un événement inexistant, l'application affichera une erreur gérée grâce à l'exception `NotFoundException`.
