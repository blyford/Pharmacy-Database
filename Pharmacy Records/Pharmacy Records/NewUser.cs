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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            new TableChoose().Show();
            this.Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            ServCon mnginput;
            mnginput = new ServCon();
            string userid = Username.Text;
            string pass = Password.Text;
            string seclvl = "1";
            if (User.clrnce() == 1 && Aclvl.Text != null)
                seclvl = Aclvl.Text;
            else if(User.clrnce() == 3 || User.clrnce() == 2)
                seclvl = "3";
            string SQLcommand = "insert into login values('" + userid + "','" + pass + "'," + seclvl + ");";
            mnginput.modify(SQLcommand);
            MessageBox.Show("Your account has been created successfully.", "Success");
            Username.Text = "";
            Password.Text = "";
            Aclvl.Text = "";

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            new login().Show();
            base.OnFormClosing(e);
        }
    }
}
