using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Alimentation_BDD
{
    class TableNiveau
    {
        public List<Niveau> GetAll()
        {
            ConnectionMySql Cnx = new ConnectionMySql();
            MySqlConnection cnx = Cnx.GetConnection();
            cnx.Open();
            List<Niveau> lesNiveaux = new List<Niveau>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "niveau";
            cmd.CommandType = CommandType.TableDirect;
            MySqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            while (Rdr.Read()) 
            {
                Niveau unNiveau = new Niveau(Rdr.GetInt32(0), Rdr.GetString(1));
                lesNiveaux.Add(unNiveau);
            }
            cnx.Close();
            return lesNiveaux;            
        }
    }
}
