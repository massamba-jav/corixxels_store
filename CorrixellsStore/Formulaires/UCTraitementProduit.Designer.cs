namespace CorrixellsStore.Formulaires
{
    partial class UCTraitementProduit
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
            this.btnajout = new System.Windows.Forms.Button();
            this.btnmodif = new System.Windows.Forms.Button();
            this.bntsupp = new System.Windows.Forms.Button();
            this.panelproduit = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnajout
            // 
            this.btnajout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btnajout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajout.Location = new System.Drawing.Point(132, 38);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(125, 33);
            this.btnajout.TabIndex = 0;
            this.btnajout.Text = "Ajouter Produit";
            this.btnajout.UseVisualStyleBackColor = false;
            this.btnajout.Click += new System.EventHandler(this.btnajout_Click);
            // 
            // btnmodif
            // 
            this.btnmodif.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmodif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btnmodif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodif.Location = new System.Drawing.Point(464, 38);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(125, 33);
            this.btnmodif.TabIndex = 1;
            this.btnmodif.Text = "Modifier Produit";
            this.btnmodif.UseVisualStyleBackColor = false;
            this.btnmodif.Click += new System.EventHandler(this.btnmodif_Click);
            // 
            // bntsupp
            // 
            this.bntsupp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bntsupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.bntsupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntsupp.Location = new System.Drawing.Point(771, 38);
            this.bntsupp.Name = "bntsupp";
            this.bntsupp.Size = new System.Drawing.Size(161, 33);
            this.bntsupp.TabIndex = 2;
            this.bntsupp.Text = "Supprimer Produit";
            this.bntsupp.UseVisualStyleBackColor = false;
            this.bntsupp.Click += new System.EventHandler(this.bntsupp_Click);
            // 
            // panelproduit
            // 
            this.panelproduit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelproduit.Location = new System.Drawing.Point(57, 88);
            this.panelproduit.Name = "panelproduit";
            this.panelproduit.Size = new System.Drawing.Size(974, 589);
            this.panelproduit.TabIndex = 3;
            this.panelproduit.Paint += new System.Windows.Forms.PaintEventHandler(this.panelproduit_Paint);
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
            // UCTraitementProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelproduit);
            this.Controls.Add(this.bntsupp);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.btnajout);
            this.MaximumSize = new System.Drawing.Size(1091, 700);
            this.Name = "UCTraitementProduit";
            this.Size = new System.Drawing.Size(1091, 700);
            this.Load += new System.EventHandler(this.UCTraitementProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnajout;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.Button bntsupp;
        private System.Windows.Forms.Panel panelproduit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
