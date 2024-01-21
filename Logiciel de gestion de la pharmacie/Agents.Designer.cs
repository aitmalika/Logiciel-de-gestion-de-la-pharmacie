namespace Logiciel_de_gestion_de_la_pharmacie
{
    partial class Agents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agents));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            ListeDesAgents = new Label();
            AjouterAgents = new Button();
            ModifierAgents = new Button();
            SupprimerAgents = new Button();
            ReinitialiserAgents = new Button();
            GenreAgent = new ComboBox();
            TextTelephoneAgents = new Label();
            TextDateDeNaissanceAgent = new Label();
            NomAgent = new TextBox();
            TextNomAgent = new Label();
            pictureBox6 = new PictureBox();
            TextGenreAgent = new Label();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            TextMotDePasseAgents = new Label();
            DateNaissanceAgent = new DateTimePicker();
            TelephoneAgent = new ComboBox();
            AgentDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            AgNum = new DataGridViewTextBoxColumn();
            AgNom = new DataGridViewTextBoxColumn();
            AgADN = new DataGridViewTextBoxColumn();
            AgTel = new DataGridViewTextBoxColumn();
            AgSex = new DataGridViewTextBoxColumn();
            AgPass = new DataGridViewTextBoxColumn();
            MotDePasseAgent = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgentDgv).BeginInit();
            SuspendLayout();
            // 
            // ListeDesAgents
            // 
            ListeDesAgents.AutoSize = true;
            ListeDesAgents.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListeDesAgents.ForeColor = Color.ForestGreen;
            ListeDesAgents.Location = new Point(503, 197);
            ListeDesAgents.Name = "ListeDesAgents";
            ListeDesAgents.Size = new Size(164, 22);
            ListeDesAgents.TabIndex = 98;
            ListeDesAgents.Text = "Liste Des Agents";
            ListeDesAgents.Click += label20_Click;
            // 
            // AjouterAgents
            // 
            AjouterAgents.BackColor = Color.ForestGreen;
            AjouterAgents.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AjouterAgents.ForeColor = Color.White;
            AjouterAgents.Location = new Point(401, 148);
            AjouterAgents.Name = "AjouterAgents";
            AjouterAgents.Size = new Size(90, 29);
            AjouterAgents.TabIndex = 97;
            AjouterAgents.Text = "Ajouter";
            AjouterAgents.UseVisualStyleBackColor = false;
            AjouterAgents.Click += AjouterAgents_Click;
            // 
            // ModifierAgents
            // 
            ModifierAgents.BackColor = Color.ForestGreen;
            ModifierAgents.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ModifierAgents.ForeColor = Color.White;
            ModifierAgents.Location = new Point(497, 149);
            ModifierAgents.Name = "ModifierAgents";
            ModifierAgents.Size = new Size(83, 28);
            ModifierAgents.TabIndex = 96;
            ModifierAgents.Text = "Modifier";
            ModifierAgents.UseVisualStyleBackColor = false;
            ModifierAgents.Click += ModifierAgents_Click;
            // 
            // SupprimerAgents
            // 
            SupprimerAgents.BackColor = Color.ForestGreen;
            SupprimerAgents.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SupprimerAgents.ForeColor = Color.White;
            SupprimerAgents.Location = new Point(597, 149);
            SupprimerAgents.Name = "SupprimerAgents";
            SupprimerAgents.Size = new Size(84, 28);
            SupprimerAgents.TabIndex = 95;
            SupprimerAgents.Text = "supprimer";
            SupprimerAgents.UseVisualStyleBackColor = false;
            SupprimerAgents.Click += SupprimerAgents_Click;
            // 
            // ReinitialiserAgents
            // 
            ReinitialiserAgents.BackColor = Color.ForestGreen;
            ReinitialiserAgents.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReinitialiserAgents.ForeColor = Color.White;
            ReinitialiserAgents.Location = new Point(696, 148);
            ReinitialiserAgents.Name = "ReinitialiserAgents";
            ReinitialiserAgents.Size = new Size(98, 28);
            ReinitialiserAgents.TabIndex = 94;
            ReinitialiserAgents.Text = "Reinitialiser";
            ReinitialiserAgents.UseVisualStyleBackColor = false;
            ReinitialiserAgents.Click += ReinitialiserAgents_Click;
            // 
            // GenreAgent
            // 
            GenreAgent.FormattingEnabled = true;
            GenreAgent.Items.AddRange(new object[] { "M", "F" });
            GenreAgent.Location = new Point(696, 103);
            GenreAgent.Name = "GenreAgent";
            GenreAgent.Size = new Size(121, 23);
            GenreAgent.TabIndex = 93;
            // 
            // TextTelephoneAgents
            // 
            TextTelephoneAgents.AutoSize = true;
            TextTelephoneAgents.BackColor = SystemColors.Control;
            TextTelephoneAgents.Location = new Point(535, 82);
            TextTelephoneAgents.Name = "TextTelephoneAgents";
            TextTelephoneAgents.Size = new Size(61, 15);
            TextTelephoneAgents.TabIndex = 92;
            TextTelephoneAgents.Text = "Telephone";
            // 
            // TextDateDeNaissanceAgent
            // 
            TextDateDeNaissanceAgent.AutoSize = true;
            TextDateDeNaissanceAgent.BackColor = SystemColors.Control;
            TextDateDeNaissanceAgent.Location = new Point(399, 82);
            TextDateDeNaissanceAgent.Name = "TextDateDeNaissanceAgent";
            TextDateDeNaissanceAgent.Size = new Size(103, 15);
            TextDateDeNaissanceAgent.TabIndex = 90;
            TextDateDeNaissanceAgent.Text = "Date de Naissance";
            // 
            // NomAgent
            // 
            NomAgent.Location = new Point(224, 103);
            NomAgent.Name = "NomAgent";
            NomAgent.Size = new Size(142, 23);
            NomAgent.TabIndex = 89;
            // 
            // TextNomAgent
            // 
            TextNomAgent.AutoSize = true;
            TextNomAgent.BackColor = SystemColors.Control;
            TextNomAgent.Location = new Point(241, 82);
            TextNomAgent.Name = "TextNomAgent";
            TextNomAgent.Size = new Size(34, 15);
            TextNomAgent.TabIndex = 88;
            TextNomAgent.Text = "Nom";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(44, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(78, 59);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // TextGenreAgent
            // 
            TextGenreAgent.AutoSize = true;
            TextGenreAgent.BackColor = SystemColors.Control;
            TextGenreAgent.Location = new Point(720, 82);
            TextGenreAgent.Name = "TextGenreAgent";
            TextGenreAgent.Size = new Size(38, 15);
            TextGenreAgent.TabIndex = 86;
            TextGenreAgent.Text = "Genre";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1028, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(27, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 85;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(571, 49);
            label3.Name = "label3";
            label3.Size = new Size(75, 22);
            label3.TabIndex = 84;
            label3.Text = "Agents";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(535, 13);
            label1.Name = "label1";
            label1.Size = new Size(227, 24);
            label1.TabIndex = 83;
            label1.Text = "PHARMACIE MALIKA";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 506);
            panel1.TabIndex = 82;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(75, 374);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // TextMotDePasseAgents
            // 
            TextMotDePasseAgents.AutoSize = true;
            TextMotDePasseAgents.BackColor = SystemColors.Control;
            TextMotDePasseAgents.Location = new Point(872, 85);
            TextMotDePasseAgents.Name = "TextMotDePasseAgents";
            TextMotDePasseAgents.Size = new Size(77, 15);
            TextMotDePasseAgents.TabIndex = 101;
            TextMotDePasseAgents.Text = "Mot de Passe";
            // 
            // DateNaissanceAgent
            // 
            DateNaissanceAgent.Format = DateTimePickerFormat.Short;
            DateNaissanceAgent.Location = new Point(401, 103);
            DateNaissanceAgent.Name = "DateNaissanceAgent";
            DateNaissanceAgent.Size = new Size(114, 23);
            DateNaissanceAgent.TabIndex = 102;
            // 
            // TelephoneAgent
            // 
            TelephoneAgent.FormattingEnabled = true;
            TelephoneAgent.Location = new Point(535, 103);
            TelephoneAgent.Name = "TelephoneAgent";
            TelephoneAgent.Size = new Size(121, 23);
            TelephoneAgent.TabIndex = 103;
            // 
            // AgentDgv
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            AgentDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AgentDgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AgentDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AgentDgv.ColumnHeadersHeight = 20;
            AgentDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            AgentDgv.Columns.AddRange(new DataGridViewColumn[] { AgNum, AgNom, AgADN, AgTel, AgSex, AgPass });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AgentDgv.DefaultCellStyle = dataGridViewCellStyle3;
            AgentDgv.GridColor = Color.FromArgb(231, 229, 255);
            AgentDgv.Location = new Point(232, 222);
            AgentDgv.Name = "AgentDgv";
            AgentDgv.RowHeadersVisible = false;
            AgentDgv.RowTemplate.Height = 25;
            AgentDgv.Size = new Size(814, 259);
            AgentDgv.TabIndex = 104;
            AgentDgv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            AgentDgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            AgentDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            AgentDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            AgentDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            AgentDgv.ThemeStyle.BackColor = Color.White;
            AgentDgv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            AgentDgv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            AgentDgv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            AgentDgv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AgentDgv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            AgentDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            AgentDgv.ThemeStyle.HeaderStyle.Height = 20;
            AgentDgv.ThemeStyle.ReadOnly = false;
            AgentDgv.ThemeStyle.RowsStyle.BackColor = Color.White;
            AgentDgv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AgentDgv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AgentDgv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            AgentDgv.ThemeStyle.RowsStyle.Height = 25;
            AgentDgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            AgentDgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            AgentDgv.CellContentClick += AgentDgv_CellContentClick;
            // 
            // AgNum
            // 
            AgNum.DataPropertyName = "AgNum";
            AgNum.HeaderText = "Num";
            AgNum.Name = "AgNum";
            AgNum.Visible = false;
            // 
            // AgNom
            // 
            AgNom.DataPropertyName = "AgNom";
            AgNom.HeaderText = "Nom";
            AgNom.Name = "AgNom";
            // 
            // AgADN
            // 
            AgADN.DataPropertyName = "AgADN";
            AgADN.HeaderText = "Date de Naissance";
            AgADN.Name = "AgADN";
            // 
            // AgTel
            // 
            AgTel.DataPropertyName = "AgTel";
            AgTel.HeaderText = "Telephone";
            AgTel.Name = "AgTel";
            // 
            // AgSex
            // 
            AgSex.DataPropertyName = "AgSex";
            AgSex.HeaderText = "Genre";
            AgSex.Name = "AgSex";
            // 
            // AgPass
            // 
            AgPass.DataPropertyName = "AgPass";
            AgPass.HeaderText = "Mot de Passe";
            AgPass.Name = "AgPass";
            // 
            // MotDePasseAgent
            // 
            MotDePasseAgent.FormattingEnabled = true;
            MotDePasseAgent.Location = new Point(839, 103);
            MotDePasseAgent.Name = "MotDePasseAgent";
            MotDePasseAgent.Size = new Size(121, 23);
            MotDePasseAgent.TabIndex = 106;
            // 
            // Agents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 506);
            Controls.Add(MotDePasseAgent);
            Controls.Add(AgentDgv);
            Controls.Add(TelephoneAgent);
            Controls.Add(DateNaissanceAgent);
            Controls.Add(TextMotDePasseAgents);
            Controls.Add(ListeDesAgents);
            Controls.Add(AjouterAgents);
            Controls.Add(ModifierAgents);
            Controls.Add(SupprimerAgents);
            Controls.Add(ReinitialiserAgents);
            Controls.Add(GenreAgent);
            Controls.Add(TextTelephoneAgents);
            Controls.Add(TextDateDeNaissanceAgent);
            Controls.Add(NomAgent);
            Controls.Add(TextNomAgent);
            Controls.Add(TextGenreAgent);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Agents";
            Text = "Agents";
            Load += Agents_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgentDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ListeDesAgents;
        private Button AjouterAgents;
        private Button ModifierAgents;
        private Button SupprimerAgents;
        private Button ReinitialiserAgents;
        private ComboBox GenreAgent;
        private Label TextTelephoneAgents;
        private Label TextDateDeNaissanceAgent;
        private TextBox NomAgent;
        private Label TextNomAgent;
        private PictureBox pictureBox6;
        private Label TextGenreAgent;
        private PictureBox pictureBox5;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private ComboBox MotDePasseAgent;
        private Label TextMotDePasseAgents;
        private DateTimePicker DateNaissanceAgent;
        private ComboBox TelephoneAgent;
        private Guna.UI2.WinForms.Guna2DataGridView AgentDgv;
        private PictureBox pictureBox4;
        private DataGridViewTextBoxColumn AgNum;
        private DataGridViewTextBoxColumn AgNom;
        private DataGridViewTextBoxColumn AgADN;
        private DataGridViewTextBoxColumn AgTel;
        private DataGridViewTextBoxColumn AgSex;
        private DataGridViewTextBoxColumn AgPass;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}