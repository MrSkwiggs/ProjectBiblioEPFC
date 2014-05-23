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
        private List<int> listeIDType;
        private Dictionary<String, int> listeAuteursDispo, listeAuteurs;
        private int SELECTEDSUPER, SELECTEDTYPE;
        bool goDeeper;

        public addOuvrageForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            goDeeper = true;
        }

        public addOuvrageForm(bool goDeeper)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.goDeeper = goDeeper;
        }

        private void addOuvrageForm_Load(object sender, EventArgs e)
        {
            listeIDType = new List<int>();

            listeAuteurs = new Dictionary<string, int>();
            listeAuteursDispo = new Dictionary<string, int>();

            fill_ListBoxes();
            tryLockControls();
        }

        private void fill_ListBoxes()
        {
            fill_AuteursDispos();
            fill_Types();
        }

        private void fill_AuteursDispos()
        {
            auteursDispoListBox.Items.Clear();
            listeAuteursDispo.Clear();
           
            DataTable auteurs = this.auteurSuperviseurTableAdapter1.GetData();
            foreach (DataRow auteur in auteurs.Rows)
            {
                String name = auteur.ItemArray[1].ToString() + ' ' + auteur.ItemArray[2].ToString();
                int id = Convert.ToInt32(auteur.ItemArray[0].ToString());
                auteursDispoListBox.Items.Add(name);
                listeAuteursDispo.Add(name, id);
            }
        }

        private void fill_Types()
        {
            typeComboBox.Items.Clear();
            listeIDType.Clear();
            
            DataTable types = this.typeTableAdapter1.GetData();
            foreach (DataRow type in types.Rows)
            {
                typeComboBox.Items.Add(type.ItemArray[1].ToString() + " - " + type.ItemArray[2].ToString());
                listeIDType.Add(Convert.ToInt32(type.ItemArray[0].ToString()));
            }
        }

        private void tryLockControls()
        {
            swapAuteurBouton.Enabled = auteursDispoListBox.Items.Count != 0 && auteursDispoListBox.SelectedItem != null;
            swapSuperBouton.Enabled = swapAuteurBouton.Enabled && superListBox.Items.Count == 0;
            removeAuteurBouton.Enabled = auteursListBox.Items.Count != 0 && auteursListBox.SelectedItem != null;
            removeSuperBouton.Enabled = superListBox.Items.Count != 0;
            moveUpBouton.Enabled = removeSuperBouton.Enabled;
            moveDownBouton.Enabled = removeAuteurBouton.Enabled && superListBox.Items.Count == 0;
            addSuperBouton.Enabled = goDeeper && superListBox.Items.Count == 0;
            addAuteurBouton.Enabled = goDeeper;
        }

        private void swapAuteurBouton_Click(object sender, EventArgs e)
        {
            string name = auteursDispoListBox.SelectedItem.ToString();
            int id;
            if(listeAuteursDispo.TryGetValue(name,out id))
            {
                auteursListBox.Items.Add(name);
                listeAuteurs.Add(name, id);
                listeAuteursDispo.Remove(name);
                auteursDispoListBox.Items.RemoveAt(auteursDispoListBox.SelectedIndex);
                if (auteursDispoListBox.Items.Count != 0)
                    auteursDispoListBox.SelectedIndex = 0;
                auteursListBox.SelectedIndex = 0;
            }

            tryLockControls();
        }

        private void GenericListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tryLockControls();
        }

        private void addTypeBouton_Click(object sender, EventArgs e)
        {
            addTypeForm addType = new addTypeForm();
            addType.ShowDialog();
            fill_Types();
        }

        private void cancelBouton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void removeAuteurBouton_Click(object sender, EventArgs e)
        {
            string name = auteursListBox.SelectedItem.ToString();
            int id;
            if (listeAuteurs.TryGetValue(name, out id))
            {
                auteursDispoListBox.Items.Add(name);
                listeAuteursDispo.Add(name, id);
                listeAuteurs.Remove(name);
                auteursListBox.Items.RemoveAt(auteursListBox.SelectedIndex);
                if (auteursListBox.Items.Count != 0)
                    auteursListBox.SelectedIndex = 0;
                auteursDispoListBox.SelectedIndex = 0;
            }

            tryLockControls();
        }

        private void swapSuperBouton_Click(object sender, EventArgs e)
        {
            string name = auteursDispoListBox.SelectedItem.ToString();
            int id;
            if (listeAuteursDispo.TryGetValue(name, out id))
            {
                superListBox.Items.Add(name);
                SELECTEDSUPER = id;
                listeAuteursDispo.Remove(name);
                auteursDispoListBox.Items.RemoveAt(auteursDispoListBox.SelectedIndex);
                if (auteursDispoListBox.Items.Count != 0)
                    auteursDispoListBox.SelectedIndex = 0;
                superListBox.SelectedIndex = 0;
            }

            tryLockControls();
        }

        private void removeSuperBouton_Click(object sender, EventArgs e)
        {
            string name = superListBox.SelectedItem.ToString();

            auteursDispoListBox.Items.Add(name);
            listeAuteursDispo.Add(name, SELECTEDTYPE);

            superListBox.Items.Clear();
            SELECTEDSUPER = -1;

            auteursDispoListBox.SelectedIndex = 0;
            
            tryLockControls();
        }

        private void moveUpBouton_Click(object sender, EventArgs e)
        {
            string name = superListBox.SelectedItem.ToString();

            auteursListBox.Items.Add(name);
            listeAuteurs.Add(name, SELECTEDTYPE);

            superListBox.Items.Clear();
            SELECTEDSUPER = -1;

            auteursListBox.SelectedIndex = 0;

            tryLockControls();
        }

        private void moveDownBouton_Click(object sender, EventArgs e)
        {
            string name = auteursListBox.SelectedItem.ToString();
            int id;
            if (listeAuteurs.TryGetValue(name, out id))
            {
                superListBox.Items.Add(name);
                SELECTEDSUPER = id;
                listeAuteurs.Remove(name);
                auteursListBox.Items.RemoveAt(auteursListBox.SelectedIndex);
                if (auteursListBox.Items.Count != 0)
                    auteursListBox.SelectedIndex = 0;
                superListBox.SelectedIndex = 0;
            }

            tryLockControls();
        }

        private void ajouterOuvrageBouton_Click(object sender, EventArgs e)
        {
            if (filledMandatory())
            {
                if (ouvrageAlreadyExists())
                    MessageBox.Show("Un ouvrage du même titre existe déjà.\nVeuillez choisir un titre différent","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                else
                {
                    String titre, date, local, entrep, section, type, auteurs = "", super = "";
                    titre = titreTextBox.Text;
                    date = dateCreaPicker.Text;
                    local = localTextBox.Text;
                    entrep = entrepriseTextBox.Text;
                    section = sectionTextBox.Text;
                    type = typeComboBox.SelectedItem.ToString();
                    if(superListBox.SelectedItem == null)
                        addOuvrage(titre,local,date,section,entrep,SELECTEDTYPE,null);
                    else
                        addOuvrage(titre, local, date, section, entrep, SELECTEDTYPE, SELECTEDSUPER);

                    addAuteurs();
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
            }
            else
                MessageBox.Show("Veuillez remplir tous les champs!\n(seul le champ surperviseur est optionnel)","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void addAuteurs()
        {
            int idOuvrage = getIDOfNewOuvrage(titreTextBox.Text);
            foreach(String auteur in auteursListBox.Items)
            {
                int idAuteur;
                if(listeAuteurs.TryGetValue(auteur,out idAuteur))
                {
                    ecrireTableAdapter1.InsertEcrire(idAuteur,idOuvrage);
                }
            }
        }


        private int getIDOfNewOuvrage(String titre)
        {
            DataTable ouvrages = this.ouvrageTableAdapter1.GetIDByTitre(titre);
            return Convert.ToInt32(ouvrages.Rows[0].ItemArray[0].ToString());
        }

        private void addOuvrage(String titre, String local, String date, String section, String entrep, int type, int? super)
        {
            this.ouvrageTableAdapter1.InsertNewOuvrage(titre,local,date,section,null,null,type,null,entrep,super);
        }

        private bool filledMandatory()
        {
            return (!titreTextBox.Text.Equals("") &&
                dateCreaPicker.Checked &&
                !localTextBox.Text.Equals("") &&
                !entrepriseTextBox.Text.Equals("") &&
                !sectionTextBox.Text.Equals("") &&
                (typeComboBox.SelectedItem != null && typeComboBox.Items.Contains(typeComboBox.SelectedItem.ToString())) &&
                auteursListBox.Items.Count != 0);
        }

        private bool ouvrageAlreadyExists()
        {
            bool res = false;

            DataTable ouvrages = this.ouvrageTableAdapter1.GetData();
            foreach (DataRow ouvrage in ouvrages.Rows)
            {
                String s = ouvrage.ItemArray[1].ToString().ToLower();
                if (s.Equals(titreTextBox.Text.ToLower()))
                    return true;
            }

            return res;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SELECTEDTYPE = listeIDType[typeComboBox.SelectedIndex];
        }

        private void addAuteurBouton_Click(object sender, EventArgs e)
        {
            //TODO: gérer l'ajout d'un nouveau membre directement assigné à la liste d'auteurs d'un nouvel ouvrage
            addAuteurForm addAuteur = new addAuteurForm(false);
            addAuteur.ShowDialog();
        }

        private void addSuperBouton_Click(object sender, EventArgs e)
        {
            //TODO: gérer l'ajout d'un nouveau membre superviseur dans nouvel ouvrage
        }
    }
}
