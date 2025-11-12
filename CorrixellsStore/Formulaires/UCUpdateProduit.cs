using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorrixellsStore.Back;

namespace CorrixellsStore.Formulaires.TraitementProduit
{
    public partial class UCUpdateProduit : UserControl
    {
        public UCUpdateProduit()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            List<Produit> listeproduits = FichierJson.recupererlisteproduit();
            bool trouve= false;
            int idp = 0;
            if(!int.TryParse(txtid.Text, out idp) || idp <= 0)
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
                        MessageBox.Show("Produit trouvé ces champs seront renseignés automatiquement !");
                        trouve = true;
                        txtnom.Text = Produit.Nom;
                        txtqte.Text = Produit.Quantite.ToString();
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
                        Produit.Nom = txtnom.Text;
                        Produit.Quantite = int.Parse(txtqte.Text);
                        Produit.PrixUnitaire = numericpu.Value;
                    }
                }
                if (!trouve)
                {
                    MessageBox.Show($"Le produit d'ID {idp} n'existe pas dans la base !");
                }
                FichierJson.enregistrerlisteproduit(listeproduits);
                MessageBox.Show("Vente modifiée avec succés !");
                txtqte.Text = "";
                txtnom.Text = "";
                txtid.Text = "";
                numericpu.Value = 0;
            }
        }

        private void UCUpdateProduit_Load(object sender, EventArgs e)
        {
            btnsearch.FlatAppearance.BorderSize = 0;
            btnmodifier.FlatAppearance.BorderSize = 0;
        }
    }
}
