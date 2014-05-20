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
    public partial class addOuvrageForm : Form
    {
        private List<int> listeIDAuteursDispo, listeIDAuteur, listeIDType;
        private int SELECTEDSUPER, SELECTEDTYPE;

        public addOuvrageForm()
        {
            InitializeComponent();
        }

        private void addOuvrageForm_Load(object sender, EventArgs e)
        {
            listeIDAuteur = new List<int>();
            listeIDAuteursDispo = new List<int>();
            listeIDType = new List<int>();

            fill_ListBoxes();
            lockControls();
        }

        private void fill_ListBoxes()
        {
            fill_AuteursDispos();
            fill_Types();
        }

        private void fill_AuteursDispos()
        {
            auteursDispoListBox.Items.Clear();
            listeIDAuteursDispo.Clear();
           
            DataTable auteurs = this.auteurSuperviseurTableAdapter1.GetData();
            foreach (DataRow auteur in auteurs.Rows)
            {
                auteursDispoListBox.Items.Add(auteur.ItemArray[1].ToString() + ' ' + auteur.ItemArray[2].ToString());
                listeIDAuteursDispo.Add(Convert.ToInt32(auteur.ItemArray[0].ToString()));
            }
        }

        private void fill_Types()
        {
            typeComboBox.Items.Clear();
            listeIDType.Clear();
            
            DataTable types = this.typeTableAdapter1.GetData();
            foreach (DataRow type in types.Rows)
            {
                typeComboBox.Items.Add(type.ItemArray[2].ToString() + " - " + type.ItemArray[1].ToString());
                listeIDType.Add(Convert.ToInt32(type.ItemArray[0].ToString()));
            }
        }

        private void lockControls()
        {
            swapAuteurBouton.Enabled = (auteursDispoListBox.Items.Count != 0 && auteursDispoListBox.SelectedItem != null);
            swapSuperBouton.Enabled = swapAuteurBouton.Enabled && superListBox.Items.Count == 0;
            removeAuteurBouton.Enabled = auteursListBox.Items.Count != 0;
            removeSuperBouton.Enabled = superListBox.Items.Count != 0;
        }

        private void swapAuteurBouton_Click(object sender, EventArgs e)
        {
            auteursListBox.Items.Add(auteursDispoListBox.SelectedItem);
            listeIDAuteur.Add(listeIDAuteursDispo[auteursDispoListBox.SelectedIndex]);
            listeIDAuteursDispo.RemoveAt(auteursDispoListBox.SelectedIndex);
            auteursDispoListBox.Items.RemoveAt(auteursDispoListBox.SelectedIndex);
            if (auteursDispoListBox.Items.Count != 0) 
                auteursDispoListBox.SelectedIndex = 0;
            lockControls();
        }

        private void GenericListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lockControls();
        }
    }
}
