using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alimentation_BDD
{
    class Eleve
    {
        //données membres
        private string nom, prenom, login, password;
        Random random = new Random();

        //accesseurs
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }       

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        
        //Constructeur
        public Eleve(string nom, string prenom, string login)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;           
        } 
        public Eleve(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;          
        }

        //Méthodes
        private string GetpasswordAleatoire()
        {
            string min = "abcdefghijklmnopqrstuvwxyz";
            string maj = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string caracspe = "&@#";
            string chiffre = "123456789";
            string password = "";
            int positionMaj = random.Next(0, 8);
            int positionChiffre = positionMaj;
            int positionCS = positionMaj;

            while (positionChiffre == positionMaj)
            {
                positionChiffre = random.Next(0, 8);
            }

            while (positionCS == positionMaj) 
            {
                positionCS = random.Next(0, 8);
            }

            for (int i = 0; i < 9; i++) 
            {
                if (i == positionMaj || i == positionChiffre || i == positionCS)
                {
                    if (i == positionChiffre || i == positionCS)
                    {
                        if (i == positionChiffre)
                        {
                            password += chiffre[random.Next(0, chiffre.Count())];
                        }
                        else
                        {
                            password += caracspe[random.Next(0, caracspe.Count())];
                        }
                    }
                    else
                    {
                        password += maj[random.Next(0, maj.Count())];
                    }
                }
                else 
                {
                    password += min[random.Next(0, min.Count())];
                }
            }
            return password;
        }


        private string GetpasswordConstruit()
        {
            string password;
            password = Convert.ToString(prenom[0] + nom);
            return password;
        }
        
        public string GetNewPassword(PasswordType type)
        {            
            switch (type) 
            {
                case PasswordType.Construit :
                    return GetpasswordConstruit();
                    
                case PasswordType.Aléatoire :
                    return GetpasswordAleatoire();
                    
                default :
                    return GetpasswordAleatoire();                    
            }
        }
    }
}
