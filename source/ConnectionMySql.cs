using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Alimentation_BDD
{
    class ConnectionMySql
    {
        //private string user, passWord, database, server;
        private MySqlConnection mySqlconnection;


        public ConnectionMySql()
        {
            string sConnection;
            sConnection = "user=root; password=siojjr; database=rallyeLecture; host=172.16.0.173";
            mySqlconnection = new MySqlConnection(sConnection);
        }

         public MySqlConnection GetConnection()
        {
            return mySqlconnection;

        }
    }
}
