using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Alimentation_BDD
{
    class TableEnseignant
    {
        public Enseignant GetByLogin(string login)
        {
            //connexion à la base de données
            ConnectionMySql Cnx = new ConnectionMySql();
            MySqlConnection cnx = Cnx.GetConnection(); 

            //Création des listes pour stocké les informations
            List<string> utilisateur = new List<string>();
            List<Enseignant> lesEnseignants = new List<Enseignant>();
            List<int> id = new List<int>();
            List<string> nom = new List<string>();
            List<string> prenom = new List<string>();
            List<string> LoginEnseignant = new List<string>();
            List<int> idAuth = new List<int>();
            cnx.Open();

            //Stocker les données dans les listes
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "enseignant";
            cmd.CommandType = CommandType.TableDirect;
            MySqlDataReader Rdr = cmd.ExecuteReader();
            while (Rdr.Read())
            {
                id.Add((int)Rdr[0]);
                nom.Add((string)Rdr[1]);
                prenom.Add((string)Rdr[2]);
                LoginEnseignant.Add((string)Rdr[3]);
                idAuth.Add((int)Rdr[4]);
            }
            cnx.Close();

            //Création des enseignants 
            for (int i = 0; i < id.Count; i++)
            {
                cnx.Open();
                MySqlCommand cmd1 = new MySqlCommand();
                cmd1.Connection = cnx;
                cmd1.CommandText = "select pass, username from aauth_users where id=@id";
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.Add("@id", MySqlDbType.Int32);
                cmd1.Parameters["@id"].Value = idAuth[i];
                MySqlDataReader Rdr1 = cmd.ExecuteReader();
                while (Rdr1.Read())
                {
                    Enseignant unEnseignant = new Enseignant(id[i], nom[i], prenom[i], LoginEnseignant[i], (string)Rdr1[0]);
                    lesEnseignants.Add(unEnseignant);
                }
                cnx.Close();

                //On attribue chaque login à chaque enseignant 
                foreach (Enseignant e in lesEnseignants)
                {
                    if (e.GetLogin == login)
                    {
                        return e;
                    }
                }
            }
            return null;
        }
    }
}
