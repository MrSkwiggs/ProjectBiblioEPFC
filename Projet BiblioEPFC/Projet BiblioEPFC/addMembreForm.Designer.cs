namespace ApplicationBiblioEPFC
{
    partial class addMembreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addMembreForm));
            this.formTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ajouterBouton = new System.Windows.Forms.Button();
            this.cancelBouton = new System.Windows.Forms.Button();
            this.nomLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.rueLabel = new System.Windows.Forms.Label();
            this.cpLabel = new System.Windows.Forms.Label();
            this.numTelLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.villeLabel = new System.Windows.Forms.Label();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.rueTextBox = new System.Windows.Forms.TextBox();
            this.cpTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.membreTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.MembreTableAdapter();
            this.formTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // formTableLayout
            // 
            this.formTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formTableLayout.ColumnCount = 4;
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.formTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.formTableLayout.Controls.Add(this.nomLabel, 0, 0);
            this.formTableLayout.Controls.Add(this.prenomLabel, 0, 1);
            this.formTableLayout.Controls.Add(this.rueLabel, 0, 3);
            this.formTableLayout.Controls.Add(this.cpLabel, 0, 4);
            this.formTableLayout.Controls.Add(this.numTelLabel, 2, 0);
            this.formTableLayout.Controls.Add(this.numLabel, 2, 3);
            this.formTableLayout.Controls.Add(this.villeLabel, 2, 4);
            this.formTableLayout.Controls.Add(this.nomTextBox, 1, 0);
            this.formTableLayout.Controls.Add(this.prenomTextBox, 1, 1);
            this.formTableLayout.Controls.Add(this.rueTextBox, 1, 3);
            this.formTableLayout.Controls.Add(this.cpTextBox, 1, 4);
            this.formTableLayout.Controls.Add(this.telTextBox, 3, 0);
            this.formTableLayout.Controls.Add(this.numTextBox, 3, 3);
            this.formTableLayout.Controls.Add(this.villeTextBox, 3, 4);
            this.formTableLayout.Location = new System.Drawing.Point(12, 12);
            this.formTableLayout.Name = "formTableLayout";
            this.formTableLayout.RowCount = 5;
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.formTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.formTableLayout.Size = new System.Drawing.Size(502, 207);
            this.formTableLayout.TabIndex = 0;
            // 
            // ajouterBouton
            // 
            this.ajouterBouton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ajouterBouton.Location = new System.Drawing.Point(165, 225);
            this.ajouterBouton.Name = "ajouterBouton";
            this.ajouterBouton.Size = new System.Drawing.Size(95, 24);
            this.ajouterBouton.TabIndex = 1;
            this.ajouterBouton.Text = "Ajouter";
            this.ajouterBouton.UseVisualStyleBackColor = true;
            this.ajouterBouton.Click += new System.EventHandler(this.ajouterBouton_Click);
            // 
            // cancelBouton
            // 
            this.cancelBouton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBouton.Location = new System.Drawing.Point(266, 225);
            this.cancelBouton.Name = "cancelBouton";
            this.cancelBouton.Size = new System.Drawing.Size(95, 24);
            this.cancelBouton.TabIndex = 2;
            this.cancelBouton.Text = "Annuler";
            this.cancelBouton.UseVisualStyleBackColor = true;
            this.cancelBouton.Click += new System.EventHandler(this.cancelBouton_Click);
            // 
            // nomLabel
            // 
            this.nomLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(18, 14);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(29, 13);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom";
            // 
            // prenomLabel
            // 
            this.prenomLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(4, 55);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(43, 13);
            this.prenomLabel.TabIndex = 1;
            this.prenomLabel.Text = "Prénom";
            // 
            // rueLabel
            // 
            this.rueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rueLabel.AutoSize = true;
            this.rueLabel.Location = new System.Drawing.Point(20, 136);
            this.rueLabel.Name = "rueLabel";
            this.rueLabel.Size = new System.Drawing.Size(27, 13);
            this.rueLabel.TabIndex = 2;
            this.rueLabel.Text = "Rue";
            // 
            // cpLabel
            // 
            this.cpLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cpLabel.AutoSize = true;
            this.cpLabel.Location = new System.Drawing.Point(11, 172);
            this.cpLabel.Name = "cpLabel";
            this.cpLabel.Size = new System.Drawing.Size(36, 26);
            this.cpLabel.TabIndex = 3;
            this.cpLabel.Text = "Code Postal";
            // 
            // numTelLabel
            // 
            this.numTelLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numTelLabel.AutoSize = true;
            this.numTelLabel.Location = new System.Drawing.Point(275, 14);
            this.numTelLabel.Name = "numTelLabel";
            this.numTelLabel.Size = new System.Drawing.Size(22, 13);
            this.numTelLabel.TabIndex = 4;
            this.numTelLabel.Text = "Tél";
            // 
            // numLabel
            // 
            this.numLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(278, 136);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(19, 13);
            this.numLabel.TabIndex = 6;
            this.numLabel.Text = "N°";
            // 
            // villeLabel
            // 
            this.villeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.villeLabel.AutoSize = true;
            this.villeLabel.Location = new System.Drawing.Point(271, 178);
            this.villeLabel.Name = "villeLabel";
            this.villeLabel.Size = new System.Drawing.Size(26, 13);
            this.villeLabel.TabIndex = 7;
            this.villeLabel.Text = "Ville";
            // 
            // nomTextBox
            // 
            this.nomTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nomTextBox.Location = new System.Drawing.Point(53, 10);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(194, 20);
            this.nomTextBox.TabIndex = 8;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prenomTextBox.Location = new System.Drawing.Point(53, 51);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(194, 20);
            this.prenomTextBox.TabIndex = 9;
            // 
            // rueTextBox
            // 
            this.rueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rueTextBox.Location = new System.Drawing.Point(53, 132);
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(194, 20);
            this.rueTextBox.TabIndex = 10;
            // 
            // cpTextBox
            // 
            this.cpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cpTextBox.Location = new System.Drawing.Point(53, 175);
            this.cpTextBox.Name = "cpTextBox";
            this.cpTextBox.Size = new System.Drawing.Size(194, 20);
            this.cpTextBox.TabIndex = 11;
            // 
            // telTextBox
            // 
            this.telTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.telTextBox.Location = new System.Drawing.Point(303, 10);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(196, 20);
            this.telTextBox.TabIndex = 12;
            // 
            // numTextBox
            // 
            this.numTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numTextBox.Location = new System.Drawing.Point(303, 132);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(196, 20);
            this.numTextBox.TabIndex = 14;
            // 
            // villeTextBox
            // 
            this.villeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.villeTextBox.Location = new System.Drawing.Point(303, 175);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(196, 20);
            this.villeTextBox.TabIndex = 15;
            // 
            // membreTableAdapter1
            // 
            this.membreTableAdapter1.ClearBeforeFill = true;
            // 
            // addMembreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 257);
            this.Controls.Add(this.cancelBouton);
            this.Controls.Add(this.ajouterBouton);
            this.Controls.Add(this.formTableLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addMembreForm";
            this.Text = "Ajouter membre";
            this.Load += new System.EventHandler(this.addMembreForm_Load);
            this.formTableLayout.ResumeLayout(false);
            this.formTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formTableLayout;
        private System.Windows.Forms.Button ajouterBouton;
        private System.Windows.Forms.Button cancelBouton;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label rueLabel;
        private System.Windows.Forms.Label cpLabel;
        private System.Windows.Forms.Label numTelLabel;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label villeLabel;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox rueTextBox;
        private System.Windows.Forms.TextBox cpTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private BiblioEPFCDataSetTableAdapters.MembreTableAdapter membreTableAdapter1;
    }
}