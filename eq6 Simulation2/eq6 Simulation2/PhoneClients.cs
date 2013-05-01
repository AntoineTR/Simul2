using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eq6_Simulation2
{
    public partial class PhoneClients : Form
    {
        public PhoneClients()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNomClient.Text = "Crevier";
            lblNomEntreprise.Text = "BMW";
        }
    }
}
