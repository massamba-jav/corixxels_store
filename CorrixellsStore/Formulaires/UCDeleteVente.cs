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
    public partial class UCDeleteVente : UserControl
    {
        public UCDeleteVente()
        {
            InitializeComponent();
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            List<Vente> listeventes = FichierJson.recupererlistevente();
            List<Produit> listeproduits = FichierJson.recupererlisteproduit();
            bool trouve = false;
            int idv = 0,idp=0,qte=0;
            if (!int.TryParse(txtid.Text, out idv) || idv <= 0)
            {
                MessageBox.Show("Veuillez saisir un ID de vente valide !");
            }
            else
            {
                foreach (var Vente in listeventes)
                {
                    //Vérification de l'existence du produit
                    if (Vente.IdVente.Equals(idv))
                    {
                        trouve = true;
                        idp = Vente.ProduitId;
                        qte = Vente.QuantiteVendue;
                        DialogResult result = MessageBox.Show(
                            $"Êtes-vous sûr de vouloir supprimer la vente du Produit ({Vente.ProduitId}) ?",
                            "Confirmation de suppression",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.Yes)
                        {
                            listeventes.Remove(Vente);
                            FichierJson.enregistrerlistevente(listeventes);
                            MessageBox.Show("Vente supprimé avec succès et remise à quantité du produit correspondant.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show($"La vente d'ID {idv} n'existe pas dans la base !");
                }
                else
                {
                    foreach (var Produit in listeproduits)
                    {
                        //Vérification de l'existence du produit
                        if (Produit.Id.Equals(idp))
                        {
                            trouve = true;
                            Produit.Quantite +=qte ;
                        }
                    }
                    FichierJson.enregistrerlisteproduit(listeproduits);
                }

            }
        }

        private void UCDeleteVente_Load(object sender, EventArgs e)
        {
            btnsupp.FlatAppearance.BorderSize = 0;
        }
    }
}
