namespace ApplicationBiblioEPFC
{
    partial class addEmpruntResForm
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
            this.infosTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.empruntSplitContainer = new System.Windows.Forms.SplitContainer();
            this.membreNameSplitContainer = new System.Windows.Forms.SplitContainer();
            this.rechMembreTextBox = new System.Windows.Forms.TextBox();
            this.rechMembreLabel = new System.Windows.Forms.Label();
            this.membreListBox = new System.Windows.Forms.ListBox();
            this.ajouterMembreBouton = new System.Windows.Forms.Button();
            this.ouvrageLabel = new System.Windows.Forms.Label();
            this.membreLabel = new System.Windows.Forms.Label();
            this.dateEmpruntLabel = new System.Windows.Forms.Label();
            this.dureeEmpruntLabel = new System.Windows.Forms.Label();
            this.ouvrageSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ouvrageNameSplitContainer = new System.Windows.Forms.SplitContainer();
            this.rechOuvrageTextBox = new System.Windows.Forms.TextBox();
            this.rechOuvrageLabel = new System.Windows.Forms.Label();
            this.ouvrageListBox = new System.Windows.Forms.ListBox();
            this.ajouterOuvrageBouton = new System.Windows.Forms.Button();
            this.dateEmpruntPicker = new System.Windows.Forms.DateTimePicker();
            this.dureeComboBox = new System.Windows.Forms.ComboBox();
            this.formSplitContainer = new System.Windows.Forms.SplitContainer();
            this.cancelBouton = new System.Windows.Forms.Button();
            this.emprunterBouton = new System.Windows.Forms.Button();
            this.ouvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter();
            this.membreTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.MembreTableAdapter();
            this.infosTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empruntSplitContainer)).BeginInit();
            this.empruntSplitContainer.Panel1.SuspendLayout();
            this.empruntSplitContainer.Panel2.SuspendLayout();
            this.empruntSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membreNameSplitContainer)).BeginInit();
            this.membreNameSplitContainer.Panel1.SuspendLayout();
            this.membreNameSplitContainer.Panel2.SuspendLayout();
            this.membreNameSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageSplitContainer)).BeginInit();
            this.ouvrageSplitContainer.Panel1.SuspendLayout();
            this.ouvrageSplitContainer.Panel2.SuspendLayout();
            this.ouvrageSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageNameSplitContainer)).BeginInit();
            this.ouvrageNameSplitContainer.Panel1.SuspendLayout();
            this.ouvrageNameSplitContainer.Panel2.SuspendLayout();
            this.ouvrageNameSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).BeginInit();
            this.formSplitContainer.Panel1.SuspendLayout();
            this.formSplitContainer.Panel2.SuspendLayout();
            this.formSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // infosTableLayout
            // 
            this.infosTableLayout.ColumnCount = 2;
            this.infosTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.infosTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infosTableLayout.Controls.Add(this.empruntSplitContainer, 1, 1);
            this.infosTableLayout.Controls.Add(this.ouvrageLabel, 0, 0);
            this.infosTableLayout.Controls.Add(this.membreLabel, 0, 1);
            this.infosTableLayout.Controls.Add(this.dateEmpruntLabel, 0, 2);
            this.infosTableLayout.Controls.Add(this.dureeEmpruntLabel, 0, 3);
            this.infosTableLayout.Controls.Add(this.ouvrageSplitContainer, 1, 0);
            this.infosTableLayout.Controls.Add(this.dateEmpruntPicker, 1, 2);
            this.infosTableLayout.Controls.Add(this.dureeComboBox, 1, 3);
            this.infosTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infosTableLayout.Location = new System.Drawing.Point(0, 0);
            this.infosTableLayout.Name = "infosTableLayout";
            this.infosTableLayout.RowCount = 3;
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.55769F));
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.44231F));
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.infosTableLayout.Size = new System.Drawing.Size(439, 364);
            this.infosTableLayout.TabIndex = 0;
            // 
            // empruntSplitContainer
            // 
            this.empruntSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empruntSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.empruntSplitContainer.IsSplitterFixed = true;
            this.empruntSplitContainer.Location = new System.Drawing.Point(73, 152);
            this.empruntSplitContainer.Name = "empruntSplitContainer";
            // 
            // empruntSplitContainer.Panel1
            // 
            this.empruntSplitContainer.Panel1.Controls.Add(this.membreNameSplitContainer);
            // 
            // empruntSplitContainer.Panel2
            // 
            this.empruntSplitContainer.Panel2.Controls.Add(this.ajouterMembreBouton);
            this.empruntSplitContainer.Size = new System.Drawing.Size(363, 152);
            this.empruntSplitContainer.SplitterDistance = 334;
            this.empruntSplitContainer.TabIndex = 5;
            // 
            // membreNameSplitContainer
            // 
            this.membreNameSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membreNameSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.membreNameSplitContainer.IsSplitterFixed = true;
            this.membreNameSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.membreNameSplitContainer.Name = "membreNameSplitContainer";
            this.membreNameSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // membreNameSplitContainer.Panel1
            // 
            this.membreNameSplitContainer.Panel1.Controls.Add(this.rechMembreTextBox);
            this.membreNameSplitContainer.Panel1.Controls.Add(this.rechMembreLabel);
            // 
            // membreNameSplitContainer.Panel2
            // 
            this.membreNameSplitContainer.Panel2.Controls.Add(this.membreListBox);
            this.membreNameSplitContainer.Size = new System.Drawing.Size(334, 152);
            this.membreNameSplitContainer.SplitterDistance = 36;
            this.membreNameSplitContainer.TabIndex = 0;
            // 
            // rechMembreTextBox
            // 
            this.rechMembreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rechMembreTextBox.Location = new System.Drawing.Point(73, 8);
            this.rechMembreTextBox.Name = "rechMembreTextBox";
            this.rechMembreTextBox.Size = new System.Drawing.Size(258, 20);
            this.rechMembreTextBox.TabIndex = 1;
            // 
            // rechMembreLabel
            // 
            this.rechMembreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rechMembreLabel.AutoSize = true;
            this.rechMembreLabel.Location = new System.Drawing.Point(4, 12);
            this.rechMembreLabel.Name = "rechMembreLabel";
            this.rechMembreLabel.Size = new System.Drawing.Size(63, 13);
            this.rechMembreLabel.TabIndex = 0;
            this.rechMembreLabel.Text = "Rechercher";
            // 
            // membreListBox
            // 
            this.membreListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membreListBox.FormattingEnabled = true;
            this.membreListBox.Location = new System.Drawing.Point(0, 0);
            this.membreListBox.Name = "membreListBox";
            this.membreListBox.Size = new System.Drawing.Size(334, 112);
            this.membreListBox.TabIndex = 0;
            this.membreListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.membreListBox_MouseClick);
            // 
            // ajouterMembreBouton
            // 
            this.ajouterMembreBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterMembreBouton.Location = new System.Drawing.Point(2, 66);
            this.ajouterMembreBouton.Name = "ajouterMembreBouton";
            this.ajouterMembreBouton.Size = new System.Drawing.Size(20, 20);
            this.ajouterMembreBouton.TabIndex = 0;
            this.ajouterMembreBouton.Text = "+";
            this.ajouterMembreBouton.UseVisualStyleBackColor = true;
            // 
            // ouvrageLabel
            // 
            this.ouvrageLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ouvrageLabel.AutoSize = true;
            this.ouvrageLabel.Location = new System.Drawing.Point(19, 68);
            this.ouvrageLabel.Name = "ouvrageLabel";
            this.ouvrageLabel.Size = new System.Drawing.Size(48, 13);
            this.ouvrageLabel.TabIndex = 0;
            this.ouvrageLabel.Text = "Ouvrage";
            // 
            // membreLabel
            // 
            this.membreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.membreLabel.AutoSize = true;
            this.membreLabel.Location = new System.Drawing.Point(22, 221);
            this.membreLabel.Name = "membreLabel";
            this.membreLabel.Size = new System.Drawing.Size(45, 13);
            this.membreLabel.TabIndex = 1;
            this.membreLabel.Text = "Membre";
            // 
            // dateEmpruntLabel
            // 
            this.dateEmpruntLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateEmpruntLabel.AutoSize = true;
            this.dateEmpruntLabel.Location = new System.Drawing.Point(37, 313);
            this.dateEmpruntLabel.Name = "dateEmpruntLabel";
            this.dateEmpruntLabel.Size = new System.Drawing.Size(30, 13);
            this.dateEmpruntLabel.TabIndex = 2;
            this.dateEmpruntLabel.Text = "Date";
            // 
            // dureeEmpruntLabel
            // 
            this.dureeEmpruntLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dureeEmpruntLabel.AutoSize = true;
            this.dureeEmpruntLabel.Location = new System.Drawing.Point(31, 342);
            this.dureeEmpruntLabel.Name = "dureeEmpruntLabel";
            this.dureeEmpruntLabel.Size = new System.Drawing.Size(36, 13);
            this.dureeEmpruntLabel.TabIndex = 3;
            this.dureeEmpruntLabel.Text = "Durée";
            // 
            // ouvrageSplitContainer
            // 
            this.ouvrageSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ouvrageSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.ouvrageSplitContainer.IsSplitterFixed = true;
            this.ouvrageSplitContainer.Location = new System.Drawing.Point(73, 3);
            this.ouvrageSplitContainer.Name = "ouvrageSplitContainer";
            // 
            // ouvrageSplitContainer.Panel1
            // 
            this.ouvrageSplitContainer.Panel1.Controls.Add(this.ouvrageNameSplitContainer);
            // 
            // ouvrageSplitContainer.Panel2
            // 
            this.ouvrageSplitContainer.Panel2.Controls.Add(this.ajouterOuvrageBouton);
            this.ouvrageSplitContainer.Size = new System.Drawing.Size(363, 143);
            this.ouvrageSplitContainer.SplitterDistance = 334;
            this.ouvrageSplitContainer.TabIndex = 4;
            // 
            // ouvrageNameSplitContainer
            // 
            this.ouvrageNameSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ouvrageNameSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ouvrageNameSplitContainer.IsSplitterFixed = true;
            this.ouvrageNameSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ouvrageNameSplitContainer.Name = "ouvrageNameSplitContainer";
            this.ouvrageNameSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ouvrageNameSplitContainer.Panel1
            // 
            this.ouvrageNameSplitContainer.Panel1.Controls.Add(this.rechOuvrageTextBox);
            this.ouvrageNameSplitContainer.Panel1.Controls.Add(this.rechOuvrageLabel);
            // 
            // ouvrageNameSplitContainer.Panel2
            // 
            this.ouvrageNameSplitContainer.Panel2.Controls.Add(this.ouvrageListBox);
            this.ouvrageNameSplitContainer.Size = new System.Drawing.Size(334, 143);
            this.ouvrageNameSplitContainer.SplitterDistance = 34;
            this.ouvrageNameSplitContainer.TabIndex = 0;
            // 
            // rechOuvrageTextBox
            // 
            this.rechOuvrageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rechOuvrageTextBox.Location = new System.Drawing.Point(73, 7);
            this.rechOuvrageTextBox.Name = "rechOuvrageTextBox";
            this.rechOuvrageTextBox.Size = new System.Drawing.Size(258, 20);
            this.rechOuvrageTextBox.TabIndex = 1;
            // 
            // rechOuvrageLabel
            // 
            this.rechOuvrageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rechOuvrageLabel.AutoSize = true;
            this.rechOuvrageLabel.Location = new System.Drawing.Point(4, 11);
            this.rechOuvrageLabel.Name = "rechOuvrageLabel";
            this.rechOuvrageLabel.Size = new System.Drawing.Size(63, 13);
            this.rechOuvrageLabel.TabIndex = 0;
            this.rechOuvrageLabel.Text = "Rechercher";
            // 
            // ouvrageListBox
            // 
            this.ouvrageListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ouvrageListBox.FormattingEnabled = true;
            this.ouvrageListBox.Location = new System.Drawing.Point(0, 0);
            this.ouvrageListBox.Name = "ouvrageListBox";
            this.ouvrageListBox.Size = new System.Drawing.Size(334, 105);
            this.ouvrageListBox.TabIndex = 0;
            this.ouvrageListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ouvrageListBox_MouseClick);
            // 
            // ajouterOuvrageBouton
            // 
            this.ajouterOuvrageBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterOuvrageBouton.Location = new System.Drawing.Point(2, 61);
            this.ajouterOuvrageBouton.Name = "ajouterOuvrageBouton";
            this.ajouterOuvrageBouton.Size = new System.Drawing.Size(20, 20);
            this.ajouterOuvrageBouton.TabIndex = 0;
            this.ajouterOuvrageBouton.Text = "+";
            this.ajouterOuvrageBouton.UseVisualStyleBackColor = true;
            // 
            // dateEmpruntPicker
            // 
            this.dateEmpruntPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateEmpruntPicker.Location = new System.Drawing.Point(154, 310);
            this.dateEmpruntPicker.Name = "dateEmpruntPicker";
            this.dateEmpruntPicker.Size = new System.Drawing.Size(200, 20);
            this.dateEmpruntPicker.TabIndex = 6;
            // 
            // dureeComboBox
            // 
            this.dureeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dureeComboBox.FormattingEnabled = true;
            this.dureeComboBox.Items.AddRange(new object[] {
            "3 jours",
            "7 jours",
            "14 jours",
            "21 jours"});
            this.dureeComboBox.Location = new System.Drawing.Point(154, 338);
            this.dureeComboBox.Name = "dureeComboBox";
            this.dureeComboBox.Size = new System.Drawing.Size(200, 21);
            this.dureeComboBox.TabIndex = 7;
            // 
            // formSplitContainer
            // 
            this.formSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.formSplitContainer.Name = "formSplitContainer";
            this.formSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // formSplitContainer.Panel1
            // 
            this.formSplitContainer.Panel1.Controls.Add(this.infosTableLayout);
            // 
            // formSplitContainer.Panel2
            // 
            this.formSplitContainer.Panel2.Controls.Add(this.cancelBouton);
            this.formSplitContainer.Panel2.Controls.Add(this.emprunterBouton);
            this.formSplitContainer.Size = new System.Drawing.Size(439, 428);
            this.formSplitContainer.SplitterDistance = 364;
            this.formSplitContainer.TabIndex = 1;
            // 
            // cancelBouton
            // 
            this.cancelBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBouton.Location = new System.Drawing.Point(222, 16);
            this.cancelBouton.Name = "cancelBouton";
            this.cancelBouton.Size = new System.Drawing.Size(94, 28);
            this.cancelBouton.TabIndex = 1;
            this.cancelBouton.Text = "Annuler";
            this.cancelBouton.UseVisualStyleBackColor = true;
            // 
            // emprunterBouton
            // 
            this.emprunterBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emprunterBouton.Location = new System.Drawing.Point(122, 16);
            this.emprunterBouton.Name = "emprunterBouton";
            this.emprunterBouton.Size = new System.Drawing.Size(94, 28);
            this.emprunterBouton.TabIndex = 0;
            this.emprunterBouton.Text = "Emprunter";
            this.emprunterBouton.UseVisualStyleBackColor = true;
            this.emprunterBouton.Click += new System.EventHandler(this.emprunterBouton_Click);
            // 
            // ouvrageTableAdapter1
            // 
            this.ouvrageTableAdapter1.ClearBeforeFill = true;
            // 
            // membreTableAdapter1
            // 
            this.membreTableAdapter1.ClearBeforeFill = true;
            // 
            // addEmpruntResForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 428);
            this.Controls.Add(this.formSplitContainer);
            this.Name = "addEmpruntResForm";
            this.Text = "Ajouter emprunt";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.infosTableLayout.ResumeLayout(false);
            this.infosTableLayout.PerformLayout();
            this.empruntSplitContainer.Panel1.ResumeLayout(false);
            this.empruntSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empruntSplitContainer)).EndInit();
            this.empruntSplitContainer.ResumeLayout(false);
            this.membreNameSplitContainer.Panel1.ResumeLayout(false);
            this.membreNameSplitContainer.Panel1.PerformLayout();
            this.membreNameSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.membreNameSplitContainer)).EndInit();
            this.membreNameSplitContainer.ResumeLayout(false);
            this.ouvrageSplitContainer.Panel1.ResumeLayout(false);
            this.ouvrageSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageSplitContainer)).EndInit();
            this.ouvrageSplitContainer.ResumeLayout(false);
            this.ouvrageNameSplitContainer.Panel1.ResumeLayout(false);
            this.ouvrageNameSplitContainer.Panel1.PerformLayout();
            this.ouvrageNameSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageNameSplitContainer)).EndInit();
            this.ouvrageNameSplitContainer.ResumeLayout(false);
            this.formSplitContainer.Panel1.ResumeLayout(false);
            this.formSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).EndInit();
            this.formSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel infosTableLayout;
        private System.Windows.Forms.Label ouvrageLabel;
        private System.Windows.Forms.Label membreLabel;
        private System.Windows.Forms.Label dateEmpruntLabel;
        private System.Windows.Forms.Label dureeEmpruntLabel;
        private System.Windows.Forms.SplitContainer formSplitContainer;
        private System.Windows.Forms.SplitContainer ouvrageSplitContainer;
        private System.Windows.Forms.SplitContainer ouvrageNameSplitContainer;
        private System.Windows.Forms.TextBox rechOuvrageTextBox;
        private System.Windows.Forms.Label rechOuvrageLabel;
        private System.Windows.Forms.Button ajouterOuvrageBouton;
        private System.Windows.Forms.SplitContainer empruntSplitContainer;
        private System.Windows.Forms.SplitContainer membreNameSplitContainer;
        private System.Windows.Forms.TextBox rechMembreTextBox;
        private System.Windows.Forms.Label rechMembreLabel;
        private System.Windows.Forms.ListBox membreListBox;
        private System.Windows.Forms.Button ajouterMembreBouton;
        private System.Windows.Forms.ListBox ouvrageListBox;
        private System.Windows.Forms.DateTimePicker dateEmpruntPicker;
        private System.Windows.Forms.ComboBox dureeComboBox;
        private BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter ouvrageTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.MembreTableAdapter membreTableAdapter1;
        private System.Windows.Forms.Button cancelBouton;
        private System.Windows.Forms.Button emprunterBouton;
    }
}