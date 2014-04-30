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
            ServCon mnginput;
            mnginput = new ServCon();
            string userid = Username.Text;
            string pass = Password.Text;
            string seclvl = Aclvl.Text;
            string SQLcommand = "insert into login values('" + userid + "','" + pass + "'," + seclvl;

        }

        private void Back_Click(object sender, EventArgs e)
        {
            new TableChoose().Show();
            this.Close();
        }
    }
}
