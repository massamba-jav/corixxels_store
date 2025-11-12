# GestionMagasin - Exemple Personnel : Corrixells store

Application de gestion de magasin réalisée en C# (console + WinForms). 
Elle permet d'ajouter,modifer,supprimer, vendre, lister des produits et visualiser le chiffre d'affaires.
Elle permet de modifer ,supprimer les ventes et afficher l'historique des ventes effectuées.

## Fonctionnalités

# Fonctionnlaités Console

- Afficher le stock des produits
- Vente de produits avec mise à jour automatique du stock
- Historique des ventes effectués
- Liste des produits en Alerte (stock faible)
- Afficher Chiffre d'affaires cumulé

# Foncrionalités WinForms

- Ajouter, modifier, supprimer des produits
- Vente de produits avec mise à jour automatique du stock
- modifier, supprimer des ventes
- Exportation en CSV
- Afficher le stock des produits
- Historique des ventes effectués
- Liste des produits en Alerte (stock faible)
- Afficher Chiffre d'affaires cumulé

## Installation

1. Dézipper le dossier : CorrixellsStore.zip
2. Ouvrir le projet dans Visual Studio 
4. Inspecter le code source si desiré 
3. Compiler puis Exécuter le projet 
4. Intéragir avec l'application
5. Si vous ne disposez pas de Visual Studio, vous pouvez lancer le fichier exécutable dans le dossier `CorrixellsStore/bin/Debug/CorrixellsStore.exe`

## Utilisation

- Dans la console, vous pouvez interagir avec l'application en utilisant les commandes suivantes :
 `1` : Afficher le stock des produits
 `2` : Ajouter un produit(à partir du menu WinForms)
 `3` : Vendre un produit
 `4` : Afficher l'historique des ventes
 `5` : Afficher les produits en alerte (stock faible)
 `6` : Afficher le chiffre d'affaires 
 `7` : Lancer le menu WinForms  
 `0` : Quitter l'application
 NB : En cas de saisie incorrecte, l'application vous demandera de saisir à nouveau une commande valide.

- Dans l'application winforms , vous verez à gauche de l'interface le menu et à droite le contenu,
  le contenu changera en fonction de l'élément sélectionné dans le menu voici les options disponibles :
`Accueil `: Pour retourner à l'accueil de l'application
`Afficher Stock`: Pour afficher le stock des produits sous forme de tableau
`Chiffre d'Affaires`: Pour afficher le chiffre d'affaires actuel du magasin
`Produit en Alerte`: Pour afficher les produits en alerte sous forme de tableau
`Historique des Ventes`: Pour afficher les ventes effectués sous forme de tableau
`Traitements Produits`: Affichera les options de gestion des produits en focntion du bouton sélectionné
  - `Ajouter Produit`: Pour ajouter un produit au stock
  - `Modifier Produit`: Pour modifier un produit existant
  - `Supprimer Produit`: Pour supprimer un produit du stock
`Traitements Ventes`: Affichera les options de gestion des ventess en focntion du bouton sélectionné
  - `Vendre Produit`: Pour vendre un produit 
  - `Modifier Vente`: Pour modifier une vente existante (uniquement la date par soucis de cohérence)
  - `Supprimer Vente`: Pour supprimer une vente
  
## Structure du projet

- `Program.cs` : point d'entrée
- `Properties/`: contient les propriétés du projet parmi lesquelles les photos utilisées par l'interface graphique 
- `Back/` : contient tout les fichiers utilisés pour la partie console
- `Formulaires/` : contient tous les éléments de l'interface graphique
- `Enregistrement/` : contient les configuration statiques pour les fichiers json et l'exportation CSV

 ## Auteur

Massamba Diagne – [LinkedIn](https://www.linkedin.com/in/massamba-diagne-3422542aa/)

