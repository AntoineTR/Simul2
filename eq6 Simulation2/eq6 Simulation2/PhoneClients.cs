﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using LUJR.Helpers;
using LUJR.Models;

namespace eq6_Simulation2
{
    public partial class PhoneClients : Form
    {
        #region Vars
        private bool mPaused = false;
        private CultureInfo ci = CultureInfo.InstalledUICulture;
        private int mCallTimer = 0;
        private Employee mEmployee;
        private string mEmployeeName;
        private int mCurrentCallID;
        private int mLastAnswerClicked = 0;
        #endregion

        #region Initialize + Constructor
        private void Form_Load(object sender, EventArgs e)
        {
            // Start timer
            mPaused = false;
            tmrCall.Start();
            tick();
            // Start calling
            nextCall();
        }
        public PhoneClients(int pEmployeeID)
        {
            InitializeComponent();
            lblLang.Text = ci.DisplayName;
            // Get info of emp
            mEmployee = EmployeeDAL.Current.GetOne(pEmployeeID);
            mEmployeeName = PersonDAL.Current.GetOne(mEmployee.PersonID).LastName;
        }
        #endregion Initialize + Constructor

        #region Utilitaires + Funcs
        private void MapFsUP(KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                btnHappy.PerformClick();

            }
            if (e.KeyData == Keys.F2)
            {
                btnUnhappy.PerformClick();

            }
            if (e.KeyData == Keys.F3)
            {
                btnNeutral.PerformClick();

            }
            if (e.KeyData == Keys.F4)
            {
                btnNoAnswer.PerformClick();

            }

        }
        private void ClearFlat()
        {
            btnNoAnswer.FlatAppearance.BorderColor = Color.Black;
            btnNoAnswer.FlatAppearance.BorderSize = 1;
            btnHappy.FlatAppearance.BorderColor = Color.Black;
            btnHappy.FlatAppearance.BorderSize = 1;
            btnUnhappy.FlatAppearance.BorderColor = Color.Black;
            btnUnhappy.FlatAppearance.BorderSize = 1;
            btnNeutral.FlatAppearance.BorderColor = Color.Black;
            btnNeutral.FlatAppearance.BorderSize = 1;

        }
        public void tick()
        {
            mCallTimer += 1;
            lblTimer.Text = String.Format("{0:00}", mCallTimer / 60) + ":" + String.Format("{0:00}", mCallTimer % 60);
        }
        public void saveCall() 
        {
            DatabaseAccess tDA = new DatabaseAccess("[Survey].[SaveCall]");
            tDA.AddParam("@CallID", mCurrentCallID);
            tDA.AddParam("@AnswerID", mLastAnswerClicked);
            tDA.AddParam("@CallLength", mCallTimer);
            tDA.AddParam("@Comments", rtbComment.Text.Trim() == "Commentaires..." ? "" : rtbComment.Text.Trim());
            
            tDA.Execute();

            tDA.Dispose();

            mCallTimer = 0;
            mLastAnswerClicked = 0;
            ClearFlat();
        }
        public void nextCall() 
        {
            DatabaseAccess tDA = new DatabaseAccess("[Survey].[NextCall]");
            tDA.AddParam("@EmpID", mEmployee.ID);
            
            SqlDataReader r;
            try
            {
                r = tDA.GetReader();
            }
            catch (SqlException ex)
            {
                r = null;
            }

            if (r != null && r.Read())
            {
                mCurrentCallID = (int)r["CallID"];

                txtText.Text = "Bonjour Monsieur " + r["NameClient"] + ", "
                    + "Je suis Monsieur " + mEmployeeName + ", je travaille pour la firme de sondage Baboubine. " +
                    "Aimeriez-vous participer à un concours afin de courir la chance de gagner une Porsche? " +
                    "Pour participer il ne suffit que de 3 minutes de votre temps pour effectuer un court sondage sur votre achat de " + r["ItemBought"] + " chez " + r["Company"] + ". " +
                    "Êtes-vous satisfait du produit acheté?";
                lblTitle.Text = r["NameClient"] + " - " + r["Phone"];
                this.Text = (string)r["NameClient"];
                rtbComment.Text = "Commentaires...";
                rtbComment.BackColor = Color.Gainsboro;
                btnPause.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\pause.png");
                btnHappy.Focus();
            }
            else 
            {
                lblTitle.Text = "";
                rtbComment.Text = "";
                txtText.Text = "";
                MessageBox.Show("Tous les appels a effectuer ont été faits!", "Fini", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            tDA.Dispose();
        }
        #endregion

        #region Events
        private void btnHappy_Click(object sender, EventArgs e)
        {
            rtbComment.Enabled = false;
            rtbComment.BackColor = Color.Gainsboro;
            btnNext.Focus();
            ClearFlat();
            btnHappy.FlatAppearance.BorderColor = Color.DarkBlue;
            btnHappy.FlatAppearance.BorderSize = 3;
            mLastAnswerClicked = 1;
        }
        private void btnUnhappy_Click(object sender, EventArgs e)
        {
            rtbComment.Enabled = true;
            rtbComment.BackColor = Color.White;
            rtbComment.Focus();
            ClearFlat();
                btnUnhappy.FlatAppearance.BorderColor = Color.DarkBlue;
                btnUnhappy.FlatAppearance.BorderSize = 3;
            rtbComment.Text = "";
            mLastAnswerClicked = 2;
        }
        private void btnNeutral_Click(object sender, EventArgs e)
        {
            rtbComment.Enabled = false;
            rtbComment.BackColor = Color.Gainsboro;
            btnNext.Focus();

            ClearFlat();
            btnNeutral.FlatAppearance.BorderColor = Color.DarkBlue;
            btnNeutral.FlatAppearance.BorderSize = 3;
            mLastAnswerClicked = 4;
        }
        private void btnNoAnswer_Click(object sender, EventArgs e)
        {
            rtbComment.Enabled = false;
            rtbComment.BackColor = Color.Gainsboro;
            btnNext.Focus();
            ClearFlat();
            btnNoAnswer.FlatAppearance.BorderColor = Color.DarkBlue;
            btnNoAnswer.FlatAppearance.BorderSize = 3;
            mLastAnswerClicked = 3;
        }

        private void btns_KeyUp(object sender, KeyEventArgs e)
        {
            MapFsUP(e);    
        }
        
        private void PhoneClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
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
            tick();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (mLastAnswerClicked == 0)
            {
                MessageBox.Show("Vous devez sélectionner une réponse", "Aucune réponse choisie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            saveCall();
            nextCall();
        }
        #endregion Events
    }
}
