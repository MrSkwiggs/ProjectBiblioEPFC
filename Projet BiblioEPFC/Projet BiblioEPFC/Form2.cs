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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int membre, ouvrage;
            short duree;
            String date;
            membre = Convert.ToInt32(this.membreBox.Text);
            ouvrage = Convert.ToInt32(this.ouvrageBox.Text);
            duree = Convert.ToInt16(this.dureeBox.Text);
            date = this.dateTimePicker1.Text;
            this.reserverTableAdapter1.InsertQuery(membre, ouvrage, date, duree);
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
