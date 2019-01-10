using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Alimentation_BDD
{
    class TableEleve
    {
        public void Insert(Eleve eleve)
        {
            //Connexion
            ConnectionMySql Cnx = new ConnectionMySql();
            MySqlConnection cnx = Cnx.GetConnection(); 

            //Récupérer l'id de la classe
            cnx.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "select max(id) from classe";
            cmd.CommandType = CommandType.Text;
            int idClasse = (int)cmd.ExecuteScalar();
            cnx.Close();

            //Hashage mdp
            Hash ha = new Hash();
            string mdph = ha.GetHashPassword(eleve.Password);

            //Insérer dans la table aauth_user
            string PrenomElve;
            cnx.Open();
            MySqlCommand cmd1 = new MySqlCommand();
            cmd1.CommandText = "insert into aauth_users(email, pass, username) values(@email, @pass, @user)";
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("@email", MySqlDbType.String);
            cmd1.Parameters.Add("@pass", MySqlDbType.String);
            cmd1.Parameters.Add("@username", MySqlDbType.String);
            cmd1.Parameters["@pass"].Value = mdph;
            PrenomElve = eleve.Prenom;
            cmd1.Parameters["@username"].Value = PrenomElve[0] + eleve.Nom;
            cmd1.Parameters["@email"].Value = eleve.Nom + PrenomElve + "@sio.jjr.fr";
            cmd1.ExecuteNonQuery();
            cnx.Close();

            //Select l'ID maximum dans la table aauht_users
            cnx.Open();
            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Connection = cnx;
            cmd2.CommandText = "select max(id) from aauth_users";
            cmd2.CommandType = CommandType.Text;
            int idA = Convert.ToInt32(cmd2.ExecuteScalar());
            cnx.Close();

            //Insérer l'élève dans la table Eleve 
            cnx.Open();
            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = cnx;
            cmd3.CommandText = "insert into elev(idclasse, nom, prenom, login, idAuth) value (@idclasse, @nom, @prenom, @login, @idAuth)";
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.Add("@idClasse", MySqlDbType.Int32);
            cmd3.Parameters.Add("@nom", MySqlDbType.String);
            cmd3.Parameters.Add("@prenom", MySqlDbType.String);
            cmd3.Parameters.Add("@login", MySqlDbType.String);
            cmd3.Parameters.Add("@idAuth", MySqlDbType.Int32);
            cmd3.Parameters["@idClasse"].Value = idClasse;
            cmd3.Parameters["@nom"].Value = eleve.Nom;
            cmd3.Parameters["@prenom"].Value = PrenomElve;
            cmd3.Parameters["@login"].Value = eleve.Login;
            cmd3.Parameters["@idAuth"].Value = idA;
            cmd3.ExecuteNonQuery();
            cnx.Close();

            //Insertion de l'élève dans Aauth_user_to_group
            cnx.Open();
            MySqlCommand cmd4 = new MySqlCommand();
            cmd4.Connection = cnx;
            cmd4.CommandText = "insert into aauth_user_to_group(user_id, group_id) values (@user, @group)";
            cmd4.CommandType = CommandType.Text;
            cmd4.Parameters.Add("@user", MySqlDbType.Int32);
            cmd4.Parameters.Add("@group", MySqlDbType.Int32);
            cmd4.Parameters["@user"].Value = idA;
            cmd4.Parameters["@group"].Value = 4;
            cnx.Close();
        }

    }
}

