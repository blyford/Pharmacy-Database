using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy_Records
{
    class ServCon
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public ServCon()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "pharmacy";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Server Connection Failed, Contact your Administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid Username/Password.  Please try again.");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void modify(string query)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }

        public string[] query(string query)
        {
            string[] result = new string[20];
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        result[i] = "";
                     
                        int jmax = reader.FieldCount;
                        for(int j = 0; j < jmax; j++)
                        {
                            if (j % 5 == 4)
                                i++;
                            result[i] += " " + reader.GetString(j);
                        }
                        i++;
                    }
                }

                this.CloseConnection();
            }
            return result;
        }

        public int access(string access)
        {
           
            decimal level = 0;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(access,connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                        level = reader.GetDecimal(0);
                }
               
                this.CloseConnection();
            }
            return Convert.ToInt32(level);
            
         }

    }
}
