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

namespace CorrixellsStore.Formulaires
{
    public partial class UCAffaire : UserControl
    {
        public UCAffaire()
        {
            InitializeComponent();
        }

        private void UCAffaire_Load(object sender, EventArgs e)
        {
            List<Vente> listeventes = FichierJson.recupererlistevente();
            DateTime date = DateTime.Now;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label6.Text = "";
            foreach (Vente vente in listeventes)
            {
                date = vente.DateVente;
                ChiffreAffaire.chiffreAffaireactuel += vente.MontantTotal;
            }
            if (ChiffreAffaire.chiffreAffaireactuel != 0) 
            {
                label1.Text = ($"Voici le chiffre d'affaire actuel du magasin qui est :");
                label4.Text = ($"{ChiffreAffaire.chiffreAffaireactuel} F CFA ");
                label2.Text = ($"   depuis la vente effectuée le :");
                label3.Text = ($"{ date} ");
            }
            else label6.Text = ($"Chiffre d'affaires actuellement nul aucune vente effectuée ! ");
        }
    }
}
