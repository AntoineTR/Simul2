using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LUJR.Models;

namespace eq6_Simulation2
{
    public partial class CallsListToBegin : Form
    {
        private int mEmployeeID = 0;

        public CallsListToBegin(int pEmployeeID)
        {
            mEmployeeID = pEmployeeID;

            InitializeComponent();
            lblTitle.Text = "Bonjour, " + EmployeeDAL.GetUsernameByID(mEmployeeID) + " !"; 
        }

        private void btnBeginCalls_Click(object sender, EventArgs e)
        {
            PhoneClients form = new PhoneClients();
            form.Show();
        }

        #region Methodes
        #endregion 
    }
}
