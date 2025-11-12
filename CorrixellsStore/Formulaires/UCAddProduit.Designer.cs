namespace CorrixellsStore.Formulaires.TraitementProduit
{
    partial class UCAddProduit
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
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtqte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericpu = new System.Windows.Forms.NumericUpDown();
            this.btnajouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericpu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnom
            // 
            this.txtnom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtnom.Location = new System.Drawing.Point(435, 181);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(228, 37);
            this.txtnom.TabIndex = 0;
            // 
            // txtqte
            // 
            this.txtqte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtqte.Location = new System.Drawing.Point(435, 262);
            this.txtqte.Multiline = true;
            this.txtqte.Name = "txtqte";
            this.txtqte.Size = new System.Drawing.Size(228, 37);
            this.txtqte.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom du produit";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantité du produit";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix unitaire ";
            // 
            // numericpu
            // 
            this.numericpu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericpu.DecimalPlaces = 2;
            this.numericpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericpu.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericpu.Location = new System.Drawing.Point(435, 347);
            this.numericpu.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericpu.Name = "numericpu";
            this.numericpu.Size = new System.Drawing.Size(228, 30);
            this.numericpu.TabIndex = 6;
            this.numericpu.ThousandsSeparator = true;
            // 
            // btnajouter
            // 
            this.btnajouter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Location = new System.Drawing.Point(472, 458);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(146, 38);
            this.btnajouter.TabIndex = 7;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ajout de Produit";
            // 
            // UCAddProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.numericpu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtqte);
            this.Controls.Add(this.txtnom);
            this.Name = "UCAddProduit";
            this.Size = new System.Drawing.Size(853, 589);
            this.Load += new System.EventHandler(this.UCAddProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtqte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericpu;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Label label4;
    }
}
