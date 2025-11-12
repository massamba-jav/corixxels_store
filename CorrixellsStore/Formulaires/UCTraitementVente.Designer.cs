namespace CorrixellsStore.Formulaires
{
    partial class UCTraitementVente
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntsupp = new System.Windows.Forms.Button();
            this.btnmodif = new System.Windows.Forms.Button();
            this.bntajout = new System.Windows.Forms.Button();
            this.panelvente = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntsupp
            // 
            this.bntsupp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntsupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.bntsupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntsupp.Location = new System.Drawing.Point(807, 38);
            this.bntsupp.Name = "bntsupp";
            this.bntsupp.Size = new System.Drawing.Size(125, 33);
            this.bntsupp.TabIndex = 8;
            this.bntsupp.Text = "Supprimer Vente";
            this.bntsupp.UseVisualStyleBackColor = false;
            this.bntsupp.Click += new System.EventHandler(this.bntsupp_Click);
            // 
            // btnmodif
            // 
            this.btnmodif.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmodif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btnmodif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodif.Location = new System.Drawing.Point(464, 38);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(125, 33);
            this.btnmodif.TabIndex = 7;
            this.btnmodif.Text = "Modifier Vente";
            this.btnmodif.UseVisualStyleBackColor = false;
            this.btnmodif.Click += new System.EventHandler(this.btnmodif_Click);
            // 
            // bntajout
            // 
            this.bntajout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.bntajout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntajout.Location = new System.Drawing.Point(132, 38);
            this.bntajout.Name = "bntajout";
            this.bntajout.Size = new System.Drawing.Size(125, 33);
            this.bntajout.TabIndex = 6;
            this.bntajout.Text = "Vendre Produit";
            this.bntajout.UseVisualStyleBackColor = false;
            this.bntajout.Click += new System.EventHandler(this.bntajout_Click);
            // 
            // panelvente
            // 
            this.panelvente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelvente.Location = new System.Drawing.Point(57, 88);
            this.panelvente.Name = "panelvente";
            this.panelvente.Size = new System.Drawing.Size(974, 589);
            this.panelvente.TabIndex = 9;
            this.panelvente.Paint += new System.Windows.Forms.PaintEventHandler(this.panelvente_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::CorrixellsStore.Properties.Resources.iconecorrixells;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // UCTraitementVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelvente);
            this.Controls.Add(this.bntsupp);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.bntajout);
            this.Name = "UCTraitementVente";
            this.Size = new System.Drawing.Size(1091, 700);
            this.Load += new System.EventHandler(this.UCTraitementVente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntsupp;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.Button bntajout;
        private System.Windows.Forms.Panel panelvente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
