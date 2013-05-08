using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LUJR.Models;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        int tEmployeeID = 0;
        if (txtUsername.Text.Length == 0) 
        {
            MessageBox.Show("Le nom d'utilisateur ne peut être vide", "Nom d'utilisateur vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtUsername.Focus();
        }
        else if (txtPassword.Text.Length == 0) 
        {
            MessageBox.Show("Le mot de passe ne peut être vide", "Mot de passe vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPassword.Focus();
        }
        else if (!EmployeeDAL.UsernameExists(txtUsername.Text.Trim()))
        {
            MessageBox.Show("Le nom d'utilisateur entré n'existe pas", "Nom d'utilisateur inexistant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtUsername.Focus();
        }
        else if ((tEmployeeID = EmployeeDAL.Authenticate(txtUsername.Text.Trim(), txtPassword.Text.Trim())) == 0)
        {
            MessageBox.Show("Le mot de passe entré est erroné", "Mot de passe erroné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPassword.Focus();
        }
        else 
        {
            this.Hide();
            eq6_Simulation2.CallsListToBegin tMainForm = new eq6_Simulation2.CallsListToBegin(tEmployeeID);
            tMainForm.Show(this);
        }
        txtPassword.Text = "";
    }
}
