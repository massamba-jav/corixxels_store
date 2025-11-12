using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorrixellsStore.Formulaires;

namespace CorrixellsStore.Back
{
    internal class Magasin
    {
        //Méthode principal du menu de l'application
        public static void choix()
        {
            //Nettoyage de la console
            Console.Clear();

            //Affichage du Menu 
            Console.WriteLine("=========== MENU MAGASIN ===========");
            Console.WriteLine("1 - Afficher le stock");
            Console.WriteLine("2 - Ajouter un produit (Via menu complet)");
            Console.WriteLine("3 - Vendre un produit");
            Console.WriteLine("4 - Historique des ventes");
            Console.WriteLine("5 - Produits en alerte");
            Console.WriteLine("6 - Chiffre d’affaires");
            Console.WriteLine("7 - Menu complet Winforms");
            Console.WriteLine("0 - Quitter");

            //Variable de contrôle de saisie
            bool erreur  ;

            //Saisie et contrôlr du choix
            do
            {
                Console.Write("Choix > ");
                erreur = false;
                string saisie = Console.ReadLine();
                int choix;
                //Contrôle technique de la saisie
                if (!int.TryParse(saisie, out choix) || choix< 0 || choix > 7)
                {
                    erreur = true; 
                    Console.WriteLine("Entrée invalide. Veuillez respecter les choix disponibles !");
                }
                else
                {
                    //Actions relatives au choix
                    switch (choix)
                    {
                        case 1:
                            Console.Clear();
                            Stock.listeproduits();
                            Magasin.confirmersortie();
                            break;
                        case 2:
                            Console.WriteLine("Ajout d’un produit (WinForms)...");
                            Application.Run(new Formulaires.CorrixellsStore());
                            Magasin.confirmersortie();
                            break;
                        case 3:
                            Console.Clear();
                            HistoriqueVente.ajouterVente();
                            Magasin.confirmersortie();

                            break;
                        case 4:
                            Console.Clear();
                            HistoriqueVente.listeVentes();
                            Magasin.confirmersortie();

                            break;
                        case 5:
                            Console.Clear();
                            Rupture.afficher();
                            Magasin.confirmersortie();

                            break;
                        case 6:
                            Console.Clear();
                            ChiffreAffaire.calculerChiffreAffairre();
                            Magasin.confirmersortie();

                            break;
                        case 7:
                            Console.WriteLine("Ouverture de l'application WinForms...");
                            Application.Run(new Formulaires.CorrixellsStore());
                            Magasin.confirmersortie();
                            break;
                        case 0:
                            Console.WriteLine("Au revoir et à Bientôt !");
                            return;
                    }
                }
                
            } while (erreur);


        }

        //Méthode de confirmation de fin du programme
        public static void confirmersortie()
        {
            bool correct;
            do
            {
                correct = true;
                Console.Write("Voulez vous retourner au menu avant de quitter (oui/non/o/n) : ");
                string saisie2 = Console.ReadLine();

                //Contrôle technique de la saisie
                if (saisie2.ToLower() == "oui" || saisie2.ToLower() == "o")
                {
                    Magasin.choix();
                }
                else if (saisie2.ToLower() == "non" || saisie2.ToLower() == "n")
                {
                    Console.WriteLine("Au revoir et à Bientôt !");
                    return;
                }
                else
                {
                    correct = false;
                    Console.WriteLine("Saisie incorrecte réessayez !");
                }

            } while (!correct);
        }
    }
}
