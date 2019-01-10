using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Alimentation_BDD
{
    class TableClasse
    {
        public void Insert(Classe classe) 
        { //Année Scolaire (varchar(45)), idEnseignant (int), idNiveau(int)
            ConnectionMySql Cnx = new ConnectionMySql();
            MySqlConnection cnx = Cnx.GetConnection();           
            cnx.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into classe(anneeScolaire, idEnseignant, idNiveau) values (@annee, @idEnseignant, @idNiveau";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@annee", MySqlDbType.String);
            cmd.Parameters.Add("@idEnseignant", MySqlDbType.String);
            cmd.Parameters.Add("@idNiveau", MySqlDbType.String);
            cmd.Parameters["@annee"].Value = classe.AnneeScolaire;
            cmd.Parameters["@idEnseignant"].Value = classe.IdEnseignant;
            cmd.Parameters["@idNiveau"].Value = classe.IdNiveau+1;
            cmd.ExecuteNonQuery();
            cnx.Close();

        }
    }
}
