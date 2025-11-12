using CorrixellsStore.Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrixellsStore.Formulaires.TraitementVente
{
    public partial class UCAddVente : UserControl
    {
        public UCAddVente()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            List<Produit> listeproduits = FichierJson.recupererlisteproduit();
            bool trouve = false;
            int idp = 0;
            if (!int.TryParse(txtid.Text, out idp) || idp <= 0)
            {
                MessageBox.Show("Veuillez saisir un ID de produit valide !");
            }
            else
            {
                foreach (var Produit in listeproduits)
                {
                    //Vérification de l'existence du produit
                    if (Produit.Id.Equals(idp))
                    {
                        trouve = true;
                        MessageBox.Show($"Le produit {Produit.Nom} à été trouvé son prix unitaire à été remplit automatiquement !");
                        numericpu.Value = Produit.PrixUnitaire;
                    }
                }
                if (!trouve)
                {
                    MessageBox.Show($"Le produit d'ID {idp} n'existe pas dans la base !");
                }

            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            List<Vente> listeventes = FichierJson.recupererlistevente();
            List<Produit> listeproduit = FichierJson.recupererlisteproduit();
            int idv, idp, qte = 0, qteVendue;
            decimal pu = 0;
            DateTime date;
            bool verif =true ; 
            idp = int.Parse(txtid.Text);
            if (listeventes.Count == 0)
            {
                idv = 1;
            }
            else
            {
                idv = listeventes.Max(vente => vente.IdVente) + 1;
            }
            if (!int.TryParse(txtqte.Text, out qteVendue) || qteVendue <= 0)
            {
                MessageBox.Show("Veuillez saisir une Quantité de produit valide !");
                verif = false;
            }
            else
            {
                foreach (var Produit in listeproduit)
                {
                    if (Produit.Id.Equals(idp))
                    {
                        //Vérification de la quantité du produit disponible
                        if ((Produit.Quantite - qteVendue) >= 0)
                        {
                            //Mis à jour de la quantité du produit
                            Produit.Quantite = Produit.Quantite - qteVendue;
                            qte = qteVendue;
                        }
                        else
                        {
                            //Rappel de la quantité actuel en cas d'insuffisance
                            MessageBox.Show($"La quantité du produit n'est pas suffisante il n'y a que {Produit.Quantite} unité disponibles actuellement !");
                        }

                    }
                }
            }
            date = dateTimePicker1.Value;
            if (verif)
            {
                pu = numericpu.Value;
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
                MessageBox.Show("Vente ajoutée avec succés !");
                txtid.Text = "";
                txtqte.Text = "";
                numericpu.Value = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Produit> listeproduit = FichierJson.recupererlisteproduit();
            int idp = int.Parse(txtid.Text);
            int qteVendue = int.Parse(txtqte.Text);
            foreach (var Produit in listeproduit)
            {
                if (Produit.Id.Equals(idp))
                {
                    //Vérification de la quantité du produit disponible
                    if ((Produit.Quantite - qteVendue) >= 0)
                    {
                        MessageBox.Show("Quantité suffisante poursuivez ");
                    }
                    else
                    {
                        //Rappel de la quantité actuel en cas d'insuffisance
                        MessageBox.Show($"La quantité du produit n'est pas suffisante il n'y a que {Produit.Quantite} unité disponibles actuellement !");
                    }

                }
            }
        }

        private void UCAddVente_Load(object sender, EventArgs e)
        {
            btnmodifier.FlatAppearance.BorderSize = 0;
            btnsearch.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;
        }
    }
}
