namespace Logiciel_de_gestion_de_la_pharmacie
{
    partial class Inscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textNomComplet = new TextBox();
            textnomutilisateur = new TextBox();
            label2 = new Label();
            label1 = new Label();
            confirmermotdepasse = new TextBox();
            textMotdepasse = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button_inscription = new Button();
            SuspendLayout();
            // 
            // textNomComplet
            // 
            textNomComplet.Location = new Point(134, 87);
            textNomComplet.Name = "textNomComplet";
            textNomComplet.Size = new Size(169, 23);
            textNomComplet.TabIndex = 7;
            // 
            // textnomutilisateur
            // 
            textnomutilisateur.Location = new Point(134, 25);
            textnomutilisateur.Name = "textnomutilisateur";
            textnomutilisateur.Size = new Size(169, 23);
            textnomutilisateur.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OliveDrab;
            label2.Location = new Point(24, 95);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 5;
            label2.Text = "Nom Complet";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OliveDrab;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 4;
            label1.Text = "Nom Utilisateur";
            // 
            // confirmermotdepasse
            // 
            confirmermotdepasse.Location = new Point(134, 207);
            confirmermotdepasse.Name = "confirmermotdepasse";
            confirmermotdepasse.Size = new Size(169, 23);
            confirmermotdepasse.TabIndex = 11;
            confirmermotdepasse.TextChanged += confirmermotdepasse_TextChanged;
            // 
            // textMotdepasse
            // 
            textMotdepasse.Location = new Point(134, 150);
            textMotdepasse.Name = "textMotdepasse";
            textMotdepasse.Size = new Size(169, 23);
            textMotdepasse.TabIndex = 10;
            textMotdepasse.TextChanged += textMotdepasse_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.OliveDrab;
            label3.Location = new Point(-1, 215);
            label3.Name = "label3";
            label3.Size = new Size(132, 15);
            label3.TabIndex = 9;
            label3.Text = "confirmer mot de passe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.OliveDrab;
            label4.Location = new Point(24, 153);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 8;
            label4.Text = "Mot de Passe";
            // 
            // button_inscription
            // 
            button_inscription.BackColor = Color.OliveDrab;
            button_inscription.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_inscription.ForeColor = Color.White;
            button_inscription.Location = new Point(134, 267);
            button_inscription.Name = "button_inscription";
            button_inscription.Size = new Size(180, 49);
            button_inscription.TabIndex = 12;
            button_inscription.Text = "Inscription";
            button_inscription.UseVisualStyleBackColor = false;
            button_inscription.Click += button_inscription_Click;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(519, 345);
            Controls.Add(button_inscription);
            Controls.Add(confirmermotdepasse);
            Controls.Add(textMotdepasse);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textNomComplet);
            Controls.Add(textnomutilisateur);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Inscription";
            Text = "Inscription";
            Load += Inscription_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNomComplet;
        private TextBox textnomutilisateur;
        private Label label2;
        private Label label1;
        private TextBox confirmermotdepasse;
        private TextBox textMotdepasse;
        private Label label3;
        private Label label4;
        private Button button_inscription;
    }
}