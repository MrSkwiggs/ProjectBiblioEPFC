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
    public partial class addTypeForm : Form
    {
        public addTypeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void addTypeForm_Load(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text.Length <= 4)
                sigleTextBox.Text = descriptionTextBox.Text;
            else
                sigleTextBox.Text = descriptionTextBox.Text.Substring(0, 4);
        }

        private void ajouterBouton_Click(object sender, EventArgs e)
        {
            if (!filledAll())
                MessageBox.Show("Veuillez remplir tous les champs\n(le champ sigle doit contenir 4 lettres)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                this.typeTableAdapter1.AddType(descriptionTextBox.Text, sigleTextBox.Text);
                this.Dispose();
            }
        }

        private bool filledAll()
        {
            return descriptionTextBox.Text.Length != 0 && sigleTextBox.Text.Length == 4;
        }

        private void cancelBouton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
