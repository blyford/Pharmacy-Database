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
            ServCon entry;
            entry = new ServCon();
            string command = "select accessID from login where password = '" + Passwordtxt.Text + "' and username = '" + Usernametxt.Text + "'";
            string user = Usernametxt.Text;
            int access = entry.access(command);
            if (access > 0 && access < 4)
            {
                MessageBox.Show("Login Credentials Authenticated.  Welcome " + user + "!", "Login Successful");
                User.setdat(access,user);
                new TableChoose().Show();
                this.Hide();
                
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
            base.OnFormClosing(e);
        }
    
    }
    
}
