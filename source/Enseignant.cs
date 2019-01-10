using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alimentation_BDD
{
    class Enseignant
    {
        //donées membres
        private int id;
        private string nom, prenom, login, Password;

        //Accesseurs
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Password1
        {
            get { return Password; }
            set { Password = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string GetLogin
        {
            get { return login; }
            set { login = value; }
        }

        //Constructeur
        public Enseignant(int id, string nom, string prenom, string login, string Password) 
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.Password = Password;
        }
    }
}
