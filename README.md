
# Documentation GestionOffreMedocs

## Description Générale
GestionOffreMedocs est une application Windows Forms développée en C#
qui permet la gestion des médicaments, leurs familles et les offres associées.
L'application utilise Entity Framework pour la gestion de la base de données (gsbMedicamentEntities).

## Structure de l'Application

### 1. Interface Principale (Form1)
- Point d'entrée de l'application
- Interface MDI (Multiple Document Interface) permettant d'ouvrir plusieurs fenêtres
- Gère la connexion à la base de données via `gsbMedicamentEntities`

### 2. Modules Principaux

#### Gestion des Médicaments
- **AjoutMedoc** : Formulaire pour ajouter de nouveaux médicaments
- **GestionMedoc** : Interface de gestion des médicaments existants

#### Gestion des Familles
- **AjoutFamille** : Formulaire pour créer de nouvelles familles de médicaments
- **GestionFamille** : Interface pour gérer les familles existantes

#### Gestion des Offres
- **FormOffre** : Gestion des offres de médicaments
  - Permet de sélectionner une famille de médicaments
  - Affiche les médicaments associés à la famille sélectionnée

### 3. Modèle de Données
L'application utilise plusieurs entités principales :
- `medicament` : Informations sur les médicaments
- `famille` : Catégorisation des médicaments
- `medecin` : Informations sur les médecins
- `offrir` : Gestion des offres

## Fonctionnalités

### Menu Principal
- Ajout de médicaments
- Ajout de familles de médicaments
- Gestion des médicaments existants
- Gestion des familles existantes
- Consultation des offres de médicaments

### Gestion des Offres
- Filtrage des médicaments par famille
- Interface intuitive avec des contrôles de visibilité
- Sélection en cascade (famille → médicaments)

## Architecture Technique
- Développé en C# .NET
- Interface utilisateur : Windows Forms
- Base de données : Entity Framework
- Structure MDI pour une navigation fluide entre les formulaires
- Utilisation de LINQ pour les requêtes de données
