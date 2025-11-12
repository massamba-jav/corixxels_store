using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace CorrixellsStore.Back
{
    //Classe Historique Vente pour les traitements liés aux ventes
    internal class HistoriqueVente
    {
        //Méthodes pour ajouter une vente
        public static void ajouterVente()
        {
            if (File.Exists(FichierJson.Vente))
            {
                // Récupération de la liste des ventes et produits actuels
                List<Vente> listeventes = FichierJson.recupererlistevente();
                List<Produit> listeproduit = FichierJson.recupererlisteproduit();
                Console.WriteLine("Vente de Produit :");
                Console.WriteLine("--------------------------------------------------");
                //Déclaration des variables de contrôle de saisie
                int idv ,idp  , qte = 0,qteVendue;
                decimal pu =0;
                DateTime date;
                bool trouve = false, verif; ;
                //Affectation dynamique des ID de vente pour éviter les doublons et erreurs de saisie
                if (listeventes.Count == 0)
                {
                    idv = 1;
                }
                else
                {
                    idv = listeventes.Max(vente => vente.IdVente) + 1;
                }
                 
                //Saise et contôle de l'ID de produit ,de la quantité et de la date
                do
                {
                    Console.Write("Id du produit : ");
                    string saisie = Console.ReadLine();

                    //Contrôle technique de la saisie
                    if (!int.TryParse(saisie, out idp) || idp <= 0)
                    {
                        Console.WriteLine("Veuillez saisir un ID de produit valide !");
                    }
                    else
                    {
                        foreach (var Produit in listeproduit)
                        {
                            //Vérification de l'existence du produit
                            if (Produit.Id.Equals(idp))
                            {
                                pu = Produit.Id;
                                trouve = true;
                            }
                        }
                        if (!trouve)
                        {
                            Console.WriteLine($"Le produit d'ID {idp} n'existe pas dans la base !");
                            idp = 0;
                        }
                    }

                } while (idp <= 0);

                //Saisie de la quantité
                do
                {
                    Console.Write("Quantité à vendre : ");
                    string saisie = Console.ReadLine();

                    //Contrôle technique de la saisie
                    if (!int.TryParse(saisie, out qteVendue) || qteVendue <= 0)
                    {
                        Console.WriteLine("Veuillez saisir une Quantité de produit valide !");
                    }
                    else
                    {
                        foreach (var Produit in listeproduit)
                        {
                            if (Produit.Id.Equals(idp))
                            {
                                //Vérification de la quantité du produit disponible
                                if((Produit.Quantite - qteVendue) >= 0)
                                {
                                    //Mis à jour de la quantité du produit
                                    Produit.Quantite = Produit.Quantite - qteVendue;
                                    qte = qteVendue;
                                }
                                else
                                {
                                    //Rappel de la quantité actuel en cas d'insuffisance
                                    Console.WriteLine($"La quantité du produit n'est pas suffisante il n'y a que {Produit.Quantite} unité disponibles actuellement !");
                                    qteVendue = 0;
                                }
                                
                            }
                        }
                    }

                } while (qteVendue <= 0);

                //Saisie de la date
                do
                {
                    verif = true;
                    Console.Write("Date de la vente (ex:25/05/2025) : ");
                    string saisie = Console.ReadLine();

                    //Contrôle technique de la saisie
                    if (!DateTime.TryParse(saisie , out date))
                    {
                        verif = false;
                        Console.WriteLine("Veuillez saisir une date valide !");
                    }

                } while (!verif);

                //Création de la vente à partir des saisies
                Vente v = new Vente
                {
                    IdVente = idv,
                    ProduitId = idp,
                    QuantiteVendue = qte,
                    PrixUnitaire = pu,
                    DateVente = date
                };

                //Ajout de la vente à la liste et sauvegarde des modifications dans les fichiers JSON
                listeventes.Add(v);
                FichierJson.enregistrerlistevente(listeventes);
                FichierJson.enregistrerlisteproduit(listeproduit);
            }
        }

        //Méthode pour afficher la liste des ventes enregistrées
        public static void listeVentes()
        {
            // Récupération de la liste des ventes actuelles
            List<Vente> listeventes = FichierJson.recupererlistevente();

            //Vérification de l'état de la liste des ventes
            if (listeventes != null && listeventes.Count > 0)
            {
                //Affichage des ventes
                Console.WriteLine("Liste des ventes :");
                Console.WriteLine("--------------------------------------------------");
                foreach (var vente in listeventes)
                {
                    Console.WriteLine($"ID Vente: {vente.IdVente}, Produit ID: {vente.ProduitId}, Quantité: {vente.QuantiteVendue}, Prix Unitaire: {vente.PrixUnitaire}, Date: {vente.DateVente.ToShortDateString()}, Montant Total: {vente.MontantTotal}");
                }
            }
            else
            {
                Console.WriteLine("Aucune vente enregistrée !");
            }
        }
    }
}
