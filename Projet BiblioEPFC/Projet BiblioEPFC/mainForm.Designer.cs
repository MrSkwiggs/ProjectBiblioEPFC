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
            this.ajouterAuteurMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.infosOuvrageTableLayout = new System.Windows.Forms.TableLayoutPanel();
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
            this.entrepriseLabel = new System.Windows.Forms.Label();
            this.entrepTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.auteursSplitContainer = new System.Windows.Forms.SplitContainer();
            this.auteursListBox = new System.Windows.Forms.ListBox();
            this.ajouterAuteurBouton = new System.Windows.Forms.Button();
            this.supprAuteurBouton = new System.Windows.Forms.Button();
            this.superSplitContainer = new System.Windows.Forms.SplitContainer();
            this.superListBox = new System.Windows.Forms.ListBox();
            this.ajouterSuperBouton = new System.Windows.Forms.Button();
            this.supprSuperBouton = new System.Windows.Forms.Button();
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
            this.membreEmpruntListBox = new System.Windows.Forms.ListBox();
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
            this.auteurInfoPageTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.infAuteurGroupBox = new System.Windows.Forms.GroupBox();
            this.infosAuteurTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.nomAuteurLabel = new System.Windows.Forms.Label();
            this.prenomAuteurLabel = new System.Windows.Forms.Label();
            this.statutAuteurLabel = new System.Windows.Forms.Label();
            this.nomAuteurTextBox = new System.Windows.Forms.TextBox();
            this.prenomAuteurTextBox = new System.Windows.Forms.TextBox();
            this.statutAuteurTextBox = new System.Windows.Forms.TextBox();
            this.travailAuteurGroupBox = new System.Windows.Forms.GroupBox();
            this.auteurPubliTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.auteurSuperviseSplitContainer = new System.Windows.Forms.SplitContainer();
            this.auteurSuperviseListBox = new System.Windows.Forms.ListBox();
            this.ajouterSupervisionAuteurBouton = new System.Windows.Forms.Button();
            this.supprSupervisionAuteurBouton = new System.Windows.Forms.Button();
            this.publiAuteurLabel = new System.Windows.Forms.Label();
            this.superviseLabel = new System.Windows.Forms.Label();
            this.auteurEcritSplitContainer = new System.Windows.Forms.SplitContainer();
            this.publiAuteurListBox = new System.Windows.Forms.ListBox();
            this.ajouterPubliAuteurBouton = new System.Windows.Forms.Button();
            this.supprPubliAuteurBouton = new System.Windows.Forms.Button();
            this.membreInfoPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infosMembreTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.infosMembrePersonalTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.nomMembreLabel = new System.Windows.Forms.Label();
            this.prenomMembreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomMembreTextBox = new System.Windows.Forms.TextBox();
            this.prenomMembreTextBox = new System.Windows.Forms.TextBox();
            this.numTelMembreTextBox = new System.Windows.Forms.TextBox();
            this.infosMembreAdresseTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.villeMembreLabel = new System.Windows.Forms.Label();
            this.rueMembreTextBox = new System.Windows.Forms.TextBox();
            this.adresseMembreLabel = new System.Windows.Forms.Label();
            this.numRueMembreTextBox = new System.Windows.Forms.TextBox();
            this.villeMembreTextBox = new System.Windows.Forms.TextBox();
            this.codePostalMembreTextBox = new System.Windows.Forms.TextBox();
            this.numRueMembreLabel = new System.Windows.Forms.Label();
            this.codePostalMembreLabel = new System.Windows.Forms.Label();
            this.empruntsReservMembreBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.reservMembreSplitContainer = new System.Windows.Forms.SplitContainer();
            this.resMembreListBox = new System.Windows.Forms.ListBox();
            this.ajouterReservMembreBouton = new System.Windows.Forms.Button();
            this.supprReservMembreBouton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.empruntMembreSplitContainer = new System.Windows.Forms.SplitContainer();
            this.empruntsMembreListBox = new System.Windows.Forms.ListBox();
            this.ajouterEmpruntMembreBouton = new System.Windows.Forms.Button();
            this.supprEmpruntMembreBouton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ouvrageTableAdapter = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter();
            this.membreTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.MembreTableAdapter();
            this.auteurParOuvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.AuteurParOuvrageTableAdapter();
            this.superParOuvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.SuperParOuvrageTableAdapter();
            this.empruntMembreParOuvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.EmpruntMembreParOuvrageTableAdapter();
            this.reservationParOuvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.ReservationParOuvrageTableAdapter();
            this.auteurSuperviseurTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter();
            this.infoOuvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.InfoOuvrageTableAdapter();
            this.publicationsParAuteurTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.PublicationsParAuteurTableAdapter();
            this.titreOuvrageParSuperTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.TitreOuvrageParSuperTableAdapter();
            this.empruntsParMembreTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.EmpruntsParMembreTableAdapter();
            this.reservParMembreTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.ReservParMembreTableAdapter();
            this.reserverTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.reserverTableAdapter();
            this.ecrireTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.ecrireTableAdapter();
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
            this.infosOuvrageTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auteursSplitContainer)).BeginInit();
            this.auteursSplitContainer.Panel1.SuspendLayout();
            this.auteursSplitContainer.Panel2.SuspendLayout();
            this.auteursSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superSplitContainer)).BeginInit();
            this.superSplitContainer.Panel1.SuspendLayout();
            this.superSplitContainer.Panel2.SuspendLayout();
            this.superSplitContainer.SuspendLayout();
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
            this.auteurInfoPage.SuspendLayout();
            this.auteurInfoPageTableLayout.SuspendLayout();
            this.infAuteurGroupBox.SuspendLayout();
            this.infosAuteurTableLayout.SuspendLayout();
            this.travailAuteurGroupBox.SuspendLayout();
            this.auteurPubliTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseSplitContainer)).BeginInit();
            this.auteurSuperviseSplitContainer.Panel1.SuspendLayout();
            this.auteurSuperviseSplitContainer.Panel2.SuspendLayout();
            this.auteurSuperviseSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auteurEcritSplitContainer)).BeginInit();
            this.auteurEcritSplitContainer.Panel1.SuspendLayout();
            this.auteurEcritSplitContainer.Panel2.SuspendLayout();
            this.auteurEcritSplitContainer.SuspendLayout();
            this.membreInfoPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.infosMembreTableLayout.SuspendLayout();
            this.infosMembrePersonalTableLayout.SuspendLayout();
            this.infosMembreAdresseTableLayout.SuspendLayout();
            this.empruntsReservMembreBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservMembreSplitContainer)).BeginInit();
            this.reservMembreSplitContainer.Panel1.SuspendLayout();
            this.reservMembreSplitContainer.Panel2.SuspendLayout();
            this.reservMembreSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empruntMembreSplitContainer)).BeginInit();
            this.empruntMembreSplitContainer.Panel1.SuspendLayout();
            this.empruntMembreSplitContainer.Panel2.SuspendLayout();
            this.empruntMembreSplitContainer.SuspendLayout();
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
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.toggleEditionMode);
            // 
            // sauvegarderLesModificationsToolStripMenuItem
            // 
            this.sauvegarderLesModificationsToolStripMenuItem.Enabled = false;
            this.sauvegarderLesModificationsToolStripMenuItem.Name = "sauvegarderLesModificationsToolStripMenuItem";
            this.sauvegarderLesModificationsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sauvegarderLesModificationsToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.sauvegarderLesModificationsToolStripMenuItem.Text = "Sauvegarder les modifications";
            this.sauvegarderLesModificationsToolStripMenuItem.Click += new System.EventHandler(this.toggleEditionMode);
            // 
            // ignorerLesModificationsToolStripMenuItem
            // 
            this.ignorerLesModificationsToolStripMenuItem.Enabled = false;
            this.ignorerLesModificationsToolStripMenuItem.Name = "ignorerLesModificationsToolStripMenuItem";
            this.ignorerLesModificationsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ignorerLesModificationsToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.ignorerLesModificationsToolStripMenuItem.Text = "Ignorer les modifications";
            this.ignorerLesModificationsToolStripMenuItem.Click += new System.EventHandler(this.toggleEditionMode);
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
            this.ajouterOuvrageMenu.Click += new System.EventHandler(this.ajouterOuvrageMenu_Click);
            // 
            // supprOuvrageMenu
            // 
            this.supprOuvrageMenu.Name = "supprOuvrageMenu";
            this.supprOuvrageMenu.Size = new System.Drawing.Size(129, 22);
            this.supprOuvrageMenu.Text = "Supprimer";
            this.supprOuvrageMenu.Click += new System.EventHandler(this.supprOuvrageMenu_Click);
            // 
            // auteursToolStripMenuItem
            // 
            this.auteursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterAuteurMenu,
            this.supprAuteurMenu});
            this.auteursToolStripMenuItem.Name = "auteursToolStripMenuItem";
            this.auteursToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.auteursToolStripMenuItem.Text = "Auteur";
            // 
            // ajouterAuteurMenu
            // 
            this.ajouterAuteurMenu.Name = "ajouterAuteurMenu";
            this.ajouterAuteurMenu.Size = new System.Drawing.Size(152, 22);
            this.ajouterAuteurMenu.Text = "Ajouter";
            this.ajouterAuteurMenu.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprAuteurMenu
            // 
            this.supprAuteurMenu.Name = "supprAuteurMenu";
            this.supprAuteurMenu.Size = new System.Drawing.Size(152, 22);
            this.supprAuteurMenu.Text = "Supprimer";
            this.supprAuteurMenu.Click += new System.EventHandler(this.supprAuteurMenu_Click);
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
            this.ajouterMembreMenu.Size = new System.Drawing.Size(152, 22);
            this.ajouterMembreMenu.Text = "Ajouter";
            this.ajouterMembreMenu.Click += new System.EventHandler(this.ajouterMembreMenu_Click);
            // 
            // supprMembreMenu
            // 
            this.supprMembreMenu.Name = "supprMembreMenu";
            this.supprMembreMenu.Size = new System.Drawing.Size(152, 22);
            this.supprMembreMenu.Text = "Supprimer";
            this.supprMembreMenu.Click += new System.EventHandler(this.supprMembreMenu_Click);
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
            this.ajouterEmpruntMenu.Size = new System.Drawing.Size(152, 22);
            this.ajouterEmpruntMenu.Text = "Ajouter";
            this.ajouterEmpruntMenu.Click += new System.EventHandler(this.ajouterEmpruntMenu_Click);
            // 
            // supprEmpruntMenu
            // 
            this.supprEmpruntMenu.Name = "supprEmpruntMenu";
            this.supprEmpruntMenu.Size = new System.Drawing.Size(152, 22);
            this.supprEmpruntMenu.Text = "Supprimer";
            this.supprEmpruntMenu.Click += new System.EventHandler(this.supprEmpruntMenu_Click);
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
            this.ajouterReservationMenu.Click += new System.EventHandler(this.ajouterReservationMenu_Click);
            // 
            // supprReservMenu
            // 
            this.supprReservMenu.Name = "supprReservMenu";
            this.supprReservMenu.Size = new System.Drawing.Size(152, 22);
            this.supprReservMenu.Text = "Supprimer";
            this.supprReservMenu.Click += new System.EventHandler(this.supprReservMenu_Click);
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
            this.formSplitContainer.SplitterWidth = 2;
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
            this.generalTreeView.Location = new System.Drawing.Point(2, 0);
            this.generalTreeView.Margin = new System.Windows.Forms.Padding(2, 3, 0, 1);
            this.generalTreeView.Name = "generalTreeView";
            this.generalTreeView.Size = new System.Drawing.Size(226, 563);
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
            this.infoTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTabs.Location = new System.Drawing.Point(0, 0);
            this.infoTabs.Name = "infoTabs";
            this.infoTabs.SelectedIndex = 0;
            this.infoTabs.Size = new System.Drawing.Size(765, 563);
            this.infoTabs.TabIndex = 0;
            this.infoTabs.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.infoTabs_Deselecting);
            // 
            // ouvrageInfoPage
            // 
            this.ouvrageInfoPage.Controls.Add(this.tableLayoutOuvrageInfo);
            this.ouvrageInfoPage.Location = new System.Drawing.Point(4, 22);
            this.ouvrageInfoPage.Name = "ouvrageInfoPage";
            this.ouvrageInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.ouvrageInfoPage.Size = new System.Drawing.Size(757, 537);
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
            this.tableLayoutOuvrageInfo.Size = new System.Drawing.Size(751, 531);
            this.tableLayoutOuvrageInfo.TabIndex = 0;
            // 
            // infoBox
            // 
            this.infoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBox.Controls.Add(this.infosOuvrageTableLayout);
            this.infoBox.Location = new System.Drawing.Point(3, 3);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(745, 259);
            this.infoBox.TabIndex = 0;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Infos";
            // 
            // infosOuvrageTableLayout
            // 
            this.infosOuvrageTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infosOuvrageTableLayout.ColumnCount = 4;
            this.infosOuvrageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.infosOuvrageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.infosOuvrageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.infosOuvrageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.infosOuvrageTableLayout.Controls.Add(this.auteursLabel, 2, 0);
            this.infosOuvrageTableLayout.Controls.Add(this.titreLabel, 0, 0);
            this.infosOuvrageTableLayout.Controls.Add(this.titreTextBox, 1, 0);
            this.infosOuvrageTableLayout.Controls.Add(this.dateCreaTextBox, 1, 1);
            this.infosOuvrageTableLayout.Controls.Add(this.dateCreaLabel, 0, 1);
            this.infosOuvrageTableLayout.Controls.Add(this.sectionLabel, 0, 2);
            this.infosOuvrageTableLayout.Controls.Add(this.sectionTextBox, 1, 2);
            this.infosOuvrageTableLayout.Controls.Add(this.localLabel, 0, 3);
            this.infosOuvrageTableLayout.Controls.Add(this.localTextBox, 1, 3);
            this.infosOuvrageTableLayout.Controls.Add(this.superLabel, 2, 1);
            this.infosOuvrageTableLayout.Controls.Add(this.entrepriseLabel, 2, 2);
            this.infosOuvrageTableLayout.Controls.Add(this.entrepTextBox, 3, 2);
            this.infosOuvrageTableLayout.Controls.Add(this.typeLabel, 2, 3);
            this.infosOuvrageTableLayout.Controls.Add(this.typeTextBox, 3, 3);
            this.infosOuvrageTableLayout.Controls.Add(this.auteursSplitContainer, 3, 0);
            this.infosOuvrageTableLayout.Controls.Add(this.superSplitContainer, 3, 1);
            this.infosOuvrageTableLayout.Location = new System.Drawing.Point(3, 16);
            this.infosOuvrageTableLayout.Name = "infosOuvrageTableLayout";
            this.infosOuvrageTableLayout.RowCount = 4;
            this.infosOuvrageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infosOuvrageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infosOuvrageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infosOuvrageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.infosOuvrageTableLayout.Size = new System.Drawing.Size(739, 240);
            this.infosOuvrageTableLayout.TabIndex = 0;
            // 
            // auteursLabel
            // 
            this.auteursLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.auteursLabel.AutoSize = true;
            this.auteursLabel.Location = new System.Drawing.Point(389, 23);
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
            this.titreTextBox.Size = new System.Drawing.Size(289, 20);
            this.titreTextBox.TabIndex = 3;
            // 
            // dateCreaTextBox
            // 
            this.dateCreaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateCreaTextBox.Location = new System.Drawing.Point(76, 80);
            this.dateCreaTextBox.Name = "dateCreaTextBox";
            this.dateCreaTextBox.ReadOnly = true;
            this.dateCreaTextBox.Size = new System.Drawing.Size(289, 20);
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
            this.sectionTextBox.Size = new System.Drawing.Size(289, 20);
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
            this.localTextBox.Size = new System.Drawing.Size(289, 20);
            this.localTextBox.TabIndex = 5;
            // 
            // superLabel
            // 
            this.superLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.superLabel.AutoSize = true;
            this.superLabel.Location = new System.Drawing.Point(373, 83);
            this.superLabel.Name = "superLabel";
            this.superLabel.Size = new System.Drawing.Size(63, 13);
            this.superLabel.TabIndex = 12;
            this.superLabel.Text = "Superviseur";
            this.superLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entrepriseLabel
            // 
            this.entrepriseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entrepriseLabel.AutoSize = true;
            this.entrepriseLabel.Location = new System.Drawing.Point(384, 143);
            this.entrepriseLabel.Name = "entrepriseLabel";
            this.entrepriseLabel.Size = new System.Drawing.Size(54, 13);
            this.entrepriseLabel.TabIndex = 10;
            this.entrepriseLabel.Text = "Entreprise";
            // 
            // entrepTextBox
            // 
            this.entrepTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.entrepTextBox.Location = new System.Drawing.Point(444, 140);
            this.entrepTextBox.Name = "entrepTextBox";
            this.entrepTextBox.ReadOnly = true;
            this.entrepTextBox.Size = new System.Drawing.Size(292, 20);
            this.entrepTextBox.TabIndex = 11;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(389, 203);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 14;
            this.typeLabel.Text = "Type";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.typeTextBox.Location = new System.Drawing.Point(444, 200);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(292, 20);
            this.typeTextBox.TabIndex = 15;
            // 
            // auteursSplitContainer
            // 
            this.auteursSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteursSplitContainer.IsSplitterFixed = true;
            this.auteursSplitContainer.Location = new System.Drawing.Point(441, 0);
            this.auteursSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.auteursSplitContainer.Name = "auteursSplitContainer";
            // 
            // auteursSplitContainer.Panel1
            // 
            this.auteursSplitContainer.Panel1.Controls.Add(this.auteursListBox);
            // 
            // auteursSplitContainer.Panel2
            // 
            this.auteursSplitContainer.Panel2.Controls.Add(this.ajouterAuteurBouton);
            this.auteursSplitContainer.Panel2.Controls.Add(this.supprAuteurBouton);
            this.auteursSplitContainer.Size = new System.Drawing.Size(298, 60);
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
            this.auteursListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.auteursListBox_MouseDoubleClick);
            // 
            // ajouterAuteurBouton
            // 
            this.ajouterAuteurBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterAuteurBouton.Location = new System.Drawing.Point(9, 10);
            this.ajouterAuteurBouton.Name = "ajouterAuteurBouton";
            this.ajouterAuteurBouton.Size = new System.Drawing.Size(20, 20);
            this.ajouterAuteurBouton.TabIndex = 0;
            this.ajouterAuteurBouton.Text = "+";
            this.ajouterAuteurBouton.UseVisualStyleBackColor = true;
            this.ajouterAuteurBouton.Click += new System.EventHandler(this.ajouterAuteurBouton_Click);
            // 
            // supprAuteurBouton
            // 
            this.supprAuteurBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprAuteurBouton.Location = new System.Drawing.Point(9, 30);
            this.supprAuteurBouton.Name = "supprAuteurBouton";
            this.supprAuteurBouton.Size = new System.Drawing.Size(20, 20);
            this.supprAuteurBouton.TabIndex = 1;
            this.supprAuteurBouton.Text = "-";
            this.supprAuteurBouton.UseVisualStyleBackColor = true;
            this.supprAuteurBouton.Click += new System.EventHandler(this.supprAuteurBouton_Click);
            // 
            // superSplitContainer
            // 
            this.superSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superSplitContainer.IsSplitterFixed = true;
            this.superSplitContainer.Location = new System.Drawing.Point(441, 60);
            this.superSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.superSplitContainer.Name = "superSplitContainer";
            // 
            // superSplitContainer.Panel1
            // 
            this.superSplitContainer.Panel1.Controls.Add(this.superListBox);
            // 
            // superSplitContainer.Panel2
            // 
            this.superSplitContainer.Panel2.Controls.Add(this.ajouterSuperBouton);
            this.superSplitContainer.Panel2.Controls.Add(this.supprSuperBouton);
            this.superSplitContainer.Size = new System.Drawing.Size(298, 60);
            this.superSplitContainer.SplitterDistance = 266;
            this.superSplitContainer.SplitterWidth = 2;
            this.superSplitContainer.TabIndex = 17;
            // 
            // superListBox
            // 
            this.superListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.superListBox.FormattingEnabled = true;
            this.superListBox.Location = new System.Drawing.Point(0, 20);
            this.superListBox.Name = "superListBox";
            this.superListBox.Size = new System.Drawing.Size(266, 17);
            this.superListBox.TabIndex = 17;
            this.superListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.superListBox_MouseDoubleClick);
            // 
            // ajouterSuperBouton
            // 
            this.ajouterSuperBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterSuperBouton.Location = new System.Drawing.Point(9, 10);
            this.ajouterSuperBouton.Name = "ajouterSuperBouton";
            this.ajouterSuperBouton.Size = new System.Drawing.Size(20, 20);
            this.ajouterSuperBouton.TabIndex = 2;
            this.ajouterSuperBouton.Text = "+";
            this.ajouterSuperBouton.UseVisualStyleBackColor = true;
            this.ajouterSuperBouton.Click += new System.EventHandler(this.ajouterSuperBouton_Click);
            // 
            // supprSuperBouton
            // 
            this.supprSuperBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprSuperBouton.Location = new System.Drawing.Point(9, 30);
            this.supprSuperBouton.Name = "supprSuperBouton";
            this.supprSuperBouton.Size = new System.Drawing.Size(20, 20);
            this.supprSuperBouton.TabIndex = 3;
            this.supprSuperBouton.Text = "-";
            this.supprSuperBouton.UseVisualStyleBackColor = true;
            this.supprSuperBouton.Click += new System.EventHandler(this.supprSuperBouton_Click);
            // 
            // empruntBox
            // 
            this.empruntBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empruntBox.Controls.Add(this.empruntSplitContainer);
            this.empruntBox.Location = new System.Drawing.Point(3, 268);
            this.empruntBox.Name = "empruntBox";
            this.empruntBox.Size = new System.Drawing.Size(745, 126);
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
            this.empruntSplitContainer.Size = new System.Drawing.Size(739, 107);
            this.empruntSplitContainer.SplitterDistance = 613;
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
            this.empruntInfoTableLayout.Controls.Add(this.membreEmpruntListBox, 1, 0);
            this.empruntInfoTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empruntInfoTableLayout.Location = new System.Drawing.Point(0, 0);
            this.empruntInfoTableLayout.Name = "empruntInfoTableLayout";
            this.empruntInfoTableLayout.RowCount = 2;
            this.empruntInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.empruntInfoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.empruntInfoTableLayout.Size = new System.Drawing.Size(613, 107);
            this.empruntInfoTableLayout.TabIndex = 0;
            // 
            // etatEmpruntTextBox
            // 
            this.etatEmpruntTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.etatEmpruntTextBox.Location = new System.Drawing.Point(370, 70);
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
            this.dateEmpruntTextBox.Size = new System.Drawing.Size(239, 20);
            this.dateEmpruntTextBox.TabIndex = 6;
            // 
            // dureeEmpruntTextBox
            // 
            this.dureeEmpruntTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dureeEmpruntTextBox.Location = new System.Drawing.Point(370, 16);
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
            this.dureeEmpruntLabel.Location = new System.Drawing.Point(328, 20);
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
            this.etatEmpruntLabel.Location = new System.Drawing.Point(338, 73);
            this.etatEmpruntLabel.Name = "etatEmpruntLabel";
            this.etatEmpruntLabel.Size = new System.Drawing.Size(26, 13);
            this.etatEmpruntLabel.TabIndex = 3;
            this.etatEmpruntLabel.Text = "État";
            this.etatEmpruntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // membreEmpruntListBox
            // 
            this.membreEmpruntListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.membreEmpruntListBox.FormattingEnabled = true;
            this.membreEmpruntListBox.Location = new System.Drawing.Point(64, 18);
            this.membreEmpruntListBox.Name = "membreEmpruntListBox";
            this.membreEmpruntListBox.Size = new System.Drawing.Size(239, 17);
            this.membreEmpruntListBox.TabIndex = 8;
            this.membreEmpruntListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.membreEmpruntListBox_MouseDoubleClick);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(122, 107);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ajouterEmpruntBouton
            // 
            this.ajouterEmpruntBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterEmpruntBouton.Enabled = false;
            this.ajouterEmpruntBouton.ForeColor = System.Drawing.Color.DarkGreen;
            this.ajouterEmpruntBouton.Location = new System.Drawing.Point(11, 11);
            this.ajouterEmpruntBouton.Name = "ajouterEmpruntBouton";
            this.ajouterEmpruntBouton.Size = new System.Drawing.Size(100, 30);
            this.ajouterEmpruntBouton.TabIndex = 0;
            this.ajouterEmpruntBouton.Text = "Ajouter Emprunt";
            this.ajouterEmpruntBouton.UseVisualStyleBackColor = true;
            this.ajouterEmpruntBouton.Click += new System.EventHandler(this.ajouterEmpruntBouton_Click);
            // 
            // supprEmpruntBouton
            // 
            this.supprEmpruntBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprEmpruntBouton.Enabled = false;
            this.supprEmpruntBouton.ForeColor = System.Drawing.Color.DarkRed;
            this.supprEmpruntBouton.Location = new System.Drawing.Point(11, 65);
            this.supprEmpruntBouton.Name = "supprEmpruntBouton";
            this.supprEmpruntBouton.Size = new System.Drawing.Size(100, 30);
            this.supprEmpruntBouton.TabIndex = 1;
            this.supprEmpruntBouton.Text = "Suppr. Emprunt";
            this.supprEmpruntBouton.UseVisualStyleBackColor = true;
            this.supprEmpruntBouton.Click += new System.EventHandler(this.supprEmpruntBouton_Click);
            // 
            // reservationBox
            // 
            this.reservationBox.Controls.Add(this.reservationSplitContainer);
            this.reservationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationBox.Location = new System.Drawing.Point(3, 400);
            this.reservationBox.Name = "reservationBox";
            this.reservationBox.Size = new System.Drawing.Size(745, 128);
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
            this.reservationSplitContainer.Size = new System.Drawing.Size(739, 109);
            this.reservationSplitContainer.SplitterDistance = 613;
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
            this.reservOuvrageInfoTableLayout.Size = new System.Drawing.Size(613, 109);
            this.reservOuvrageInfoTableLayout.TabIndex = 0;
            // 
            // dateReservTextBox
            // 
            this.dateReservTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateReservTextBox.Location = new System.Drawing.Point(64, 71);
            this.dateReservTextBox.Name = "dateReservTextBox";
            this.dateReservTextBox.ReadOnly = true;
            this.dateReservTextBox.Size = new System.Drawing.Size(239, 20);
            this.dateReservTextBox.TabIndex = 7;
            // 
            // dureeReservTextBox
            // 
            this.dureeReservTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dureeReservTextBox.Location = new System.Drawing.Point(370, 17);
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
            this.dureeReservLabel.Location = new System.Drawing.Point(328, 20);
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
            this.reservListBox.Size = new System.Drawing.Size(239, 48);
            this.reservListBox.TabIndex = 9;
            this.reservListBox.SelectedIndexChanged += new System.EventHandler(this.reservListBox_SelectedIndexChanged);
            this.reservListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.reservListBox_MouseDoubleClick);
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(122, 109);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // ajouterReservBouton
            // 
            this.ajouterReservBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterReservBouton.Enabled = false;
            this.ajouterReservBouton.ForeColor = System.Drawing.Color.DarkGreen;
            this.ajouterReservBouton.Location = new System.Drawing.Point(11, 7);
            this.ajouterReservBouton.Name = "ajouterReservBouton";
            this.ajouterReservBouton.Size = new System.Drawing.Size(100, 40);
            this.ajouterReservBouton.TabIndex = 0;
            this.ajouterReservBouton.Text = "Ajouter Réservation";
            this.ajouterReservBouton.UseVisualStyleBackColor = true;
            this.ajouterReservBouton.Click += new System.EventHandler(this.ajouterReservBouton_Click);
            // 
            // supprReservBouton
            // 
            this.supprReservBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprReservBouton.Enabled = false;
            this.supprReservBouton.ForeColor = System.Drawing.Color.DarkRed;
            this.supprReservBouton.Location = new System.Drawing.Point(11, 61);
            this.supprReservBouton.Name = "supprReservBouton";
            this.supprReservBouton.Size = new System.Drawing.Size(100, 40);
            this.supprReservBouton.TabIndex = 1;
            this.supprReservBouton.Text = "Supprimer Réservation";
            this.supprReservBouton.UseVisualStyleBackColor = true;
            this.supprReservBouton.Click += new System.EventHandler(this.supprReservBouton_Click);
            // 
            // auteurInfoPage
            // 
            this.auteurInfoPage.Controls.Add(this.auteurInfoPageTableLayout);
            this.auteurInfoPage.Location = new System.Drawing.Point(4, 22);
            this.auteurInfoPage.Name = "auteurInfoPage";
            this.auteurInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.auteurInfoPage.Size = new System.Drawing.Size(757, 537);
            this.auteurInfoPage.TabIndex = 1;
            this.auteurInfoPage.Text = "Auteur";
            this.auteurInfoPage.UseVisualStyleBackColor = true;
            // 
            // auteurInfoPageTableLayout
            // 
            this.auteurInfoPageTableLayout.ColumnCount = 1;
            this.auteurInfoPageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.auteurInfoPageTableLayout.Controls.Add(this.infAuteurGroupBox, 0, 0);
            this.auteurInfoPageTableLayout.Controls.Add(this.travailAuteurGroupBox, 0, 1);
            this.auteurInfoPageTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteurInfoPageTableLayout.Location = new System.Drawing.Point(3, 3);
            this.auteurInfoPageTableLayout.Name = "auteurInfoPageTableLayout";
            this.auteurInfoPageTableLayout.RowCount = 2;
            this.auteurInfoPageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.91714F));
            this.auteurInfoPageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.08286F));
            this.auteurInfoPageTableLayout.Size = new System.Drawing.Size(751, 531);
            this.auteurInfoPageTableLayout.TabIndex = 0;
            // 
            // infAuteurGroupBox
            // 
            this.infAuteurGroupBox.Controls.Add(this.infosAuteurTableLayout);
            this.infAuteurGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infAuteurGroupBox.Location = new System.Drawing.Point(3, 3);
            this.infAuteurGroupBox.Name = "infAuteurGroupBox";
            this.infAuteurGroupBox.Size = new System.Drawing.Size(745, 121);
            this.infAuteurGroupBox.TabIndex = 0;
            this.infAuteurGroupBox.TabStop = false;
            this.infAuteurGroupBox.Text = "Infos";
            // 
            // infosAuteurTableLayout
            // 
            this.infosAuteurTableLayout.ColumnCount = 2;
            this.infosAuteurTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.infosAuteurTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.infosAuteurTableLayout.Controls.Add(this.nomAuteurLabel, 0, 0);
            this.infosAuteurTableLayout.Controls.Add(this.prenomAuteurLabel, 0, 1);
            this.infosAuteurTableLayout.Controls.Add(this.statutAuteurLabel, 0, 2);
            this.infosAuteurTableLayout.Controls.Add(this.nomAuteurTextBox, 1, 0);
            this.infosAuteurTableLayout.Controls.Add(this.prenomAuteurTextBox, 1, 1);
            this.infosAuteurTableLayout.Controls.Add(this.statutAuteurTextBox, 1, 2);
            this.infosAuteurTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infosAuteurTableLayout.Location = new System.Drawing.Point(3, 16);
            this.infosAuteurTableLayout.Name = "infosAuteurTableLayout";
            this.infosAuteurTableLayout.RowCount = 3;
            this.infosAuteurTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.infosAuteurTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.infosAuteurTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.infosAuteurTableLayout.Size = new System.Drawing.Size(739, 102);
            this.infosAuteurTableLayout.TabIndex = 0;
            // 
            // nomAuteurLabel
            // 
            this.nomAuteurLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nomAuteurLabel.AutoSize = true;
            this.nomAuteurLabel.Location = new System.Drawing.Point(41, 10);
            this.nomAuteurLabel.Name = "nomAuteurLabel";
            this.nomAuteurLabel.Size = new System.Drawing.Size(29, 13);
            this.nomAuteurLabel.TabIndex = 0;
            this.nomAuteurLabel.Text = "Nom";
            // 
            // prenomAuteurLabel
            // 
            this.prenomAuteurLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.prenomAuteurLabel.AutoSize = true;
            this.prenomAuteurLabel.Location = new System.Drawing.Point(27, 44);
            this.prenomAuteurLabel.Name = "prenomAuteurLabel";
            this.prenomAuteurLabel.Size = new System.Drawing.Size(43, 13);
            this.prenomAuteurLabel.TabIndex = 1;
            this.prenomAuteurLabel.Text = "Prénom";
            // 
            // statutAuteurLabel
            // 
            this.statutAuteurLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statutAuteurLabel.AutoSize = true;
            this.statutAuteurLabel.Location = new System.Drawing.Point(38, 78);
            this.statutAuteurLabel.Name = "statutAuteurLabel";
            this.statutAuteurLabel.Size = new System.Drawing.Size(32, 13);
            this.statutAuteurLabel.TabIndex = 2;
            this.statutAuteurLabel.Text = "Satut";
            // 
            // nomAuteurTextBox
            // 
            this.nomAuteurTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nomAuteurTextBox.Location = new System.Drawing.Point(76, 7);
            this.nomAuteurTextBox.Name = "nomAuteurTextBox";
            this.nomAuteurTextBox.Size = new System.Drawing.Size(302, 20);
            this.nomAuteurTextBox.TabIndex = 3;
            // 
            // prenomAuteurTextBox
            // 
            this.prenomAuteurTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.prenomAuteurTextBox.Location = new System.Drawing.Point(76, 41);
            this.prenomAuteurTextBox.Name = "prenomAuteurTextBox";
            this.prenomAuteurTextBox.Size = new System.Drawing.Size(302, 20);
            this.prenomAuteurTextBox.TabIndex = 4;
            // 
            // statutAuteurTextBox
            // 
            this.statutAuteurTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statutAuteurTextBox.Location = new System.Drawing.Point(76, 75);
            this.statutAuteurTextBox.Name = "statutAuteurTextBox";
            this.statutAuteurTextBox.Size = new System.Drawing.Size(302, 20);
            this.statutAuteurTextBox.TabIndex = 5;
            // 
            // travailAuteurGroupBox
            // 
            this.travailAuteurGroupBox.Controls.Add(this.auteurPubliTableLayout);
            this.travailAuteurGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.travailAuteurGroupBox.Location = new System.Drawing.Point(3, 130);
            this.travailAuteurGroupBox.Name = "travailAuteurGroupBox";
            this.travailAuteurGroupBox.Size = new System.Drawing.Size(745, 398);
            this.travailAuteurGroupBox.TabIndex = 1;
            this.travailAuteurGroupBox.TabStop = false;
            // 
            // auteurPubliTableLayout
            // 
            this.auteurPubliTableLayout.ColumnCount = 2;
            this.auteurPubliTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.auteurPubliTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.auteurPubliTableLayout.Controls.Add(this.auteurSuperviseSplitContainer, 1, 1);
            this.auteurPubliTableLayout.Controls.Add(this.publiAuteurLabel, 0, 0);
            this.auteurPubliTableLayout.Controls.Add(this.superviseLabel, 1, 0);
            this.auteurPubliTableLayout.Controls.Add(this.auteurEcritSplitContainer, 0, 1);
            this.auteurPubliTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteurPubliTableLayout.Location = new System.Drawing.Point(3, 16);
            this.auteurPubliTableLayout.Name = "auteurPubliTableLayout";
            this.auteurPubliTableLayout.RowCount = 2;
            this.auteurPubliTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.068602F));
            this.auteurPubliTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.9314F));
            this.auteurPubliTableLayout.Size = new System.Drawing.Size(739, 379);
            this.auteurPubliTableLayout.TabIndex = 0;
            // 
            // auteurSuperviseSplitContainer
            // 
            this.auteurSuperviseSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteurSuperviseSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.auteurSuperviseSplitContainer.IsSplitterFixed = true;
            this.auteurSuperviseSplitContainer.Location = new System.Drawing.Point(372, 26);
            this.auteurSuperviseSplitContainer.Name = "auteurSuperviseSplitContainer";
            // 
            // auteurSuperviseSplitContainer.Panel1
            // 
            this.auteurSuperviseSplitContainer.Panel1.Controls.Add(this.auteurSuperviseListBox);
            // 
            // auteurSuperviseSplitContainer.Panel2
            // 
            this.auteurSuperviseSplitContainer.Panel2.Controls.Add(this.ajouterSupervisionAuteurBouton);
            this.auteurSuperviseSplitContainer.Panel2.Controls.Add(this.supprSupervisionAuteurBouton);
            this.auteurSuperviseSplitContainer.Size = new System.Drawing.Size(364, 350);
            this.auteurSuperviseSplitContainer.SplitterDistance = 301;
            this.auteurSuperviseSplitContainer.TabIndex = 3;
            // 
            // auteurSuperviseListBox
            // 
            this.auteurSuperviseListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteurSuperviseListBox.FormattingEnabled = true;
            this.auteurSuperviseListBox.Location = new System.Drawing.Point(0, 0);
            this.auteurSuperviseListBox.Name = "auteurSuperviseListBox";
            this.auteurSuperviseListBox.Size = new System.Drawing.Size(301, 350);
            this.auteurSuperviseListBox.TabIndex = 2;
            this.auteurSuperviseListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.auteurSuperviseListBox_MouseDoubleClick);
            // 
            // ajouterSupervisionAuteurBouton
            // 
            this.ajouterSupervisionAuteurBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterSupervisionAuteurBouton.Location = new System.Drawing.Point(19, 155);
            this.ajouterSupervisionAuteurBouton.Name = "ajouterSupervisionAuteurBouton";
            this.ajouterSupervisionAuteurBouton.Size = new System.Drawing.Size(20, 20);
            this.ajouterSupervisionAuteurBouton.TabIndex = 4;
            this.ajouterSupervisionAuteurBouton.Text = "+";
            this.ajouterSupervisionAuteurBouton.UseVisualStyleBackColor = true;
            this.ajouterSupervisionAuteurBouton.Click += new System.EventHandler(this.ajouterSupervisionAuteurBouton_Click);
            // 
            // supprSupervisionAuteurBouton
            // 
            this.supprSupervisionAuteurBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprSupervisionAuteurBouton.Location = new System.Drawing.Point(19, 175);
            this.supprSupervisionAuteurBouton.Name = "supprSupervisionAuteurBouton";
            this.supprSupervisionAuteurBouton.Size = new System.Drawing.Size(20, 20);
            this.supprSupervisionAuteurBouton.TabIndex = 5;
            this.supprSupervisionAuteurBouton.Text = "-";
            this.supprSupervisionAuteurBouton.UseVisualStyleBackColor = true;
            this.supprSupervisionAuteurBouton.Click += new System.EventHandler(this.supprSupervisionAuteurBouton_Click);
            // 
            // publiAuteurLabel
            // 
            this.publiAuteurLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.publiAuteurLabel.AutoSize = true;
            this.publiAuteurLabel.Location = new System.Drawing.Point(152, 10);
            this.publiAuteurLabel.Name = "publiAuteurLabel";
            this.publiAuteurLabel.Size = new System.Drawing.Size(64, 13);
            this.publiAuteurLabel.TabIndex = 0;
            this.publiAuteurLabel.Text = "Publications";
            // 
            // superviseLabel
            // 
            this.superviseLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.superviseLabel.AutoSize = true;
            this.superviseLabel.Location = new System.Drawing.Point(527, 10);
            this.superviseLabel.Name = "superviseLabel";
            this.superviseLabel.Size = new System.Drawing.Size(54, 13);
            this.superviseLabel.TabIndex = 1;
            this.superviseLabel.Text = "Supervise";
            // 
            // auteurEcritSplitContainer
            // 
            this.auteurEcritSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteurEcritSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.auteurEcritSplitContainer.IsSplitterFixed = true;
            this.auteurEcritSplitContainer.Location = new System.Drawing.Point(3, 26);
            this.auteurEcritSplitContainer.Name = "auteurEcritSplitContainer";
            // 
            // auteurEcritSplitContainer.Panel1
            // 
            this.auteurEcritSplitContainer.Panel1.Controls.Add(this.publiAuteurListBox);
            // 
            // auteurEcritSplitContainer.Panel2
            // 
            this.auteurEcritSplitContainer.Panel2.Controls.Add(this.ajouterPubliAuteurBouton);
            this.auteurEcritSplitContainer.Panel2.Controls.Add(this.supprPubliAuteurBouton);
            this.auteurEcritSplitContainer.Size = new System.Drawing.Size(363, 350);
            this.auteurEcritSplitContainer.SplitterDistance = 301;
            this.auteurEcritSplitContainer.TabIndex = 2;
            // 
            // publiAuteurListBox
            // 
            this.publiAuteurListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publiAuteurListBox.FormattingEnabled = true;
            this.publiAuteurListBox.Location = new System.Drawing.Point(0, 0);
            this.publiAuteurListBox.Name = "publiAuteurListBox";
            this.publiAuteurListBox.Size = new System.Drawing.Size(301, 350);
            this.publiAuteurListBox.TabIndex = 2;
            this.publiAuteurListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.publiAuteurListBox_MouseDoubleClick);
            // 
            // ajouterPubliAuteurBouton
            // 
            this.ajouterPubliAuteurBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterPubliAuteurBouton.Location = new System.Drawing.Point(19, 155);
            this.ajouterPubliAuteurBouton.Name = "ajouterPubliAuteurBouton";
            this.ajouterPubliAuteurBouton.Size = new System.Drawing.Size(20, 20);
            this.ajouterPubliAuteurBouton.TabIndex = 4;
            this.ajouterPubliAuteurBouton.Text = "+";
            this.ajouterPubliAuteurBouton.UseVisualStyleBackColor = true;
            this.ajouterPubliAuteurBouton.Click += new System.EventHandler(this.ajouterPubliAuteurBouton_Click);
            // 
            // supprPubliAuteurBouton
            // 
            this.supprPubliAuteurBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprPubliAuteurBouton.Location = new System.Drawing.Point(19, 175);
            this.supprPubliAuteurBouton.Name = "supprPubliAuteurBouton";
            this.supprPubliAuteurBouton.Size = new System.Drawing.Size(20, 20);
            this.supprPubliAuteurBouton.TabIndex = 5;
            this.supprPubliAuteurBouton.Text = "-";
            this.supprPubliAuteurBouton.UseVisualStyleBackColor = true;
            this.supprPubliAuteurBouton.Click += new System.EventHandler(this.supprPubliAuteurBouton_Click);
            // 
            // membreInfoPage
            // 
            this.membreInfoPage.Controls.Add(this.tableLayoutPanel1);
            this.membreInfoPage.Location = new System.Drawing.Point(4, 22);
            this.membreInfoPage.Name = "membreInfoPage";
            this.membreInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.membreInfoPage.Size = new System.Drawing.Size(757, 537);
            this.membreInfoPage.TabIndex = 2;
            this.membreInfoPage.Text = "Membre";
            this.membreInfoPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.empruntsReservMembreBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.63277F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.36723F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(751, 531);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.infosMembreTableLayout);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos";
            // 
            // infosMembreTableLayout
            // 
            this.infosMembreTableLayout.ColumnCount = 2;
            this.infosMembreTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.60217F));
            this.infosMembreTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.39783F));
            this.infosMembreTableLayout.Controls.Add(this.infosMembrePersonalTableLayout, 0, 0);
            this.infosMembreTableLayout.Controls.Add(this.infosMembreAdresseTableLayout, 1, 0);
            this.infosMembreTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infosMembreTableLayout.Location = new System.Drawing.Point(3, 16);
            this.infosMembreTableLayout.Name = "infosMembreTableLayout";
            this.infosMembreTableLayout.RowCount = 1;
            this.infosMembreTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infosMembreTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infosMembreTableLayout.Size = new System.Drawing.Size(739, 212);
            this.infosMembreTableLayout.TabIndex = 0;
            // 
            // infosMembrePersonalTableLayout
            // 
            this.infosMembrePersonalTableLayout.ColumnCount = 2;
            this.infosMembrePersonalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.01208F));
            this.infosMembrePersonalTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.98792F));
            this.infosMembrePersonalTableLayout.Controls.Add(this.nomMembreLabel, 0, 0);
            this.infosMembrePersonalTableLayout.Controls.Add(this.prenomMembreLabel, 0, 1);
            this.infosMembrePersonalTableLayout.Controls.Add(this.label3, 0, 2);
            this.infosMembrePersonalTableLayout.Controls.Add(this.nomMembreTextBox, 1, 0);
            this.infosMembrePersonalTableLayout.Controls.Add(this.prenomMembreTextBox, 1, 1);
            this.infosMembrePersonalTableLayout.Controls.Add(this.numTelMembreTextBox, 1, 2);
            this.infosMembrePersonalTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infosMembrePersonalTableLayout.Location = new System.Drawing.Point(3, 3);
            this.infosMembrePersonalTableLayout.Name = "infosMembrePersonalTableLayout";
            this.infosMembrePersonalTableLayout.RowCount = 3;
            this.infosMembrePersonalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.infosMembrePersonalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.infosMembrePersonalTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.infosMembrePersonalTableLayout.Size = new System.Drawing.Size(331, 206);
            this.infosMembrePersonalTableLayout.TabIndex = 0;
            // 
            // nomMembreLabel
            // 
            this.nomMembreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nomMembreLabel.AutoSize = true;
            this.nomMembreLabel.Location = new System.Drawing.Point(20, 27);
            this.nomMembreLabel.Name = "nomMembreLabel";
            this.nomMembreLabel.Size = new System.Drawing.Size(29, 13);
            this.nomMembreLabel.TabIndex = 0;
            this.nomMembreLabel.Text = "Nom";
            // 
            // prenomMembreLabel
            // 
            this.prenomMembreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.prenomMembreLabel.AutoSize = true;
            this.prenomMembreLabel.Location = new System.Drawing.Point(6, 95);
            this.prenomMembreLabel.Name = "prenomMembreLabel";
            this.prenomMembreLabel.Size = new System.Drawing.Size(43, 13);
            this.prenomMembreLabel.TabIndex = 1;
            this.prenomMembreLabel.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "N° Tél";
            // 
            // nomMembreTextBox
            // 
            this.nomMembreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nomMembreTextBox.Location = new System.Drawing.Point(55, 24);
            this.nomMembreTextBox.Name = "nomMembreTextBox";
            this.nomMembreTextBox.ReadOnly = true;
            this.nomMembreTextBox.Size = new System.Drawing.Size(273, 20);
            this.nomMembreTextBox.TabIndex = 3;
            // 
            // prenomMembreTextBox
            // 
            this.prenomMembreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prenomMembreTextBox.Location = new System.Drawing.Point(55, 92);
            this.prenomMembreTextBox.Name = "prenomMembreTextBox";
            this.prenomMembreTextBox.ReadOnly = true;
            this.prenomMembreTextBox.Size = new System.Drawing.Size(273, 20);
            this.prenomMembreTextBox.TabIndex = 4;
            // 
            // numTelMembreTextBox
            // 
            this.numTelMembreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numTelMembreTextBox.Location = new System.Drawing.Point(55, 161);
            this.numTelMembreTextBox.Name = "numTelMembreTextBox";
            this.numTelMembreTextBox.ReadOnly = true;
            this.numTelMembreTextBox.Size = new System.Drawing.Size(273, 20);
            this.numTelMembreTextBox.TabIndex = 5;
            // 
            // infosMembreAdresseTableLayout
            // 
            this.infosMembreAdresseTableLayout.ColumnCount = 4;
            this.infosMembreAdresseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.infosMembreAdresseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.21978F));
            this.infosMembreAdresseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.26374F));
            this.infosMembreAdresseTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.40659F));
            this.infosMembreAdresseTableLayout.Controls.Add(this.villeMembreLabel, 0, 1);
            this.infosMembreAdresseTableLayout.Controls.Add(this.rueMembreTextBox, 1, 0);
            this.infosMembreAdresseTableLayout.Controls.Add(this.adresseMembreLabel, 0, 0);
            this.infosMembreAdresseTableLayout.Controls.Add(this.numRueMembreTextBox, 3, 0);
            this.infosMembreAdresseTableLayout.Controls.Add(this.villeMembreTextBox, 1, 1);
            this.infosMembreAdresseTableLayout.Controls.Add(this.codePostalMembreTextBox, 3, 1);
            this.infosMembreAdresseTableLayout.Controls.Add(this.numRueMembreLabel, 2, 0);
            this.infosMembreAdresseTableLayout.Controls.Add(this.codePostalMembreLabel, 2, 1);
            this.infosMembreAdresseTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infosMembreAdresseTableLayout.Location = new System.Drawing.Point(340, 3);
            this.infosMembreAdresseTableLayout.Name = "infosMembreAdresseTableLayout";
            this.infosMembreAdresseTableLayout.RowCount = 2;
            this.infosMembreAdresseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infosMembreAdresseTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infosMembreAdresseTableLayout.Size = new System.Drawing.Size(396, 206);
            this.infosMembreAdresseTableLayout.TabIndex = 1;
            // 
            // villeMembreLabel
            // 
            this.villeMembreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.villeMembreLabel.AutoSize = true;
            this.villeMembreLabel.Location = new System.Drawing.Point(30, 148);
            this.villeMembreLabel.Name = "villeMembreLabel";
            this.villeMembreLabel.Size = new System.Drawing.Size(26, 13);
            this.villeMembreLabel.TabIndex = 8;
            this.villeMembreLabel.Text = "Ville";
            // 
            // rueMembreTextBox
            // 
            this.rueMembreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rueMembreTextBox.Location = new System.Drawing.Point(62, 41);
            this.rueMembreTextBox.Name = "rueMembreTextBox";
            this.rueMembreTextBox.ReadOnly = true;
            this.rueMembreTextBox.Size = new System.Drawing.Size(212, 20);
            this.rueMembreTextBox.TabIndex = 4;
            // 
            // adresseMembreLabel
            // 
            this.adresseMembreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.adresseMembreLabel.AutoSize = true;
            this.adresseMembreLabel.Location = new System.Drawing.Point(11, 45);
            this.adresseMembreLabel.Name = "adresseMembreLabel";
            this.adresseMembreLabel.Size = new System.Drawing.Size(45, 13);
            this.adresseMembreLabel.TabIndex = 0;
            this.adresseMembreLabel.Text = "Adresse";
            // 
            // numRueMembreTextBox
            // 
            this.numRueMembreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numRueMembreTextBox.Location = new System.Drawing.Point(324, 41);
            this.numRueMembreTextBox.Name = "numRueMembreTextBox";
            this.numRueMembreTextBox.ReadOnly = true;
            this.numRueMembreTextBox.Size = new System.Drawing.Size(69, 20);
            this.numRueMembreTextBox.TabIndex = 5;
            // 
            // villeMembreTextBox
            // 
            this.villeMembreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.villeMembreTextBox.Location = new System.Drawing.Point(62, 144);
            this.villeMembreTextBox.Name = "villeMembreTextBox";
            this.villeMembreTextBox.ReadOnly = true;
            this.villeMembreTextBox.Size = new System.Drawing.Size(212, 20);
            this.villeMembreTextBox.TabIndex = 6;
            // 
            // codePostalMembreTextBox
            // 
            this.codePostalMembreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.codePostalMembreTextBox.Location = new System.Drawing.Point(324, 144);
            this.codePostalMembreTextBox.Name = "codePostalMembreTextBox";
            this.codePostalMembreTextBox.ReadOnly = true;
            this.codePostalMembreTextBox.Size = new System.Drawing.Size(69, 20);
            this.codePostalMembreTextBox.TabIndex = 7;
            // 
            // numRueMembreLabel
            // 
            this.numRueMembreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numRueMembreLabel.AutoSize = true;
            this.numRueMembreLabel.Location = new System.Drawing.Point(299, 45);
            this.numRueMembreLabel.Name = "numRueMembreLabel";
            this.numRueMembreLabel.Size = new System.Drawing.Size(19, 13);
            this.numRueMembreLabel.TabIndex = 9;
            this.numRueMembreLabel.Text = "N°";
            // 
            // codePostalMembreLabel
            // 
            this.codePostalMembreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.codePostalMembreLabel.AutoSize = true;
            this.codePostalMembreLabel.Location = new System.Drawing.Point(283, 141);
            this.codePostalMembreLabel.Name = "codePostalMembreLabel";
            this.codePostalMembreLabel.Size = new System.Drawing.Size(35, 26);
            this.codePostalMembreLabel.TabIndex = 10;
            this.codePostalMembreLabel.Text = "Code postal";
            // 
            // empruntsReservMembreBox
            // 
            this.empruntsReservMembreBox.Controls.Add(this.tableLayoutPanel3);
            this.empruntsReservMembreBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empruntsReservMembreBox.Location = new System.Drawing.Point(3, 240);
            this.empruntsReservMembreBox.Name = "empruntsReservMembreBox";
            this.empruntsReservMembreBox.Size = new System.Drawing.Size(745, 288);
            this.empruntsReservMembreBox.TabIndex = 2;
            this.empruntsReservMembreBox.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.reservMembreSplitContainer, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.empruntMembreSplitContainer, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.068602F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.9314F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(739, 269);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // reservMembreSplitContainer
            // 
            this.reservMembreSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservMembreSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.reservMembreSplitContainer.IsSplitterFixed = true;
            this.reservMembreSplitContainer.Location = new System.Drawing.Point(372, 19);
            this.reservMembreSplitContainer.Name = "reservMembreSplitContainer";
            // 
            // reservMembreSplitContainer.Panel1
            // 
            this.reservMembreSplitContainer.Panel1.Controls.Add(this.resMembreListBox);
            // 
            // reservMembreSplitContainer.Panel2
            // 
            this.reservMembreSplitContainer.Panel2.Controls.Add(this.ajouterReservMembreBouton);
            this.reservMembreSplitContainer.Panel2.Controls.Add(this.supprReservMembreBouton);
            this.reservMembreSplitContainer.Size = new System.Drawing.Size(364, 247);
            this.reservMembreSplitContainer.SplitterDistance = 301;
            this.reservMembreSplitContainer.TabIndex = 3;
            // 
            // resMembreListBox
            // 
            this.resMembreListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resMembreListBox.FormattingEnabled = true;
            this.resMembreListBox.Location = new System.Drawing.Point(0, 0);
            this.resMembreListBox.Name = "resMembreListBox";
            this.resMembreListBox.Size = new System.Drawing.Size(301, 247);
            this.resMembreListBox.TabIndex = 2;
            this.resMembreListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resMembreListBox_MouseDoubleClick);
            // 
            // ajouterReservMembreBouton
            // 
            this.ajouterReservMembreBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterReservMembreBouton.Location = new System.Drawing.Point(19, 103);
            this.ajouterReservMembreBouton.Name = "ajouterReservMembreBouton";
            this.ajouterReservMembreBouton.Size = new System.Drawing.Size(20, 20);
            this.ajouterReservMembreBouton.TabIndex = 4;
            this.ajouterReservMembreBouton.Text = "+";
            this.ajouterReservMembreBouton.UseVisualStyleBackColor = true;
            this.ajouterReservMembreBouton.Click += new System.EventHandler(this.ajouterReservMembreBouton_Click);
            // 
            // supprReservMembreBouton
            // 
            this.supprReservMembreBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprReservMembreBouton.Location = new System.Drawing.Point(19, 123);
            this.supprReservMembreBouton.Name = "supprReservMembreBouton";
            this.supprReservMembreBouton.Size = new System.Drawing.Size(20, 20);
            this.supprReservMembreBouton.TabIndex = 5;
            this.supprReservMembreBouton.Text = "-";
            this.supprReservMembreBouton.UseVisualStyleBackColor = true;
            this.supprReservMembreBouton.Click += new System.EventHandler(this.supprReservMembreBouton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emprunts";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Réservations";
            // 
            // empruntMembreSplitContainer
            // 
            this.empruntMembreSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empruntMembreSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.empruntMembreSplitContainer.IsSplitterFixed = true;
            this.empruntMembreSplitContainer.Location = new System.Drawing.Point(3, 19);
            this.empruntMembreSplitContainer.Name = "empruntMembreSplitContainer";
            // 
            // empruntMembreSplitContainer.Panel1
            // 
            this.empruntMembreSplitContainer.Panel1.Controls.Add(this.empruntsMembreListBox);
            // 
            // empruntMembreSplitContainer.Panel2
            // 
            this.empruntMembreSplitContainer.Panel2.Controls.Add(this.ajouterEmpruntMembreBouton);
            this.empruntMembreSplitContainer.Panel2.Controls.Add(this.supprEmpruntMembreBouton);
            this.empruntMembreSplitContainer.Size = new System.Drawing.Size(363, 247);
            this.empruntMembreSplitContainer.SplitterDistance = 301;
            this.empruntMembreSplitContainer.TabIndex = 2;
            // 
            // empruntsMembreListBox
            // 
            this.empruntsMembreListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empruntsMembreListBox.FormattingEnabled = true;
            this.empruntsMembreListBox.Location = new System.Drawing.Point(0, 0);
            this.empruntsMembreListBox.Name = "empruntsMembreListBox";
            this.empruntsMembreListBox.Size = new System.Drawing.Size(301, 247);
            this.empruntsMembreListBox.TabIndex = 2;
            this.empruntsMembreListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.empruntsMembreListBox_MouseDoubleClick);
            // 
            // ajouterEmpruntMembreBouton
            // 
            this.ajouterEmpruntMembreBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouterEmpruntMembreBouton.Location = new System.Drawing.Point(19, 103);
            this.ajouterEmpruntMembreBouton.Name = "ajouterEmpruntMembreBouton";
            this.ajouterEmpruntMembreBouton.Size = new System.Drawing.Size(20, 20);
            this.ajouterEmpruntMembreBouton.TabIndex = 4;
            this.ajouterEmpruntMembreBouton.Text = "+";
            this.ajouterEmpruntMembreBouton.UseVisualStyleBackColor = true;
            this.ajouterEmpruntMembreBouton.Click += new System.EventHandler(this.ajouterEmpruntMembreBouton_Click);
            // 
            // supprEmpruntMembreBouton
            // 
            this.supprEmpruntMembreBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprEmpruntMembreBouton.Location = new System.Drawing.Point(19, 123);
            this.supprEmpruntMembreBouton.Name = "supprEmpruntMembreBouton";
            this.supprEmpruntMembreBouton.Size = new System.Drawing.Size(20, 20);
            this.supprEmpruntMembreBouton.TabIndex = 5;
            this.supprEmpruntMembreBouton.Text = "-";
            this.supprEmpruntMembreBouton.UseVisualStyleBackColor = true;
            this.supprEmpruntMembreBouton.Click += new System.EventHandler(this.supprEmpruntMembreBouton_Click);
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
            // publicationsParAuteurTableAdapter1
            // 
            this.publicationsParAuteurTableAdapter1.ClearBeforeFill = true;
            // 
            // titreOuvrageParSuperTableAdapter1
            // 
            this.titreOuvrageParSuperTableAdapter1.ClearBeforeFill = true;
            // 
            // empruntsParMembreTableAdapter1
            // 
            this.empruntsParMembreTableAdapter1.ClearBeforeFill = true;
            // 
            // reservParMembreTableAdapter1
            // 
            this.reservParMembreTableAdapter1.ClearBeforeFill = true;
            // 
            // reserverTableAdapter1
            // 
            this.reserverTableAdapter1.ClearBeforeFill = true;
            // 
            // ecrireTableAdapter1
            // 
            this.ecrireTableAdapter1.ClearBeforeFill = true;
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
            this.infosOuvrageTableLayout.ResumeLayout(false);
            this.infosOuvrageTableLayout.PerformLayout();
            this.auteursSplitContainer.Panel1.ResumeLayout(false);
            this.auteursSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.auteursSplitContainer)).EndInit();
            this.auteursSplitContainer.ResumeLayout(false);
            this.superSplitContainer.Panel1.ResumeLayout(false);
            this.superSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superSplitContainer)).EndInit();
            this.superSplitContainer.ResumeLayout(false);
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
            this.auteurInfoPage.ResumeLayout(false);
            this.auteurInfoPageTableLayout.ResumeLayout(false);
            this.infAuteurGroupBox.ResumeLayout(false);
            this.infosAuteurTableLayout.ResumeLayout(false);
            this.infosAuteurTableLayout.PerformLayout();
            this.travailAuteurGroupBox.ResumeLayout(false);
            this.auteurPubliTableLayout.ResumeLayout(false);
            this.auteurPubliTableLayout.PerformLayout();
            this.auteurSuperviseSplitContainer.Panel1.ResumeLayout(false);
            this.auteurSuperviseSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.auteurSuperviseSplitContainer)).EndInit();
            this.auteurSuperviseSplitContainer.ResumeLayout(false);
            this.auteurEcritSplitContainer.Panel1.ResumeLayout(false);
            this.auteurEcritSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.auteurEcritSplitContainer)).EndInit();
            this.auteurEcritSplitContainer.ResumeLayout(false);
            this.membreInfoPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.infosMembreTableLayout.ResumeLayout(false);
            this.infosMembrePersonalTableLayout.ResumeLayout(false);
            this.infosMembrePersonalTableLayout.PerformLayout();
            this.infosMembreAdresseTableLayout.ResumeLayout(false);
            this.infosMembreAdresseTableLayout.PerformLayout();
            this.empruntsReservMembreBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.reservMembreSplitContainer.Panel1.ResumeLayout(false);
            this.reservMembreSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservMembreSplitContainer)).EndInit();
            this.reservMembreSplitContainer.ResumeLayout(false);
            this.empruntMembreSplitContainer.Panel1.ResumeLayout(false);
            this.empruntMembreSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empruntMembreSplitContainer)).EndInit();
            this.empruntMembreSplitContainer.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutOuvrageInfo;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.GroupBox empruntBox;
        private System.Windows.Forms.GroupBox reservationBox;
        private System.Windows.Forms.TableLayoutPanel infosOuvrageTableLayout;
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
        private System.Windows.Forms.TextBox dateReservTextBox;
        private System.Windows.Forms.TextBox dureeReservTextBox;
        private System.Windows.Forms.Label superLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private BiblioEPFCDataSetTableAdapters.InfoOuvrageTableAdapter infoOuvrageTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderLesModificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignorerLesModificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterAuteurMenu;
        private System.Windows.Forms.ToolStripMenuItem supprAuteurMenu;
        private System.Windows.Forms.SplitContainer auteursSplitContainer;
        private System.Windows.Forms.Button ajouterAuteurBouton;
        private System.Windows.Forms.Button supprAuteurBouton;
        private System.Windows.Forms.ListBox reservListBox;
        private System.Windows.Forms.ListBox superListBox;
        private System.Windows.Forms.TableLayoutPanel auteurInfoPageTableLayout;
        private System.Windows.Forms.GroupBox infAuteurGroupBox;
        private System.Windows.Forms.GroupBox travailAuteurGroupBox;
        private System.Windows.Forms.TableLayoutPanel infosAuteurTableLayout;
        private System.Windows.Forms.Label nomAuteurLabel;
        private System.Windows.Forms.Label prenomAuteurLabel;
        private System.Windows.Forms.Label statutAuteurLabel;
        private System.Windows.Forms.TextBox nomAuteurTextBox;
        private System.Windows.Forms.TextBox prenomAuteurTextBox;
        private System.Windows.Forms.TextBox statutAuteurTextBox;
        private System.Windows.Forms.SplitContainer superSplitContainer;
        private System.Windows.Forms.Button ajouterSuperBouton;
        private System.Windows.Forms.Button supprSuperBouton;
        private System.Windows.Forms.TableLayoutPanel auteurPubliTableLayout;
        private System.Windows.Forms.Label publiAuteurLabel;
        private System.Windows.Forms.Label superviseLabel;
        private System.Windows.Forms.ListBox publiAuteurListBox;
        private System.Windows.Forms.SplitContainer auteurSuperviseSplitContainer;
        private System.Windows.Forms.ListBox auteurSuperviseListBox;
        private System.Windows.Forms.Button ajouterSupervisionAuteurBouton;
        private System.Windows.Forms.Button supprSupervisionAuteurBouton;
        private System.Windows.Forms.SplitContainer auteurEcritSplitContainer;
        private System.Windows.Forms.Button ajouterPubliAuteurBouton;
        private System.Windows.Forms.Button supprPubliAuteurBouton;
        private BiblioEPFCDataSetTableAdapters.PublicationsParAuteurTableAdapter publicationsParAuteurTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.TitreOuvrageParSuperTableAdapter titreOuvrageParSuperTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel infosMembreTableLayout;
        private System.Windows.Forms.TableLayoutPanel infosMembrePersonalTableLayout;
        private System.Windows.Forms.Label nomMembreLabel;
        private System.Windows.Forms.Label prenomMembreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomMembreTextBox;
        private System.Windows.Forms.TextBox prenomMembreTextBox;
        private System.Windows.Forms.TextBox numTelMembreTextBox;
        private System.Windows.Forms.TableLayoutPanel infosMembreAdresseTableLayout;
        private System.Windows.Forms.Label villeMembreLabel;
        private System.Windows.Forms.TextBox rueMembreTextBox;
        private System.Windows.Forms.Label adresseMembreLabel;
        private System.Windows.Forms.TextBox numRueMembreTextBox;
        private System.Windows.Forms.TextBox villeMembreTextBox;
        private System.Windows.Forms.TextBox codePostalMembreTextBox;
        private System.Windows.Forms.Label numRueMembreLabel;
        private System.Windows.Forms.Label codePostalMembreLabel;
        private System.Windows.Forms.GroupBox empruntsReservMembreBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.SplitContainer reservMembreSplitContainer;
        private System.Windows.Forms.ListBox resMembreListBox;
        private System.Windows.Forms.Button ajouterReservMembreBouton;
        private System.Windows.Forms.Button supprReservMembreBouton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer empruntMembreSplitContainer;
        private System.Windows.Forms.ListBox empruntsMembreListBox;
        private System.Windows.Forms.Button ajouterEmpruntMembreBouton;
        private System.Windows.Forms.Button supprEmpruntMembreBouton;
        private BiblioEPFCDataSetTableAdapters.EmpruntsParMembreTableAdapter empruntsParMembreTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.ReservParMembreTableAdapter reservParMembreTableAdapter1;
        private System.Windows.Forms.ListBox membreEmpruntListBox;
        private BiblioEPFCDataSetTableAdapters.reserverTableAdapter reserverTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.ecrireTableAdapter ecrireTableAdapter1;

    }
}

