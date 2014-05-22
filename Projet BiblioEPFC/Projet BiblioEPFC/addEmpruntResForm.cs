using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace ApplicationBiblioEPFC
{
    public partial class addEmpruntResForm : Form
    {
        private int SELECTEDOUVRAGE;
        private int SELECTEDMEMBRE;
        private String SELECTEDTYPE;

        private List<int> listeIDOuvrage;
        private ListBox cacheOuvrageListBox;
        private List<int> cacheListeIDOuvrage;

        private List<int> listeIDMembre;
        private ListBox cacheMembreListBox;
        private List<int> cacheListeIDMembre;
        private bool selectedAll;
        private bool lockOuvrage;

        public addEmpruntResForm(String type)
        {
            InitializeComponent();
            SELECTEDTYPE = type;
            this.Text = "Ajouter " + type;
            lockOuvrage = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public addEmpruntResForm(String type, int idOuvrage)
        {
            InitializeComponent();
            SELECTEDTYPE = type;
            SELECTEDOUVRAGE = idOuvrage;
            this.Text = "Ajouter " + type;
            lockOuvrage = true;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listeIDOuvrage = new List<int>();
            listeIDMembre = new List<int>();

            cacheOuvrageListBox = new ListBox();
            cacheMembreListBox = new ListBox();
            
            cacheListeIDMembre = new List<int>();
            cacheListeIDOuvrage = new List<int>();

            selectedAll = false;
            fill_OuvrageListBox();
            fill_MembreListBox();
            dureeComboBox.SelectedIndex = 2;

            if (SELECTEDTYPE.Equals("emprunt"))
                goBouton.Text = "Emprunter";
            else
                goBouton.Text = "Réserver";
        }

        private void fill_OuvrageListBox()
        {
            ouvrageListBox.Items.Clear();
            listeIDOuvrage.Clear();
            if(lockOuvrage)
            {
                DataRow ouvrage = this.infoOuvrageTableAdapter1.GetDataByID(SELECTEDOUVRAGE).Rows[0];
                ouvrageListBox.Items.Add(ouvrage.ItemArray[0].ToString());
                listeIDOuvrage.Add(SELECTEDOUVRAGE);
                ouvrageListBox.SelectedIndex = 0;
                rechOuvrageTextBox.ReadOnly = true;
            }
            else
            {
                DataTable ouvrages = this.ouvrageTableAdapter1.GetData();
                foreach (DataRow ouvrage in ouvrages.Rows)
                {
                    ouvrageListBox.Items.Add(ouvrage.ItemArray[1].ToString());
                    listeIDOuvrage.Add(Convert.ToInt32(ouvrage.ItemArray[0].ToString()));
                }
            }
            foreach(var item in ouvrageListBox.Items)
                cacheOuvrageListBox.Items.Add(item);
            foreach (int i in listeIDOuvrage)
                cacheListeIDOuvrage.Add(i);
        }

        private void fill_MembreListBox()
        {
            membreListBox.Items.Clear();
            listeIDMembre.Clear();
            DataTable membres = this.membreTableAdapter1.GetData();
            String s;
            foreach (DataRow membre in membres.Rows)
            {
                s = membre.ItemArray[1].ToString() + ' ' + membre.ItemArray[2].ToString();
                membreListBox.Items.Add(s);
                listeIDMembre.Add(Convert.ToInt32(membre.ItemArray[0].ToString()));
            }
            foreach(var item in membreListBox.Items)
                cacheMembreListBox.Items.Add(item);
            foreach (int i in listeIDMembre)
                cacheListeIDMembre.Add(i);
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
            else
            {
                try
                {
                    this.reserverTableAdapter1.InsertQuery(SELECTEDMEMBRE, SELECTEDOUVRAGE, date, duree);
                }
                catch (SqlException e)
                {
                    if(e.Message.StartsWith("Violation de la contrainte"))
                        this.reserverTableAdapter1.UpdateDateAndDuree(date, duree, SELECTEDMEMBRE, SELECTEDOUVRAGE);
                    else
                        throw;
                }
            }
        }

        private void goBouton_Click(object sender, EventArgs e)
        {
            if (!selectedAll)
                MessageBox.Show("Veuillez sélectionner un ouvrage et un membre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (noConcurringData())
                {
                    addEmpruntRes();
                    DialogResult = DialogResult.Yes;
                    this.Dispose();
                }
            }
        }

        private bool noConcurringData()
        {
            switch (SELECTEDTYPE)
            {
                    //TODO: gérer le cas d'ajout d'emprunt qui finit après une date de réservation.
                case "emprunt":
                    DataTable ouvrage = this.ouvrageTableAdapter1.GetDataBy2(SELECTEDOUVRAGE);
                    if (!ouvrage.Rows[0].ItemArray[8].ToString().Equals(""))
                    {
                        var res = MessageBox.Show("Un emprunt existe déjà pour cet ouvrage,\ncontinuer quand même ? (l'ancien emprunt sera remplacé)"
                            , "Attention"
                            , MessageBoxButtons.YesNo
                            , MessageBoxIcon.Exclamation);

                        return res == DialogResult.Yes;
                    }
                    return true;

                    //TODO: gérer le cas d'ajout de réservation dans une période déjà réservée
                case "réservation":
                    DataTable reservation = this.reserverTableAdapter1.GetProbableProblem(SELECTEDMEMBRE, SELECTEDOUVRAGE);
                    if (reservation.Rows.Count != 0)
                    {
                        var res = MessageBox.Show("Cet ouvrage est déjà réservé par ce membre,\ncontinuer quand même ?\n(les anciennes date et durée seront remplacées)"
                            , "Attention"
                            , MessageBoxButtons.YesNo
                            , MessageBoxIcon.Exclamation);

                        return res == DialogResult.Yes;
                    }
                    return true;
            }
            return false;
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

        private void cancelBouton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void rechOuvrageTextBox_TextChanged(object sender, EventArgs e)
        {
            filter_ListBox((TextBox)sender, ouvrageListBox, listeIDOuvrage, cacheListeIDOuvrage, cacheOuvrageListBox);
        }

        private void filter_ListBox(TextBox rech, ListBox listBox, List<int> ListeID, List<int> cacheListeID, ListBox cacheListBox)
        {
            listBox.BeginUpdate();
            listBox.Items.Clear();
            ListeID.Clear();
            if (rech.Text != string.Empty)
            {
                for (int i = 0; i < cacheListBox.Items.Count; ++i)
                {
                    var s = cacheListBox.Items[i].ToString();
                    if (s.IndexOf(rech.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        listBox.Items.Add(s);
                        ListeID.Add(cacheListeID[i]);
                    }
                }
            }
            else
            {
                foreach (var item in cacheListBox.Items)
                    listBox.Items.Add(item);
                foreach (int i in cacheListeID)
                    ListeID.Add(i);
            }
            listBox.EndUpdate();
        }

        private void rechMembreTextBox_TextChanged(object sender, EventArgs e)
        {
            filter_ListBox(rechMembreTextBox, membreListBox, listeIDMembre, cacheListeIDMembre, cacheMembreListBox);
        }

        private void ajouterOuvrageBouton_Click(object sender, EventArgs e)
        {
            addOuvrageForm addOuvrage = new addOuvrageForm();
            addOuvrage.ShowDialog();

            fill_OuvrageListBox();
        }

        private void ajouterMembreBouton_Click(object sender, EventArgs e)
        {
            //TODO: gérer l'ajout d'un membre lors de l'ajout d'un(e) emprunt/réservation
        }
    }
}
