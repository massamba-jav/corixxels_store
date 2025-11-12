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
    public partial class UCUpdateVente : UserControl
    {
        public UCUpdateVente()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            List<Vente> listeventes = FichierJson.recupererlistevente();
            bool trouve = false;
            int idv = 0;
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
                        dateTimePicker1.Value = Vente.DateVente;
                    }
                }
                if (!trouve)
                {
                    MessageBox.Show($"La vente d'ID {idv} n'existe pas dans la base !");
                }
            }
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            List<Vente> listeventes = FichierJson.recupererlistevente();
            DateTime date;
            int idv = int.Parse(txtid.Text);
            date = dateTimePicker1.Value;
            foreach (var Vente in listeventes)
            {
                //Vérification de l'existence de la vente
                if (Vente.IdVente.Equals(idv))
                {
                    Vente.DateVente = date;
                }
            }
            FichierJson.enregistrerlistevente(listeventes);
            MessageBox.Show("Vente modifiée avec succés !");
            txtid.Text = "";
        }

        private void UCUpdateVente_Load(object sender, EventArgs e)
        {
            btnmodifier.FlatAppearance.BorderSize = 0;
            btnsearch.FlatAppearance.BorderSize = 0;
        }
    }
}
