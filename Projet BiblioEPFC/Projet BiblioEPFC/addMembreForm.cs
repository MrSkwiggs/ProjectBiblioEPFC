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
    public partial class addMembreForm : Form
    {
        public addMembreForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cancelBouton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void addMembreForm_Load(object sender, EventArgs e)
        {

        }

        private void ajouterBouton_Click(object sender, EventArgs e)
        {
            if (filledAll())
            {
                String nom, prenom, tel, rue, ville;
                short num, cp;
                nom = nomTextBox.Text;
                prenom = prenomTextBox.Text;
                tel = telTextBox.Text;
                rue = rueTextBox.Text;
                num = Convert.ToInt16(numTextBox.Text);
                cp = Convert.ToInt16(cpTextBox.Text);
                ville = villeTextBox.Text;

                if (!alreadyExists(nom, prenom))
                {
                    this.membreTableAdapter1.AddMembre(nom, prenom, rue, num, cp, ville, tel);
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                else
                    MessageBox.Show("Un membre du même nom existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool filledAll()
        {
            return !nomTextBox.Text.Equals("")
                && !prenomTextBox.Text.Equals("")
                && !telTextBox.Text.Equals("")
                && !rueTextBox.Text.Equals("")
                && !numTextBox.Text.Equals("")
                && !cpTextBox.Text.Equals("")
                && !villeTextBox.Text.Equals("");
        }

        private bool alreadyExists(String nom, String prenom)
        {
            DataTable membres = this.membreTableAdapter1.GetDataByNom(nom, prenom);
            foreach (DataRow membre in membres.Rows)
                return true;
            return false;
        }
    }
}
