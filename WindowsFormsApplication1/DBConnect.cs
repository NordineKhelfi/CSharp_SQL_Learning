using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class DBConnect
    {


        public MySqlConnection sqlConnect;
        string table;


        public DBConnect(string server, string database, string uid, string password, string table)
        {
            this.table = table;
            sqlConnect = new MySqlConnection("SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password + ";");
        }


        //open connection
        public bool OpenConnection()
        {

            try
            {
                sqlConnect.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //close connection
        public void CloseConnection()
        {
            try
            {
                sqlConnect.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //insert statement
        public void Insert(string name, int age)
        {
            string query;
            if (age != 0)
                query = "INSERT INTO " + table + " (name, age) VALUES('" + name + "', '" + age.ToString() + "');";
            else
                query = "INSERT INTO " + table + " (name) VALUES('" + name + "');";

            MySqlCommand sqlCmd = new MySqlCommand(query, sqlConnect);

            sqlCmd.ExecuteNonQuery();

        }



        //Select statement
        public List<String>[] Select()
        {
            string query = "SELECT * from " + table;

            List<String>[] lists = new List<string>[3];
            lists[0] = new List<string>();
            lists[1] = new List<string>();
            lists[2] = new List<string>();

            if (sqlConnect.State == System.Data.ConnectionState.Open)
            {
                MySqlCommand sqlCmd = new MySqlCommand(query, sqlConnect);

                //Create a data reader and execute the command
                MySqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

                //Read the data and store them in the lists
                if (sqlDataReader.HasRows)
                    while (sqlDataReader.Read())
                    {
                        lists[0].Add(sqlDataReader["id"] + "");
                        lists[1].Add(sqlDataReader["name"] + "");
                        lists[2].Add(sqlDataReader["age"] + "");
                    }
                else
                    MessageBox.Show("Data Reader hasn't rows.");
                //Close data reader
                sqlDataReader.Close();

                return lists;
            }
            else
                return lists;
        }



        //Delete statement
        public void Delete(string name)
        {
            string query = "DELETE FROM " + table + " WHERE name='" + name + "';";

            if(sqlConnect.State == System.Data.ConnectionState.Open)
            {
                MySqlCommand sqlCmd = new MySqlCommand(query, sqlConnect);
                sqlCmd.ExecuteNonQuery();
            }
        }



    }
}
