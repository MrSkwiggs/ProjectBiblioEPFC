namespace ApplicationBiblioEPFC
{
    partial class addTypeForm
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.typeTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.TypeTableAdapter();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.sigleLabel = new System.Windows.Forms.Label();
            this.ajouterBouton = new System.Windows.Forms.Button();
            this.cancelBouton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.sigleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // typeTableAdapter1
            // 
            this.typeTableAdapter1.ClearBeforeFill = true;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 13);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description";
            // 
            // sigleLabel
            // 
            this.sigleLabel.AutoSize = true;
            this.sigleLabel.Location = new System.Drawing.Point(13, 49);
            this.sigleLabel.Name = "sigleLabel";
            this.sigleLabel.Size = new System.Drawing.Size(30, 13);
            this.sigleLabel.TabIndex = 1;
            this.sigleLabel.Text = "Sigle";
            // 
            // ajouterBouton
            // 
            this.ajouterBouton.Location = new System.Drawing.Point(56, 103);
            this.ajouterBouton.Name = "ajouterBouton";
            this.ajouterBouton.Size = new System.Drawing.Size(75, 23);
            this.ajouterBouton.TabIndex = 2;
            this.ajouterBouton.Text = "Ajouter";
            this.ajouterBouton.UseVisualStyleBackColor = true;
            this.ajouterBouton.Click += new System.EventHandler(this.ajouterBouton_Click);
            // 
            // cancelBouton
            // 
            this.cancelBouton.Location = new System.Drawing.Point(137, 103);
            this.cancelBouton.Name = "cancelBouton";
            this.cancelBouton.Size = new System.Drawing.Size(75, 23);
            this.cancelBouton.TabIndex = 3;
            this.cancelBouton.Text = "Annuler";
            this.cancelBouton.UseVisualStyleBackColor = true;
            this.cancelBouton.Click += new System.EventHandler(this.cancelBouton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.descriptionTextBox.Location = new System.Drawing.Point(79, 10);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(177, 20);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // sigleTextBox
            // 
            this.sigleTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sigleTextBox.Location = new System.Drawing.Point(79, 46);
            this.sigleTextBox.MaxLength = 4;
            this.sigleTextBox.Name = "sigleTextBox";
            this.sigleTextBox.Size = new System.Drawing.Size(71, 20);
            this.sigleTextBox.TabIndex = 5;
            // 
            // addTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 138);
            this.Controls.Add(this.sigleTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.cancelBouton);
            this.Controls.Add(this.ajouterBouton);
            this.Controls.Add(this.sigleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Name = "addTypeForm";
            this.Text = "Ajouter type";
            this.Load += new System.EventHandler(this.addTypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BiblioEPFCDataSetTableAdapters.TypeTableAdapter typeTableAdapter1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label sigleLabel;
        private System.Windows.Forms.Button ajouterBouton;
        private System.Windows.Forms.Button cancelBouton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox sigleTextBox;
    }
}