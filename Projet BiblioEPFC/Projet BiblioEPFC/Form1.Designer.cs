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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ouvragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.labelRechercher = new System.Windows.Forms.Label();
            this.textBoxRechercher = new System.Windows.Forms.TextBox();
            this.generalTreeView = new System.Windows.Forms.TreeView();
            this.ouvrageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioEPFCDataSet = new WindowsFormsApplication1.BiblioEPFCDataSet();
            this.infoTabs = new System.Windows.Forms.TabControl();
            this.ouvrageInfoPage = new System.Windows.Forms.TabPage();
            this.auteurInfoPage = new System.Windows.Forms.TabPage();
            this.ouvrageTableAdapter = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter();
            this.membreTableAdapter1 = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.MembreTableAdapter();
            this.auteurParOuvrageTableAdapter1 = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.AuteurParOuvrageTableAdapter();
            this.superParOuvrageTableAdapter1 = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.SuperParOuvrageTableAdapter();
            this.empruntMembreParOuvrageTableAdapter1 = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.EmpruntMembreParOuvrageTableAdapter();
            this.reservationParOuvrageTableAdapter1 = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.ReservationParOuvrageTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.auteurSuperviseurTableAdapter1 = new WindowsFormsApplication1.BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter();
            this.membreInfoPage = new System.Windows.Forms.TabPage();
            this.empruntInfoPage = new System.Windows.Forms.TabPage();
            this.reservationInfoPage = new System.Windows.Forms.TabPage();
            this.tableLayoutOuvrageInfo = new System.Windows.Forms.TableLayoutPanel();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.empruntBox = new System.Windows.Forms.GroupBox();
            this.reservationBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvragesToolStripMenuItem,
            this.membresToolStripMenuItem,
            this.empruntsToolStripMenuItem,
            this.réservationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ouvragesToolStripMenuItem
            // 
            this.ouvragesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.ouvragesToolStripMenuItem.Name = "ouvragesToolStripMenuItem";
            this.ouvragesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ouvragesToolStripMenuItem.Text = "Ouvrages";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // membresToolStripMenuItem
            // 
            this.membresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.supprimerToolStripMenuItem2});
            this.membresToolStripMenuItem.Name = "membresToolStripMenuItem";
            this.membresToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.membresToolStripMenuItem.Text = "Membres";
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem2.Text = "Ajouter";
            // 
            // supprimerToolStripMenuItem2
            // 
            this.supprimerToolStripMenuItem2.Name = "supprimerToolStripMenuItem2";
            this.supprimerToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem2.Text = "Supprimer";
            // 
            // empruntsToolStripMenuItem
            // 
            this.empruntsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.supprimerToolStripMenuItem1});
            this.empruntsToolStripMenuItem.Name = "empruntsToolStripMenuItem";
            this.empruntsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.empruntsToolStripMenuItem.Text = "Emprunts";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            // 
            // réservationsToolStripMenuItem
            // 
            this.réservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem3,
            this.supprimerToolStripMenuItem3});
            this.réservationsToolStripMenuItem.Name = "réservationsToolStripMenuItem";
            this.réservationsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.réservationsToolStripMenuItem.Text = "Réservations";
            // 
            // ajouterToolStripMenuItem3
            // 
            this.ajouterToolStripMenuItem3.Name = "ajouterToolStripMenuItem3";
            this.ajouterToolStripMenuItem3.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem3.Text = "Ajouter";
            this.ajouterToolStripMenuItem3.Click += new System.EventHandler(this.ajouterToolStripMenuItem3_Click);
            // 
            // supprimerToolStripMenuItem3
            // 
            this.supprimerToolStripMenuItem3.Name = "supprimerToolStripMenuItem3";
            this.supprimerToolStripMenuItem3.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem3.Text = "Supprimer";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.infoTabs);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(974, 524);
            this.splitContainer1.SplitterDistance = 229;
            this.splitContainer1.TabIndex = 0;
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
            this.splitContainer2.Size = new System.Drawing.Size(223, 518);
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
            this.generalTreeView.Size = new System.Drawing.Size(217, 485);
            this.generalTreeView.TabIndex = 0;
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
            this.infoTabs.Size = new System.Drawing.Size(734, 518);
            this.infoTabs.TabIndex = 0;
            // 
            // ouvrageInfoPage
            // 
            this.ouvrageInfoPage.Controls.Add(this.tableLayoutOuvrageInfo);
            this.ouvrageInfoPage.Location = new System.Drawing.Point(4, 22);
            this.ouvrageInfoPage.Name = "ouvrageInfoPage";
            this.ouvrageInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.ouvrageInfoPage.Size = new System.Drawing.Size(726, 492);
            this.ouvrageInfoPage.TabIndex = 0;
            this.ouvrageInfoPage.Text = "Ouvrage";
            this.ouvrageInfoPage.UseVisualStyleBackColor = true;
            this.ouvrageInfoPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // auteurInfoPage
            // 
            this.auteurInfoPage.Location = new System.Drawing.Point(4, 22);
            this.auteurInfoPage.Name = "auteurInfoPage";
            this.auteurInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.auteurInfoPage.Size = new System.Drawing.Size(727, 492);
            this.auteurInfoPage.TabIndex = 1;
            this.auteurInfoPage.Text = "Auteur";
            this.auteurInfoPage.UseVisualStyleBackColor = true;
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(974, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // auteurSuperviseurTableAdapter1
            // 
            this.auteurSuperviseurTableAdapter1.ClearBeforeFill = true;
            // 
            // membreInfoPage
            // 
            this.membreInfoPage.Location = new System.Drawing.Point(4, 22);
            this.membreInfoPage.Name = "membreInfoPage";
            this.membreInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.membreInfoPage.Size = new System.Drawing.Size(727, 492);
            this.membreInfoPage.TabIndex = 2;
            this.membreInfoPage.Text = "Membre";
            this.membreInfoPage.UseVisualStyleBackColor = true;
            // 
            // empruntInfoPage
            // 
            this.empruntInfoPage.Location = new System.Drawing.Point(4, 22);
            this.empruntInfoPage.Name = "empruntInfoPage";
            this.empruntInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.empruntInfoPage.Size = new System.Drawing.Size(727, 492);
            this.empruntInfoPage.TabIndex = 3;
            this.empruntInfoPage.Text = "Emprunt";
            this.empruntInfoPage.UseVisualStyleBackColor = true;
            // 
            // reservationInfoPage
            // 
            this.reservationInfoPage.Location = new System.Drawing.Point(4, 22);
            this.reservationInfoPage.Name = "reservationInfoPage";
            this.reservationInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.reservationInfoPage.Size = new System.Drawing.Size(727, 492);
            this.reservationInfoPage.TabIndex = 4;
            this.reservationInfoPage.Text = "Réservation(s)";
            this.reservationInfoPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutOuvrageInfo
            // 
            this.tableLayoutOuvrageInfo.ColumnCount = 1;
            this.tableLayoutOuvrageInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOuvrageInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutOuvrageInfo.Controls.Add(this.infoBox, 0, 0);
            this.tableLayoutOuvrageInfo.Controls.Add(this.empruntBox, 0, 1);
            this.tableLayoutOuvrageInfo.Controls.Add(this.reservationBox, 0, 2);
            this.tableLayoutOuvrageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutOuvrageInfo.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutOuvrageInfo.Name = "tableLayoutOuvrageInfo";
            this.tableLayoutOuvrageInfo.RowCount = 3;
            this.tableLayoutOuvrageInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.5F));
            this.tableLayoutOuvrageInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.tableLayoutOuvrageInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutOuvrageInfo.Size = new System.Drawing.Size(720, 486);
            this.tableLayoutOuvrageInfo.TabIndex = 0;
            // 
            // infoBox
            // 
            this.infoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBox.Location = new System.Drawing.Point(3, 3);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(714, 241);
            this.infoBox.TabIndex = 0;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Infos";
            // 
            // empruntBox
            // 
            this.empruntBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empruntBox.Location = new System.Drawing.Point(3, 250);
            this.empruntBox.Name = "empruntBox";
            this.empruntBox.Size = new System.Drawing.Size(714, 113);
            this.empruntBox.TabIndex = 1;
            this.empruntBox.TabStop = false;
            this.empruntBox.Text = "Emprunt";
            // 
            // reservationBox
            // 
            this.reservationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationBox.Location = new System.Drawing.Point(3, 369);
            this.reservationBox.Name = "reservationBox";
            this.reservationBox.Size = new System.Drawing.Size(714, 114);
            this.reservationBox.TabIndex = 2;
            this.reservationBox.TabStop = false;
            this.reservationBox.Text = "Réservation(s)";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 570);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empruntsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem membresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem2;
        private BiblioEPFCDataSetTableAdapters.SuperParOuvrageTableAdapter superParOuvrageTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.EmpruntMembreParOuvrageTableAdapter empruntMembreParOuvrageTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.ReservationParOuvrageTableAdapter reservationParOuvrageTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem réservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem3;
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

    }
}

