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
using CorrixellsStore.Enregistrement;

namespace CorrixellsStore.Formulaires
{
    public partial class UCStock : UserControl
    {
        public UCStock()
        {
            InitializeComponent();
            ChargerDepuisListe();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        List<Produit> listeproduits = FichierJson.recupererlisteproduit();
        private void ChargerDepuisListe()
        {
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = listeproduits;
        }

        private void btnexportcsv_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Fichier CSV (*.csv)|*.csv";
                sfd.FileName = "stockproduit.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportCSV.ExporterListeCSV(listeproduits, sfd.FileName);
                    MessageBox.Show("Exportation réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UCStock_Load(object sender, EventArgs e)
        {
            btnexportcsv.FlatAppearance.BorderSize = 0;
            // Dans le constructeur ou l'événement Load
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 200, 120);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }
    }
}
