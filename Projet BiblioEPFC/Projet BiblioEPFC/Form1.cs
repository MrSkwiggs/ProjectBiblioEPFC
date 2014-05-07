using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            treeViewCache = new TreeView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'biblioEPFCDataSet.Ouvrage'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.ouvrageTableAdapter.Fill(this.biblioEPFCDataSet.Ouvrage);

            fill_GeneralTree();

            this.ActiveControl = textBoxRechercher;
        }

        #region Remplissage du TreeView

        private void fill_GeneralTree()
        {
            generalTreeView.BeginUpdate();
            generalTreeView.Nodes.Add(nodeOuvrage());
            generalTreeView.Nodes.Add(nodeMembre());
            generalTreeView.Nodes.Add(nodeEmprunt());
            //generalTreeView.Nodes.Add(nodeReservation());
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
            ouvrageNode.Name = ouvrage.ItemArray[0].ToString();
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
                auteursNode.Nodes.Add(nodeGenericPerson(auteur.ItemArray[0].ToString(), auteur.ItemArray[1].ToString(), auteur.ItemArray[2].ToString()));

            return auteursNode;
        }

        private TreeNode nodeGenericPerson(String id, String nom, String prenom)
        {
            TreeNode auteurNode = new TreeNode();
            auteurNode.Name = id;
            auteurNode.Text = nom + ' ' + prenom;

            return auteurNode;
        }

        private TreeNode nodeSuper(DataRow ouvrage)
        {
            DataTable superviseur = this.superParOuvrageTableAdapter1.GetData((int)ouvrage.ItemArray[0]);
            TreeNode superNode = new TreeNode();
            superNode.Name = superNode.Text = "Superviseur(s)";
            foreach(DataRow super in superviseur.Rows)
                superNode.Nodes.Add(nodeGenericPerson(super.ItemArray[2].ToString(), super.ItemArray[0].ToString(), super.ItemArray[1].ToString()));

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
            }

            return nodeEmprunt;
        }

        private TreeNode nodeReservation(DataRow ouvrage)
        {
            DataTable reservationMembres = this.reservationParOuvrageTableAdapter1.GetData((int)ouvrage.ItemArray[0]);
            TreeNode nodeReservation = new TreeNode();
            nodeReservation.Name = nodeReservation.Text = "Réservation(s)";
            foreach (DataRow reservation in reservationMembres.Rows)
                nodeReservation.Nodes.Add(nodeGenericPerson(reservation.ItemArray[0].ToString(), reservation.ItemArray[1].ToString(), reservation.ItemArray[2].ToString()));

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
                membreNode.Nodes.Add(nodeGenericPerson(membre.ItemArray[0].ToString(), membre.ItemArray[1].ToString(), membre.ItemArray[2].ToString()));

            return membreNode;
        }

        #endregion

        #region nodeEmprunt

        private TreeNode nodeEmprunt()
        {
            TreeNode empruntNode = new TreeNode();
            empruntNode.Name = empruntNode.Text = "Emprunt(s)";

            TreeNode ouvrages = new TreeNode();
            ouvrages.Nodes.Add((TreeNode)generalTreeView.Nodes[generalTreeView.Nodes.IndexOfKey("Ouvrages")].Clone());

            foreach(TreeNode ouvrage in ouvrages.Nodes)
                foreach(TreeNode category in ouvrage.Nodes)
                {
                    int emprunt = category.Nodes.IndexOfKey("Emprunt");
                    if(category.Nodes[emprunt].GetNodeCount(false) > 0)
                        empruntNode.Nodes.Add(nodeEmpruntChildren(ouvrage, category.Nodes[emprunt]));
                }

            return empruntNode;
        }

        private TreeNode nodeEmpruntChildren(TreeNode ouvrage, TreeNode membre)
        {
            TreeNode emprunt = new TreeNode();
            emprunt.Name = ouvrage.Name;
            emprunt.Text = ouvrage.Text;

            TreeNode membreNode = new TreeNode();
            membreNode.Name = membre.Name;
            membreNode.Text = membre.Text;

            emprunt.Nodes.Add(membreNode);

            return emprunt;
        }

        #endregion

        #region nodeReservation

        //private TreeNode nodeReservation()
        //{
        //    TreeNode resNode = new TreeNode();
        //    resNode.Name = resNode.Text = "Réservation(s)";
        //    DataTable reservations = this.
        //}

        #endregion

        private void fill_CacheTree()
        {
            foreach (TreeNode _node in generalTreeView.Nodes)
                treeViewCache.Nodes.Add((TreeNode)_node.Clone());
        }

        #endregion

        //private void fill_Treeview()
        //{
        //    generalTreeView.BeginUpdate();
        //    DataTable ouvrages = this.ouvrageTableAdapter.GetData();
        //    DataTable membres = this.membreTableAdapter1.GetData();
        //    generalTreeView.Nodes.Clear();
        //    generalTreeView.Nodes.Add("Ouvrages");
        //    generalTreeView.Nodes.Add("Membres");

        //    int it = 0;
        //    foreach (DataRow row in ouvrages.Rows)  //pour chaque ouvrage
        //    {
        //        //crée le noeud ouvrage
        //        generalTreeView.Nodes[0].Nodes.Add(row.ItemArray[1].ToString());

        //        //rajoute les noeuds enfants suivants:
        //        generalTreeView.Nodes[0].Nodes[it].Nodes.Add("Auteur(s)");
        //        generalTreeView.Nodes[0].Nodes[it].Nodes.Add("Superviseur(s)");
        //        generalTreeView.Nodes[0].Nodes[it].Nodes.Add("Emprunt(s)");
        //        generalTreeView.Nodes[0].Nodes[it].Nodes.Add("Réservation(s)");

        //        //charge les data pour chacun des noeuds ci dessus
        //        DataTable auteurs = this.auteurParOuvrageTableAdapter1.GetData((int)row.ItemArray[0]);
        //        DataTable superviseurs = this.superParOuvrageTableAdapter1.GetData((int)row.ItemArray[0]);
        //        DataTable empruntMembres = this.empruntMembreParOuvrageTableAdapter1.GetData((int)row.ItemArray[0]);
        //        DataTable reservationMembres = this.reservationParOuvrageTableAdapter1.GetData((int)row.ItemArray[0]);

        //        //pour chacun de ces noeuds, crée les noeuds enfants correspondants
        //        foreach (DataRow auteur in auteurs.Rows)
        //            generalTreeView.Nodes[0].Nodes[it].Nodes[0].Nodes.Add(auteur.ItemArray[1].ToString() + ' ' + auteur.ItemArray[2].ToString());

        //        foreach (DataRow superviseur in superviseurs.Rows)
        //            generalTreeView.Nodes[0].Nodes[it].Nodes[1].Nodes.Add(superviseur.ItemArray[0].ToString() + ' ' + superviseur.ItemArray[1].ToString());

        //        foreach (DataRow empruntMembre in empruntMembres.Rows)
        //            generalTreeView.Nodes[0].Nodes[it].Nodes[2].Nodes.Add(empruntMembre.ItemArray[1].ToString() + ' ' + empruntMembre.ItemArray[2].ToString());

        //        foreach (DataRow reservationMembre in reservationMembres.Rows)
        //            generalTreeView.Nodes[0].Nodes[it].Nodes[3].Nodes.Add(reservationMembre.ItemArray[1].ToString() + ' ' + reservationMembre.ItemArray[2].ToString());

        //        ++it;
        //    }

        //    it = 0;
        //    foreach (DataRow row in membres.Rows)
        //        generalTreeView.Nodes[1].Nodes.Add(row.ItemArray[1].ToString());

        //    foreach (TreeNode _node in generalTreeView.Nodes)
        //        treeViewCache.Nodes.Add((TreeNode)_node.Clone());
        //    generalTreeView.EndUpdate();
        //}

        private void update_Treeview()
        {
            generalTreeView.Nodes.Clear();
            fill_GeneralTree();
            treeViewCache.Nodes.Clear();
            foreach (TreeNode _node in generalTreeView.Nodes)
                treeViewCache.Nodes.Add((TreeNode)_node.Clone());
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private bool treeContains(string s)
        {
            foreach (TreeNode t in generalTreeView.Nodes)
                if(t.Text.Equals(s))
                    return true;
            return false;
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
                            if(!treeContains(_childNode.Text))
                                this.generalTreeView.Nodes.Add((TreeNode)_childNode.Clone());
                        }
                        foreach (TreeNode _c_ChildNode in _childNode.Nodes)
                        {
                            //if (_c_ChildNode.Text.IndexOf(textBoxRechercher.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                            //    generalTreeView.Nodes.Add((TreeNode)_c_ChildNode.Clone());
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form2 reservationForm = new Form2();
            reservationForm.ShowDialog();
            update_Treeview();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
