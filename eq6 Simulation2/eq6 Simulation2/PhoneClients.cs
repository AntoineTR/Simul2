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
            txtConv.Text = "Bonjour Monsieur Tremblay, "
                + "Je suis Monsieur Crevier, je travaille pour la firme de sondage Baboubine." +
                "Aimeriez-vous participer à un concours afin de courir la chance de gagner une Porsche ?" +
                "Pour participer il ne suffit que de 3 minutes de votre temps pour effectuer un court sondage sur votre achat de canapé chez Brault et Martineau. "+
                "Êtes-vous satisfait du produit acheté?";
            
        }

        private void grbConversation_Enter(object sender, EventArgs e)
        {

        }
    }
}
