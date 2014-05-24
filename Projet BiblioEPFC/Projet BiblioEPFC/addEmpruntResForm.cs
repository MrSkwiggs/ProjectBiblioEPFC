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
                ajouterOuvrageBouton.Enabled = false;
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
                    else
                    {
                        DataTable reservations = reserverTableAdapter1.GetReservsByOuvrage(SELECTEDOUVRAGE);
                        DateTime dateMin, dateMax;
                        dateMin = new DateTime();
                        dateMax = new DateTime();
                        if (reservations.Rows.Count != 0)
                        {
                            for (int i = 0; i < reservations.Rows.Count; ++i)
                            {
                                if (i == 0)
                                    dateMin = DateTime.Parse(reservations.Rows[i].ItemArray[2].ToString());
                                dateMax = DateTime.Parse(reservations.Rows[i].ItemArray[2].ToString()).AddDays(Convert.ToInt32(reservations.Rows[i].ItemArray[3].ToString()));
                            }

                            //DateTime dateEmprunt = DateTime.Parse(ouvrage.Rows[0].ItemArray[5].ToString());
                            //int duree = Convert.ToInt32(ouvrage.Rows[0].ItemArray[6].ToString());
                            //DateTime dateFinEmprunt = dateEmprunt.AddDays(duree);

                            DateTime nouvelEmprunt = DateTime.Parse(dateEmpruntPicker.Text);
                            int newDuree = Convert.ToInt32(dureeComboBox.Text.Split(' ')[0]);
                            DateTime dateFinNewEmprunt = nouvelEmprunt.AddDays(newDuree);

                            if (dateFinNewEmprunt.CompareTo(dateMin) >= 0 && dateFinNewEmprunt.CompareTo(dateMax) <= 0)
                            {
                                MessageBox.Show("La date de retour de cet emprunt empiète sur une période durant laquelle cet ouvrage est déjà réservé.\nRéduisez si possible la durée de l'emprunt.\nSinon, la première date libre est : "
                                    + dateMax.AddDays(1).ToShortDateString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                            else if (nouvelEmprunt.CompareTo(dateMax) <= 0 && dateFinNewEmprunt.CompareTo(dateMax) >= 0)
                            {
                                MessageBox.Show("La date d'emprunt empiète sur une période durant laquelle cet ouvrage est déjà réservé.\nCet ouvrage sera disponible au plus tôt le : "
                                    + dateMax.AddDays(1).ToShortDateString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                    return true;

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
                    else
                    {
                        DataTable reservations = this.reserverTableAdapter1.GetReservsByOuvrage(SELECTEDOUVRAGE);
                        DataTable infoOuvrage = this.ouvrageTableAdapter1.GetDataBy2(SELECTEDOUVRAGE);
                        if (infoOuvrage.Rows.Count != 0 && !infoOuvrage.Rows[0].ItemArray[5].ToString().Equals(""))
                        {
                            DateTime dateEmprunt = DateTime.Parse(infoOuvrage.Rows[0].ItemArray[5].ToString());
                            int dureeEmprunt = Convert.ToInt32(infoOuvrage.Rows[0].ItemArray[6].ToString());
                            DateTime dateFinEmprunt = dateEmprunt.AddDays(dureeEmprunt);

                            DateTime dateReserv = DateTime.Parse(dateEmpruntPicker.Text);
                            int dureeReserv = Convert.ToInt32(dureeComboBox.SelectedItem.ToString().Split(' ')[0]);
                            DateTime dateFinReserv = dateReserv.AddDays(dureeReserv);

                            DateTime dateMin, dateMax;
                            dateMin = new DateTime(dateEmprunt.Year,dateEmprunt.Month,dateEmprunt.Day);
                            dateMax = new DateTime(dateFinEmprunt.Year,dateFinEmprunt.Month,dateFinEmprunt.Day);

                            for (int i = 0; i < reservations.Rows.Count; ++i)
                            {
                                if (i == 0)
                                    dateMin = DateTime.Parse(reservations.Rows[i].ItemArray[2].ToString());
                                dateMax = DateTime.Parse(reservations.Rows[i].ItemArray[2].ToString()).AddDays(Convert.ToInt32(reservations.Rows[i].ItemArray[3].ToString()));
                            }

                            if(dateFinReserv.CompareTo(dateEmprunt) >= 0 && dateFinReserv.CompareTo(dateFinEmprunt) <= 0)
                            {
                                MessageBox.Show("Un emprunt déjà programmé aura commencé avant la fin de cette réservation."
                                    + "\nVeuillez si possible diminuer la durée de la réservation."
                                    + "\nSinon, la première date de réservation possible est : " 
                                    + dateMax.AddDays(1).ToShortDateString(),"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                return false;
                            }
                            else if(dateReserv.CompareTo(dateFinEmprunt) <= 0 && dateFinReserv.CompareTo(dateFinEmprunt) >= 0)
                            {
                                MessageBox.Show("Cette réservation empiète sur un emprunt déjà en cours."
                                    + "\nLa première date de réservation possible est : " 
                                    + dateMax.AddDays(1).ToShortDateString(),"Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                return false;
                            }
                            else if (dateFinReserv.CompareTo(dateMin) >= 0 && dateFinReserv.CompareTo(dateMax) <= 0)
                            {
                                MessageBox.Show("La date de fin de cette réservation empiète sur une période d'une autre réservation."
                                    + "\nVeuillez si possible diminuer la durée de la réservation."
                                    + "\nSinon, la première date de réservation possible est : "
                                    + dateMax.AddDays(1).ToShortDateString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                            else if (dateReserv.CompareTo(dateMin) >= 0 && dateReserv.CompareTo(dateMax) <= 0)
                            {
                                MessageBox.Show("La réservation empiète sur la période d'une autre réservation."
                                    + "\nLa première date de réservation possible est :"
                                    + dateMax.AddDays(1).ToShortDateString(), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
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
            addMembreForm addMembre = new addMembreForm();
            var res = addMembre.ShowDialog();
            if (res == DialogResult.OK)
                fill_MembreListBox();
        }
    }
}
