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
    public partial class CustomerData : Form
    {
        public CustomerData()
        {
            InitializeComponent();
        }

        private void CustomerData_Load(object sender, EventArgs e)
        {
            Cname.Text = User.person();
            ServCon custout;
            custout = new ServCon();
            if(User.clrnce() == 3)
            {
                string command = "select * from customer where cstusername = '" + User.person() + "'";
                string[] results = custout.query(command);
                int i = 0;
                while (results[i] != null)
                {
                    custlist.Items.Add(results[i];
                    i++;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new NewUser().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TableChoose().Show();
            this.Close();
        }
    }
}
