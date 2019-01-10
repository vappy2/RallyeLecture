namespace Alimentation_BDD
{
    partial class IntregrationCVSEleves
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chb_random = new System.Windows.Forms.CheckBox();
            this.chb_Construit = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_fichiersave = new System.Windows.Forms.ComboBox();
            this.cb_niveau = new System.Windows.Forms.ComboBox();
            this.tb_annéescolaire = new System.Windows.Forms.TextBox();
            this.cbCSV = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Répertoire des fichiers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fichier CSV à intégrer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Année Scolaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Niveau";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mot de passe";
            // 
            // chb_random
            // 
            this.chb_random.AutoSize = true;
            this.chb_random.Location = new System.Drawing.Point(131, 219);
            this.chb_random.Name = "chb_random";
            this.chb_random.Size = new System.Drawing.Size(67, 17);
            this.chb_random.TabIndex = 5;
            this.chb_random.Text = "Aléatoire";
            this.chb_random.UseVisualStyleBackColor = true;
            // 
            // chb_Construit
            // 
            this.chb_Construit.AutoSize = true;
            this.chb_Construit.Location = new System.Drawing.Point(281, 219);
            this.chb_Construit.Name = "chb_Construit";
            this.chb_Construit.Size = new System.Drawing.Size(67, 17);
            this.chb_Construit.TabIndex = 6;
            this.chb_Construit.Text = "Construit";
            this.chb_Construit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lancer l\'intégration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_fichiersave
            // 
            this.cb_fichiersave.FormattingEnabled = true;
            this.cb_fichiersave.Location = new System.Drawing.Point(131, 21);
            this.cb_fichiersave.Name = "cb_fichiersave";
            this.cb_fichiersave.Size = new System.Drawing.Size(270, 21);
            this.cb_fichiersave.TabIndex = 9;
            // 
            // cb_niveau
            // 
            this.cb_niveau.FormattingEnabled = true;
            this.cb_niveau.Items.AddRange(new object[] {
            "CP",
            "CE1",
            "CE2",
            "CM1",
            "CM2",
            "6è"});
            this.cb_niveau.Location = new System.Drawing.Point(131, 174);
            this.cb_niveau.Name = "cb_niveau";
            this.cb_niveau.Size = new System.Drawing.Size(129, 21);
            this.cb_niveau.TabIndex = 10;
            // 
            // tb_annéescolaire
            // 
            this.tb_annéescolaire.Location = new System.Drawing.Point(131, 148);
            this.tb_annéescolaire.Name = "tb_annéescolaire";
            this.tb_annéescolaire.Size = new System.Drawing.Size(67, 20);
            this.tb_annéescolaire.TabIndex = 11;
            // 
            // cbCSV
            // 
            this.cbCSV.FormattingEnabled = true;
            this.cbCSV.Location = new System.Drawing.Point(141, 58);
            this.cbCSV.Name = "cbCSV";
            this.cbCSV.Size = new System.Drawing.Size(260, 79);
            this.cbCSV.TabIndex = 12;
            // 
            // IntregrationCVSEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 301);
            this.Controls.Add(this.cbCSV);
            this.Controls.Add(this.tb_annéescolaire);
            this.Controls.Add(this.cb_niveau);
            this.Controls.Add(this.cb_fichiersave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chb_Construit);
            this.Controls.Add(this.chb_random);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IntregrationCVSEleves";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chb_random;
        private System.Windows.Forms.CheckBox chb_Construit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_fichiersave;
        private System.Windows.Forms.ComboBox cb_niveau;
        private System.Windows.Forms.TextBox tb_annéescolaire;
        private System.Windows.Forms.CheckedListBox cbCSV;
    }
}

