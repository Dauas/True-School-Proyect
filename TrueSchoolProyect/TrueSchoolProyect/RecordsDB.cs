using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TrueSchoolProyect
{
    class RecordsDB
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public RecordsDB()
        {
            server = "sql3.freemysqlhosting.net";
            database = "sql374402";
            uid = "sql374402";
            password = "lF2%jQ1!";
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
            catch (MySqlException e)
            {
                switch(e.Number)
                {
                    case 0:
                        //Server Conn Error
                        Console.WriteLine("Server Connection Error");
                        break;

                    case 1045:
                        //Wrong Username or Password
                        Console.WriteLine("Wrong Username or Password");
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
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        public List<string>[] SelectHighScores()
        {
            string query = "SELECT * FROM scores ORDER BY score DESC LIMIT 5";
            //string mime490score = "";
            List<string>[] ScoreList = new List<string>[3];
            ScoreList[0] = new List<string>();
            ScoreList[1] = new List<string>();
            ScoreList[2] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //mime490score = dataReader.GetString(1).ToString();

                while (dataReader.Read())
                {
                    ScoreList[0].Add(dataReader["id"] + "");
                    ScoreList[1].Add(dataReader["username"] + "");
                    ScoreList[2].Add(dataReader["score"] + "");
                }

                dataReader.Close();

                this.CloseConnection();

                return ScoreList;
            }
            return ScoreList;
        }
        public void WriteNewScore(string newusername,int newscore)
        {
            string query = "INSERT INTO scores (username, score) VALUES ('"+newusername+"','"+newscore+"')";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;

                cmd.ExecuteNonQuery();

                this.CloseConnection();

            }
        }
    }
}
