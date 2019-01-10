using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alimentation_BDD
{
    class Niveau
    {
        //données membres
        private int id;
        private string niveauScolaire;

        //Accesseurs
        public string NiveauScolaire
        {
            get { return niveauScolaire; }
            set { niveauScolaire = value; }
        }

        //Constructeur
        public Niveau(int id, string niveauScolaire) 
        {
            this.id = id;
            this.niveauScolaire = niveauScolaire;
        }
    }
}
