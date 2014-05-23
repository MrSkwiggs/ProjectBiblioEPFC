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
    public partial class addAuteurForm : Form
    {
        Dictionary<String, int> listeOuvragesDispo, listeEcrits, listeSuper;

        public addAuteurForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public addAuteurForm(bool goDeeper)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lockAddOuvrage(goDeeper);
        }

        private void addAuteurForm_Load(object sender, EventArgs e)
        {
            listeOuvragesDispo = new Dictionary<String, int>();
            listeEcrits = new Dictionary<String, int>();
            listeSuper = new Dictionary<String, int>();

            this.ouvrageTableAdapter1.Fill(biblioEPFCDataSet.Ouvrage);
            fill_OuvrageListBox();
            tryLockControls();
        }

        private void fill_OuvrageListBox()
        {
            DataTable ouvrages = this.ouvrageTableAdapter1.GetData();
            foreach (DataRow ouvrage in ouvrages.Rows)
            {
                String titre = ouvrage.ItemArray[1].ToString();
                int id = Convert.ToInt32(ouvrage.ItemArray[0].ToString());
                ouvragesDispoListBox.Items.Add(titre);
                listeOuvragesDispo.Add(titre, id);
            }
        }

        private void tryLockControls()
        {
            swapEcritBouton.Enabled = ouvragesDispoListBox.Items.Count != 0 && ouvragesDispoListBox.SelectedItem != null;
            removeEcritBouton.Enabled = ecritsListBox.Items.Count != 0 && ecritsListBox.SelectedItem != null;

            swapSuperBouton.Enabled = swapEcritBouton.Enabled;
            removeSuperBouton.Enabled = superListBox.Items.Count != 0 && superListBox.SelectedItem != null;

            moveUpBouton.Enabled = removeSuperBouton.Enabled;
            moveDownBouton.Enabled = removeEcritBouton.Enabled;
        }

        private void lockAddOuvrage(bool goDeeper)
        {
            addEcritBouton.Enabled = goDeeper;
            addSuperBouton.Enabled = goDeeper;
        }

        private void addEcritBouton_Click(object sender, EventArgs e)
        {
            addOuvrageForm addEcrit = new addOuvrageForm(false);
            addEcrit.ShowDialog();
        }

        private void swapEcritBouton_Click(object sender, EventArgs e)
        {
            string titre = ouvragesDispoListBox.SelectedItem.ToString();
            int id;
            if (listeOuvragesDispo.TryGetValue(titre, out id))
            {
                ecritsListBox.Items.Add(titre);
                listeEcrits.Add(titre, id);
                listeOuvragesDispo.Remove(titre);
                ouvragesDispoListBox.Items.RemoveAt(ouvragesDispoListBox.SelectedIndex);
                if (ouvragesDispoListBox.Items.Count != 0)
                    ouvragesDispoListBox.SelectedIndex = 0;
                ecritsListBox.SelectedIndex = 0;
            }

            tryLockControls();
        }

        private void ouvragesDispoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tryLockControls();
        }

        private void removeEcritBouton_Click(object sender, EventArgs e)
        {
            string titre = ecritsListBox.SelectedItem.ToString();
            int id;
            if (listeEcrits.TryGetValue(titre, out id))
            {
                ouvragesDispoListBox.Items.Add(titre);
                listeOuvragesDispo.Add(titre, id);
                listeEcrits.Remove(titre);
                ecritsListBox.Items.RemoveAt(ecritsListBox.SelectedIndex);
                if (ecritsListBox.Items.Count != 0)
                    ecritsListBox.SelectedIndex = 0;
                ouvragesDispoListBox.SelectedIndex = 0;
            }

            tryLockControls();
        }

        private void moveDownBouton_Click(object sender, EventArgs e)
        {
            string titre = ecritsListBox.SelectedItem.ToString();
            if (!alreadySupervised(titre))
            {
                int id;
                if (listeEcrits.TryGetValue(titre, out id))
                {
                    superListBox.Items.Add(titre);
                    listeSuper.Add(titre, id);
                    listeEcrits.Remove(titre);
                    ecritsListBox.Items.RemoveAt(ecritsListBox.SelectedIndex);
                    if (ecritsListBox.Items.Count != 0)
                        ecritsListBox.SelectedIndex = 0;
                    superListBox.SelectedIndex = 0;
                }

                tryLockControls();
            }
            else
                showErrorAlreadySupervised(titre);
        }

        private void moveUpBouton_Click(object sender, EventArgs e)
        {
            string titre = superListBox.SelectedItem.ToString();
            int id;
            if (listeSuper.TryGetValue(titre, out id))
            {
                ecritsListBox.Items.Add(titre);
                listeEcrits.Add(titre, id);
                listeSuper.Remove(titre);
                superListBox.Items.RemoveAt(superListBox.SelectedIndex);
                if (superListBox.Items.Count != 0)
                    superListBox.SelectedIndex = 0;
                ecritsListBox.SelectedIndex = 0;
            }

            tryLockControls();
        }

        private void swapSuperBouton_Click(object sender, EventArgs e)
        {
            string titre = ouvragesDispoListBox.SelectedItem.ToString();
            if (!alreadySupervised(titre))
            {
                int id;
                if (listeOuvragesDispo.TryGetValue(titre, out id))
                {
                    superListBox.Items.Add(titre);
                    listeSuper.Add(titre, id);
                    listeOuvragesDispo.Remove(titre);
                    ouvragesDispoListBox.Items.RemoveAt(ouvragesDispoListBox.SelectedIndex);
                    if (ouvragesDispoListBox.Items.Count != 0)
                        ouvragesDispoListBox.SelectedIndex = 0;
                    superListBox.SelectedIndex = 0;
                }

                tryLockControls();
            }
            else
                showErrorAlreadySupervised(titre);
        }

        private bool alreadySupervised(String titre)
        {
            DataTable ouvrages = this.ouvrageTableAdapter1.GetIDByTitre(titre);
            if (ouvrages.Rows.Count != 0)
            {
                return ouvrages.Rows[0].ItemArray[10].ToString().Equals("");
            }
            else
                return false;
        }

        private void showErrorAlreadySupervised(String titre)
        {
            MessageBox.Show("L'ouvrage \"" + titre + "\" est déjà supervisé par un autre auteur.\nIl n'est pas possible d'attribuer plus d'un superviseur par ouvrage.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void removeSuperBouton_Click(object sender, EventArgs e)
        {
            string titre = superListBox.SelectedItem.ToString();
            int id;
            if (listeSuper.TryGetValue(titre, out id))
            {
                ouvragesDispoListBox.Items.Add(titre);
                listeOuvragesDispo.Add(titre, id);
                listeSuper.Remove(titre);
                superListBox.Items.RemoveAt(superListBox.SelectedIndex);
                if (superListBox.Items.Count != 0)
                    superListBox.SelectedIndex = 0;
                ouvragesDispoListBox.SelectedIndex = 0;
            }

            tryLockControls();
        }

        private void cancelBouton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void ajouterBouton_Click(object sender, EventArgs e)
        {
            if (filled_Minimum())
            {
                if (!selected_Ouvrages())
                {
                    var res = MessageBox.Show("Vous n'avez pas attribué d'ouvrage(s) à cet auteur.\nContinuer ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.Yes)
                        addAuteur();
                    else
                        return;
                }
                else
                    addAuteur();

                this.Dispose();
            }
            else
                MessageBox.Show("Veuillez remplir au minimum les champs suivants:\n\tNom\n\tPrénom\n\tStatut", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool filled_Minimum()
        {
            return nomTextBox.Text != ""
                && prenomTextBox.Text != ""
                && statutComboBox.SelectedItem != null;
        }

        private bool selected_Ouvrages()
        {
            return ecritsListBox.SelectedItem != null
                || superListBox.SelectedItem != null;
        }

        private void addAuteur()
        {
            String nom, prenom, statut;
            nom = nomTextBox.Text;
            prenom = prenomTextBox.Text;
            statut = statutComboBox.SelectedItem.ToString();

            this.auteurSuperviseurTableAdapter1.AddNewAuteur(nom, prenom, statut);
            appendOuvrages(nom, prenom);
        }

        private void appendOuvrages(String nom, String prenom)
        {
            DataTable auteurs = auteurSuperviseurTableAdapter1.GetIDByName(nom,prenom);
            int idAuteur;
            if (auteurs.Rows.Count != 0)
            {
                idAuteur = Convert.ToInt32(auteurs.Rows[0].ItemArray[0].ToString());
                int idOuvrage;
                foreach (var ecrit in ecritsListBox.Items)
                {
                    if (listeEcrits.TryGetValue(ecrit.ToString(), out idOuvrage))
                    {
                        ecrireTableAdapter1.InsertEcrire(idAuteur, idOuvrage);
                    }
                }
            }
            //TODO: finir appendOuvrages (partie supervisions)
            //if(
        }
    }
}
