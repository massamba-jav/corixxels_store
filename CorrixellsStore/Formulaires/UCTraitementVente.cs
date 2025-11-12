using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrixellsStore.Formulaires.TraitementVente;
using System.Windows.Forms;

namespace CorrixellsStore.Formulaires
{
    public partial class UCTraitementVente : UserControl
    {
        public UCTraitementVente()
        {
            InitializeComponent();
            panelvente.Padding = new Padding(3); 
        }
        private void AfficherUserControl(UserControl uc)
        {
            panelvente.Controls.Clear();
            panelvente.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Margin = new Padding(0);
        }

        private void bntajout_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCAddVente());
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCUpdateVente());
        }

        private void bntsupp_Click(object sender, EventArgs e)
        {
            AfficherUserControl(new UCDeleteVente());
        }

        private void panelvente_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(230, 200, 120), 3)) // 3 = épaisseur
            {
                e.Graphics.DrawRectangle(pen, 0, 0, panelvente.Width - 1, panelvente.Height - 1);
            }
        }

        private void UCTraitementVente_Load(object sender, EventArgs e)
        {
            bntajout.FlatAppearance.BorderSize = 0;
            btnmodif.FlatAppearance.BorderSize = 0;
            bntsupp.FlatAppearance.BorderSize = 0;
        }
    }
}
