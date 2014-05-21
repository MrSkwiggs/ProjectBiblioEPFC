using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ApplicationBiblioEPFC
{
    public partial class mainForm : Form
    {
        private enum Edition { NORMAL, EDITING };
        private enum Emprunt { AUCUN, EMPRUNTE };
        private enum Reservation { AUCUNE, EXISTANTE };
        private Edition editState;
        private Emprunt empruntState;
        private Reservation reservState;
        private List<int> listeIDAuteur;
        private List<int> listeIDOuvrageReserv;
        private List<int> listeIDAuteurPubli;
        private List<int> listeIDAuteurSupervise;
        private List<int> listeIDMembreEmprunt;
        private List<int> listeIDMembreReserv;
        private int IDMEMBREEMPRUNT;
        private int SELECTEDOUVRAGE;
        private int SELECTEDAUTEUR;
        private int SELECTEDMEMBRE;

        #region Initialisation

        public mainForm()
        {
            InitializeComponent();
            treeViewCache = new TreeView();
            listeIDAuteur = new List<int>();
            listeIDOuvrageReserv = new List<int>();
            listeIDAuteurPubli = new List<int>();
            listeIDAuteurSupervise = new List<int>();
            listeIDMembreEmprunt = new List<int>();
            listeIDMembreReserv = new List<int>();
            SELECTEDAUTEUR = SELECTEDOUVRAGE = SELECTEDMEMBRE = -1;
            editState = Edition.NORMAL;
            lockControls(true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fill_GeneralTree();

            this.ActiveControl = textBoxRechercher;
        }

        #endregion

        #region Gestion du Treeview

        #region Remplissage du TreeView

        private void fill_GeneralTree()
        {
            generalTreeView.BeginUpdate();
            generalTreeView.Nodes.Add(nodeOuvrage());
            generalTreeView.Nodes.Add(nodeMembre());
            generalTreeView.Nodes.Add(nodeEmprunt());
            generalTreeView.Nodes.Add(nodeReservation());
            generalTreeView.Nodes.Add(nodeAuteurSuper());
            generalTreeView.Sort();
            fill_CacheTree();
            generalTreeView.EndUpdate();
        }

        #region nodeOuvrage

        private TreeNode nodeOuvrage()
        {
            TreeNode ouvrageNode = new TreeNode();
            ouvrageNode.Name = ouvrageNode.Text = "Ouvrages";
            DataTable ouvrages = this.ouvrageTableAdapter.GetData();
            foreach (DataRow ouvrage in ouvrages.Rows)
                ouvrageNode.Nodes.Add(nodeOuvrageChild(ouvrage));

            return ouvrageNode;
        }

        private TreeNode nodeOuvrageChild(DataRow ouvrage)
        {
            TreeNode ouvrageNode = new TreeNode();
            ouvrageNode.Name = "ouvrage " + ouvrage.ItemArray[0].ToString();
            ouvrageNode.Text = ouvrage.ItemArray[1].ToString();
            ouvrageNode.Nodes.Add(nodeAuteur(ouvrage));
            ouvrageNode.Nodes.Add(nodeSuper(ouvrage));
            ouvrageNode.Nodes.Add(nodeEmprunt(ouvrage));
            ouvrageNode.Nodes.Add(nodeReservation(ouvrage));

            return ouvrageNode;
        }

        private TreeNode nodeAuteur(DataRow ouvrage)
        {
            DataTable auteurs = this.auteurParOuvrageTableAdapter1.GetData((int)ouvrage.ItemArray[0]);
            TreeNode auteursNode = new TreeNode();
            auteursNode.Name = auteursNode.Text = "Auteur(s)";
            foreach (DataRow auteur in auteurs.Rows)
                auteursNode.Nodes.Add(nodeGenericPerson("auteur", auteur.ItemArray[0].ToString(), auteur.ItemArray[1].ToString(), auteur.ItemArray[2].ToString()));

            return auteursNode;
        }

        private TreeNode nodeGenericPerson(String type, String id, String nom, String prenom)
        {
            TreeNode auteurNode = new TreeNode();
            auteurNode.Name = type + ' ' + id;
            auteurNode.Text = nom + ' ' + prenom;

            return auteurNode;
        }

        private TreeNode nodeSuper(DataRow ouvrage)
        {
            DataTable superviseur = this.superParOuvrageTableAdapter1.GetData((int)ouvrage.ItemArray[0]);
            TreeNode superNode = new TreeNode();
            superNode.Name = superNode.Text = "Superviseur(s)";
            foreach(DataRow super in superviseur.Rows)
                superNode.Nodes.Add(nodeGenericPerson("auteur", super.ItemArray[2].ToString(), super.ItemArray[0].ToString(), super.ItemArray[1].ToString()));

            return superNode;
        }

        private TreeNode nodeEmprunt(DataRow ouvrage)
        {
            DataTable empruntMembres = this.empruntMembreParOuvrageTableAdapter1.GetData((int)ouvrage.ItemArray[0]);
            TreeNode nodeEmprunt = new TreeNode();
            nodeEmprunt.Name = nodeEmprunt.Text = "Emprunt";
            TreeNode nodeEmpruntChild = new TreeNode();
            if (empruntMembres.Rows.Count > 0)  //en toute logique, une seule réservation par ouvrage possible
            {
                nodeEmpruntChild.Name = empruntMembres.Rows[0].ItemArray[0].ToString();
                nodeEmpruntChild.Text = empruntMembres.Rows[0].ItemArray[1].ToString() + ' ' + empruntMembres.Rows[0].ItemArray[2].ToString();
                nodeEmprunt.Nodes.Add(nodeEmpruntChild);
            }

            return nodeEmprunt;
        }

        private TreeNode nodeReservation(DataRow ouvrage)
        {
            DataTable reservationMembres = this.reservationParOuvrageTableAdapter1.GetData((int)ouvrage.ItemArray[0]);
            TreeNode nodeReservation = new TreeNode();
            nodeReservation.Name = nodeReservation.Text = "Réservation(s)";
            foreach (DataRow reservation in reservationMembres.Rows)
                nodeReservation.Nodes.Add(nodeGenericPerson("membre", reservation.ItemArray[0].ToString(), reservation.ItemArray[1].ToString(), reservation.ItemArray[2].ToString()));

            return nodeReservation;
        }

        #endregion

        #region nodeMembre

        private TreeNode nodeMembre()
        {
            TreeNode membreNode = new TreeNode();
            membreNode.Name = membreNode.Text = "Membres";

            DataTable membres = this.membreTableAdapter1.GetData();
            foreach(DataRow membre in membres.Rows)
                membreNode.Nodes.Add(nodeGenericPerson("membre", membre.ItemArray[0].ToString(), membre.ItemArray[1].ToString(), membre.ItemArray[2].ToString()));

            return membreNode;
        }

        #endregion

        #region nodeEmprunt

        private TreeNode nodeEmprunt()
        {
            TreeNode empruntNode = new TreeNode();
            empruntNode.Name = empruntNode.Text = "Emprunt(s)";

            nodeGenericCategory(ref empruntNode, "Emprunt");

            return empruntNode;
        }

        private void nodeGenericCategory(ref TreeNode categoryNode, String categoryName)
        {
            foreach (TreeNode ouvrage in generalTreeView.Nodes[generalTreeView.Nodes.IndexOfKey("Ouvrages")].Nodes)
            {
                int categoryIndex = ouvrage.Nodes.IndexOfKey(categoryName);
                if (ouvrage.Nodes[categoryIndex].Nodes.Count > 0)
                {
                    categoryNode.Nodes.Add(nodeOuvrageCategory(ouvrage, categoryIndex));
                }
            }
        }

        private TreeNode nodeOuvrageCategory(TreeNode ouvrage, int categoryIndex)
        {
            TreeNode ouvrageNode = new TreeNode();
            ouvrageNode.Name = ouvrage.Name;
            ouvrageNode.Text = ouvrage.Text;
            foreach (TreeNode categoryChild in ouvrage.Nodes[categoryIndex].Nodes)
            {
                ouvrageNode.Nodes.Add(nodeGenericCategoryChildren(ouvrage, categoryChild));
            }

            return ouvrageNode;
        }

        private TreeNode nodeGenericCategoryChildren(TreeNode ouvrage, TreeNode membre)
        {
            TreeNode membreNode = new TreeNode();
            membreNode.Name = membre.Name;
            membreNode.Text = membre.Text;

            return membreNode;
        }

        #endregion

        #region nodeReservation

        private TreeNode nodeReservation()
        {
            TreeNode resNode = new TreeNode();
            resNode.Name = resNode.Text = "Réservation(s)";

            nodeGenericCategory(ref resNode, "Réservation(s)");

            return resNode;
        }

        #endregion

        #region nodeAuteurSuper

        private TreeNode nodeAuteurSuper()
        {
            TreeNode auteurSuperNode = new TreeNode();
            auteurSuperNode.Name = auteurSuperNode.Text = "Auteurs";

            DataTable auteurs = this.auteurSuperviseurTableAdapter1.GetData();
            foreach(DataRow auteur in auteurs.Rows)
                auteurSuperNode.Nodes.Add(nodeGenericPerson("auteur", auteur.ItemArray[0].ToString(), auteur.ItemArray[1].ToString(), auteur.ItemArray[2].ToString()));

            return auteurSuperNode;
        }
        

        #endregion

        private void fill_CacheTree()
        {
            foreach (TreeNode _node in generalTreeView.Nodes)
                treeViewCache.Nodes.Add((TreeNode)_node.Clone());
        }

        #endregion

        private void update_Treeview()
        {
            generalTreeView.Nodes.Clear();
            fill_GeneralTree();
            treeViewCache.Nodes.Clear();
            foreach (TreeNode _node in generalTreeView.Nodes)
                treeViewCache.Nodes.Add((TreeNode)_node.Clone());
        }

        private bool treeContains(string s)
        {
            foreach (TreeNode t in generalTreeView.Nodes)
                if(t.Text.Equals(s))
                    return true;
            return false;
        }

        #endregion

        #region Fill InfoPage

        private void fill_InfoPage(TreeNode infos)
        {
            String[] s;
            s = infos.Name.Split(' ');
            int id = 0;
            if (s.GetLength(0) > 1)
                id = Convert.ToInt32(s[1].ToString());
            switch (s[0])
            {
                case "ouvrage":
                    fill_OuvragePage(id);
                    break;

                case "auteur":
                    fill_AuteurPage(id);
                    break;

                case "membre":
                    fill_MembrePage(id);
                    break;
            }
        }

            #region fill OuvragePage

        private void fill_OuvragePage(int idOuvrage)
        {
            this.SELECTEDOUVRAGE = idOuvrage;
            fill_OuvrageInfoBox();
            fill_OuvrageEmpruntBox();
            fill_OuvrageAuteursSuper();
            fill_OuvrageReservBox();

            refreshStateDisplay();
        }

        private void fill_OuvrageInfoBox()
        {
            this.auteursListBox.Items.Clear();
            this.listeIDAuteur.Clear();
            DataTable ouvrages = this.infoOuvrageTableAdapter1.GetDataByID(SELECTEDOUVRAGE);
            DataRow ouvrage = ouvrages.Rows[0];
            int it = 0;
            DateTime dateCrea = new DateTime();

            this.titreTextBox.Text = ouvrage.ItemArray[it++].ToString();
            this.localTextBox.Text = ouvrage.ItemArray[it++].ToString();
            dateCrea = DateTime.Parse(ouvrage.ItemArray[it++].ToString());
            this.dateCreaTextBox.Text = dateCrea.ToShortDateString();
            this.sectionTextBox.Text = ouvrage.ItemArray[it++].ToString();
            this.typeTextBox.Text = ouvrage.ItemArray[it++].ToString() + " - " + ouvrage.ItemArray[it++].ToString();
            this.entrepTextBox.Text = ouvrage.ItemArray[it++].ToString();
        }

        private void fill_OuvrageEmpruntBox()
        {
            DataTable emprunts = this.empruntMembreParOuvrageTableAdapter1.GetData(SELECTEDOUVRAGE);
            DateTime dateRetour = new DateTime();
            int it = 1, duree = 0;
            if (emprunts.Rows.Count != 0)
            {
                membreEmpruntListBox.Items.Clear();
                empruntState = Emprunt.EMPRUNTE;
                DataRow emprunt = emprunts.Rows[0];
                this.membreEmpruntListBox.Items.Add(emprunt.ItemArray[it++].ToString() + ' ' + emprunt.ItemArray[it++].ToString());
                dateRetour = DateTime.Parse(emprunt.ItemArray[it++].ToString());
                this.dateEmpruntTextBox.Text = dateRetour.ToShortDateString();
                duree = Convert.ToInt16(emprunt.ItemArray[it++].ToString());
                this.dureeEmpruntTextBox.Text = duree + " jours";
                this.etatEmpruntTextBox.Text = etatEmprunt(dateRetour.AddDays(duree));
                this.IDMEMBREEMPRUNT = Convert.ToInt32(emprunt.ItemArray[0].ToString());
            }
            else
            {
                empruntState = Emprunt.AUCUN;
                this.membreEmpruntListBox.Items.Clear();
                this.dateEmpruntTextBox.Clear();
                this.dureeEmpruntTextBox.Clear();
                this.etatEmpruntTextBox.Text = etatEmprunt(null);
            }
        }

        private void fill_OuvrageAuteursSuper()
        {
            this.listeIDAuteur.Clear();
            this.superListBox.Items.Clear();

            DataTable auteurs = this.auteurParOuvrageTableAdapter1.GetData(SELECTEDOUVRAGE);
            foreach (DataRow auteur in auteurs.Rows)
            {
                this.auteursListBox.Items.Add(auteur.ItemArray[1].ToString() + ' ' + auteur.ItemArray[2].ToString());
                listeIDAuteur.Add(Convert.ToInt32(auteur.ItemArray[0].ToString()));
            }

            DataTable supers = this.superParOuvrageTableAdapter1.GetData(SELECTEDOUVRAGE);
            if (supers.Rows.Count != 0)
            {
                DataRow super = supers.Rows[0];
                this.superListBox.Items.Add(super.ItemArray[0].ToString() + ' ' + super.ItemArray[1].ToString());
                listeIDAuteur.Add(Convert.ToInt32(super.ItemArray[2].ToString()));
            }
        }

        private void fill_OuvrageReservBox()
        {
            reservListBox.Items.Clear();
            listeIDOuvrageReserv.Clear();
            DataTable reservs = this.reservationParOuvrageTableAdapter1.GetData(SELECTEDOUVRAGE);
            reservState = Reservation.AUCUNE;
            foreach(DataRow res in reservs.Rows)
            {
                reservState = Reservation.EXISTANTE;
                reservListBox.Items.Add(res.ItemArray[1].ToString() + ' ' + res.ItemArray[2].ToString());
                listeIDOuvrageReserv.Add(Convert.ToInt32(res.ItemArray[0].ToString()));
            }
            if (reservListBox.Items.Count > 0)
                reservListBox.SelectedIndex = 0;
            refreshOuvrageReservBox(0);
        }

            #endregion

            #region fill AuteurPage

        private void fill_AuteurPage(int idAuteur)
        {
            this.SELECTEDAUTEUR = idAuteur;
            fill_AuteurInfoBox();
            fill_AuteurPubliBox();
            fill_AuteurSuperBox();
        }

        private void fill_AuteurInfoBox()
        {
            DataTable infos = this.auteurSuperviseurTableAdapter1.GetDataByIDAutSup(SELECTEDAUTEUR);
            DataRow info = infos.Rows[0];
            this.nomAuteurTextBox.Text = info.ItemArray[1].ToString();
            this.prenomAuteurTextBox.Text = info.ItemArray[2].ToString();
            this.statutAuteurTextBox.Text = info.ItemArray[3].ToString();
        }

        private void fill_AuteurPubliBox()
        {
            listeIDAuteurPubli.Clear();
            publiAuteurListBox.Items.Clear();
            DataTable publis = this.publicationsParAuteurTableAdapter1.GetDataByAuteur(SELECTEDAUTEUR);
            foreach (DataRow publi in publis.Rows)
            {
                publiAuteurListBox.Items.Add(publi.ItemArray[1].ToString());
                listeIDAuteurPubli.Add(Convert.ToInt32(publi.ItemArray[0].ToString()));
            }
        }

        private void fill_AuteurSuperBox()
        {
            listeIDAuteurSupervise.Clear();
            auteurSuperviseListBox.Items.Clear();
            DataTable ouvrages = this.titreOuvrageParSuperTableAdapter1.GetTitreBySuper(SELECTEDAUTEUR);
            foreach (DataRow ouvrage in ouvrages.Rows)
            {
                auteurSuperviseListBox.Items.Add(ouvrage.ItemArray[1].ToString());
                listeIDAuteurSupervise.Add(Convert.ToInt32(ouvrage.ItemArray[0].ToString()));
            }
        }

            #endregion

            #region fill MembrePage

        private void fill_MembrePage(int idMembre)
        {
            this.SELECTEDMEMBRE = idMembre;
            fill_MembreInfoBox();
            fill_MembreEmpruntBox();
            fill_MembreReservBox();
        }

        private void fill_MembreInfoBox()
        {
            DataTable membres = this.membreTableAdapter1.GetInfoByIDMembre(SELECTEDMEMBRE);
            DataRow membre = membres.Rows[0];
            int it = 1;
            this.nomMembreTextBox.Text = membre.ItemArray[it++].ToString();
            this.prenomMembreTextBox.Text = membre.ItemArray[it++].ToString();
            this.rueMembreTextBox.Text = membre.ItemArray[it++].ToString();
            this.numRueMembreTextBox.Text = membre.ItemArray[it++].ToString();
            this.codePostalMembreTextBox.Text = membre.ItemArray[it++].ToString();
            this.villeMembreTextBox.Text = membre.ItemArray[it++].ToString();
            this.numTelMembreTextBox.Text = membre.ItemArray[it++].ToString();
        }

        private void fill_MembreEmpruntBox()
        {
            this.listeIDMembreEmprunt.Clear();
            this.empruntsMembreListBox.Items.Clear();
            DataTable emprunts = this.empruntsParMembreTableAdapter1.GetEmpruntsByIDMembre(IDMEMBREEMPRUNT);
            foreach(DataRow emprunt in emprunts.Rows)
            {
                DateTime d = DateTime.Parse(emprunt.ItemArray[2].ToString());
                String s = emprunt.ItemArray[1].ToString();
                if (s.Length > 15)
                    s = s.Substring(0, 15) + "...";
                this.empruntsMembreListBox.Items.Add(s + ", emprunté le " + d.ToShortDateString() + " pour " + emprunt.ItemArray[3].ToString() + " jours");
                listeIDMembreEmprunt.Add(Convert.ToInt32(emprunt.ItemArray[0].ToString()));
            }
        }

        private void fill_MembreReservBox()
        {
            this.listeIDMembreReserv.Clear();
            this.resMembreListBox.Items.Clear();
            DataTable reservs = this.reservParMembreTableAdapter1.GetReservByIDMembre(SELECTEDMEMBRE);
            foreach (DataRow reserv in reservs.Rows)
            {
                DateTime d = DateTime.Parse(reserv.ItemArray[2].ToString());
                String s = reserv.ItemArray[1].ToString();
                if (s.Length > 15)
                    s = s.Substring(0, 15) + "...";
                this.resMembreListBox.Items.Add(s + " réservé le " + d.ToShortDateString() + " pour " + reserv.ItemArray[3].ToString() + " jours");
                listeIDMembreReserv.Add(Convert.ToInt32(reserv.ItemArray[0].ToString()));
            }
        }

            #endregion

        #endregion

        #region Methods

        private String etatEmprunt(DateTime? dateRetour)
        {
            String res = "Aucun emprunt en cours";
            if (dateRetour != null)
            {
                DateTime currDate = DateTime.Today;
                int x = currDate.CompareTo(dateRetour);
                if (x < 0)
                    res = "En cours";
                else if (x == 0)
                    res = "Retour aujourd'hui !";
                else
                    res = "En retard";
            }

            return res;
        }

        private void refreshStateDisplay()
        {
            if (SELECTEDOUVRAGE != -1)
            {
                #region editionState

                switch (this.editState)
                {
                    case Edition.EDITING:
                        this.modifierToolStripMenuItem.Enabled = false;
                        this.sauvegarderLesModificationsToolStripMenuItem.Enabled = this.ignorerLesModificationsToolStripMenuItem.Enabled = true;
                        break;

                    case Edition.NORMAL:
                        this.modifierToolStripMenuItem.Enabled = true;
                        this.sauvegarderLesModificationsToolStripMenuItem.Enabled = this.ignorerLesModificationsToolStripMenuItem.Enabled = false;
                        break;
                }

                #endregion

                #region empruntState
                switch (this.empruntState)
                {
                    case Emprunt.EMPRUNTE:
                        this.ajouterEmpruntBouton.Enabled = false;
                        this.supprEmpruntBouton.Enabled = true;
                        break;

                    case Emprunt.AUCUN:
                        this.ajouterEmpruntBouton.Enabled = true;
                        this.supprEmpruntBouton.Enabled = false;

                        break;
                }

                #endregion

                #region reservState

                switch (reservState)
                {
                    case Reservation.EXISTANTE:
                        this.ajouterReservBouton.Enabled = true;
                        this.supprReservBouton.Enabled = true;
                        break;
                    case Reservation.AUCUNE:
                        this.ajouterReservBouton.Enabled = true;
                        this.supprReservBouton.Enabled = false;
                        break;
                }

                #endregion
            }
        }

        private void lockControls(bool locked)
        {
            lockOuvragePage(locked);
            lockAuteurPage(locked);
            lockMembrePage(locked);
        }

        private void lockOuvragePage(bool locked)
        {
            foreach (Control c in infosOuvrageTableLayout.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    ((TextBox)c).ReadOnly = locked;
            }

            foreach (Control c in auteursSplitContainer.Panel2.Controls)
                if (c.GetType() == typeof(Button))
                    c.Enabled = !locked;

            foreach (Control c in superSplitContainer.Panel2.Controls)
                if (c.GetType() == typeof(Button))
                    c.Enabled = !locked;
        }

        private void lockAuteurPage(bool locked)
        {
            foreach (Control c in infosAuteurTableLayout.Controls)
                if (c.GetType() == typeof(TextBox))
                    ((TextBox)c).ReadOnly = locked;

            foreach (Control c in auteurEcritSplitContainer.Panel2.Controls)
                c.Enabled = !locked;

            foreach (Control c in auteurSuperviseSplitContainer.Panel2.Controls)
                c.Enabled = !locked;
        }

        private void lockMembrePage(bool locked)
        {
            foreach (Control c in infosMembrePersonalTableLayout.Controls)
                if (c.GetType() == typeof(TextBox))
                    ((TextBox)c).ReadOnly = locked;
            foreach(Control c in infosMembreAdresseTableLayout.Controls)
                if (c.GetType() == typeof(TextBox))
                    ((TextBox)c).ReadOnly = locked;
            foreach (Button b in empruntMembreSplitContainer.Panel2.Controls)
                b.Enabled = !locked;
            foreach (Button b in reservMembreSplitContainer.Panel2.Controls)
                b.Enabled = !locked;
        }

        private void showInfoPage(TreeNode n)
        {
            String[] s = n.Name.Split(' ');
            showInfoPage(s[0]);
        }

        private void showInfoPage(String s)
        {
            switch (s)
            {
                case "ouvrage":
                    infoTabs.SelectedIndex = 0;
                    break;
                case "auteur":
                    infoTabs.SelectedIndex = 1;
                    break;
                case "membre":
                    infoTabs.SelectedIndex = 2;
                    break;
            }
        }

        private void refreshOuvrageReservBox(int index)
        {
            switch (reservState)
            {
                case Reservation.EXISTANTE:
                    if (SELECTEDOUVRAGE != -1)
                    {
                        DataTable reservs = this.reservationParOuvrageTableAdapter1.GetData(this.SELECTEDOUVRAGE);
                        DataRow res = reservs.Rows[index];
                        DateTime dateReserv = DateTime.Parse(res.ItemArray[3].ToString());
                        this.dateReservTextBox.Text = dateReserv.ToShortDateString();
                        this.dureeReservTextBox.Text = res.ItemArray[4].ToString() + " jours";
                    }
                    break;
                case Reservation.AUCUNE:
                    this.dateReservTextBox.Clear();
                    this.dureeReservTextBox.Clear();
                    break;
            }
        }

        private void refresh_All()
        {
            update_Treeview();
            if(SELECTEDOUVRAGE != -1)
                fill_OuvragePage(SELECTEDOUVRAGE);
            this.ActiveControl = textBoxRechercher;
            refreshStateDisplay();
            refreshOuvrageReservBox(0);
        }

        #endregion

        #region Events

        private void toggleEditionMode(object sender, EventArgs e)
        {
            bool locked;
            if (editState == Edition.NORMAL)
            {
                editState = Edition.EDITING;
                locked = false;
            }
            else
            {
                editState = Edition.NORMAL;
                locked = true;
            }
            lockControls(locked);
            refreshStateDisplay();
        }

        private void generalTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            generalTreeView_NodeMouseClick(sender, e);
            showInfoPage(e.Node);
        }

        private void reservListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshOuvrageReservBox(reservListBox.SelectedIndex);
        }

        private void generalTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            fill_InfoPage(e.Node);
        }

        private void ajouterReservBouton_Click(object sender, EventArgs e)
        {
            addEmpruntResForm addRes = new addEmpruntResForm("réservation", SELECTEDOUVRAGE);
            var res = addRes.ShowDialog();
            if (res == DialogResult.Yes)
            {
                reservState = Reservation.EXISTANTE;
            }
            refresh_All();
        }

        private void textBoxRechercher_TextChanged(object sender, EventArgs e)
        {
            this.generalTreeView.BeginUpdate();
            this.generalTreeView.Nodes.Clear();
            if (this.textBoxRechercher.Text != string.Empty)
            {
                foreach (TreeNode _parentNode in treeViewCache.Nodes)
                {
                    foreach (TreeNode _childNode in _parentNode.Nodes)
                    {
                        if (_childNode.Text.IndexOf(textBoxRechercher.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            if (!treeContains(_childNode.Text))
                                this.generalTreeView.Nodes.Add((TreeNode)_childNode.Clone());
                        }
                        foreach (TreeNode _c_ChildNode in _childNode.Nodes)
                        {
                            foreach (TreeNode _c_c_ChildNode in _c_ChildNode.Nodes)
                            {
                                if (_c_c_ChildNode.Text.IndexOf(textBoxRechercher.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    if (!treeContains(_c_c_ChildNode.Text))
                                        generalTreeView.Nodes.Add((TreeNode)_c_c_ChildNode.Clone());
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (TreeNode _node in this.treeViewCache.Nodes)
                {
                    generalTreeView.Nodes.Add((TreeNode)_node.Clone());
                }
            }
            //enables redrawing tree after all objects have been added
            this.generalTreeView.EndUpdate();
        }

        private void auteursListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (auteursListBox.Items.Count != 0 && auteursListBox.SelectedItem != null)
            {
                fill_AuteurPage(listeIDAuteur[auteursListBox.SelectedIndex]);
                showInfoPage("auteur");
            }
        }

        private void superListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (superListBox.Items.Count != 0)
            {
                fill_AuteurPage(listeIDAuteur[listeIDAuteur.Count-1]);
                showInfoPage("auteur");
            }
        }

        private void publiAuteurListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (publiAuteurListBox.Items.Count != 0 && publiAuteurListBox.SelectedItem != null)
            {
                fill_OuvragePage(listeIDAuteurPubli[publiAuteurListBox.SelectedIndex]);
                showInfoPage("ouvrage");
            }
        }

        private void auteurSuperviseListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (auteurSuperviseListBox.Items.Count != 0 && auteurSuperviseListBox.SelectedItem != null)
            {
                fill_OuvragePage(listeIDAuteurSupervise[auteurSuperviseListBox.SelectedIndex]);
                showInfoPage("ouvrage");
            }
        }

        private void reservListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (reservListBox.Items.Count != 0 && reservListBox.SelectedItem != null)
            {
                fill_MembrePage(listeIDOuvrageReserv[reservListBox.SelectedIndex]);
                showInfoPage("membre");
            }
        }

        private void empruntsMembreListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (empruntsMembreListBox.Items.Count != 0 && empruntsMembreListBox.SelectedItem != null)
            {
                fill_OuvragePage(listeIDMembreEmprunt[empruntsMembreListBox.SelectedIndex]);
                showInfoPage("ouvrage");
            }
        }

        private void resMembreListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (resMembreListBox.Items.Count != 0 && resMembreListBox.SelectedItem != null)
            {
                fill_OuvragePage(listeIDMembreReserv[resMembreListBox.SelectedIndex]);
                showInfoPage("ouvrage");
            }
        }

        private void membreEmpruntListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (membreEmpruntListBox.Items.Count != 0 && membreEmpruntListBox.SelectedItem != null)
            {
                fill_MembrePage(IDMEMBREEMPRUNT);
                showInfoPage("membre");
            }
        }

        private void infoTabs_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (editState == Edition.EDITING)
            {
                var res = MessageBox.Show("Edtion en cours, quitter la page ? \n(les changements seront perdus !)", "Quitter la page ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void ajouterEmpruntBouton_Click(object sender, EventArgs e)
        {
            addEmpruntResForm addEmprunt = new addEmpruntResForm("emprunt", SELECTEDOUVRAGE);
            var res = addEmprunt.ShowDialog();
            if (res == DialogResult.Yes)
                empruntState = Emprunt.EMPRUNTE;
            else
                empruntState = Emprunt.AUCUN;

            refresh_All();
        }

        private void supprEmpruntBouton_Click(object sender, EventArgs e)
        {
            this.ouvrageTableAdapter.UpdateEmprunt(null, null, null, SELECTEDOUVRAGE);

            refresh_All();
        }

        private void ajouterEmpruntMenu_Click(object sender, EventArgs e)
        {
            addEmpruntResForm addEmprunt = new addEmpruntResForm("emprunt");
            var res = addEmprunt.ShowDialog();
            if (res == DialogResult.Yes)
                empruntState = Emprunt.EMPRUNTE;
            else
                empruntState = Emprunt.AUCUN;

            refresh_All();
        }

        private void supprReservBouton_Click(object sender, EventArgs e)
        {
            this.reserverTableAdapter1.DeleteReserv(listeIDOuvrageReserv[reservListBox.SelectedIndex], SELECTEDOUVRAGE);
            listeIDOuvrageReserv.RemoveAt(reservListBox.SelectedIndex);

            refresh_All();
        }

        private void ajouterReservationMenu_Click(object sender, EventArgs e)
        {
            addEmpruntResForm addRes = new addEmpruntResForm("réservation");
            var res = addRes.ShowDialog();
            if (res == DialogResult.Yes)
            {
                reservState = Reservation.EXISTANTE;
            }

            refresh_All();
        }
        
        private void ajouterOuvrageMenu_Click(object sender, EventArgs e)
        {
            addOuvrageForm addOuvrage = new addOuvrageForm();
            addOuvrage.ShowDialog();
            refresh_All();
        }
        
        #endregion

        private void supprOuvrageMenu_Click(object sender, EventArgs e)
        {
            if (SELECTEDOUVRAGE != -1)
            {
                var res = MessageBox.Show("Voulez-vous vraiment supprimer l'ouvrage :\n\"" + titreTextBox.Text + "\" ?\nToutes les références vers cet ouvrage seront également supprimées.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {

                    this.ouvrageTableAdapter.DeleteOuvrage(SELECTEDOUVRAGE);
                    SELECTEDOUVRAGE = -1;
                    refresh_All();
                }
            }
        }
    }
}
