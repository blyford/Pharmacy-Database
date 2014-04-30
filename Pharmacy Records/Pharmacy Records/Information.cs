using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Pharmacy_Records
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServCon mnginput;
            mnginput = new ServCon();
            string managerID = mngID.Text;
            string mngfname = fnamebox.Text;
            string mnglname = lnamebox.Text;

            string SQLcommand = "insert into login values(" + managerID + ",'" + mngfname + "','" + mnglname + "')";
            mnginput.modify(SQLcommand);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            ServCon mnginput;
            mnginput = new ServCon();
            string managerID = mngID.Text;
            string mngfname = fnamebox.Text;
            string mnglname = lnamebox.Text;

            string SQLcommand = "update login set username = '" + mngfname + "', lastname = '" + mnglname + "' where mngID = " + managerID;
            mnginput.modify(SQLcommand);
            MessageBox.Show("The Information has been Updated", "Query Successful");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ServCon mnginput;
            mnginput = new ServCon();
            string managerID = mngID.Text;
            string mngfname = fnamebox.Text;
            string mnglname = lnamebox.Text;

            string SQLcommand = "delete from login where username = " + managerID;
            mnginput.modify(SQLcommand);
        }

        private void Dataoutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            
            ServCon mngout;
            mngout = new ServCon();
            if (Fullreport.Checked == true)
            {
                string command = "select * from sale";
                string[] results = mngout.query(command);
                int i = 0;
                while(results[i] != null)
                {
                    Dataoutput.Items.Add(results[i]);
                    i++;
                }
            }
            else if (YearSal.Checked == true)
            {
                Dataoutput.Items.Add("Under Constuction!");
            }
            else if (Names.Checked == true)
            {
                Dataoutput.Items.Add("Under Constuction!");
            }
            else
            {
                MessageBox.Show("No searches selected.\nPlease select a search type.", "Search Error");
            }
        }

        private void Information_Load(object sender, EventArgs e)
        {
            if (User.clrnce() == 3)
            {
                mngID.Hide();
                label7.Hide();                    
            }
        }

    }
}
