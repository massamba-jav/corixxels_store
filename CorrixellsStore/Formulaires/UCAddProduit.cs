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
    public partial class UCAddProduit : UserControl
    {
        public UCAddProduit()
        {
            InitializeComponent();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            List<Produit> listeproduits = FichierJson.recupererlisteproduit();
            int idp,qte;
            decimal pu;
            string nom;
            bool erreur = false;
            if (listeproduits.Count == 0)
            {
                idp = 1;
            }
            else
            {
                idp = listeproduits.Max(produit => produit.Id) + 1;
            }
            nom = txtnom.Text;
                //Contrôle technique de la saisie
            if (!int.TryParse(txtqte.Text, out qte) || qte <= 0)
            {
                erreur = true;
            }
            pu = numericpu.Value;
            //Contrôle technique de la saisie
            if (pu <= 0)
            {
                erreur = true;
            }
            if (erreur)
            {
                MessageBox.Show("Erreur lors veuillez vérifier les  champs");
            }
            else
            {
                Produit p = new Produit
                {
                    Id = idp,
                    Nom = nom,
                    Quantite = qte,
                    PrixUnitaire = pu
                };
                listeproduits.Add(p);
                FichierJson.enregistrerlisteproduit(listeproduits);
                MessageBox.Show("Produit ajouté avec succès !");
                txtnom.Text = "";
                txtqte.Text = "";
                numericpu.Value = 0;
            }
        }

        private void UCAddProduit_Load(object sender, EventArgs e)
        {
            btnajouter.FlatAppearance.BorderSize = 0;
        }
    }
}
