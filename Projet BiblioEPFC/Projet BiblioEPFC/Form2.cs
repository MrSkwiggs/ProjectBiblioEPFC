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
        private int SELECTEDOUVRAGE;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int idOuvrage)
        {
            this.SELECTEDOUVRAGE = idOuvrage;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
