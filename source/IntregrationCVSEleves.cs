using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Alimentation_BDD
{
    public partial class IntregrationCVSEleves : Form
    {
        public IntregrationCVSEleves()
        {
            InitializeComponent();
            TableNiveau uneTableNiveau = new TableNiveau();
            List<Niveau> lesNiveaux = uneTableNiveau.GetAll();
            foreach (Niveau n in lesNiveaux)
            {
                cb_niveau.Items.Add(n.NiveauScolaire);
            }
            cbCSV.Click += new EventHandler(cb_fichiersave_Click);
            chb_Construit.Click += new EventHandler(chb_Construit_Click);
            chb_random.Click += new EventHandler(chb_random_Click);
        }

        //Pas les 2 boutons en même temps
        private void chb_random_Click(object sender, EventArgs e)
        {
            chb_Construit.Checked = false;
        }

        private void chb_Construit_Click(object sender, EventArgs e)
        {
            chb_random.Checked = false;
        }

        private void cb_fichiersave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            cb_fichiersave.Text = fbd.SelectedPath;
            if (cb_fichiersave.Text != "")
            {
                DirectoryInfo direct = new DirectoryInfo(@cbCSV.Text);
                FileInfo[] fichiers = direct.GetFiles("*.csv");
                foreach (FileInfo f in fichiers)
                {
                    cbCSV.Items.Add(f.Name);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd2 = new FolderBrowserDialog();
            string loaded = fbd2.SelectedPath + "/" + Convert.ToString(cbCSV.SelectedItem);
            string create = fbd2.SelectedPath;
            LesEleves lesEleves = new LesEleves();
            PasswordType type;
            if (tb_annéescolaire.Text != "")
            {
                if (cb_niveau.Text != "")
                {
                    if (chb_random.Checked == true || chb_Construit.Checked == true)
                    {
                        if (chb_random.Checked == true)
                        {
                            type = PasswordType.Aléatoire;
                        }
                        else
                        {
                            type = PasswordType.Construit;
                        }
                        List<Eleve> lesNomsEleves = lesEleves.LoadCsv(type);
                        TableEnseignant uneTableEnseignant = new TableEnseignant();
                        Enseignant unEnseignant = uneTableEnseignant.GetByLogin("enseignant@sio.jjr.fr");
                        Classe uneClasse = new Classe(unEnseignant.Id, tb_annéescolaire.Text, cb_niveau.SelectedIndex);
                        TableClasse uneTableClasse = new TableClasse();
                        uneTableClasse.Insert(uneClasse);
                        TableEleve uneTableEleve = new TableEleve();
                        foreach (Eleve eleve in lesNomsEleves)
                        {
                            uneTableEleve.Insert(eleve);
                        }
                        lesEleves.CreateCvsPasswordFile(create + "/" + tb_annéescolaire.Text + cb_niveau.Text);
                        MessageBox.Show("Intégration réussie");
                    }

                    else
                    {
                        MessageBox.Show("Sélectionné un type de mot de passe");
                    }
                }

                else
                {
                    MessageBox.Show("Sélectionné un niveau scolaire");
                }
            }
            else
            {
                MessageBox.Show("Sélectionné une année scolaire");
            }
            
        }

    }
}
