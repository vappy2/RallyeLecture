using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Alimentation_BDD
{
    class LesEleves
    {
        List<Eleve> lesEleves;

        public LesEleves()
        {
            lesEleves = new List<Eleve>();            
        }

        public void CreateCvsPasswordFile(string nomfichier)
        {
            StreamWriter sw = new StreamWriter(nomfichier+".csv");
            sw.WriteLine("login");
            foreach (Eleve e in lesEleves)
            {
                sw.WriteLine("{0}", e.Login);
            }
            sw.Close();                       
        }

        public List<Eleve> LoadCsv(PasswordType type)
        {
            string ligne;
            StreamReader newCSV = new StreamReader("maClasseCm2_2018.csv");
            lesEleves = new List<Eleve>();
            ligne = newCSV.ReadLine();
            while (ligne != null)
            {                
                string[] read = ligne.Split(';');
                string login = read[1] + read[0] + "@sio.jjr.fr";
                Eleve unEleve = new Eleve(read[0], read[1],login);
                lesEleves.Add(unEleve);
                ligne = newCSV.ReadLine();
            }  
            return lesEleves;
        }
    }
}
