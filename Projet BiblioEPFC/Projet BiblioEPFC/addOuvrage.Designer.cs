namespace ApplicationBiblioEPFC
{
    partial class addOuvrageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addOuvrageForm));
            this.infosTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.localTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.entrepriseTextBox = new System.Windows.Forms.TextBox();
            this.titreLabel = new System.Windows.Forms.Label();
            this.dateCreaLabel = new System.Windows.Forms.Label();
            this.localLabel = new System.Windows.Forms.Label();
            this.entrepriseLabel = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.titreTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addTypeBouton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.dateCreaPicker = new System.Windows.Forms.DateTimePicker();
            this.formSplitContainer = new System.Windows.Forms.SplitContainer();
            this.auteursTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.swapButtonsPanel = new System.Windows.Forms.Panel();
            this.removeSuperBouton = new System.Windows.Forms.Button();
            this.swapSuperBouton = new System.Windows.Forms.Button();
            this.removeAuteurBouton = new System.Windows.Forms.Button();
            this.swapAuteurBouton = new System.Windows.Forms.Button();
            this.auteursDispoListBox = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.auteursLabel = new System.Windows.Forms.Label();
            this.addAuteurBouton = new System.Windows.Forms.Button();
            this.auteursListBox = new System.Windows.Forms.ListBox();
            this.superLabel = new System.Windows.Forms.Label();
            this.moveDownBouton = new System.Windows.Forms.Button();
            this.moveUpBouton = new System.Windows.Forms.Button();
            this.addSuperBouton = new System.Windows.Forms.Button();
            this.superListBox = new System.Windows.Forms.ListBox();
            this.ajouterOuvrageBouton = new System.Windows.Forms.Button();
            this.cancelBouton = new System.Windows.Forms.Button();
            this.auteurSuperviseurTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter();
            this.typeTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.TypeTableAdapter();
            this.ouvrageTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter();
            this.ecrireTableAdapter1 = new ApplicationBiblioEPFC.BiblioEPFCDataSetTableAdapters.ecrireTableAdapter();
            this.infosTableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).BeginInit();
            this.formSplitContainer.Panel1.SuspendLayout();
            this.formSplitContainer.Panel2.SuspendLayout();
            this.formSplitContainer.SuspendLayout();
            this.auteursTableLayout.SuspendLayout();
            this.swapButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infosTableLayout
            // 
            this.infosTableLayout.ColumnCount = 4;
            this.infosTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.75758F));
            this.infosTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.09091F));
            this.infosTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0304F));
            this.infosTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.infosTableLayout.Controls.Add(this.localTextBox, 1, 2);
            this.infosTableLayout.Controls.Add(this.sectionTextBox, 3, 1);
            this.infosTableLayout.Controls.Add(this.entrepriseTextBox, 3, 0);
            this.infosTableLayout.Controls.Add(this.titreLabel, 0, 0);
            this.infosTableLayout.Controls.Add(this.dateCreaLabel, 0, 1);
            this.infosTableLayout.Controls.Add(this.localLabel, 0, 2);
            this.infosTableLayout.Controls.Add(this.entrepriseLabel, 2, 0);
            this.infosTableLayout.Controls.Add(this.sectionLabel, 2, 1);
            this.infosTableLayout.Controls.Add(this.typeLabel, 2, 2);
            this.infosTableLayout.Controls.Add(this.titreTextBox, 1, 0);
            this.infosTableLayout.Controls.Add(this.panel1, 3, 2);
            this.infosTableLayout.Controls.Add(this.dateCreaPicker, 1, 1);
            this.infosTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infosTableLayout.Location = new System.Drawing.Point(0, 0);
            this.infosTableLayout.Name = "infosTableLayout";
            this.infosTableLayout.RowCount = 3;
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.infosTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.infosTableLayout.Size = new System.Drawing.Size(660, 140);
            this.infosTableLayout.TabIndex = 0;
            // 
            // localTextBox
            // 
            this.localTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.localTextBox.Location = new System.Drawing.Point(74, 106);
            this.localTextBox.Name = "localTextBox";
            this.localTextBox.Size = new System.Drawing.Size(252, 20);
            this.localTextBox.TabIndex = 10;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionTextBox.Location = new System.Drawing.Point(398, 59);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(259, 20);
            this.sectionTextBox.TabIndex = 9;
            // 
            // entrepriseTextBox
            // 
            this.entrepriseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.entrepriseTextBox.Location = new System.Drawing.Point(398, 13);
            this.entrepriseTextBox.Name = "entrepriseTextBox";
            this.entrepriseTextBox.Size = new System.Drawing.Size(259, 20);
            this.entrepriseTextBox.TabIndex = 7;
            // 
            // titreLabel
            // 
            this.titreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.titreLabel.AutoSize = true;
            this.titreLabel.Location = new System.Drawing.Point(40, 16);
            this.titreLabel.Name = "titreLabel";
            this.titreLabel.Size = new System.Drawing.Size(28, 13);
            this.titreLabel.TabIndex = 0;
            this.titreLabel.Text = "Titre";
            // 
            // dateCreaLabel
            // 
            this.dateCreaLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateCreaLabel.AutoSize = true;
            this.dateCreaLabel.Location = new System.Drawing.Point(20, 56);
            this.dateCreaLabel.Name = "dateCreaLabel";
            this.dateCreaLabel.Size = new System.Drawing.Size(48, 26);
            this.dateCreaLabel.TabIndex = 1;
            this.dateCreaLabel.Text = "Date de création";
            // 
            // localLabel
            // 
            this.localLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.localLabel.AutoSize = true;
            this.localLabel.Location = new System.Drawing.Point(5, 109);
            this.localLabel.Name = "localLabel";
            this.localLabel.Size = new System.Drawing.Size(63, 13);
            this.localLabel.TabIndex = 2;
            this.localLabel.Text = "Localisation";
            // 
            // entrepriseLabel
            // 
            this.entrepriseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.entrepriseLabel.AutoSize = true;
            this.entrepriseLabel.Location = new System.Drawing.Point(338, 16);
            this.entrepriseLabel.Name = "entrepriseLabel";
            this.entrepriseLabel.Size = new System.Drawing.Size(54, 13);
            this.entrepriseLabel.TabIndex = 3;
            this.entrepriseLabel.Text = "Entreprise";
            // 
            // sectionLabel
            // 
            this.sectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(349, 62);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(43, 13);
            this.sectionLabel.TabIndex = 4;
            this.sectionLabel.Text = "Section";
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(361, 109);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type";
            // 
            // titreTextBox
            // 
            this.titreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titreTextBox.Location = new System.Drawing.Point(74, 13);
            this.titreTextBox.Name = "titreTextBox";
            this.titreTextBox.Size = new System.Drawing.Size(252, 20);
            this.titreTextBox.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addTypeBouton);
            this.panel1.Controls.Add(this.typeComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(398, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 42);
            this.panel1.TabIndex = 11;
            // 
            // addTypeBouton
            // 
            this.addTypeBouton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addTypeBouton.Location = new System.Drawing.Point(227, 10);
            this.addTypeBouton.Name = "addTypeBouton";
            this.addTypeBouton.Size = new System.Drawing.Size(20, 20);
            this.addTypeBouton.TabIndex = 2;
            this.addTypeBouton.Text = "+";
            this.addTypeBouton.UseVisualStyleBackColor = true;
            this.addTypeBouton.Click += new System.EventHandler(this.addTypeBouton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.typeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.typeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(0, 10);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(221, 21);
            this.typeComboBox.TabIndex = 0;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // dateCreaPicker
            // 
            this.dateCreaPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateCreaPicker.Location = new System.Drawing.Point(74, 59);
            this.dateCreaPicker.Name = "dateCreaPicker";
            this.dateCreaPicker.Size = new System.Drawing.Size(252, 20);
            this.dateCreaPicker.TabIndex = 12;
            // 
            // formSplitContainer
            // 
            this.formSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formSplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.formSplitContainer.IsSplitterFixed = true;
            this.formSplitContainer.Location = new System.Drawing.Point(12, 12);
            this.formSplitContainer.Name = "formSplitContainer";
            this.formSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // formSplitContainer.Panel1
            // 
            this.formSplitContainer.Panel1.Controls.Add(this.infosTableLayout);
            // 
            // formSplitContainer.Panel2
            // 
            this.formSplitContainer.Panel2.Controls.Add(this.auteursTableLayout);
            this.formSplitContainer.Size = new System.Drawing.Size(660, 433);
            this.formSplitContainer.SplitterDistance = 140;
            this.formSplitContainer.TabIndex = 1;
            // 
            // auteursTableLayout
            // 
            this.auteursTableLayout.ColumnCount = 3;
            this.auteursTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.auteursTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.auteursTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.auteursTableLayout.Controls.Add(this.swapButtonsPanel, 1, 0);
            this.auteursTableLayout.Controls.Add(this.auteursDispoListBox, 0, 0);
            this.auteursTableLayout.Controls.Add(this.splitContainer1, 2, 0);
            this.auteursTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteursTableLayout.Location = new System.Drawing.Point(0, 0);
            this.auteursTableLayout.Name = "auteursTableLayout";
            this.auteursTableLayout.RowCount = 1;
            this.auteursTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.auteursTableLayout.Size = new System.Drawing.Size(660, 289);
            this.auteursTableLayout.TabIndex = 0;
            // 
            // swapButtonsPanel
            // 
            this.swapButtonsPanel.Controls.Add(this.removeSuperBouton);
            this.swapButtonsPanel.Controls.Add(this.swapSuperBouton);
            this.swapButtonsPanel.Controls.Add(this.removeAuteurBouton);
            this.swapButtonsPanel.Controls.Add(this.swapAuteurBouton);
            this.swapButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swapButtonsPanel.Location = new System.Drawing.Point(300, 3);
            this.swapButtonsPanel.Name = "swapButtonsPanel";
            this.swapButtonsPanel.Size = new System.Drawing.Size(60, 283);
            this.swapButtonsPanel.TabIndex = 0;
            // 
            // removeSuperBouton
            // 
            this.removeSuperBouton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeSuperBouton.Location = new System.Drawing.Point(11, 220);
            this.removeSuperBouton.Name = "removeSuperBouton";
            this.removeSuperBouton.Size = new System.Drawing.Size(37, 23);
            this.removeSuperBouton.TabIndex = 3;
            this.removeSuperBouton.Text = "<-";
            this.removeSuperBouton.UseVisualStyleBackColor = true;
            this.removeSuperBouton.Click += new System.EventHandler(this.removeSuperBouton_Click);
            // 
            // swapSuperBouton
            // 
            this.swapSuperBouton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.swapSuperBouton.Location = new System.Drawing.Point(11, 191);
            this.swapSuperBouton.Name = "swapSuperBouton";
            this.swapSuperBouton.Size = new System.Drawing.Size(37, 23);
            this.swapSuperBouton.TabIndex = 2;
            this.swapSuperBouton.Text = "->";
            this.swapSuperBouton.UseVisualStyleBackColor = true;
            this.swapSuperBouton.Click += new System.EventHandler(this.swapSuperBouton_Click);
            // 
            // removeAuteurBouton
            // 
            this.removeAuteurBouton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeAuteurBouton.Location = new System.Drawing.Point(11, 69);
            this.removeAuteurBouton.Name = "removeAuteurBouton";
            this.removeAuteurBouton.Size = new System.Drawing.Size(37, 23);
            this.removeAuteurBouton.TabIndex = 1;
            this.removeAuteurBouton.Text = "<-";
            this.removeAuteurBouton.UseVisualStyleBackColor = true;
            this.removeAuteurBouton.Click += new System.EventHandler(this.removeAuteurBouton_Click);
            // 
            // swapAuteurBouton
            // 
            this.swapAuteurBouton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.swapAuteurBouton.Location = new System.Drawing.Point(11, 40);
            this.swapAuteurBouton.Name = "swapAuteurBouton";
            this.swapAuteurBouton.Size = new System.Drawing.Size(37, 23);
            this.swapAuteurBouton.TabIndex = 0;
            this.swapAuteurBouton.Text = "->";
            this.swapAuteurBouton.UseVisualStyleBackColor = true;
            this.swapAuteurBouton.Click += new System.EventHandler(this.swapAuteurBouton_Click);
            // 
            // auteursDispoListBox
            // 
            this.auteursDispoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auteursDispoListBox.FormattingEnabled = true;
            this.auteursDispoListBox.Location = new System.Drawing.Point(3, 3);
            this.auteursDispoListBox.Name = "auteursDispoListBox";
            this.auteursDispoListBox.Size = new System.Drawing.Size(291, 283);
            this.auteursDispoListBox.Sorted = true;
            this.auteursDispoListBox.TabIndex = 1;
            this.auteursDispoListBox.SelectedIndexChanged += new System.EventHandler(this.GenericListBox_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(366, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.auteursLabel);
            this.splitContainer1.Panel1.Controls.Add(this.addAuteurBouton);
            this.splitContainer1.Panel1.Controls.Add(this.auteursListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.superLabel);
            this.splitContainer1.Panel2.Controls.Add(this.moveDownBouton);
            this.splitContainer1.Panel2.Controls.Add(this.moveUpBouton);
            this.splitContainer1.Panel2.Controls.Add(this.addSuperBouton);
            this.splitContainer1.Panel2.Controls.Add(this.superListBox);
            this.splitContainer1.Size = new System.Drawing.Size(291, 283);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 2;
            // 
            // auteursLabel
            // 
            this.auteursLabel.AutoSize = true;
            this.auteursLabel.Location = new System.Drawing.Point(3, 0);
            this.auteursLabel.Name = "auteursLabel";
            this.auteursLabel.Size = new System.Drawing.Size(49, 13);
            this.auteursLabel.TabIndex = 2;
            this.auteursLabel.Text = "Auteur(s)";
            // 
            // addAuteurBouton
            // 
            this.addAuteurBouton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addAuteurBouton.Location = new System.Drawing.Point(259, 60);
            this.addAuteurBouton.Name = "addAuteurBouton";
            this.addAuteurBouton.Size = new System.Drawing.Size(20, 20);
            this.addAuteurBouton.TabIndex = 1;
            this.addAuteurBouton.Text = "+";
            this.addAuteurBouton.UseVisualStyleBackColor = true;
            this.addAuteurBouton.Click += new System.EventHandler(this.addAuteurBouton_Click);
            // 
            // auteursListBox
            // 
            this.auteursListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auteursListBox.FormattingEnabled = true;
            this.auteursListBox.Location = new System.Drawing.Point(3, 14);
            this.auteursListBox.Name = "auteursListBox";
            this.auteursListBox.Size = new System.Drawing.Size(250, 121);
            this.auteursListBox.Sorted = true;
            this.auteursListBox.TabIndex = 0;
            this.auteursListBox.SelectedIndexChanged += new System.EventHandler(this.GenericListBox_SelectedIndexChanged);
            // 
            // superLabel
            // 
            this.superLabel.AutoSize = true;
            this.superLabel.Location = new System.Drawing.Point(3, 47);
            this.superLabel.Name = "superLabel";
            this.superLabel.Size = new System.Drawing.Size(63, 13);
            this.superLabel.TabIndex = 5;
            this.superLabel.Text = "Superviseur";
            // 
            // moveDownBouton
            // 
            this.moveDownBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moveDownBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveDownBouton.Location = new System.Drawing.Point(148, 12);
            this.moveDownBouton.Name = "moveDownBouton";
            this.moveDownBouton.Size = new System.Drawing.Size(27, 36);
            this.moveDownBouton.TabIndex = 4;
            this.moveDownBouton.Text = "˅";
            this.moveDownBouton.UseVisualStyleBackColor = true;
            this.moveDownBouton.Click += new System.EventHandler(this.moveDownBouton_Click);
            // 
            // moveUpBouton
            // 
            this.moveUpBouton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moveUpBouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveUpBouton.Location = new System.Drawing.Point(115, 12);
            this.moveUpBouton.Name = "moveUpBouton";
            this.moveUpBouton.Size = new System.Drawing.Size(27, 36);
            this.moveUpBouton.TabIndex = 3;
            this.moveUpBouton.Text = "˄";
            this.moveUpBouton.UseVisualStyleBackColor = true;
            this.moveUpBouton.Click += new System.EventHandler(this.moveUpBouton_Click);
            // 
            // addSuperBouton
            // 
            this.addSuperBouton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addSuperBouton.Location = new System.Drawing.Point(259, 63);
            this.addSuperBouton.Name = "addSuperBouton";
            this.addSuperBouton.Size = new System.Drawing.Size(20, 20);
            this.addSuperBouton.TabIndex = 2;
            this.addSuperBouton.Text = "+";
            this.addSuperBouton.UseVisualStyleBackColor = true;
            this.addSuperBouton.Click += new System.EventHandler(this.addSuperBouton_Click);
            // 
            // superListBox
            // 
            this.superListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.superListBox.FormattingEnabled = true;
            this.superListBox.Location = new System.Drawing.Point(3, 63);
            this.superListBox.Name = "superListBox";
            this.superListBox.Size = new System.Drawing.Size(250, 17);
            this.superListBox.TabIndex = 0;
            this.superListBox.SelectedIndexChanged += new System.EventHandler(this.GenericListBox_SelectedIndexChanged);
            // 
            // ajouterOuvrageBouton
            // 
            this.ajouterOuvrageBouton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ajouterOuvrageBouton.Location = new System.Drawing.Point(260, 451);
            this.ajouterOuvrageBouton.Name = "ajouterOuvrageBouton";
            this.ajouterOuvrageBouton.Size = new System.Drawing.Size(79, 29);
            this.ajouterOuvrageBouton.TabIndex = 2;
            this.ajouterOuvrageBouton.Text = "Ajouter";
            this.ajouterOuvrageBouton.UseVisualStyleBackColor = true;
            this.ajouterOuvrageBouton.Click += new System.EventHandler(this.ajouterOuvrageBouton_Click);
            // 
            // cancelBouton
            // 
            this.cancelBouton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelBouton.Location = new System.Drawing.Point(345, 451);
            this.cancelBouton.Name = "cancelBouton";
            this.cancelBouton.Size = new System.Drawing.Size(79, 29);
            this.cancelBouton.TabIndex = 3;
            this.cancelBouton.Text = "Annuler";
            this.cancelBouton.UseVisualStyleBackColor = true;
            this.cancelBouton.Click += new System.EventHandler(this.cancelBouton_Click);
            // 
            // auteurSuperviseurTableAdapter1
            // 
            this.auteurSuperviseurTableAdapter1.ClearBeforeFill = true;
            // 
            // typeTableAdapter1
            // 
            this.typeTableAdapter1.ClearBeforeFill = true;
            // 
            // ouvrageTableAdapter1
            // 
            this.ouvrageTableAdapter1.ClearBeforeFill = true;
            // 
            // ecrireTableAdapter1
            // 
            this.ecrireTableAdapter1.ClearBeforeFill = true;
            // 
            // addOuvrageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 491);
            this.Controls.Add(this.cancelBouton);
            this.Controls.Add(this.ajouterOuvrageBouton);
            this.Controls.Add(this.formSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 530);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 530);
            this.Name = "addOuvrageForm";
            this.Text = "Ajouter ouvrage";
            this.Load += new System.EventHandler(this.addOuvrageForm_Load);
            this.infosTableLayout.ResumeLayout(false);
            this.infosTableLayout.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.formSplitContainer.Panel1.ResumeLayout(false);
            this.formSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formSplitContainer)).EndInit();
            this.formSplitContainer.ResumeLayout(false);
            this.auteursTableLayout.ResumeLayout(false);
            this.swapButtonsPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel infosTableLayout;
        private System.Windows.Forms.Label titreLabel;
        private System.Windows.Forms.Label dateCreaLabel;
        private System.Windows.Forms.Label localLabel;
        private System.Windows.Forms.Label entrepriseLabel;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.SplitContainer formSplitContainer;
        private System.Windows.Forms.TableLayoutPanel auteursTableLayout;
        private System.Windows.Forms.Panel swapButtonsPanel;
        private System.Windows.Forms.Button removeAuteurBouton;
        private System.Windows.Forms.Button swapAuteurBouton;
        private System.Windows.Forms.Button removeSuperBouton;
        private System.Windows.Forms.Button swapSuperBouton;
        private System.Windows.Forms.ListBox auteursDispoListBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button addAuteurBouton;
        private System.Windows.Forms.ListBox auteursListBox;
        private System.Windows.Forms.ListBox superListBox;
        private System.Windows.Forms.Button ajouterOuvrageBouton;
        private System.Windows.Forms.Button cancelBouton;
        private System.Windows.Forms.Button addSuperBouton;
        private System.Windows.Forms.TextBox localTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.TextBox entrepriseTextBox;
        private System.Windows.Forms.TextBox titreTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addTypeBouton;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.DateTimePicker dateCreaPicker;
        private BiblioEPFCDataSetTableAdapters.AuteurSuperviseurTableAdapter auteurSuperviseurTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.TypeTableAdapter typeTableAdapter1;
        private System.Windows.Forms.Button moveDownBouton;
        private System.Windows.Forms.Button moveUpBouton;
        private System.Windows.Forms.Label auteursLabel;
        private System.Windows.Forms.Label superLabel;
        private BiblioEPFCDataSetTableAdapters.OuvrageTableAdapter ouvrageTableAdapter1;
        private BiblioEPFCDataSetTableAdapters.ecrireTableAdapter ecrireTableAdapter1;


    }
}