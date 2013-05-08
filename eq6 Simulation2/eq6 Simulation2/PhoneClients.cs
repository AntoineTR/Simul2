using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace eq6_Simulation2
{
    public partial class PhoneClients : Form
    {
        private bool mPaused = false;
        private CultureInfo ci = CultureInfo.InstalledUICulture;
        int i = 0;
        public PhoneClients()
        {
            InitializeComponent();
            lblLang.Text = ci.DisplayName;
            lblTimer.Text = i.ToString();
            tmrCall.Start();
        }

        private void Form_Load(object sender, EventArgs e)
        {
             

            txtText.Text = "Bonjour Monsieur Tremblay, "
                + "Je suis Monsieur Crevier, je travaille pour la firme de sondage Baboubine. " +
                "Aimeriez-vous participer à un concours afin de courir la chance de gagner une Porsche ? " + 
                "Pour participer il ne suffit que de 3 minutes de votre temps pour effectuer un court sondage sur votre achat de canapé chez Brault et Martineau. " +
                "Êtes-vous satisfait du produit acheté?";
            lblTitle.Text = "Jean Tremblay - 1 (514) 123-4567";
            this.Text = "Jean Tremblay";
            rtbComment.Text = "Commentaires...";
            rtbComment.BackColor = Color.Gainsboro;
            btnPause.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\pause.png");
            btnHappy.Focus();
        }

        private void btnUnhappy_Click(object sender, EventArgs e)
        {
            rtbComment.Enabled = true;
            rtbComment.BackColor = Color.White;
            rtbComment.Focus();

            rtbComment.Text = ""; 
        }

        private void btnSelected(object sender, EventArgs e)
        {
            rtbComment.Enabled = false;
            rtbComment.BackColor = Color.Gainsboro;
            btnNext.Focus();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneClients));
            if (mPaused)
            {
                mPaused = false;
                tmrCall.Start();
                btnPause.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\pause.png");
            }
            else 
            {
                mPaused = true;
                tmrCall.Stop();
                btnPause.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\play.png");            
            }
        }

        private void tmrAppel_Tick(object sender, EventArgs e)
        {
            i += 1;
            lblTimer.Text = String.Format("{0:00}", i / 60) + ":" + String.Format("{0:00}", i % 60);
        }

    }
}
