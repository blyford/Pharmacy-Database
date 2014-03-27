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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {

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

            string SQLcommand = "insert into manager values(" + managerID + ",'" + mngfname + "','" + mnglname + "')";
            mnginput.execute(SQLcommand);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            ServCon mnginput;
            mnginput = new ServCon();
            string managerID = mngID.Text;
            string mngfname = fnamebox.Text;
            string mnglname = lnamebox.Text;

            string SQLcommand = "update manager set firstname = '" + mngfname + "', lastname = '" + mnglname + "' where mngID = " + managerID;
            mnginput.execute(SQLcommand);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ServCon mnginput;
            mnginput = new ServCon();
            string managerID = mngID.Text;
            string mngfname = fnamebox.Text;
            string mnglname = lnamebox.Text;

            string SQLcommand = "delete from manager where mngID = " + managerID;
            mnginput.execute(SQLcommand);
        }
    }
}
