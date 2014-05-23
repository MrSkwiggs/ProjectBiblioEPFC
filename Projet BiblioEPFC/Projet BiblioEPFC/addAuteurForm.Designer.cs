namespace ApplicationBiblioEPFC
{
    partial class addAuteurForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAuteurForm));
            this.formSplitContainer = new System.Windows.Forms.SplitContainer();
            this.statutComboBox = new System.Windows.Forms.ComboBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.statutLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.subSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ouvrageDispoGroupBox = new System.Windows.Forms.GroupBox();
            this.ouvragesDispoListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ecritsPanel = new System.Windows.Forms.Panel();
            this.addEcritBouton = new System.Windows.Forms.Button();
            this.ecritsGroupBox = new System.Windows.Forms.GroupBox();
            this.ecritsListBox = new System.Windows.Forms.ListBox();
            this.versEcritsPanel = new System.Windows.Forms.Panel();
            this.removeEcritBouton = new System.Windows.Forms.Button();
            this.swapEcritBouton = new System.Windows.Forms.Button();
            this.versSuperviseLabel = new System.Windows.Forms.Panel();
            this.removeSuperBouton = new System.Windows.Forms.Button();
            this.swapSuperBouton = new System.Windows.Forms.Button();
            this.swapEcritSuper = new System.Windows.Forms.Panel();
            this.moveDownBouton = new System.Windows.Forms.Button();
            this.moveUpBouton = new System.Windows.Forms.Button();
            this.superPanel = new System.Windows.Forms.Panel();
            this.addSuperBouton = new System.Windows.Forms.Button();
            this.superGroupBox = new System.Windows.Forms.GroupBox();
            this.superListBox = new System.Windows.Forms.ListBox();
            this.cancelBouton = new System.Windows.Forms.Button();
            this.ajouterBouton = new System.Windows.Forms.Button();
            this.auteurSuperviseurTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter();
            this.ecrireTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.ecrireTableAdapter();
            this.ouvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter();
            this.ouvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioEPFCDataSet = new ApplicationBiblioEPFC.BiblioEPFCDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).BeginInit();
            this.formSplitContainer.Panel1.SuspendLayout();
            this.formSplitContainer.Panel2.SuspendLayout();
            this.formSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subSplitContainer)).BeginInit();
            this.subSplitContainer.Panel1.SuspendLayout();
            this.subSplitContainer.Panel2.SuspendLayout();
            this.subSplitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ouvrageDispoGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ecritsPanel.SuspendLayout();
            this.ecritsGroupBox.SuspendLayout();
            this.versEcritsPanel.SuspendLayout();
            this.versSuperviseLabel.SuspendLayout();
            this.swapEcritSuper.SuspendLayout();
            this.superPanel.SuspendLayout();
            this.superGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // formSplitContainer
            // 
            this.formSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.formSplitContainer.IsSplitterFixed = true;
            this.formSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.formSplitContainer.Name = "formSplitContainer";
            this.formSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // formSplitContainer.Panel1
            // 
            this.formSplitContainer.Panel1.Controls.Add(this.statutComboBox);
            this.formSplitContainer.Panel1.Controls.Add(this.prenomTextBox);
            this.formSplitContainer.Panel1.Controls.Add(this.nomTextBox);
            this.formSplitContainer.Panel1.Controls.Add(this.statutLabel);
            this.formSplitContainer.Panel1.Controls.Add(this.prenomLabel);
            this.formSplitContainer.Panel1.Controls.Add(this.nomLabel);
            // 
            // formSplitContainer.Panel2
            // 
            this.formSplitContainer.Panel2.Controls.Add(this.subSplitContainer);
            this.formSplitContainer.Size = new System.Drawing.Size(674, 516);
            this.formSplitContainer.SplitterDistance = 85;
            this.formSplitContainer.TabIndex = 0;
            // 
            // statutComboBox
            // 
            this.statutComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statutComboBox.FormattingEnabled = true;
            this.statutComboBox.Items.AddRange(new object[] {
            "auteur",
            "etudiant",
            "professeur"});
            this.statutComboBox.Location = new System.Drawing.Point(481, 32);
            this.statutComboBox.Name = "statutComboBox";
            this.statutComboBox.Size = new System.Drawing.Size(181, 21);
            this.statutComboBox.TabIndex = 5;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prenomTextBox.Location = new System.Drawing.Point(59, 46);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(373, 20);
            this.prenomTextBox.TabIndex = 4;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomTextBox.Location = new System.Drawing.Point(59, 20);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(373, 20);
            this.nomTextBox.TabIndex = 3;
            // 
            // statutLabel
            // 
            this.statutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statutLabel.AutoSize = true;
            this.statutLabel.Location = new System.Drawing.Point(440, 35);
            this.statutLabel.Name = "statutLabel";
            this.statutLabel.Size = new System.Drawing.Size(35, 13);
            this.statutLabel.TabIndex = 2;
            this.statutLabel.Text = "Statut";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(18, 49);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(43, 13);
            this.prenomLabel.TabIndex = 1;
            this.prenomLabel.Text = "Prénom";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(24, 23);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(29, 13);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom";
            // 
            // subSplitContainer
            // 
            this.subSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.subSplitContainer.IsSplitterFixed = true;
            this.subSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.subSplitContainer.Name = "subSplitContainer";
            this.subSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // subSplitContainer.Panel1
            // 
            this.subSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // subSplitContainer.Panel2
            // 
            this.subSplitContainer.Panel2.Controls.Add(this.cancelBouton);
            this.subSplitContainer.Panel2.Controls.Add(this.ajouterBouton);
            this.subSplitContainer.Size = new System.Drawing.Size(674, 427);
            this.subSplitContainer.SplitterDistance = 380;
            this.subSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.7359F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.2641F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ouvrageDispoGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ouvrageDispoGroupBox
            // 
            this.ouvrageDispoGroupBox.Controls.Add(this.ouvragesDispoListBox);
            this.ouvrageDispoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ouvrageDispoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ouvrageDispoGroupBox.Name = "ouvrageDispoGroupBox";
            this.ouvrageDispoGroupBox.Size = new System.Drawing.Size(308, 374);
            this.ouvrageDispoGroupBox.TabIndex = 0;
            this.ouvrageDispoGroupBox.TabStop = false;
            this.ouvrageDispoGroupBox.Text = "Ouvrages disponibles";
            // 
            // ouvragesDispoListBox
            // 
            this.ouvragesDispoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ouvragesDispoListBox.FormattingEnabled = true;
            this.ouvragesDispoListBox.Location = new System.Drawing.Point(3, 16);
            this.ouvragesDispoListBox.Name = "ouvragesDispoListBox";
            this.ouvragesDispoListBox.Size = new System.Drawing.Size(302, 355);
            this.ouvragesDispoListBox.Sorted = true;
            this.ouvragesDispoListBox.TabIndex = 0;
            this.ouvragesDispoListBox.SelectedIndexChanged += new System.EventHandler(this.ouvragesDispoListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ecritsPanel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.versEcritsPanel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.versSuperviseLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.swapEcritSuper, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.superPanel, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(317, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(354, 374);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ecritsPanel
            // 
            this.ecritsPanel.Controls.Add(this.addEcritBouton);
            this.ecritsPanel.Controls.Add(this.ecritsGroupBox);
            this.ecritsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ecritsPanel.Location = new System.Drawing.Point(47, 3);
            this.ecritsPanel.Name = "ecritsPanel";
            this.ecritsPanel.Size = new System.Drawing.Size(304, 161);
            this.ecritsPanel.TabIndex = 0;
            // 
            // addEcritBouton
            // 
            this.addEcritBouton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addEcritBouton.Location = new System.Drawing.Point(275, 69);
            this.addEcritBouton.Name = "addEcritBouton";
            this.addEcritBouton.Size = new System.Drawing.Size(23, 22);
            this.addEcritBouton.TabIndex = 4;
            this.addEcritBouton.Text = "+";
            this.addEcritBouton.UseVisualStyleBackColor = true;
            this.addEcritBouton.Click += new System.EventHandler(this.addEcritBouton_Click);
            // 
            // ecritsGroupBox
            // 
            this.ecritsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ecritsGroupBox.Controls.Add(this.ecritsListBox);
            this.ecritsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ecritsGroupBox.Name = "ecritsGroupBox";
            this.ecritsGroupBox.Size = new System.Drawing.Size(267, 155);
            this.ecritsGroupBox.TabIndex = 3;
            this.ecritsGroupBox.TabStop = false;
            this.ecritsGroupBox.Text = "Ouvrages écrits";
            // 
            // ecritsListBox
            // 
            this.ecritsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ecritsListBox.FormattingEnabled = true;
            this.ecritsListBox.Location = new System.Drawing.Point(3, 16);
            this.ecritsListBox.Name = "ecritsListBox";
            this.ecritsListBox.Size = new System.Drawing.Size(261, 136);
            this.ecritsListBox.Sorted = true;
            this.ecritsListBox.TabIndex = 0;
            // 
            // versEcritsPanel
            // 
            this.versEcritsPanel.Controls.Add(this.removeEcritBouton);
            this.versEcritsPanel.Controls.Add(this.swapEcritBouton);
            this.versEcritsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versEcritsPanel.Location = new System.Drawing.Point(3, 3);
            this.versEcritsPanel.Name = "versEcritsPanel";
            this.versEcritsPanel.Size = new System.Drawing.Size(38, 161);
            this.versEcritsPanel.TabIndex = 0;
            // 
            // removeEcritBouton
            // 
            this.removeEcritBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeEcritBouton.Location = new System.Drawing.Point(3, 83);
            this.removeEcritBouton.Name = "removeEcritBouton";
            this.removeEcritBouton.Size = new System.Drawing.Size(32, 24);
            this.removeEcritBouton.TabIndex = 1;
            this.removeEcritBouton.Text = "<-";
            this.removeEcritBouton.UseVisualStyleBackColor = true;
            this.removeEcritBouton.Click += new System.EventHandler(this.removeEcritBouton_Click);
            // 
            // swapEcritBouton
            // 
            this.swapEcritBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.swapEcritBouton.Location = new System.Drawing.Point(3, 53);
            this.swapEcritBouton.Name = "swapEcritBouton";
            this.swapEcritBouton.Size = new System.Drawing.Size(32, 24);
            this.swapEcritBouton.TabIndex = 0;
            this.swapEcritBouton.Text = "->";
            this.swapEcritBouton.UseVisualStyleBackColor = true;
            this.swapEcritBouton.Click += new System.EventHandler(this.swapEcritBouton_Click);
            // 
            // versSuperviseLabel
            // 
            this.versSuperviseLabel.Controls.Add(this.removeSuperBouton);
            this.versSuperviseLabel.Controls.Add(this.swapSuperBouton);
            this.versSuperviseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versSuperviseLabel.Location = new System.Drawing.Point(3, 210);
            this.versSuperviseLabel.Name = "versSuperviseLabel";
            this.versSuperviseLabel.Size = new System.Drawing.Size(38, 161);
            this.versSuperviseLabel.TabIndex = 1;
            // 
            // removeSuperBouton
            // 
            this.removeSuperBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeSuperBouton.Location = new System.Drawing.Point(3, 83);
            this.removeSuperBouton.Name = "removeSuperBouton";
            this.removeSuperBouton.Size = new System.Drawing.Size(32, 24);
            this.removeSuperBouton.TabIndex = 3;
            this.removeSuperBouton.Text = "<-";
            this.removeSuperBouton.UseVisualStyleBackColor = true;
            this.removeSuperBouton.Click += new System.EventHandler(this.removeSuperBouton_Click);
            // 
            // swapSuperBouton
            // 
            this.swapSuperBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.swapSuperBouton.Location = new System.Drawing.Point(3, 53);
            this.swapSuperBouton.Name = "swapSuperBouton";
            this.swapSuperBouton.Size = new System.Drawing.Size(32, 24);
            this.swapSuperBouton.TabIndex = 2;
            this.swapSuperBouton.Text = "->";
            this.swapSuperBouton.UseVisualStyleBackColor = true;
            this.swapSuperBouton.Click += new System.EventHandler(this.swapSuperBouton_Click);
            // 
            // swapEcritSuper
            // 
            this.swapEcritSuper.Controls.Add(this.moveDownBouton);
            this.swapEcritSuper.Controls.Add(this.moveUpBouton);
            this.swapEcritSuper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swapEcritSuper.Location = new System.Drawing.Point(47, 170);
            this.swapEcritSuper.Name = "swapEcritSuper";
            this.swapEcritSuper.Size = new System.Drawing.Size(304, 34);
            this.swapEcritSuper.TabIndex = 2;
            // 
            // moveDownBouton
            // 
            this.moveDownBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moveDownBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveDownBouton.Location = new System.Drawing.Point(155, 3);
            this.moveDownBouton.Name = "moveDownBouton";
            this.moveDownBouton.Size = new System.Drawing.Size(27, 28);
            this.moveDownBouton.TabIndex = 6;
            this.moveDownBouton.Text = "˅";
            this.moveDownBouton.UseVisualStyleBackColor = true;
            this.moveDownBouton.Click += new System.EventHandler(this.moveDownBouton_Click);
            // 
            // moveUpBouton
            // 
            this.moveUpBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moveUpBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUpBouton.Location = new System.Drawing.Point(122, 3);
            this.moveUpBouton.Name = "moveUpBouton";
            this.moveUpBouton.Size = new System.Drawing.Size(27, 28);
            this.moveUpBouton.TabIndex = 5;
            this.moveUpBouton.Text = "˄";
            this.moveUpBouton.UseVisualStyleBackColor = true;
            this.moveUpBouton.Click += new System.EventHandler(this.moveUpBouton_Click);
            // 
            // superPanel
            // 
            this.superPanel.Controls.Add(this.addSuperBouton);
            this.superPanel.Controls.Add(this.superGroupBox);
            this.superPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superPanel.Location = new System.Drawing.Point(47, 210);
            this.superPanel.Name = "superPanel";
            this.superPanel.Size = new System.Drawing.Size(304, 161);
            this.superPanel.TabIndex = 3;
            // 
            // addSuperBouton
            // 
            this.addSuperBouton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addSuperBouton.Location = new System.Drawing.Point(275, 69);
            this.addSuperBouton.Name = "addSuperBouton";
            this.addSuperBouton.Size = new System.Drawing.Size(23, 22);
            this.addSuperBouton.TabIndex = 5;
            this.addSuperBouton.Text = "+";
            this.addSuperBouton.UseVisualStyleBackColor = true;
            // 
            // superGroupBox
            // 
            this.superGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.superGroupBox.Controls.Add(this.superListBox);
            this.superGroupBox.Location = new System.Drawing.Point(3, 3);
            this.superGroupBox.Name = "superGroupBox";
            this.superGroupBox.Size = new System.Drawing.Size(267, 155);
            this.superGroupBox.TabIndex = 0;
            this.superGroupBox.TabStop = false;
            this.superGroupBox.Text = "Ouvrages supervisés";
            // 
            // superListBox
            // 
            this.superListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superListBox.FormattingEnabled = true;
            this.superListBox.Location = new System.Drawing.Point(3, 16);
            this.superListBox.Name = "superListBox";
            this.superListBox.Size = new System.Drawing.Size(261, 136);
            this.superListBox.Sorted = true;
            this.superListBox.TabIndex = 0;
            // 
            // cancelBouton
            // 
            this.cancelBouton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cancelBouton.Location = new System.Drawing.Point(340, 5);
            this.cancelBouton.Name = "cancelBouton";
            this.cancelBouton.Size = new System.Drawing.Size(90, 32);
            this.cancelBouton.TabIndex = 1;
            this.cancelBouton.Text = "Annuler";
            this.cancelBouton.UseVisualStyleBackColor = true;
            this.cancelBouton.Click += new System.EventHandler(this.cancelBouton_Click);
            // 
            // ajouterBouton
            // 
            this.ajouterBouton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ajouterBouton.Location = new System.Drawing.Point(244, 5);
            this.ajouterBouton.Name = "ajouterBouton";
            this.ajouterBouton.Size = new System.Drawing.Size(90, 32);
            this.ajouterBouton.TabIndex = 0;
            this.ajouterBouton.Text = "Ajouter";
            this.ajouterBouton.UseVisualStyleBackColor = true;
            this.ajouterBouton.Click += new System.EventHandler(this.ajouterBouton_Click);
            // 
            // auteurSuperviseurTableAdapter1
            // 
            this.auteurSuperviseurTableAdapter1.ClearBeforeFill = true;
            // 
            // ecrireTableAdapter1
            // 
            this.ecrireTableAdapter1.ClearBeforeFill = true;
            // 
            // ouvrageTableAdapter1
            // 
            this.ouvrageTableAdapter1.ClearBeforeFill = true;
            // 
            // ouvrageBindingSource
            // 
            this.ouvrageBindingSource.DataMember = "Ouvrage";
            this.ouvrageBindingSource.DataSource = this.biblioEPFCDataSet;
            // 
            // biblioEPFCDataSet
            // 
            this.biblioEPFCDataSet.DataSetName = "BiblioEPFCDataSet";
            this.biblioEPFCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addAuteurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 516);
            this.Controls.Add(this.formSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "addAuteurForm";
            this.Text = "Ajouteur auteur";
            this.Load += new System.EventHandler(this.addAuteurForm_Load);
            this.formSplitContainer.Panel1.ResumeLayout(false);
            this.formSplitContainer.Panel1.PerformLayout();
            this.formSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).EndInit();
            this.formSplitContainer.ResumeLayout(false);
            this.subSplitContainer.Panel1.ResumeLayout(false);
            this.subSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subSplitContainer)).EndInit();
            this.subSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ouvrageDispoGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ecritsPanel.ResumeLayout(false);
            this.ecritsGroupBox.ResumeLayout(false);
            this.versEcritsPanel.ResumeLayout(false);
            this.versSuperviseLabel.ResumeLayout(false);
            this.swapEcritSuper.ResumeLayout(false);
            this.superPanel.ResumeLayout(false);
            this.superGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter auteurSuperviseurTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.ecrireTableAdapter ecrireTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter ouvrageTableAdapter1;
        private System.Windows.Forms.SplitContainer formSplitContainer;
        private System.Windows.Forms.Label statutLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.ComboBox statutComboBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.SplitContainer subSplitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox ouvrageDispoGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel versEcritsPanel;
        private System.Windows.Forms.Button removeEcritBouton;
        private System.Windows.Forms.Button swapEcritBouton;
        private System.Windows.Forms.Panel versSuperviseLabel;
        private System.Windows.Forms.Button removeSuperBouton;
        private System.Windows.Forms.Button swapSuperBouton;
        private System.Windows.Forms.Panel swapEcritSuper;
        private System.Windows.Forms.Button cancelBouton;
        private System.Windows.Forms.Button ajouterBouton;
        private System.Windows.Forms.ListBox ouvragesDispoListBox;
        private System.Windows.Forms.BindingSource ouvrageBindingSource;
        private BiblioEPFCDataSet biblioEPFCDataSet;
        private System.Windows.Forms.Panel ecritsPanel;
        private System.Windows.Forms.Button addEcritBouton;
        private System.Windows.Forms.GroupBox ecritsGroupBox;
        private System.Windows.Forms.ListBox ecritsListBox;
        private System.Windows.Forms.Button moveDownBouton;
        private System.Windows.Forms.Button moveUpBouton;
        private System.Windows.Forms.Panel superPanel;
        private System.Windows.Forms.Button addSuperBouton;
        private System.Windows.Forms.GroupBox superGroupBox;
        private System.Windows.Forms.ListBox superListBox;
    }
}