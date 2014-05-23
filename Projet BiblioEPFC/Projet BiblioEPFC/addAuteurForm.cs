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
        public addAuteurForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void addAuteurForm_Load(object sender, EventArgs e)
        {
            fill_OuvragesDispo();
        }

        private void fill_OuvragesDispo()
        {
            DataTable ouvrages = this.ouvrageTableAdapter1.GetData();

            ouvragesDispoListBox.DisplayMember = ouvrages.Columns[1].ColumnName;
            ouvragesDispoListBox.ValueMember = ouvrages.Columns[0].ColumnName;
        }
    }
}
