using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrixellsStore.Formulaires.TraitementProduit;
using System.Windows.Forms;

namespace CorrixellsStore.Formulaires
{
    public partial class UCTraitementProduit : UserControl
    {
        public UCTraitementProduit()
        {
            InitializeComponent();
            panelproduit.Padding = new Padding(3);
        }
        private void AfficherUserControl(UserControl uc)
        {
            panelproduit.Controls.Clear();
            panelproduit.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Margin = new Padding(0);
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCAddProduit());
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCUpdateProduit());
        }

        private void bntsupp_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCDeleteProduit());
        }

        private void panelproduit_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(230, 200, 120), 3)) // 3 = épaisseur
            {
                e.Graphics.DrawRectangle(pen, 0, 0, panelproduit.Width - 1, panelproduit.Height - 1);
            }
        }

        private void UCTraitementProduit_Load(object sender, EventArgs e)
        {
            btnajout.FlatAppearance.BorderSize = 0;
            btnmodif.FlatAppearance.BorderSize = 0;
            bntsupp.FlatAppearance.BorderSize = 0;
        }
    }
}
