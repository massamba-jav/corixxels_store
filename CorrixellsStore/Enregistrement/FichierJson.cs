using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using CorrixellsStore.Back;
using Newtonsoft.Json;

namespace CorrixellsStore
{
    //Classe FichierJson
    internal class FichierJson
    {
        // Chemin des fichiers JSON (pour eviter les erreurs de chemin)
        public static string Produit = "produit.json";
        public static string Vente = "vente.json";

        // Méthode pour créer les fichiers JSON (commentée pour éviter l'écrasement des données existantes)
        public static void  createfichier()
        {
            //Créer le fichier des produits
            //---File.Create(FichierJson.Produit);

            // Créer le fichier des ventes
            //---File.Create(FichierJson.Vente);

            //Créer la liste de toutes les ventes
            //---List<Vente> listeVente = new List<Vente>();

            //Créer la liste de tous les produits
            //---List<Produit> listeProduit = new List<Produit>();

            //Créer le format json de la liste des ventes
            //---string json = JsonConvert.SerializeObject(listeVente,Formatting.Indented);

            //Créer le format json de la liste des produits
            //---string json2 = JsonConvert.SerializeObject(listeProduit,Formatting.Indented);

            //Sauvegarde de la liste des ventes dans le fichier 
            //---File.WriteAllText($"{FichierJson.Vente}", json);

            //Sauvegarde de la liste des produits dans le fichier
            //---File.WriteAllText($"{FichierJson.Produit}", json2);

            
        }

        // Méthode pour récupérer la liste des ventes depuis le fichier JSON
        public static List<Vente> recupererlistevente()
        {
            string json = File.ReadAllText(FichierJson.Vente);
            return JsonConvert.DeserializeObject<List<Vente>>(json);
        }

        // Méthode pour enregistrer la liste des ventes éventuellement modifiée 
        public static void enregistrerlistevente(List<Vente> listevente)
        {
            string json2 = JsonConvert.SerializeObject(listevente, Formatting.Indented);
            File.WriteAllText($"{FichierJson.Vente}", json2);
            Console.WriteLine("Vente ajoutée avec succés !");
        }

        // Méthode pour récupérer la liste des produits depuis le fichier JSON
        public static List<Produit> recupererlisteproduit()
        {
            string json = File.ReadAllText(FichierJson.Produit);
            return JsonConvert.DeserializeObject<List<Produit>>(json);
        }

        // Méthode pour enregistrer la liste des produits éventuellement modifiée 
        public static void enregistrerlisteproduit(List<Produit> listeproduit)
        {
            string json2 = JsonConvert.SerializeObject(listeproduit, Formatting.Indented);
            File.WriteAllText($"{FichierJson.Produit}", json2);
        }
    }
}
