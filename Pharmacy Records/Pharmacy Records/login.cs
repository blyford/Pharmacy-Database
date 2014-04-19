using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharmacy_Records
{
    
    public partial class login : Form
    {

        string User = "Bill Clinton";
        string Passcode = "Food";


        public login()
        {
            InitializeComponent();
        }

        private void Pharmpic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t Pharmacy Database\n\t         Version 1.0\n\n By:     Chris Mentzer and Braden Lyford", "About");
        }
        
        private void loginbtn_Click(object sender, EventArgs e)
        {
            
            if (Passwordtxt.Text == Passcode && Usernametxt.Text == User)
            {
                MessageBox.Show("Login Credentials Authenticated.  Welcome " + User + "!", "Login Successful");
                new TableChoose().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect combination of Username or Password,\n\tplease try again.",
                "Incorrect Login");
                Usernametxt.Text = null;
                Passwordtxt.Text = null;
                Usernametxt.Focus();
                loginbtn.Enabled = false;
            }
        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {
            Passwordtxt.PasswordChar = '*';
            if (Usernametxt.Text != null && Passwordtxt.Text != null)
            {
                loginbtn.Enabled = true;
                AcceptButton = loginbtn;
            }
        }

    
    }
}
