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
            MessageBox.Show("Nom d'utilisateur vide", "Le nom d'utilisateur ne peut être vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if (txtPassword.Text.Length == 0) 
        {
            MessageBox.Show("Mot de passe vide", "Le mot de passe ne peut être vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if (!EmployeeDAL.UsernameExists(txtUsername.Text.Trim()))
        {
            MessageBox.Show("Nom d'utilisateur inexistant", "Le nom d'utilisateur entré n'existe pas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if ((tEmployeeID = EmployeeDAL.Authenticate(txtUsername.Text.Trim(), txtPassword.Text.Trim())) == 0)
        {
            MessageBox.Show("Mot de passe erroné", "Le mot de passe entré est erroné", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else 
        {
            this.Hide();
            eq6_Simulation2.CallsListToBegin tMainForm = new eq6_Simulation2.CallsListToBegin(tEmployeeID);
            tMainForm.Show(this);
        }
    }
}
