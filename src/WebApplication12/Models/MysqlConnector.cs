using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Configuration;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication12.Models
{
   
    public class MysqlConnector
    {
        public string test_name { get; set; }
        public string test_role { get; set; }

        private MySqlConnection connectio;
        


        
        public MysqlConnector()
        {

            connect();
            MySqlCommand query = new MySqlCommand();
            query.Connection = connectio;
            query.CommandText = string.Format("Select * from users");

            MySqlDataReader reader = query.ExecuteReader();

            reader.Read();
            try
            {
                test_name = reader.GetString(1);
                test_role = reader.GetString(2);
                reader.Close();
            }
            catch (Exception err)
            {
                test_name = err.ToString();
                test_role = err.ToString();
                reader.Close();

            }
        }


        private void connect()
        {

           
            string ConnectionString="server=localhost ;database=xdata; uid=root ; pwd=1234";

            connectio = new MySqlConnection(ConnectionString);
            connectio.Open();
            
            

        }

                   
    
    }

}
