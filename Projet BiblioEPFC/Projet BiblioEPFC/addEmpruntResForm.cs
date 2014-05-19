using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace ApplicationBiblioEPFC
{
    public partial class addEmpruntResForm : Form
    {
        private int SELECTEDOUVRAGE;
        private int SELECTEDMEMBRE;
        private String SELECTEDTYPE;
        private List<int> listeIDOuvrage;
        private List<String> cacheOuvrages;
        private List<int> listeIDMembre;
        private List<String> cacheMembres;
        private bool selectedAll;

        public addEmpruntResForm(String type)
        {
            InitializeComponent();
            SELECTEDTYPE = type;
            this.Text = "Ajouter " + type;
        }

        public addEmpruntResForm(String type, int idOuvrage)
        {
            InitializeComponent();
            SELECTEDTYPE = type;
            SELECTEDOUVRAGE = idOuvrage;
            this.Text = "Ajouter " + type;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listeIDOuvrage = new List<int>();
            listeIDMembre = new List<int>();
            cacheOuvrages = new List<string>();
            cacheMembres = new List<string>();
            selectedAll = false;
            fill_OuvrageListBox();
            fill_MembreListBox();
            dureeComboBox.SelectedIndex = 2;
        }

        private void fill_OuvrageListBox()
        {
            DataTable ouvrages = this.ouvrageTableAdapter1.GetData();
            foreach (DataRow ouvrage in ouvrages.Rows)
            {
                ouvrageListBox.Items.Add(ouvrage.ItemArray[1].ToString());
                listeIDOuvrage.Add(Convert.ToInt32(ouvrage.ItemArray[0].ToString()));
                cacheOuvrages.Add(ouvrage.ItemArray[1].ToString());
            }
        }

        private void fill_MembreListBox()
        {
            DataTable membres = this.membreTableAdapter1.GetData();
            String s;
            foreach (DataRow membre in membres.Rows)
            {
                s = membre.ItemArray[1].ToString() + ' ' + membre.ItemArray[2].ToString();
                membreListBox.Items.Add(s);
                listeIDMembre.Add(Convert.ToInt32(membre.ItemArray[0].ToString()));
                cacheMembres.Add(s);
            }
        }

        private void addEmpruntRes()
        {
            String date = dateEmpruntPicker.Text;
            String[] s = dureeComboBox.SelectedItem.ToString().Split(' ');
            Int16 duree = Convert.ToInt16(s[0]);

            if (SELECTEDTYPE.Equals("emprunt"))
            {
                this.ouvrageTableAdapter1.UpdateEmprunt(date, duree, SELECTEDMEMBRE, SELECTEDOUVRAGE);
            }
            //else
            //    addReserv
        }

        private void emprunterBouton_Click(object sender, EventArgs e)
        {
            if (!selectedAll)
                MessageBox.Show("Veuillez sélectionner un ouvrage et un membre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                bool go = true;
                DataTable ouvrage = this.ouvrageTableAdapter1.GetDataBy2(SELECTEDOUVRAGE);
                if (!ouvrage.Rows[0].ItemArray[8].ToString().Equals(""))
                {
                    var res = MessageBox.Show("Un emprunt existe déjà pour cet ouvrage,\ncontinuer quand même ? (l'ancien emprunt sera remplacé)"
                    , "Attention"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    go = res == DialogResult.Yes;
                }
                if (go)
                {
                    addEmpruntRes();
                }
            }
        }

        private void ouvrageListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (ouvrageListBox.Items.Count != 0 && ouvrageListBox.SelectedItem != null)
                SELECTEDOUVRAGE = listeIDOuvrage[ouvrageListBox.SelectedIndex];
            verifySelection();
        }

        private void membreListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (membreListBox.Items.Count != 0 && membreListBox.SelectedItem != null)
                SELECTEDMEMBRE = listeIDMembre[membreListBox.SelectedIndex];
            verifySelection();
        }

        private void verifySelection()
        {
            selectedAll = (ouvrageListBox.Items.Count != 0 && ouvrageListBox.SelectedItem != null) && (membreListBox.Items.Count != 0 && membreListBox.SelectedItem != null);
        }
    }
}
