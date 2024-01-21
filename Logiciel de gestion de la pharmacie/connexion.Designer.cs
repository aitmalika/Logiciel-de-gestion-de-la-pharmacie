namespace Logiciel_de_gestion_de_la_pharmacie
{
    partial class connexion
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
            label1 = new Label();
            label2 = new Label();
            textnomutilisateur = new TextBox();
            textmotdepasse = new TextBox();
            button_connexion = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom Utilisateur";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Mot de passe";
            label2.Click += label2_Click;
            // 
            // textnomutilisateur
            // 
            textnomutilisateur.Location = new Point(122, 61);
            textnomutilisateur.Name = "textnomutilisateur";
            textnomutilisateur.Size = new Size(218, 23);
            textnomutilisateur.TabIndex = 2;
            // 
            // textmotdepasse
            // 
            textmotdepasse.Location = new Point(122, 118);
            textmotdepasse.Name = "textmotdepasse";
            textmotdepasse.Size = new Size(218, 23);
            textmotdepasse.TabIndex = 3;
            // 
            // button_connexion
            // 
            button_connexion.BackColor = Color.ForestGreen;
            button_connexion.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_connexion.ForeColor = Color.White;
            button_connexion.Location = new Point(122, 168);
            button_connexion.Name = "button_connexion";
            button_connexion.Size = new Size(218, 46);
            button_connexion.TabIndex = 4;
            button_connexion.Text = "Connexion";
            button_connexion.UseVisualStyleBackColor = false;
            button_connexion.Click += button_connexion_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // connexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 272);
            Controls.Add(button_connexion);
            Controls.Add(textmotdepasse);
            Controls.Add(textnomutilisateur);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "connexion";
            Text = "Connexion";
            Load += connexion_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textnomutilisateur;
        private TextBox textmotdepasse;
        private Button button_connexion;
        private FileSystemWatcher fileSystemWatcher1;
    }
}