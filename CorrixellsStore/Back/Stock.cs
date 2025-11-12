using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace CorrixellsStore.Back
{
    // Classe pour le stock pour faciliter
    internal class Stock
    {
        //Méthode pour afficher le stock de produits
        public static void listeproduits()
        {
            // Récupération de la liste des produits actuels
            List<Produit> listeproduit = FichierJson.recupererlisteproduit();

            //Vérification de l'état de la liste des produits
            if (listeproduit != null && listeproduit.Count > 0)
            {
                //Affichage des ventes
                Console.WriteLine("Stock des produits :");
                Console.WriteLine("--------------------------------------------------");
                foreach (var produit in listeproduit)
                {
                    Console.WriteLine(produit);
                }
            }
            else
            {
                Console.WriteLine("Aucun produit enregistrée !");
            }
        }
    }
}
