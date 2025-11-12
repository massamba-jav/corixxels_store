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

namespace CorrixellsStore.Formulaires.TraitementProduit
{
    public partial class UCDeleteProduit : UserControl
    {
        public UCDeleteProduit()
        {
            InitializeComponent();
        }

        private void btnsupp_Click(object sender, EventArgs e)
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
                        DialogResult result = MessageBox.Show(
                            $"Êtes-vous sûr de vouloir supprimer ce Produit ({Produit.Nom}) ?",
                            "Confirmation de suppression",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.Yes)
                        {
                            listeproduits.Remove(Produit);
                            FichierJson.enregistrerlisteproduit(listeproduits);
                            MessageBox.Show("Produit supprimé avec succès.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtid.Text = "";
                            break;
                        }
                        else
                        {
                            txtid.Text = "";
                            MessageBox.Show("Suppression annulée.", "Annulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }

                    }
                }
                if (!trouve)
                {
                    MessageBox.Show($"Le produit d'ID {idp} n'existe pas dans la base !");
                }

            }
        }

        private void UCDeleteProduit_Load(object sender, EventArgs e)
        {
            btnsupp.FlatAppearance.BorderSize = 0;
        }
    }
}
