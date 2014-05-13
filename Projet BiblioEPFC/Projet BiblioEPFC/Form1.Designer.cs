using System.Collections.Generic;

namespace ApplicationBiblioEPFC
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
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderLesModificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignorerLesModificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterOuvrageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.supprOuvrageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.auteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprAuteurMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.membresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMembreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.supprMembreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterEmpruntMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.supprEmpruntMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterReservationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.supprReservMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.formSplitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.labelRechercher = new System.Windows.Forms.Label();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.generalTreeView = new System.Windows.Forms.TreeView();
            this.ouvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioEPFCDataSet = new ApplicationBiblioEPFC.BiblioEPFCDataSet();
            this.infoTabs = new System.Windows.Forms.TabControl();
            this.ouvrageInfoPage = new System.Windows.Forms.TabPage();
            this.tableLayoutOuvrageInfo = new System.Windows.Forms.TableLayoutPanel();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.infosTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.auteursLabel = new System.Windows.Forms.Label();
            this.titreLabel = new System.Windows.Forms.Label();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.dateCreaTextBox = new System.Windows.Forms.TextBox();
            this.dateCreaLabel = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.localLabel = new System.Windows.Forms.Label();
            this.localTextBox = new System.Windows.Forms.TextBox();
            this.superLabel = new System.Windows.Forms.Label();
            this.superTextBox = new System.Windows.Forms.TextBox();
            this.entrepriseLabel = new System.Windows.Forms.Label();
            this.entrepTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.auteursSplitContainer = new System.Windows.Forms.SplitContainer();
            this.auteursListBox = new System.Windows.Forms.ListBox();
            this.auteursBoutonsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ajouterAuteurBouton = new System.Windows.Forms.Button();
            this.supprAuteurBouton = new System.Windows.Forms.Button();
            this.empruntBox = new System.Windows.Forms.GroupBox();
            this.empruntSplitContainer = new System.Windows.Forms.SplitContainer();
            this.empruntInfoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.etatEmpruntTextBox = new System.Windows.Forms.TextBox();
            this.dateEmpruntTextBox = new System.Windows.Forms.TextBox();
            this.dureeEmpruntTextBox = new System.Windows.Forms.TextBox();
            this.emprunteParLabel = new System.Windows.Forms.Label();
            this.dateEmpruntLabel = new System.Windows.Forms.Label();
            this.dureeEmpruntLabel = new System.Windows.Forms.Label();
            this.etatEmpruntLabel = new System.Windows.Forms.Label();
            this.membreEmpruntTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ajouterEmpruntBouton = new System.Windows.Forms.Button();
            this.supprEmpruntBouton = new System.Windows.Forms.Button();
            this.reservationBox = new System.Windows.Forms.GroupBox();
            this.reservationSplitContainer = new System.Windows.Forms.SplitContainer();
            this.reservOuvrageInfoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dateReservTextBox = new System.Windows.Forms.TextBox();
            this.dureeReservTextBox = new System.Windows.Forms.TextBox();
            this.reserveParLabel = new System.Windows.Forms.Label();
            this.dateReservLabel = new System.Windows.Forms.Label();
            this.dureeReservLabel = new System.Windows.Forms.Label();
            this.reservListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ajouterReservBouton = new System.Windows.Forms.Button();
            this.supprReservBouton = new System.Windows.Forms.Button();
            this.auteurInfoPage = new System.Windows.Forms.TabPage();
            this.membreInfoPage = new System.Windows.Forms.TabPage();
            this.empruntInfoPage = new System.Windows.Forms.TabPage();
            this.reservationInfoPage = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ouvrageTableAdapter = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter();
            this.membreTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.MembreTableAdapter();
            this.auteurParOuvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.AuteurParOuvrageTableAdapter();
            this.superParOuvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.SuperParOuvrageTableAdapter();
            this.empruntMembreParOuvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.EmpruntMembreParOuvrageTableAdapter();
            this.reservationParOuvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.ReservationParOuvrageTableAdapter();
            this.auteurSuperviseurTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter();
            this.infoOuvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.InfoOuvrageTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.auteursSplitContainer)).BeginInit();
            this.auteursSplitContainer.Panel1.SuspendLayout();
            this.auteursSplitContainer.Panel2.SuspendLayout();
            this.auteursSplitContainer.SuspendLayout();
            this.auteursBoutonsFlowLayout.SuspendLayout();
            this.empruntBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empruntSplitContainer)).BeginInit();
            this.empruntSplitContainer.Panel1.SuspendLayout();
            this.empruntSplitContainer.Panel2.SuspendLayout();
            this.empruntSplitContainer.SuspendLayout();
            this.empruntInfoTableLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.reservationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationSplitContainer)).BeginInit();
            this.reservationSplitContainer.Panel1.SuspendLayout();
            this.reservationSplitContainer.Panel2.SuspendLayout();
            this.reservationSplitContainer.SuspendLayout();
            this.reservOuvrageInfoTableLayout.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editerToolStripMenuItem,
            this.ouvragesToolStripMenuItem,
            this.auteursToolStripMenuItem,
            this.membresToolStripMenuItem,
            this.empruntsToolStripMenuItem,
            this.réservationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.sauvegarderLesModificationsToolStripMenuItem,
            this.ignorerLesModificationsToolStripMenuItem});
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editerToolStripMenuItem.Text = "Edition";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // sauvegarderLesModificationsToolStripMenuItem
            // 
            this.sauvegarderLesModificationsToolStripMenuItem.Enabled = false;
            this.sauvegarderLesModificationsToolStripMenuItem.Name = "sauvegarderLesModificationsToolStripMenuItem";
            this.sauvegarderLesModificationsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sauvegarderLesModificationsToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.sauvegarderLesModificationsToolStripMenuItem.Text = "Sauvegarder les modifications";
            this.sauvegarderLesModificationsToolStripMenuItem.Click += new System.EventHandler(this.stopEditionMenuClick);
            // 
            // ignorerLesModificationsToolStripMenuItem
            // 
            this.ignorerLesModificationsToolStripMenuItem.Enabled = false;
            this.ignorerLesModificationsToolStripMenuItem.Name = "ignorerLesModificationsToolStripMenuItem";
            this.ignorerLesModificationsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ignorerLesModificationsToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.ignorerLesModificationsToolStripMenuItem.Text = "Ignorer les modifications";
            this.ignorerLesModificationsToolStripMenuItem.Click += new System.EventHandler(this.stopEditionMenuClick);
            // 
            // ouvragesToolStripMenuItem
            // 
            this.ouvragesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterOuvrageMenu,
            this.supprOuvrageMenu});
            this.ouvragesToolStripMenuItem.Name = "ouvragesToolStripMenuItem";
            this.ouvragesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.ouvragesToolStripMenuItem.Text = "Ouvrage";
            // 
            // ajouterOuvrageMenu
            // 
            this.ajouterOuvrageMenu.Name = "ajouterOuvrageMenu";
            this.ajouterOuvrageMenu.Size = new System.Drawing.Size(129, 22);
            this.ajouterOuvrageMenu.Text = "Ajouter";
            // 
            // supprOuvrageMenu
            // 
            this.supprOuvrageMenu.Name = "supprOuvrageMenu";
            this.supprOuvrageMenu.Size = new System.Drawing.Size(129, 22);
            this.supprOuvrageMenu.Text = "Supprimer";
            // 
            // auteursToolStripMenuItem
            // 
            this.auteursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprAuteurMenu});
            this.auteursToolStripMenuItem.Name = "auteursToolStripMenuItem";
            this.auteursToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.auteursToolStripMenuItem.Text = "Auteur";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // supprAuteurMenu
            // 
            this.supprAuteurMenu.Name = "supprAuteurMenu";
            this.supprAuteurMenu.Size = new System.Drawing.Size(129, 22);
            this.supprAuteurMenu.Text = "Supprimer";
            // 
            // membresToolStripMenuItem
            // 
            this.membresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterMembreMenu,
            this.supprMembreMenu});
            this.membresToolStripMenuItem.Name = "membresToolStripMenuItem";
            this.membresToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.membresToolStripMenuItem.Text = "Membre";
            // 
            // ajouterMembreMenu
            // 
            this.ajouterMembreMenu.Name = "ajouterMembreMenu";
            this.ajouterMembreMenu.Size = new System.Drawing.Size(129, 22);
            this.ajouterMembreMenu.Text = "Ajouter";
            // 
            // supprMembreMenu
            // 
            this.supprMembreMenu.Name = "supprMembreMenu";
            this.supprMembreMenu.Size = new System.Drawing.Size(129, 22);
            this.supprMembreMenu.Text = "Supprimer";
            // 
            // empruntsToolStripMenuItem
            // 
            this.empruntsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterEmpruntMenu,
            this.supprEmpruntMenu});
            this.empruntsToolStripMenuItem.Name = "empruntsToolStripMenuItem";
            this.empruntsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.empruntsToolStripMenuItem.Text = "Emprunt";
            // 
            // ajouterEmpruntMenu
            // 
            this.ajouterEmpruntMenu.Name = "ajouterEmpruntMenu";
            this.ajouterEmpruntMenu.Size = new System.Drawing.Size(129, 22);
            this.ajouterEmpruntMenu.Text = "Ajouter";
            // 
            // supprEmpruntMenu
            // 
            this.supprEmpruntMenu.Name = "supprEmpruntMenu";
            this.supprEmpruntMenu.Size = new System.Drawing.Size(129, 22);
            this.supprEmpruntMenu.Text = "Supprimer";
            // 
            // réservationsToolStripMenuItem
            // 
            this.réservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterReservationMenu,
            this.supprReservMenu});
            this.réservationsToolStripMenuItem.Name = "réservationsToolStripMenuItem";
            this.réservationsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.réservationsToolStripMenuItem.Text = "Réservation";
            // 
            // ajouterReservationMenu
            // 
            this.ajouterReservationMenu.Name = "ajouterReservationMenu";
            this.ajouterReservationMenu.Size = new System.Drawing.Size(152, 22);
            this.ajouterReservationMenu.Text = "Ajouter";
            this.ajouterReservationMenu.Click += new System.EventHandler(this.ajouterReserv);
            // 
            // supprReservMenu
            // 
            this.supprReservMenu.Name = "supprReservMenu";
            this.supprReservMenu.Size = new System.Drawing.Size(152, 22);
            this.supprReservMenu.Text = "Supprimer";
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
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
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
            this.splitContainer2.Size = new System.Drawing.Size(229, 563);
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
            this.splitContainer3.Size = new System.Drawing.Size(226, 26);
            this.splitContainer3.SplitterDistance = 74;
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
            this.textBoxRechercher.Size = new System.Drawing.Size(145, 20);
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
            this.generalTreeView.Location = new System.Drawing.Point(3, 0);
            this.generalTreeView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.generalTreeView.Name = "generalTreeView";
            this.generalTreeView.Size = new System.Drawing.Size(220, 548);
            this.generalTreeView.TabIndex = 0;
            this.generalTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.generalTreeView_NodeMouseClick);
            this.generalTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.generalTreeView_NodeMouseDoubleClick);
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
            this.infoTabs.Controls.Add(this.ouvrageInfoPage);
            this.infoTabs.Controls.Add(this.auteurInfoPage);
            this.infoTabs.Controls.Add(this.membreInfoPage);
            this.infoTabs.Controls.Add(this.empruntInfoPage);
            this.infoTabs.Controls.Add(this.reservationInfoPage);
            this.infoTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTabs.Location = new System.Drawing.Point(0, 0);
            this.infoTabs.Name = "infoTabs";
            this.infoTabs.SelectedIndex = 0;
            this.infoTabs.Size = new System.Drawing.Size(763, 563);
            this.infoTabs.TabIndex = 0;
            // 
            // ouvrageInfoPage
            // 
            this.ouvrageInfoPage.Controls.Add(this.tableLayoutOuvrageInfo);
            this.ouvrageInfoPage.Location = new System.Drawing.Point(4, 22);
            this.ouvrageInfoPage.Name = "ouvrageInfoPage";
            this.ouvrageInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.ouvrageInfoPage.Size = new System.Drawing.Size(755, 537);
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
            this.tableLayoutOuvrageInfo.Size = new System.Drawing.Size(749, 531);
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
            this.infoBox.Size = new System.Drawing.Size(743, 259);
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
            this.infosTableLayout.Controls.Add(this.auteursLabel, 2, 0);
            this.infosTableLayout.Controls.Add(this.titreLabel, 0, 0);
            this.infosTableLayout.Controls.Add(this.titreTextBox, 1, 0);
            this.infosTableLayout.Controls.Add(this.dateCreaTextBox, 1, 1);
            this.infosTableLayout.Controls.Add(this.dateCreaLabel, 0, 1);
            this.infosTableLayout.Controls.Add(this.sectionLabel, 0, 2);
            this.infosTableLayout.Controls.Add(this.sectionTextBox, 1, 2);
            this.infosTableLayout.Controls.Add(this.localLabel, 0, 3);
            this.infosTableLayout.Controls.Add(this.localTextBox, 1, 3);
            this.infosTableLayout.Controls.Add(this.superLabel, 2, 1);
            this.infosTableLayout.Controls.Add(this.superTextBox, 3, 1);
            this.infosTableLayout.Controls.Add(this.entrepriseLabel, 2, 2);
            this.infosTableLayout.Controls.Add(this.entrepTextBox, 3, 2);
            this.infosTableLayout.Controls.Add(this.typeLabel, 2, 3);
            this.infosTableLayout.Controls.Add(this.typeTextBox, 3, 3);
            this.infosTableLayout.Controls.Add(this.auteursSplitContainer, 3, 0);
            this.infosTableLayout.Location = new System.Drawing.Point(3, 16);
            this.infosTableLayout.Name = "infosTableLayout";
            this.infosTableLayout.RowCount = 4;
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infosTableLayout.Size = new System.Drawing.Size(737, 240);
            this.infosTableLayout.TabIndex = 0;
            // 
            // auteursLabel
            // 
            this.auteursLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.auteursLabel.AutoSize = true;
            this.auteursLabel.Location = new System.Drawing.Point(388, 23);
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
            this.titreTextBox.Location = new System.Drawing.Point(76, 20);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.ReadOnly = true;
            this.titreTextBox.Size = new System.Drawing.Size(288, 20);
            this.titreTextBox.TabIndex = 3;
            // 
            // dateCreaTextBox
            // 
            this.dateCreaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateCreaTextBox.Location = new System.Drawing.Point(76, 80);
            this.dateCreaTextBox.Name = "dateCreaTextBox";
            this.dateCreaTextBox.ReadOnly = true;
            this.dateCreaTextBox.Size = new System.Drawing.Size(288, 20);
            this.dateCreaTextBox.TabIndex = 4;
            // 
            // dateCreaLabel
            // 
            this.dateCreaLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateCreaLabel.AutoSize = true;
            this.dateCreaLabel.Location = new System.Drawing.Point(22, 77);
            this.dateCreaLabel.Name = "dateCreaLabel";
            this.dateCreaLabel.Size = new System.Drawing.Size(48, 26);
            this.dateCreaLabel.TabIndex = 7;
            this.dateCreaLabel.Text = "Date de création";
            // 
            // sectionLabel
            // 
            this.sectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(27, 143);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(43, 13);
            this.sectionLabel.TabIndex = 9;
            this.sectionLabel.Text = "Section";
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionTextBox.Location = new System.Drawing.Point(76, 140);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.ReadOnly = true;
            this.sectionTextBox.Size = new System.Drawing.Size(288, 20);
            this.sectionTextBox.TabIndex = 6;
            // 
            // localLabel
            // 
            this.localLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.localLabel.AutoSize = true;
            this.localLabel.Location = new System.Drawing.Point(7, 203);
            this.localLabel.Name = "localLabel";
            this.localLabel.Size = new System.Drawing.Size(63, 13);
            this.localLabel.TabIndex = 8;
            this.localLabel.Text = "Localisation";
            // 
            // localTextBox
            // 
            this.localTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.localTextBox.Location = new System.Drawing.Point(76, 200);
            this.localTextBox.Name = "localTextBox";
            this.localTextBox.ReadOnly = true;
            this.localTextBox.Size = new System.Drawing.Size(288, 20);
            this.localTextBox.TabIndex = 5;
            // 
            // superLabel
            // 
            this.superLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.superLabel.AutoSize = true;
            this.superLabel.Location = new System.Drawing.Point(372, 83);
            this.superLabel.Name = "superLabel";
            this.superLabel.Size = new System.Drawing.Size(63, 13);
            this.superLabel.TabIndex = 12;
            this.superLabel.Text = "Superviseur";
            this.superLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // superTextBox
            // 
            this.superTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.superTextBox.Location = new System.Drawing.Point(443, 80);
            this.superTextBox.Name = "superTextBox";
            this.superTextBox.ReadOnly = true;
            this.superTextBox.Size = new System.Drawing.Size(291, 20);
            this.superTextBox.TabIndex = 13;
            // 
            // entrepriseLabel
            // 
            this.entrepriseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entrepriseLabel.AutoSize = true;
            this.entrepriseLabel.Location = new System.Drawing.Point(383, 143);
            this.entrepriseLabel.Name = "entrepriseLabel";
            this.entrepriseLabel.Size = new System.Drawing.Size(54, 13);
            this.entrepriseLabel.TabIndex = 10;
            this.entrepriseLabel.Text = "Entreprise";
            // 
            // entrepTextBox
            // 
            this.entrepTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.entrepTextBox.Location = new System.Drawing.Point(443, 140);
            this.entrepTextBox.Name = "entrepTextBox";
            this.entrepTextBox.ReadOnly = true;
            this.entrepTextBox.Size = new System.Drawing.Size(291, 20);
            this.entrepTextBox.TabIndex = 11;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(388, 203);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 14;
            this.typeLabel.Text = "Type";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.typeTextBox.Location = new System.Drawing.Point(443, 200);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(291, 20);
            this.typeTextBox.TabIndex = 15;
            // 
            // auteursSplitContainer
            // 
            this.auteursSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteursSplitContainer.IsSplitterFixed = true;
            this.auteursSplitContainer.Location = new System.Drawing.Point(440, 0);
            this.auteursSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.auteursSplitContainer.Name = "auteursSplitContainer";
            // 
            // auteursSplitContainer.Panel1
            // 
            this.auteursSplitContainer.Panel1.Controls.Add(this.auteursListBox);
            // 
            // auteursSplitContainer.Panel2
            // 
            this.auteursSplitContainer.Panel2.Controls.Add(this.auteursBoutonsFlowLayout);
            this.auteursSplitContainer.Size = new System.Drawing.Size(297, 60);
            this.auteursSplitContainer.SplitterDistance = 266;
            this.auteursSplitContainer.SplitterWidth = 2;
            this.auteursSplitContainer.TabIndex = 16;
            // 
            // auteursListBox
            // 
            this.auteursListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteursListBox.FormattingEnabled = true;
            this.auteursListBox.Location = new System.Drawing.Point(0, 0);
            this.auteursListBox.MinimumSize = new System.Drawing.Size(4, 56);
            this.auteursListBox.Name = "auteursListBox";
            this.auteursListBox.Size = new System.Drawing.Size(266, 60);
            this.auteursListBox.Sorted = true;
            this.auteursListBox.TabIndex = 1;
            // 
            // auteursBoutonsFlowLayout
            // 
            this.auteursBoutonsFlowLayout.Controls.Add(this.ajouterAuteurBouton);
            this.auteursBoutonsFlowLayout.Controls.Add(this.supprAuteurBouton);
            this.auteursBoutonsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteursBoutonsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.auteursBoutonsFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.auteursBoutonsFlowLayout.Name = "auteursBoutonsFlowLayout";
            this.auteursBoutonsFlowLayout.Size = new System.Drawing.Size(29, 60);
            this.auteursBoutonsFlowLayout.TabIndex = 0;
            // 
            // ajouterAuteurBouton
            // 
            this.ajouterAuteurBouton.Location = new System.Drawing.Point(3, 3);
            this.ajouterAuteurBouton.Name = "ajouterAuteurBouton";
            this.ajouterAuteurBouton.Size = new System.Drawing.Size(20, 20);
            this.ajouterAuteurBouton.TabIndex = 0;
            this.ajouterAuteurBouton.Text = "+";
            this.ajouterAuteurBouton.UseVisualStyleBackColor = true;
            // 
            // supprAuteurBouton
            // 
            this.supprAuteurBouton.Location = new System.Drawing.Point(3, 29);
            this.supprAuteurBouton.Name = "supprAuteurBouton";
            this.supprAuteurBouton.Size = new System.Drawing.Size(20, 20);
            this.supprAuteurBouton.TabIndex = 1;
            this.supprAuteurBouton.Text = "-";
            this.supprAuteurBouton.UseVisualStyleBackColor = true;
            // 
            // empruntBox
            // 
            this.empruntBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.empruntBox.Controls.Add(this.empruntSplitContainer);
            this.empruntBox.Location = new System.Drawing.Point(3, 268);
            this.empruntBox.Name = "empruntBox";
            this.empruntBox.Size = new System.Drawing.Size(743, 126);
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
            this.empruntSplitContainer.Panel1.Controls.Add(this.empruntInfoTableLayout);
            // 
            // empruntSplitContainer.Panel2
            // 
            this.empruntSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.empruntSplitContainer.Size = new System.Drawing.Size(737, 107);
            this.empruntSplitContainer.SplitterDistance = 612;
            this.empruntSplitContainer.TabIndex = 0;
            // 
            // empruntInfoTableLayout
            // 
            this.empruntInfoTableLayout.ColumnCount = 4;
            this.empruntInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.empruntInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.empruntInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.empruntInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.empruntInfoTableLayout.Controls.Add(this.etatEmpruntTextBox, 3, 1);
            this.empruntInfoTableLayout.Controls.Add(this.dateEmpruntTextBox, 1, 1);
            this.empruntInfoTableLayout.Controls.Add(this.dureeEmpruntTextBox, 3, 0);
            this.empruntInfoTableLayout.Controls.Add(this.emprunteParLabel, 0, 0);
            this.empruntInfoTableLayout.Controls.Add(this.dateEmpruntLabel, 0, 1);
            this.empruntInfoTableLayout.Controls.Add(this.dureeEmpruntLabel, 2, 0);
            this.empruntInfoTableLayout.Controls.Add(this.etatEmpruntLabel, 2, 1);
            this.empruntInfoTableLayout.Controls.Add(this.membreEmpruntTextBox, 1, 0);
            this.empruntInfoTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empruntInfoTableLayout.Location = new System.Drawing.Point(0, 0);
            this.empruntInfoTableLayout.Name = "empruntInfoTableLayout";
            this.empruntInfoTableLayout.RowCount = 2;
            this.empruntInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.empruntInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.empruntInfoTableLayout.Size = new System.Drawing.Size(612, 107);
            this.empruntInfoTableLayout.TabIndex = 0;
            // 
            // etatEmpruntTextBox
            // 
            this.etatEmpruntTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.etatEmpruntTextBox.Location = new System.Drawing.Point(369, 70);
            this.etatEmpruntTextBox.Name = "etatEmpruntTextBox";
            this.etatEmpruntTextBox.ReadOnly = true;
            this.etatEmpruntTextBox.Size = new System.Drawing.Size(240, 20);
            this.etatEmpruntTextBox.TabIndex = 7;
            // 
            // dateEmpruntTextBox
            // 
            this.dateEmpruntTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEmpruntTextBox.Location = new System.Drawing.Point(64, 70);
            this.dateEmpruntTextBox.Name = "dateEmpruntTextBox";
            this.dateEmpruntTextBox.ReadOnly = true;
            this.dateEmpruntTextBox.Size = new System.Drawing.Size(238, 20);
            this.dateEmpruntTextBox.TabIndex = 6;
            // 
            // dureeEmpruntTextBox
            // 
            this.dureeEmpruntTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dureeEmpruntTextBox.Location = new System.Drawing.Point(369, 16);
            this.dureeEmpruntTextBox.Name = "dureeEmpruntTextBox";
            this.dureeEmpruntTextBox.ReadOnly = true;
            this.dureeEmpruntTextBox.Size = new System.Drawing.Size(240, 20);
            this.dureeEmpruntTextBox.TabIndex = 5;
            // 
            // emprunteParLabel
            // 
            this.emprunteParLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.emprunteParLabel.AutoSize = true;
            this.emprunteParLabel.Location = new System.Drawing.Point(6, 13);
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
            this.dateEmpruntLabel.Location = new System.Drawing.Point(28, 73);
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
            this.dureeEmpruntLabel.Location = new System.Drawing.Point(327, 20);
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
            this.etatEmpruntLabel.Location = new System.Drawing.Point(337, 73);
            this.etatEmpruntLabel.Name = "etatEmpruntLabel";
            this.etatEmpruntLabel.Size = new System.Drawing.Size(26, 13);
            this.etatEmpruntLabel.TabIndex = 3;
            this.etatEmpruntLabel.Text = "État";
            this.etatEmpruntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // membreEmpruntTextBox
            // 
            this.membreEmpruntTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.membreEmpruntTextBox.Location = new System.Drawing.Point(64, 16);
            this.membreEmpruntTextBox.Name = "membreEmpruntTextBox";
            this.membreEmpruntTextBox.ReadOnly = true;
            this.membreEmpruntTextBox.Size = new System.Drawing.Size(238, 20);
            this.membreEmpruntTextBox.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ajouterEmpruntBouton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.supprEmpruntBouton, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(121, 107);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ajouterEmpruntBouton
            // 
            this.ajouterEmpruntBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterEmpruntBouton.ForeColor = System.Drawing.Color.DarkGreen;
            this.ajouterEmpruntBouton.Location = new System.Drawing.Point(10, 11);
            this.ajouterEmpruntBouton.Name = "ajouterEmpruntBouton";
            this.ajouterEmpruntBouton.Size = new System.Drawing.Size(100, 30);
            this.ajouterEmpruntBouton.TabIndex = 0;
            this.ajouterEmpruntBouton.Text = "Ajouter Emprunt";
            this.ajouterEmpruntBouton.UseVisualStyleBackColor = true;
            // 
            // supprEmpruntBouton
            // 
            this.supprEmpruntBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprEmpruntBouton.Enabled = false;
            this.supprEmpruntBouton.ForeColor = System.Drawing.Color.DarkRed;
            this.supprEmpruntBouton.Location = new System.Drawing.Point(10, 65);
            this.supprEmpruntBouton.Name = "supprEmpruntBouton";
            this.supprEmpruntBouton.Size = new System.Drawing.Size(100, 30);
            this.supprEmpruntBouton.TabIndex = 1;
            this.supprEmpruntBouton.Text = "Suppr. Emprunt";
            this.supprEmpruntBouton.UseVisualStyleBackColor = true;
            // 
            // reservationBox
            // 
            this.reservationBox.Controls.Add(this.reservationSplitContainer);
            this.reservationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationBox.Location = new System.Drawing.Point(3, 400);
            this.reservationBox.Name = "reservationBox";
            this.reservationBox.Size = new System.Drawing.Size(743, 128);
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
            this.reservationSplitContainer.Panel1.Controls.Add(this.reservOuvrageInfoTableLayout);
            // 
            // reservationSplitContainer.Panel2
            // 
            this.reservationSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.reservationSplitContainer.Size = new System.Drawing.Size(737, 109);
            this.reservationSplitContainer.SplitterDistance = 612;
            this.reservationSplitContainer.TabIndex = 1;
            // 
            // reservOuvrageInfoTableLayout
            // 
            this.reservOuvrageInfoTableLayout.ColumnCount = 4;
            this.reservOuvrageInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reservOuvrageInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.reservOuvrageInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.reservOuvrageInfoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.reservOuvrageInfoTableLayout.Controls.Add(this.dateReservTextBox, 1, 1);
            this.reservOuvrageInfoTableLayout.Controls.Add(this.dureeReservTextBox, 3, 0);
            this.reservOuvrageInfoTableLayout.Controls.Add(this.reserveParLabel, 0, 0);
            this.reservOuvrageInfoTableLayout.Controls.Add(this.dateReservLabel, 0, 1);
            this.reservOuvrageInfoTableLayout.Controls.Add(this.dureeReservLabel, 2, 0);
            this.reservOuvrageInfoTableLayout.Controls.Add(this.reservListBox, 1, 0);
            this.reservOuvrageInfoTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservOuvrageInfoTableLayout.Location = new System.Drawing.Point(0, 0);
            this.reservOuvrageInfoTableLayout.Name = "reservOuvrageInfoTableLayout";
            this.reservOuvrageInfoTableLayout.RowCount = 2;
            this.reservOuvrageInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.reservOuvrageInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.reservOuvrageInfoTableLayout.Size = new System.Drawing.Size(612, 109);
            this.reservOuvrageInfoTableLayout.TabIndex = 0;
            // 
            // dateReservTextBox
            // 
            this.dateReservTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateReservTextBox.Location = new System.Drawing.Point(64, 71);
            this.dateReservTextBox.Name = "dateReservTextBox";
            this.dateReservTextBox.ReadOnly = true;
            this.dateReservTextBox.Size = new System.Drawing.Size(238, 20);
            this.dateReservTextBox.TabIndex = 7;
            // 
            // dureeReservTextBox
            // 
            this.dureeReservTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dureeReservTextBox.Location = new System.Drawing.Point(369, 17);
            this.dureeReservTextBox.Name = "dureeReservTextBox";
            this.dureeReservTextBox.ReadOnly = true;
            this.dureeReservTextBox.Size = new System.Drawing.Size(240, 20);
            this.dureeReservTextBox.TabIndex = 6;
            // 
            // reserveParLabel
            // 
            this.reserveParLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reserveParLabel.AutoSize = true;
            this.reserveParLabel.Location = new System.Drawing.Point(11, 14);
            this.reserveParLabel.Name = "reserveParLabel";
            this.reserveParLabel.Size = new System.Drawing.Size(47, 26);
            this.reserveParLabel.TabIndex = 0;
            this.reserveParLabel.Text = "Réservé par";
            this.reserveParLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateReservLabel
            // 
            this.dateReservLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateReservLabel.AutoSize = true;
            this.dateReservLabel.Location = new System.Drawing.Point(28, 75);
            this.dateReservLabel.Name = "dateReservLabel";
            this.dateReservLabel.Size = new System.Drawing.Size(30, 13);
            this.dateReservLabel.TabIndex = 1;
            this.dateReservLabel.Text = "Date";
            this.dateReservLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dureeReservLabel
            // 
            this.dureeReservLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dureeReservLabel.AutoSize = true;
            this.dureeReservLabel.Location = new System.Drawing.Point(327, 20);
            this.dureeReservLabel.Name = "dureeReservLabel";
            this.dureeReservLabel.Size = new System.Drawing.Size(36, 13);
            this.dureeReservLabel.TabIndex = 2;
            this.dureeReservLabel.Text = "Durée";
            this.dureeReservLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reservListBox
            // 
            this.reservListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservListBox.FormattingEnabled = true;
            this.reservListBox.Location = new System.Drawing.Point(64, 3);
            this.reservListBox.Name = "reservListBox";
            this.reservListBox.Size = new System.Drawing.Size(238, 48);
            this.reservListBox.TabIndex = 9;
            this.reservListBox.SelectedIndexChanged += new System.EventHandler(this.reservListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.ajouterReservBouton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.supprReservBouton, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(121, 109);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // ajouterReservBouton
            // 
            this.ajouterReservBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterReservBouton.ForeColor = System.Drawing.Color.DarkGreen;
            this.ajouterReservBouton.Location = new System.Drawing.Point(10, 7);
            this.ajouterReservBouton.Name = "ajouterReservBouton";
            this.ajouterReservBouton.Size = new System.Drawing.Size(100, 40);
            this.ajouterReservBouton.TabIndex = 0;
            this.ajouterReservBouton.Text = "Ajouter Réservation";
            this.ajouterReservBouton.UseVisualStyleBackColor = true;
            this.ajouterReservBouton.Click += new System.EventHandler(this.ajouterReserv);
            // 
            // supprReservBouton
            // 
            this.supprReservBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprReservBouton.ForeColor = System.Drawing.Color.DarkRed;
            this.supprReservBouton.Location = new System.Drawing.Point(10, 61);
            this.supprReservBouton.Name = "supprReservBouton";
            this.supprReservBouton.Size = new System.Drawing.Size(100, 40);
            this.supprReservBouton.TabIndex = 1;
            this.supprReservBouton.Text = "Supprimer Réservation";
            this.supprReservBouton.UseVisualStyleBackColor = true;
            // 
            // auteurInfoPage
            // 
            this.auteurInfoPage.Location = new System.Drawing.Point(4, 22);
            this.auteurInfoPage.Name = "auteurInfoPage";
            this.auteurInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.auteurInfoPage.Size = new System.Drawing.Size(755, 537);
            this.auteurInfoPage.TabIndex = 1;
            this.auteurInfoPage.Text = "Auteur";
            this.auteurInfoPage.UseVisualStyleBackColor = true;
            // 
            // membreInfoPage
            // 
            this.membreInfoPage.Location = new System.Drawing.Point(4, 22);
            this.membreInfoPage.Name = "membreInfoPage";
            this.membreInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.membreInfoPage.Size = new System.Drawing.Size(755, 537);
            this.membreInfoPage.TabIndex = 2;
            this.membreInfoPage.Text = "Membre";
            this.membreInfoPage.UseVisualStyleBackColor = true;
            // 
            // empruntInfoPage
            // 
            this.empruntInfoPage.Location = new System.Drawing.Point(4, 22);
            this.empruntInfoPage.Name = "empruntInfoPage";
            this.empruntInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.empruntInfoPage.Size = new System.Drawing.Size(755, 537);
            this.empruntInfoPage.TabIndex = 3;
            this.empruntInfoPage.Text = "Emprunt";
            this.empruntInfoPage.UseVisualStyleBackColor = true;
            // 
            // reservationInfoPage
            // 
            this.reservationInfoPage.Location = new System.Drawing.Point(4, 22);
            this.reservationInfoPage.Name = "reservationInfoPage";
            this.reservationInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.reservationInfoPage.Size = new System.Drawing.Size(755, 537);
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
            // infoOuvrageTableAdapter1
            // 
            this.infoOuvrageTableAdapter1.ClearBeforeFill = true;
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
            this.auteursSplitContainer.Panel1.ResumeLayout(false);
            this.auteursSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.auteursSplitContainer)).EndInit();
            this.auteursSplitContainer.ResumeLayout(false);
            this.auteursBoutonsFlowLayout.ResumeLayout(false);
            this.empruntBox.ResumeLayout(false);
            this.empruntSplitContainer.Panel1.ResumeLayout(false);
            this.empruntSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empruntSplitContainer)).EndInit();
            this.empruntSplitContainer.ResumeLayout(false);
            this.empruntInfoTableLayout.ResumeLayout(false);
            this.empruntInfoTableLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.reservationBox.ResumeLayout(false);
            this.reservationSplitContainer.Panel1.ResumeLayout(false);
            this.reservationSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationSplitContainer)).EndInit();
            this.reservationSplitContainer.ResumeLayout(false);
            this.reservOuvrageInfoTableLayout.ResumeLayout(false);
            this.reservOuvrageInfoTableLayout.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem supprOuvrageMenu;
        private System.Windows.Forms.ToolStripMenuItem empruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterEmpruntMenu;
        private System.Windows.Forms.ToolStripMenuItem supprEmpruntMenu;
        private System.Windows.Forms.ToolStripMenuItem membresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMembreMenu;
        private System.Windows.Forms.ToolStripMenuItem supprMembreMenu;
        private BiblioEPFCDataSetTableAdapters.SuperParOuvrageTableAdapter superParOuvrageTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.EmpruntMembreParOuvrageTableAdapter empruntMembreParOuvrageTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.ReservationParOuvrageTableAdapter reservationParOuvrageTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem réservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterReservationMenu;
        private System.Windows.Forms.ToolStripMenuItem supprReservMenu;
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
        private System.Windows.Forms.TextBox dateCreaTextBox;
        private System.Windows.Forms.TextBox localTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.Label dateCreaLabel;
        private System.Windows.Forms.Label localLabel;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label entrepriseLabel;
        private System.Windows.Forms.TextBox entrepTextBox;
        private System.Windows.Forms.SplitContainer empruntSplitContainer;
        private System.Windows.Forms.TableLayoutPanel empruntInfoTableLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ajouterEmpruntBouton;
        private System.Windows.Forms.Button supprEmpruntBouton;
        private System.Windows.Forms.SplitContainer reservationSplitContainer;
        private System.Windows.Forms.TableLayoutPanel reservOuvrageInfoTableLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button ajouterReservBouton;
        private System.Windows.Forms.Button supprReservBouton;
        private System.Windows.Forms.Label emprunteParLabel;
        private System.Windows.Forms.Label dateEmpruntLabel;
        private System.Windows.Forms.Label dureeEmpruntLabel;
        private System.Windows.Forms.Label etatEmpruntLabel;
        private System.Windows.Forms.Label reserveParLabel;
        private System.Windows.Forms.Label dateReservLabel;
        private System.Windows.Forms.Label dureeReservLabel;
        private System.Windows.Forms.TextBox etatEmpruntTextBox;
        private System.Windows.Forms.TextBox dateEmpruntTextBox;
        private System.Windows.Forms.TextBox dureeEmpruntTextBox;
        private System.Windows.Forms.TextBox membreEmpruntTextBox;
        private System.Windows.Forms.TextBox dateReservTextBox;
        private System.Windows.Forms.TextBox dureeReservTextBox;
        private System.Windows.Forms.Label superLabel;
        private System.Windows.Forms.TextBox superTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private BiblioEPFCDataSetTableAdapters.InfoOuvrageTableAdapter infoOuvrageTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderLesModificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignorerLesModificationsToolStripMenuItem;
        private enum Edition        { NORMAL, EDITING };
        private enum Emprunt        { AUCUN, EMPRUNTE };
        private enum Reservation    { AUCUNE, EXISTANTE };
        private Edition editState;
        private Emprunt empruntState;
        private Reservation reservState;
        private List<int> listeIDAuteur;
        private List<int> listeIDMembre;
        private int SELECTEDOUVRAGE;
        private System.Windows.Forms.ToolStripMenuItem auteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprAuteurMenu;
        private System.Windows.Forms.SplitContainer auteursSplitContainer;
        private System.Windows.Forms.FlowLayoutPanel auteursBoutonsFlowLayout;
        private System.Windows.Forms.Button ajouterAuteurBouton;
        private System.Windows.Forms.Button supprAuteurBouton;
        private System.Windows.Forms.ListBox reservListBox;

    }
}

