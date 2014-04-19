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
    public partial class TableChoose : Form
    {
        public TableChoose()
        {
            InitializeComponent();
        }

        private void TableChoose_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Administration Data");
            comboBox1.Items.Add("Managment Information");
            comboBox1.Items.Add("Employee Information");
            comboBox1.Items.Add("Customer Information");
            comboBox1.Items.Add("Sales Data");
            comboBox1.Items.Add("Warehouse Data");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void modbutton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Managment Information")
            {
                new Information().Show();
            }
            else if (comboBox1.SelectedItem == "Administration Data")
            {
                MessageBox.Show("You do not have access to this table.", "Access Denied");
                new Information().Show();
            }
            else if (comboBox1.SelectedItem == "Employee Information")
            {
                MessageBox.Show("You do not have access to this table.", "Access Denied");
                new Information().Show();
            }
            else if (comboBox1.SelectedItem == "Customer Information")
            {
                MessageBox.Show("You do not have access to this table.", "Access Denied");
                new Information().Show();
            }
            else if (comboBox1.SelectedItem == "Sales Data")
            {
                MessageBox.Show("You do not have access to this table.", "Access Denied");
                new Information().Show();
            }
            else if (comboBox1.SelectedItem == "Warehouse Data")
            {
                MessageBox.Show("You do not have access to this table.", "Access Denied");
                new Information().Show();
            }
            else
            {
                MessageBox.Show("You must select a table from the list!", "Database Error");
                new Information().Show();
            }


        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
