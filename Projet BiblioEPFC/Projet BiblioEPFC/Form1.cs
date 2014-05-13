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
        #region Initialisation

        public mainForm()
        {
            InitializeComponent();
            treeViewCache = new TreeView();
            listeIDAuteur = new List<int>();
            listeIDMembre = new List<int>();
            editState = Edition.NORMAL;
            stopEditionMenuClick(null,null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.Ouvrage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ouvrageTableAdapter.Fill(this.biblioEPFCDataSet.Ouvrage);

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
            auteurNode.Name = "person " + id;
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

        #region Recherche de node

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
                            if(!treeContains(_childNode.Text))
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

        #endregion 

        #endregion

        #region Fill InfoPage

        private void fill_InfoPage(TreeNode infos)
        {
            String[] s;
            s = infos.Name.Split(' ');
            switch (s[0])
            {
                case "ouvrage":
                    {
                        fill_OuvragePage(Convert.ToInt32(s[1]));
                        break;
                    }
                //case "Auteur(s)":
                //    {
                //        fill_AuteurPage(infos);
                //        break;
                //    }
                //case "Membres
            }
        }

        #region fill OuvragePage

        private void fill_OuvragePage(int idOuvrage)
        {
            this.SELECTEDOUVRAGE = idOuvrage;
            fill_OuvrageInfoBox(idOuvrage);
            fill_OuvrageEmpruntBox(idOuvrage);
            fill_OuvrageAuteursSuper(idOuvrage);
            fill_OuvrageReservBox(idOuvrage);

            refreshStateDisplay();
        }

        private void fill_OuvrageInfoBox(int idOuvrage)
        {
            this.auteursListBox.Items.Clear();
            this.listeIDAuteur.Clear();
            DataTable ouvrages = this.infoOuvrageTableAdapter1.GetDataByID(idOuvrage);
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

        private void fill_OuvrageEmpruntBox(int idOuvrage)
        {
            DataTable emprunts = this.empruntMembreParOuvrageTableAdapter1.GetData(idOuvrage);
            DateTime dateRetour = new DateTime();
            int it = 1, duree = 0;
            if (emprunts.Rows.Count != 0)
            {
                empruntState = Emprunt.EMPRUNTE;
                DataRow emprunt = emprunts.Rows[0];
                this.membreEmpruntTextBox.Text = emprunt.ItemArray[it++].ToString() + ' ' + emprunt.ItemArray[it++].ToString();
                dateRetour = DateTime.Parse(emprunt.ItemArray[it++].ToString());
                this.dateEmpruntTextBox.Text = dateRetour.ToShortDateString();
                duree = Convert.ToInt32(emprunt.ItemArray[it++].ToString());
                this.dureeEmpruntTextBox.Text = duree + " jours";
                this.etatEmpruntTextBox.Text = etatEmprunt(dateRetour.AddDays(duree));
            }
            else
            {
                empruntState = Emprunt.AUCUN;
                this.membreEmpruntTextBox.Clear();
                this.dateEmpruntTextBox.Clear();
                this.dureeEmpruntTextBox.Clear();
                this.etatEmpruntTextBox.Text = etatEmprunt(null);
            }
        }

        private void fill_OuvrageAuteursSuper(int idOuvrage)
        {
            DataTable supers = this.superParOuvrageTableAdapter1.GetData(idOuvrage);
            if (supers.Rows.Count != 0)
            {
                DataRow super = supers.Rows[0];
                this.superTextBox.Text = super.ItemArray[0].ToString() + ' ' + super.ItemArray[1].ToString();
            }
            else
                this.superTextBox.Clear();

            DataTable auteurs = this.auteurParOuvrageTableAdapter1.GetData(idOuvrage);
            foreach (DataRow auteur in auteurs.Rows)
            {
                this.auteursListBox.Items.Add(auteur.ItemArray[1].ToString() + ' ' + auteur.ItemArray[2].ToString());
                listeIDAuteur.Add(Convert.ToInt32(auteur.ItemArray[0].ToString()));
            }
        }

        private void fill_OuvrageReservBox(int idOuvrage)
        {
            reservListBox.Items.Clear();
            DataTable reservs = this.reservationParOuvrageTableAdapter1.GetData(idOuvrage);
            reservState = Reservation.AUCUNE;
            foreach(DataRow res in reservs.Rows)
            {
                reservState = Reservation.EXISTANTE;
                reservListBox.Items.Add(res.ItemArray[1].ToString() + ' ' + res.ItemArray[2].ToString());
                listeIDMembre.Add(Convert.ToInt32(res.ItemArray[0].ToString()));
            }
            if (reservListBox.Items.Count > 0)
                reservListBox.SelectedIndex = 0;
            refreshOuvrageReservBox(0);
        }

        private String etatEmprunt(DateTime? dateRetour)
        {
            String res;
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
            else
                res = "Aucun emprunt en cours";

            return res;
        }

        #endregion

        #endregion

        #region Methods

        private void refreshStateDisplay()
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

            switch(this.empruntState)
            {
                case Emprunt.EMPRUNTE:
                    this.ajouterEmpruntMenu.Enabled = false;
                    this.supprEmpruntMenu.Enabled = true;
                    this.ajouterEmpruntBouton.Enabled = false;
                    this.supprEmpruntBouton.Enabled = true;
                    break;
                    
                case Emprunt.AUCUN:
                    this.ajouterEmpruntMenu.Enabled = true;
                    this.supprEmpruntMenu.Enabled = false;
                    this.ajouterEmpruntBouton.Enabled = true;
                    this.supprEmpruntBouton.Enabled = false;
                    break;
            }

            #endregion

            #region reservState

            switch(reservState)
            {
                case Reservation.EXISTANTE:
                    this.supprReservBouton.Enabled = true;
                    this.supprReservMenu.Enabled = true;
                    break;
                case Reservation.AUCUNE:
                    this.supprReservBouton.Enabled = false;
                    this.supprReservMenu.Enabled = false;
                    break;
            }

            #endregion
        }

        private void showInfoPage(TreeNode n)
        {
            String[] s = n.Name.Split(' ');
            switch(s[0])
            {
                case "ouvrage":
                    infoTabs.SelectedIndex = 0;
                    break;
                case "auteur":
                case "super":
                    infoTabs.SelectedIndex = 1;
                    break;
                case "membre":
                    infoTabs.SelectedIndex = 2;
                    break;
                case "emprunt":
                    infoTabs.SelectedIndex = 3;
                    break;
                case "reservation":
                    infoTabs.SelectedIndex = 4;
                    break;
            }
        }

        private void refreshOuvrageReservBox(int index)
        {
            switch (reservState)
            {
                case Reservation.EXISTANTE:
                    DataTable reservs = this.reservationParOuvrageTableAdapter1.GetData(this.SELECTEDOUVRAGE);
                    DataRow res = reservs.Rows[index];
                    DateTime dateReserv = DateTime.Parse(res.ItemArray[3].ToString());
                    this.dateReservTextBox.Text = dateReserv.ToShortDateString();
                    this.dureeReservTextBox.Text = res.ItemArray[4].ToString() + " jours";
                    break;
                case Reservation.AUCUNE:
                    this.dateReservTextBox.Clear();
                    this.dureeReservTextBox.Clear();
                    break;
            }
        }  

        #endregion

        #region Events

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    editState = Edition.EDITING;
                    foreach (Control c in this.infosTableLayout.Controls)
                    {
                        if (c.GetType() == typeof(TextBox))
                            ((TextBox)c).ReadOnly = false;
                    }

                    foreach(Control c in auteursBoutonsFlowLayout.Controls)
                        if (c.GetType() == typeof(Button))
                            c.Enabled = true;

                    refreshStateDisplay();
                }

        private void stopEditionMenuClick(object sender, EventArgs e)
                        {
                            editState = Edition.NORMAL;
                            foreach (Control c in this.infosTableLayout.Controls)
                            {
                                if (c.GetType() == typeof(TextBox))
                                    ((TextBox)c).ReadOnly = true;
                            }

                            foreach (Control c in auteursBoutonsFlowLayout.Controls)
                                if (c.GetType() == typeof(Button))
                                    c.Enabled = false;

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

        private void ajouterReserv(object sender, EventArgs e)
                {
                    Form2 reservationForm = new Form2();
                    reservationForm.ShowDialog();
                    update_Treeview();
                }

        #endregion
    }
}
