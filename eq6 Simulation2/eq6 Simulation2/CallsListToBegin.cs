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

            FillListView(); 
        }

        private void btnBeginCalls_Click(object sender, EventArgs e)
        {
            PhoneClients leTemp = new PhoneClients(mEmployeeID);
            leTemp.ShowDialog(this);
        }
        #region Methodes
        public void FillListView()
        {
            IEnumerable<Survey> iSurveys = SurveyDAL.Current.GetAll();

            foreach (Survey survey in iSurveys)
            {
                Company c = CompanyDAL.Current.DB.FirstOrDefault<Company>("WHERE ID=@0", survey.CompanyID);
                
                ListViewItem listItem = new ListViewItem(c.Name);
                listItem.SubItems.Add(survey.DateStart.ToShortDateString());
                listItem.SubItems.Add(survey.DateEnd.ToShortDateString()); 
                lsvSurveys.Items.Add(listItem);
            }
        }
        #endregion 

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Owner.Close();
        }

        private void CallsListToBegin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Close();
        }
    }
}
