using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace CorrixellsStore.Back
{
    //Classe Rupture pour gérer les produits en rupture
    internal class Rupture
    {
        //Méthode pour afficher les produits en rupture
        public static void afficher()
        {
            // Récupération de la liste des produits actuels
            List<Produit> listeproduit = FichierJson.recupererlisteproduit();
            int nb= 0 ;

            //Vérification de l'état de la liste des produits
            if (listeproduit != null && listeproduit.Count > 0)
            {
                //Affichage des produits en rupture
                Console.WriteLine("Liste des produits en alerte de rupture :");
                Console.WriteLine("--------------------------------------------------");
                foreach (var produit in listeproduit)
                {
                    // Contrôle de la quantité
                    if(produit.Quantite <= 10)
                    {
                        nb++;
                        Console.WriteLine(produit);
                    }
                }
                if( nb == 0)
                {
                    Console.WriteLine("Aucun produit n'est en rupture actuellement !");
                }
            }
            else
            {
                Console.WriteLine("Aucun produit enregistrée !");
            }
        }
    }
}
