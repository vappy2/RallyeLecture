using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alimentation_BDD
{
    class Classe
    {
        //Données Membres
        private int idEnseignant, idNiveau;
        private string anneeScolaire;

    //Accesseurs
        public int IdNiveau
        {
            get { return idNiveau; }
            set { idNiveau = value; }
        }
 
        public int IdEnseignant
        {
            get { return idEnseignant; }
            set { idEnseignant = value; }
        }

        public string AnneeScolaire
        {
            get { return anneeScolaire; }
            set { anneeScolaire = value; }
        }
       
        //Constructeur
        public Classe(int idNiveau, string anneeScolaire, int idEnseignant)
        {
            this.anneeScolaire = anneeScolaire;
            this.idNiveau = idNiveau;
            this.idEnseignant = idEnseignant;
        }
    }
        
}
