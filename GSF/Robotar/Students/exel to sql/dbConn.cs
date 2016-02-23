using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace exel_to_sql
{
    class dbconn
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        MySqlCommand nySkipun;
        MySqlDataReader lesari = null;

        public dbconn(){
            inital();
        }

        private void inital(){
            server = "tsuts.tskoli.is";
            database = "2410982069_gsf_verk_1";//þarf dbname
            uid = "2410982069";
            password = "svolu2";
            string lol = "SERVER="+server+";DATABASE="+database+";UID="+uid+";PASSWORD="+password+";";

            connection = new MySqlConnection(lol);
        }
        private bool conn(){
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
                        Console.WriteLine("Cannot connect to server. Contact admin");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password");
                        break;
		            default: return false;
                break;
	            }
		        throw;
	        }
        }
        private bool close()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }
        public void insert(string skipun)
        {

            if (this.conn()==true)
            {
                MySqlCommand cmd = new MySqlCommand(skipun, connection);

                cmd.ExecuteNonQuery();

                this.close();
            }
        }
	/*
            UPDATE table_name
            SET column1=value1,column2=value2,...
            WHERE some_column=some_value;
         */
        public void update(string skipun)
        {
            //thessari method tharf ad breyta eftir hverju verkefni
            string sql = skipun;

            if (this.conn()==true)
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                this.close();
            }
        }
        public void delete(string skipun)
        {
            string sql = skipun;

            if (this.conn() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                this.close();
            }
        }
        public List<string> skipun(string skipunin)
        {
            List<string> log = new List<string>();
            string line = null;
            if (conn()==true)
            {
                nySkipun = new MySqlCommand(skipunin, connection);
                lesari = nySkipun.ExecuteReader();
                while (lesari.Read())
                {
                    for (int i = 0; i < lesari.FieldCount; i++)
                    {
                        line += lesari.GetValue(i).ToString()+":";
                    }
                    log.Add(line);
                }
                close();
                return log;
            }
            return log;
        }
    }
}
