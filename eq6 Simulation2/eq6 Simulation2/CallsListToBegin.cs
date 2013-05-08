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
    public partial class CallsListToBegin : Form
    {
        private int mEmployeeID = 0;

        public CallsListToBegin(int pEmployeeID)
        {
            mEmployeeID = pEmployeeID;
            InitializeComponent();
        }

        private void btnBeginCalls_Click(object sender, EventArgs e)
        {
            PhoneClients leTemp = new PhoneClients();
            leTemp.Show();

        }
    }
}
