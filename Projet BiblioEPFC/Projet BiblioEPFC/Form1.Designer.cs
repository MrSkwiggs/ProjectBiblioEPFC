using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ouvragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterOuvrageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMembreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterEmpruntMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterReservationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.formSplitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.labelRechercher = new System.Windows.Forms.Label();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.generalTreeView = new System.Windows.Forms.TreeView();
            this.ouvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioEPFCDataSet = new WindowsFormsApplication1.BiblioEPFCDataSet();
            this.infoTabs = new System.Windows.Forms.TabControl();
            this.ouvrageInfoPage = new System.Windows.Forms.TabPage();
            this.tableLayoutOuvrageInfo = new System.Windows.Forms.TableLayoutPanel();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.infosTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.auteursListBox = new System.Windows.Forms.ListBox();
            this.auteursLabel = new System.Windows.Forms.Label();
            this.titreLabel = new System.Windows.Forms.Label();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateCreaLabel = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.localLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.superLabel = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.entrepriseLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editerOuvrageBouton = new System.Windows.Forms.Button();
            this.empruntBox = new System.Windows.Forms.GroupBox();
            this.empruntSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.emprunteParLabel = new System.Windows.Forms.Label();
            this.dateEmpruntLabel = new System.Windows.Forms.Label();
            this.dureeEmpruntLabel = new System.Windows.Forms.Label();
            this.etatEmpruntLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ajouterEmpruntBouton = new System.Windows.Forms.Button();
            this.boutonSuppEmprunt = new System.Windows.Forms.Button();
            this.reservationBox = new System.Windows.Forms.GroupBox();
            this.reservationSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ajouterReservBouton = new System.Windows.Forms.Button();
            this.suppReservBouton = new System.Windows.Forms.Button();
            this.auteurInfoPage = new System.Windows.Forms.TabPage();
            this.membreInfoPage = new System.Windows.Forms.TabPage();
            this.empruntInfoPage = new System.Windows.Forms.TabPage();
            this.reservationInfoPage = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ouvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter();
            this.membreTableAdapter1 = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.MembreTableAdapter();
            this.auteurParOuvrageTableAdapter1 = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.AuteurParOuvrageTableAdapter();
            this.superParOuvrageTableAdapter1 = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.SuperParOuvrageTableAdapter();
            this.empruntMembreParOuvrageTableAdapter1 = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.EmpruntMembreParOuvrageTableAdapter();
            this.reservationParOuvrageTableAdapter1 = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.ReservationParOuvrageTableAdapter();
            this.auteurSuperviseurTableAdapter1 = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).BeginInit();
            this.formSplitContainer.Panel1.SuspendLayout();
            this.formSplitContainer.Panel2.SuspendLayout();
            this.formSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).BeginInit();
            this.infoTabs.SuspendLayout();
            this.ouvrageInfoPage.SuspendLayout();
            this.tableLayoutOuvrageInfo.SuspendLayout();
            this.infoBox.SuspendLayout();
            this.infosTableLayout.SuspendLayout();
            this.empruntBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empruntSplitContainer)).BeginInit();
            this.empruntSplitContainer.Panel1.SuspendLayout();
            this.empruntSplitContainer.Panel2.SuspendLayout();
            this.empruntSplitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.reservationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationSplitContainer)).BeginInit();
            this.reservationSplitContainer.Panel1.SuspendLayout();
            this.reservationSplitContainer.Panel2.SuspendLayout();
            this.reservationSplitContainer.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvragesToolStripMenuItem,
            this.membresToolStripMenuItem,
            this.empruntsToolStripMenuItem,
            this.réservationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ouvragesToolStripMenuItem
            // 
            this.ouvragesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterOuvrageMenu,
            this.supprimerToolStripMenuItem});
            this.ouvragesToolStripMenuItem.Name = "ouvragesToolStripMenuItem";
            this.ouvragesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.ouvragesToolStripMenuItem.Text = "Ouvrage";
            // 
            // ajouterOuvrageMenu
            // 
            this.ajouterOuvrageMenu.Name = "ajouterOuvrageMenu";
            this.ajouterOuvrageMenu.Size = new System.Drawing.Size(152, 22);
            this.ajouterOuvrageMenu.Text = "Ajouter";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // membresToolStripMenuItem
            // 
            this.membresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterMembreMenu,
            this.supprimerToolStripMenuItem2});
            this.membresToolStripMenuItem.Name = "membresToolStripMenuItem";
            this.membresToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.membresToolStripMenuItem.Text = "Membre";
            // 
            // ajouterMembreMenu
            // 
            this.ajouterMembreMenu.Name = "ajouterMembreMenu";
            this.ajouterMembreMenu.Size = new System.Drawing.Size(152, 22);
            this.ajouterMembreMenu.Text = "Ajouter";
            // 
            // supprimerToolStripMenuItem2
            // 
            this.supprimerToolStripMenuItem2.Name = "supprimerToolStripMenuItem2";
            this.supprimerToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem2.Text = "Supprimer";
            // 
            // empruntsToolStripMenuItem
            // 
            this.empruntsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterEmpruntMenu,
            this.supprimerToolStripMenuItem1});
            this.empruntsToolStripMenuItem.Name = "empruntsToolStripMenuItem";
            this.empruntsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.empruntsToolStripMenuItem.Text = "Emprunt";
            // 
            // ajouterEmpruntMenu
            // 
            this.ajouterEmpruntMenu.Name = "ajouterEmpruntMenu";
            this.ajouterEmpruntMenu.Size = new System.Drawing.Size(152, 22);
            this.ajouterEmpruntMenu.Text = "Ajouter";
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            // 
            // réservationsToolStripMenuItem
            // 
            this.réservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterReservationMenu,
            this.supprimerToolStripMenuItem3});
            this.réservationsToolStripMenuItem.Name = "réservationsToolStripMenuItem";
            this.réservationsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.réservationsToolStripMenuItem.Text = "Réservation";
            // 
            // ajouterReservationMenu
            // 
            this.ajouterReservationMenu.Name = "ajouterReservationMenu";
            this.ajouterReservationMenu.Size = new System.Drawing.Size(152, 22);
            this.ajouterReservationMenu.Text = "Ajouter";
            this.ajouterReservationMenu.Click += new System.EventHandler(this.ajouterToolStripMenuItem3_Click);
            // 
            // supprimerToolStripMenuItem3
            // 
            this.supprimerToolStripMenuItem3.Name = "supprimerToolStripMenuItem3";
            this.supprimerToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem3.Text = "Supprimer";
            // 
            // formSplitContainer
            // 
            this.formSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.formSplitContainer.IsSplitterFixed = true;
            this.formSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.formSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.formSplitContainer.Name = "formSplitContainer";
            // 
            // formSplitContainer.Panel1
            // 
            this.formSplitContainer.Panel1.Controls.Add(this.splitContainer2);
            this.formSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // formSplitContainer.Panel2
            // 
            this.formSplitContainer.Panel2.Controls.Add(this.infoTabs);
            this.formSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.formSplitContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.formSplitContainer.Size = new System.Drawing.Size(996, 563);
            this.formSplitContainer.SplitterDistance = 229;
            this.formSplitContainer.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.MinimumSize = new System.Drawing.Size(223, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.generalTreeView);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(223, 557);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.labelRechercher);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.textBoxRechercher);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer3.Size = new System.Drawing.Size(220, 26);
            this.splitContainer3.SplitterDistance = 73;
            this.splitContainer3.TabIndex = 0;
            // 
            // labelRechercher
            // 
            this.labelRechercher.AutoSize = true;
            this.labelRechercher.Location = new System.Drawing.Point(9, 6);
            this.labelRechercher.Name = "labelRechercher";
            this.labelRechercher.Size = new System.Drawing.Size(63, 13);
            this.labelRechercher.TabIndex = 0;
            this.labelRechercher.Text = "Rechercher";
            // 
            // textBoxRechercher
            // 
            this.textBoxRechercher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRechercher.Location = new System.Drawing.Point(3, 3);
            this.textBoxRechercher.Name = "textBoxRechercher";
            this.textBoxRechercher.Size = new System.Drawing.Size(140, 20);
            this.textBoxRechercher.TabIndex = 0;
            this.textBoxRechercher.WordWrap = false;
            this.textBoxRechercher.TextChanged += new System.EventHandler(this.textBoxRechercher_TextChanged);
            // 
            // generalTreeView
            // 
            this.generalTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalTreeView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.ouvrageBindingSource, "titre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "null"));
            this.generalTreeView.Location = new System.Drawing.Point(3, 3);
            this.generalTreeView.Name = "generalTreeView";
            this.generalTreeView.Size = new System.Drawing.Size(217, 530);
            this.generalTreeView.TabIndex = 0;
            this.generalTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.generalTreeView_NodeMouseClick);
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
            // infoTabs
            // 
            this.infoTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoTabs.Controls.Add(this.ouvrageInfoPage);
            this.infoTabs.Controls.Add(this.auteurInfoPage);
            this.infoTabs.Controls.Add(this.membreInfoPage);
            this.infoTabs.Controls.Add(this.empruntInfoPage);
            this.infoTabs.Controls.Add(this.reservationInfoPage);
            this.infoTabs.Location = new System.Drawing.Point(3, 3);
            this.infoTabs.Name = "infoTabs";
            this.infoTabs.SelectedIndex = 0;
            this.infoTabs.Size = new System.Drawing.Size(756, 557);
            this.infoTabs.TabIndex = 0;
            // 
            // ouvrageInfoPage
            // 
            this.ouvrageInfoPage.Controls.Add(this.tableLayoutOuvrageInfo);
            this.ouvrageInfoPage.Location = new System.Drawing.Point(4, 22);
            this.ouvrageInfoPage.Name = "ouvrageInfoPage";
            this.ouvrageInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.ouvrageInfoPage.Size = new System.Drawing.Size(748, 531);
            this.ouvrageInfoPage.TabIndex = 0;
            this.ouvrageInfoPage.Text = "Ouvrage";
            this.ouvrageInfoPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutOuvrageInfo
            // 
            this.tableLayoutOuvrageInfo.ColumnCount = 1;
            this.tableLayoutOuvrageInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutOuvrageInfo.Controls.Add(this.infoBox, 0, 0);
            this.tableLayoutOuvrageInfo.Controls.Add(this.empruntBox, 0, 1);
            this.tableLayoutOuvrageInfo.Controls.Add(this.reservationBox, 0, 2);
            this.tableLayoutOuvrageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutOuvrageInfo.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutOuvrageInfo.Name = "tableLayoutOuvrageInfo";
            this.tableLayoutOuvrageInfo.RowCount = 3;
            this.tableLayoutOuvrageInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOuvrageInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutOuvrageInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutOuvrageInfo.Size = new System.Drawing.Size(742, 525);
            this.tableLayoutOuvrageInfo.TabIndex = 0;
            // 
            // infoBox
            // 
            this.infoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBox.Controls.Add(this.infosTableLayout);
            this.infoBox.Location = new System.Drawing.Point(3, 3);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(736, 256);
            this.infoBox.TabIndex = 0;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Infos";
            // 
            // infosTableLayout
            // 
            this.infosTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infosTableLayout.ColumnCount = 4;
            this.infosTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.infosTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.infosTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.infosTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.infosTableLayout.Controls.Add(this.auteursListBox, 3, 0);
            this.infosTableLayout.Controls.Add(this.auteursLabel, 2, 0);
            this.infosTableLayout.Controls.Add(this.titreLabel, 0, 0);
            this.infosTableLayout.Controls.Add(this.titreTextBox, 1, 0);
            this.infosTableLayout.Controls.Add(this.textBox2, 1, 1);
            this.infosTableLayout.Controls.Add(this.dateCreaLabel, 0, 1);
            this.infosTableLayout.Controls.Add(this.sectionLabel, 0, 2);
            this.infosTableLayout.Controls.Add(this.textBox4, 1, 2);
            this.infosTableLayout.Controls.Add(this.localLabel, 0, 3);
            this.infosTableLayout.Controls.Add(this.textBox3, 1, 3);
            this.infosTableLayout.Controls.Add(this.superLabel, 2, 1);
            this.infosTableLayout.Controls.Add(this.textBox13, 3, 1);
            this.infosTableLayout.Controls.Add(this.entrepriseLabel, 2, 2);
            this.infosTableLayout.Controls.Add(this.textBox1, 3, 2);
            this.infosTableLayout.Controls.Add(this.editerOuvrageBouton, 3, 3);
            this.infosTableLayout.Location = new System.Drawing.Point(3, 16);
            this.infosTableLayout.Name = "infosTableLayout";
            this.infosTableLayout.RowCount = 4;
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infosTableLayout.Size = new System.Drawing.Size(730, 237);
            this.infosTableLayout.TabIndex = 0;
            // 
            // auteursListBox
            // 
            this.auteursListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auteursListBox.FormattingEnabled = true;
            this.auteursListBox.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "c",
            "d",
            "e",
            "f",
            "r"});
            this.auteursListBox.Location = new System.Drawing.Point(441, 3);
            this.auteursListBox.MinimumSize = new System.Drawing.Size(4, 56);
            this.auteursListBox.Name = "auteursListBox";
            this.auteursListBox.Size = new System.Drawing.Size(286, 56);
            this.auteursListBox.Sorted = true;
            this.auteursListBox.TabIndex = 1;
            // 
            // auteursLabel
            // 
            this.auteursLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.auteursLabel.AutoSize = true;
            this.auteursLabel.Location = new System.Drawing.Point(386, 23);
            this.auteursLabel.Name = "auteursLabel";
            this.auteursLabel.Size = new System.Drawing.Size(49, 13);
            this.auteursLabel.TabIndex = 0;
            this.auteursLabel.Text = "Auteur(s)";
            this.auteursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titreLabel
            // 
            this.titreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.titreLabel.AutoSize = true;
            this.titreLabel.Location = new System.Drawing.Point(42, 23);
            this.titreLabel.Name = "titreLabel";
            this.titreLabel.Size = new System.Drawing.Size(28, 13);
            this.titreLabel.TabIndex = 2;
            this.titreLabel.Text = "Titre";
            this.titreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titreTextBox
            // 
            this.titreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titreTextBox.Location = new System.Drawing.Point(76, 19);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.ReadOnly = true;
            this.titreTextBox.Size = new System.Drawing.Size(286, 20);
            this.titreTextBox.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(76, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(286, 20);
            this.textBox2.TabIndex = 4;
            // 
            // dateCreaLabel
            // 
            this.dateCreaLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateCreaLabel.AutoSize = true;
            this.dateCreaLabel.Location = new System.Drawing.Point(22, 75);
            this.dateCreaLabel.Name = "dateCreaLabel";
            this.dateCreaLabel.Size = new System.Drawing.Size(48, 26);
            this.dateCreaLabel.TabIndex = 7;
            this.dateCreaLabel.Text = "Date de création";
            // 
            // sectionLabel
            // 
            this.sectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(27, 141);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(43, 13);
            this.sectionLabel.TabIndex = 9;
            this.sectionLabel.Text = "Section";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(76, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(286, 20);
            this.textBox4.TabIndex = 6;
            // 
            // localLabel
            // 
            this.localLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.localLabel.AutoSize = true;
            this.localLabel.Location = new System.Drawing.Point(7, 200);
            this.localLabel.Name = "localLabel";
            this.localLabel.Size = new System.Drawing.Size(63, 13);
            this.localLabel.TabIndex = 8;
            this.localLabel.Text = "Localisation";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(76, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(286, 20);
            this.textBox3.TabIndex = 5;
            // 
            // superLabel
            // 
            this.superLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.superLabel.AutoSize = true;
            this.superLabel.Location = new System.Drawing.Point(370, 82);
            this.superLabel.Name = "superLabel";
            this.superLabel.Size = new System.Drawing.Size(63, 13);
            this.superLabel.TabIndex = 12;
            this.superLabel.Text = "Superviseur";
            this.superLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox13.Location = new System.Drawing.Point(441, 78);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(286, 20);
            this.textBox13.TabIndex = 13;
            // 
            // entrepriseLabel
            // 
            this.entrepriseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entrepriseLabel.AutoSize = true;
            this.entrepriseLabel.Location = new System.Drawing.Point(381, 141);
            this.entrepriseLabel.Name = "entrepriseLabel";
            this.entrepriseLabel.Size = new System.Drawing.Size(54, 13);
            this.entrepriseLabel.TabIndex = 10;
            this.entrepriseLabel.Text = "Entreprise";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(441, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 11;
            // 
            // editerOuvrageBouton
            // 
            this.editerOuvrageBouton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editerOuvrageBouton.ForeColor = System.Drawing.Color.DarkBlue;
            this.editerOuvrageBouton.Location = new System.Drawing.Point(441, 192);
            this.editerOuvrageBouton.Name = "editerOuvrageBouton";
            this.editerOuvrageBouton.Size = new System.Drawing.Size(286, 30);
            this.editerOuvrageBouton.TabIndex = 14;
            this.editerOuvrageBouton.Text = "Éditer";
            this.editerOuvrageBouton.UseVisualStyleBackColor = true;
            // 
            // empruntBox
            // 
            this.empruntBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empruntBox.Controls.Add(this.empruntSplitContainer);
            this.empruntBox.Location = new System.Drawing.Point(3, 265);
            this.empruntBox.Name = "empruntBox";
            this.empruntBox.Size = new System.Drawing.Size(736, 125);
            this.empruntBox.TabIndex = 1;
            this.empruntBox.TabStop = false;
            this.empruntBox.Text = "Emprunt";
            // 
            // empruntSplitContainer
            // 
            this.empruntSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empruntSplitContainer.Location = new System.Drawing.Point(3, 16);
            this.empruntSplitContainer.Name = "empruntSplitContainer";
            // 
            // empruntSplitContainer.Panel1
            // 
            this.empruntSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // empruntSplitContainer.Panel2
            // 
            this.empruntSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.empruntSplitContainer.Size = new System.Drawing.Size(730, 106);
            this.empruntSplitContainer.SplitterDistance = 607;
            this.empruntSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.emprunteParLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateEmpruntLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dureeEmpruntLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.etatEmpruntLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 106);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(365, 69);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(239, 20);
            this.textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(63, 69);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(236, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(365, 16);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(239, 20);
            this.textBox6.TabIndex = 5;
            // 
            // emprunteParLabel
            // 
            this.emprunteParLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.emprunteParLabel.AutoSize = true;
            this.emprunteParLabel.Location = new System.Drawing.Point(5, 13);
            this.emprunteParLabel.Name = "emprunteParLabel";
            this.emprunteParLabel.Size = new System.Drawing.Size(52, 26);
            this.emprunteParLabel.TabIndex = 0;
            this.emprunteParLabel.Text = "Emprunté par ";
            this.emprunteParLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEmpruntLabel
            // 
            this.dateEmpruntLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateEmpruntLabel.AutoSize = true;
            this.dateEmpruntLabel.Location = new System.Drawing.Point(27, 73);
            this.dateEmpruntLabel.Name = "dateEmpruntLabel";
            this.dateEmpruntLabel.Size = new System.Drawing.Size(30, 13);
            this.dateEmpruntLabel.TabIndex = 1;
            this.dateEmpruntLabel.Text = "Date";
            this.dateEmpruntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dureeEmpruntLabel
            // 
            this.dureeEmpruntLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dureeEmpruntLabel.AutoSize = true;
            this.dureeEmpruntLabel.Location = new System.Drawing.Point(323, 20);
            this.dureeEmpruntLabel.Name = "dureeEmpruntLabel";
            this.dureeEmpruntLabel.Size = new System.Drawing.Size(36, 13);
            this.dureeEmpruntLabel.TabIndex = 2;
            this.dureeEmpruntLabel.Text = "Durée";
            this.dureeEmpruntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // etatEmpruntLabel
            // 
            this.etatEmpruntLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.etatEmpruntLabel.AutoSize = true;
            this.etatEmpruntLabel.Location = new System.Drawing.Point(333, 73);
            this.etatEmpruntLabel.Name = "etatEmpruntLabel";
            this.etatEmpruntLabel.Size = new System.Drawing.Size(26, 13);
            this.etatEmpruntLabel.TabIndex = 3;
            this.etatEmpruntLabel.Text = "État";
            this.etatEmpruntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(63, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(236, 20);
            this.textBox5.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ajouterEmpruntBouton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.boutonSuppEmprunt, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(119, 106);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ajouterEmpruntBouton
            // 
            this.ajouterEmpruntBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterEmpruntBouton.ForeColor = System.Drawing.Color.DarkGreen;
            this.ajouterEmpruntBouton.Location = new System.Drawing.Point(9, 11);
            this.ajouterEmpruntBouton.Name = "ajouterEmpruntBouton";
            this.ajouterEmpruntBouton.Size = new System.Drawing.Size(100, 30);
            this.ajouterEmpruntBouton.TabIndex = 0;
            this.ajouterEmpruntBouton.Text = "Ajouter Emprunt";
            this.ajouterEmpruntBouton.UseVisualStyleBackColor = true;
            // 
            // boutonSuppEmprunt
            // 
            this.boutonSuppEmprunt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boutonSuppEmprunt.Enabled = false;
            this.boutonSuppEmprunt.ForeColor = System.Drawing.Color.DarkRed;
            this.boutonSuppEmprunt.Location = new System.Drawing.Point(9, 64);
            this.boutonSuppEmprunt.Name = "boutonSuppEmprunt";
            this.boutonSuppEmprunt.Size = new System.Drawing.Size(100, 30);
            this.boutonSuppEmprunt.TabIndex = 1;
            this.boutonSuppEmprunt.Text = "Suppr. Emprunt";
            this.boutonSuppEmprunt.UseVisualStyleBackColor = true;
            // 
            // reservationBox
            // 
            this.reservationBox.Controls.Add(this.reservationSplitContainer);
            this.reservationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationBox.Location = new System.Drawing.Point(3, 396);
            this.reservationBox.Name = "reservationBox";
            this.reservationBox.Size = new System.Drawing.Size(736, 126);
            this.reservationBox.TabIndex = 2;
            this.reservationBox.TabStop = false;
            this.reservationBox.Text = "Réservation(s)";
            // 
            // reservationSplitContainer
            // 
            this.reservationSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationSplitContainer.Location = new System.Drawing.Point(3, 16);
            this.reservationSplitContainer.Name = "reservationSplitContainer";
            // 
            // reservationSplitContainer.Panel1
            // 
            this.reservationSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // reservationSplitContainer.Panel2
            // 
            this.reservationSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.reservationSplitContainer.Size = new System.Drawing.Size(730, 107);
            this.reservationSplitContainer.SplitterDistance = 607;
            this.reservationSplitContainer.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.textBox12, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox11, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox10, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox9, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(607, 107);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Location = new System.Drawing.Point(365, 70);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(239, 20);
            this.textBox12.TabIndex = 8;
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.Location = new System.Drawing.Point(63, 70);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(236, 20);
            this.textBox11.TabIndex = 7;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Location = new System.Drawing.Point(365, 16);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(239, 20);
            this.textBox10.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.Location = new System.Drawing.Point(63, 16);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(236, 20);
            this.textBox9.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.ajouterReservBouton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.suppReservBouton, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(119, 107);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // ajouterReservBouton
            // 
            this.ajouterReservBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterReservBouton.ForeColor = System.Drawing.Color.DarkGreen;
            this.ajouterReservBouton.Location = new System.Drawing.Point(9, 6);
            this.ajouterReservBouton.Name = "ajouterReservBouton";
            this.ajouterReservBouton.Size = new System.Drawing.Size(100, 40);
            this.ajouterReservBouton.TabIndex = 0;
            this.ajouterReservBouton.Text = "Ajouter Réservation";
            this.ajouterReservBouton.UseVisualStyleBackColor = true;
            // 
            // suppReservBouton
            // 
            this.suppReservBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.suppReservBouton.ForeColor = System.Drawing.Color.DarkRed;
            this.suppReservBouton.Location = new System.Drawing.Point(9, 60);
            this.suppReservBouton.Name = "suppReservBouton";
            this.suppReservBouton.Size = new System.Drawing.Size(100, 40);
            this.suppReservBouton.TabIndex = 1;
            this.suppReservBouton.Text = "Supprimer Réservation";
            this.suppReservBouton.UseVisualStyleBackColor = true;
            // 
            // auteurInfoPage
            // 
            this.auteurInfoPage.Location = new System.Drawing.Point(4, 22);
            this.auteurInfoPage.Name = "auteurInfoPage";
            this.auteurInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.auteurInfoPage.Size = new System.Drawing.Size(748, 531);
            this.auteurInfoPage.TabIndex = 1;
            this.auteurInfoPage.Text = "Auteur";
            this.auteurInfoPage.UseVisualStyleBackColor = true;
            // 
            // membreInfoPage
            // 
            this.membreInfoPage.Location = new System.Drawing.Point(4, 22);
            this.membreInfoPage.Name = "membreInfoPage";
            this.membreInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.membreInfoPage.Size = new System.Drawing.Size(748, 531);
            this.membreInfoPage.TabIndex = 2;
            this.membreInfoPage.Text = "Membre";
            this.membreInfoPage.UseVisualStyleBackColor = true;
            // 
            // empruntInfoPage
            // 
            this.empruntInfoPage.Location = new System.Drawing.Point(4, 22);
            this.empruntInfoPage.Name = "empruntInfoPage";
            this.empruntInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.empruntInfoPage.Size = new System.Drawing.Size(748, 531);
            this.empruntInfoPage.TabIndex = 3;
            this.empruntInfoPage.Text = "Emprunt";
            this.empruntInfoPage.UseVisualStyleBackColor = true;
            // 
            // reservationInfoPage
            // 
            this.reservationInfoPage.Location = new System.Drawing.Point(4, 22);
            this.reservationInfoPage.Name = "reservationInfoPage";
            this.reservationInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.reservationInfoPage.Size = new System.Drawing.Size(748, 531);
            this.reservationInfoPage.TabIndex = 4;
            this.reservationInfoPage.Text = "Réservation(s)";
            this.reservationInfoPage.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(996, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ouvrageTableAdapter
            // 
            this.ouvrageTableAdapter.ClearBeforeFill = true;
            // 
            // membreTableAdapter1
            // 
            this.membreTableAdapter1.ClearBeforeFill = true;
            // 
            // auteurParOuvrageTableAdapter1
            // 
            this.auteurParOuvrageTableAdapter1.ClearBeforeFill = true;
            // 
            // superParOuvrageTableAdapter1
            // 
            this.superParOuvrageTableAdapter1.ClearBeforeFill = true;
            // 
            // empruntMembreParOuvrageTableAdapter1
            // 
            this.empruntMembreParOuvrageTableAdapter1.ClearBeforeFill = true;
            // 
            // reservationParOuvrageTableAdapter1
            // 
            this.reservationParOuvrageTableAdapter1.ClearBeforeFill = true;
            // 
            // auteurSuperviseurTableAdapter1
            // 
            this.auteurSuperviseurTableAdapter1.ClearBeforeFill = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 609);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.formSplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblio EPFC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.formSplitContainer.Panel1.ResumeLayout(false);
            this.formSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).EndInit();
            this.formSplitContainer.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ouvrageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioEPFCDataSet)).EndInit();
            this.infoTabs.ResumeLayout(false);
            this.ouvrageInfoPage.ResumeLayout(false);
            this.tableLayoutOuvrageInfo.ResumeLayout(false);
            this.infoBox.ResumeLayout(false);
            this.infosTableLayout.ResumeLayout(false);
            this.infosTableLayout.PerformLayout();
            this.empruntBox.ResumeLayout(false);
            this.empruntSplitContainer.Panel1.ResumeLayout(false);
            this.empruntSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empruntSplitContainer)).EndInit();
            this.empruntSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.reservationBox.ResumeLayout(false);
            this.reservationSplitContainer.Panel1.ResumeLayout(false);
            this.reservationSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationSplitContainer)).EndInit();
            this.reservationSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer formSplitContainer;
        private System.Windows.Forms.TreeView generalTreeView;
        private BiblioEPFCDataSet biblioEPFCDataSet;
        private System.Windows.Forms.BindingSource ouvrageBindingSource;
        private BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter ouvrageTableAdapter;
        private BiblioEPFCDataSetTableAdapters.MembreTableAdapter membreTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.AuteurParOuvrageTableAdapter auteurParOuvrageTableAdapter1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label labelRechercher;
        private System.Windows.Forms.TextBox textBoxRechercher;
        private System.Windows.Forms.TreeView treeViewCache;
        private System.Windows.Forms.ToolStripMenuItem ouvragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterOuvrageMenu;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterEmpruntMenu;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem membresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMembreMenu;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem2;
        private BiblioEPFCDataSetTableAdapters.SuperParOuvrageTableAdapter superParOuvrageTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.EmpruntMembreParOuvrageTableAdapter empruntMembreParOuvrageTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.ReservationParOuvrageTableAdapter reservationParOuvrageTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem réservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterReservationMenu;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem3;
        private System.Windows.Forms.TabControl infoTabs;
        private System.Windows.Forms.TabPage ouvrageInfoPage;
        private System.Windows.Forms.TabPage auteurInfoPage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter auteurSuperviseurTableAdapter1;
        private System.Windows.Forms.TabPage membreInfoPage;
        private System.Windows.Forms.TabPage empruntInfoPage;
        private System.Windows.Forms.TabPage reservationInfoPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutOuvrageInfo;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.GroupBox empruntBox;
        private System.Windows.Forms.GroupBox reservationBox;
        private System.Windows.Forms.TableLayoutPanel infosTableLayout;
        private System.Windows.Forms.Label auteursLabel;
        private System.Windows.Forms.ListBox auteursListBox;
        private System.Windows.Forms.Label titreLabel;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label dateCreaLabel;
        private System.Windows.Forms.Label localLabel;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label entrepriseLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer empruntSplitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ajouterEmpruntBouton;
        private System.Windows.Forms.Button boutonSuppEmprunt;
        private System.Windows.Forms.SplitContainer reservationSplitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button ajouterReservBouton;
        private System.Windows.Forms.Button suppReservBouton;
        private System.Windows.Forms.Label emprunteParLabel;
        private System.Windows.Forms.Label dateEmpruntLabel;
        private System.Windows.Forms.Label dureeEmpruntLabel;
        private System.Windows.Forms.Label etatEmpruntLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label superLabel;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button editerOuvrageBouton;

    }
}

