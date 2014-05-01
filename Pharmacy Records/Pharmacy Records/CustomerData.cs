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
            int check = User.clrnce();
            custout = new ServCon();
            //if(User.clrnce() == 3)
            //{
                string command = "select * from customer where cstusername = '" + User.person() + "'";
                string[] results = custout.query(command);
                int i = 0;
                while (results[i] != null)
                {
                    custdat.Items.Add(results[i]);
                    i++;
                }
            
            //}
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cquery_Click(object sender, EventArgs e)
        {
            ServCon custout;
            custout = new ServCon();
            string command = "";
            if (cSale.Checked)
                command = "select * from sale, customer where sale.cstID = customer.cstID and cstusername = '" + User.person() + "'";
            else if (cScript.Checked)
                command = "select * from perscription, sale, customer where perscription.saleid = sale.saleid and sale.cstID = customer.cstID and customer.cstusername = '" + User.person() + "'";
            else if (cDrug.Checked)
                command = "select * from drug, perscription, sale, customer where drug.drugID = perscription.drugID and perscription.saleID = sale.saleID and sale.cstid = customer.cstid and customer.cstusername = '" + User.person() + "'";
            string[] results = custout.query(command);
            int i = 0;
            while (results[i] != null)
            {
                //results[i] += '\n';
                custdat.Items.Add(results[i]);
                i++;
            }
        }

        private void Cupdate_Click(object sender, EventArgs e)
        {
            new NewUser().Show();
            this.Close();
        }

        private void CBack_Click(object sender, EventArgs e)
        {
            new TableChoose().Show();
            this.Close();
        }

    }

}
