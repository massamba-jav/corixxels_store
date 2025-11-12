using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrixellsStore.Formulaires
{
    //Classe du Formulaire
    public partial class CorrixellsStore : Form
    {
        public CorrixellsStore()
        {
            InitializeComponent();
        }
        private void AfficherUserControl(UserControl uc)
        {
            panelContenu.Controls.Clear();
            panelContenu.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnaccueil_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCAccueil());
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCStock());
        }

        private void btnaffaire_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCAffaire());
        }

        private void btnalerte_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCAlerte());
        }

        private void btnhistorique_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCHistorique());
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCTraitementProduit());
        }

        private void btnvente_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCTraitementVente());
        }

        private void btnconsole_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
