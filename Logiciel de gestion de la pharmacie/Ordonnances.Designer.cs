namespace Logiciel_de_gestion_de_la_pharmacie
{
    partial class Ordonnances
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordonnances));
            DataGridOrdonnances = new Guna.UI2.WinForms.Guna2DataGridView();
            NumOrd = new DataGridViewTextBoxColumn();
            NCNSS = new DataGridViewTextBoxColumn();
            Nomdupatient = new DataGridViewTextBoxColumn();
            Nommedecin = new DataGridViewTextBoxColumn();
            DateOrd = new DataGridViewTextBoxColumn();
            TextNomdupatient = new TextBox();
            CNSS = new Label();
            TextNCNSS = new TextBox();
            NomMed = new Label();
            TextNommedecin = new TextBox();
            Nom = new Label();
            Date = new Label();
            AjouterOrdonnance = new Button();
            ModifierOrdonnance = new Button();
            SupprimerOrdonnance = new Button();
            ReinitialiserOrdonnance = new Button();
            TextDateOrd = new DateTimePicker();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DataGridOrdonnances).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // DataGridOrdonnances
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridOrdonnances.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridOrdonnances.BackgroundColor = Color.Khaki;
            DataGridOrdonnances.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridOrdonnances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridOrdonnances.ColumnHeadersHeight = 20;
            DataGridOrdonnances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridOrdonnances.Columns.AddRange(new DataGridViewColumn[] { NumOrd, NCNSS, Nomdupatient, Nommedecin, DateOrd });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridOrdonnances.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridOrdonnances.GridColor = Color.FromArgb(231, 229, 255);
            DataGridOrdonnances.Location = new Point(147, 97);
            DataGridOrdonnances.Name = "DataGridOrdonnances";
            DataGridOrdonnances.RowHeadersVisible = false;
            DataGridOrdonnances.RowTemplate.Height = 25;
            DataGridOrdonnances.Size = new Size(710, 351);
            DataGridOrdonnances.TabIndex = 87;
            DataGridOrdonnances.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridOrdonnances.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridOrdonnances.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridOrdonnances.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridOrdonnances.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridOrdonnances.ThemeStyle.BackColor = Color.Khaki;
            DataGridOrdonnances.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridOrdonnances.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridOrdonnances.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridOrdonnances.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridOrdonnances.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridOrdonnances.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridOrdonnances.ThemeStyle.HeaderStyle.Height = 20;
            DataGridOrdonnances.ThemeStyle.ReadOnly = false;
            DataGridOrdonnances.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridOrdonnances.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridOrdonnances.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridOrdonnances.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridOrdonnances.ThemeStyle.RowsStyle.Height = 25;
            DataGridOrdonnances.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridOrdonnances.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridOrdonnances.CellContentClick += DataGridOrdonnances_CellContentClick;
            // 
            // NumOrd
            // 
            NumOrd.DataPropertyName = "NumOrd";
            NumOrd.HeaderText = "NumeroOrdannance";
            NumOrd.Name = "NumOrd";
            NumOrd.Visible = false;
            // 
            // NCNSS
            // 
            NCNSS.DataPropertyName = "NCNSS";
            NCNSS.HeaderText = "CNSS";
            NCNSS.Name = "NCNSS";
            // 
            // Nomdupatient
            // 
            Nomdupatient.DataPropertyName = "Nomdupatient";
            Nomdupatient.HeaderText = "Nom du patient";
            Nomdupatient.Name = "Nomdupatient";
            // 
            // Nommedecin
            // 
            Nommedecin.DataPropertyName = "Nommedecin";
            Nommedecin.HeaderText = "Nom du medecin";
            Nommedecin.Name = "Nommedecin";
            // 
            // DateOrd
            // 
            DateOrd.DataPropertyName = "DateOrd";
            DateOrd.HeaderText = "Date Ordonnance";
            DateOrd.Name = "DateOrd";
            // 
            // TextNomdupatient
            // 
            TextNomdupatient.Location = new Point(339, 48);
            TextNomdupatient.Name = "TextNomdupatient";
            TextNomdupatient.Size = new Size(115, 23);
            TextNomdupatient.TabIndex = 93;
            TextNomdupatient.TextChanged += TextNomdupatient_TextChanged;
            // 
            // CNSS
            // 
            CNSS.AutoSize = true;
            CNSS.BackColor = Color.OliveDrab;
            CNSS.ForeColor = Color.White;
            CNSS.Location = new Point(157, 27);
            CNSS.Name = "CNSS";
            CNSS.Size = new Size(83, 15);
            CNSS.TabIndex = 92;
            CNSS.Text = "Numéro CNSS";
            // 
            // TextNCNSS
            // 
            TextNCNSS.Location = new Point(147, 48);
            TextNCNSS.Name = "TextNCNSS";
            TextNCNSS.Size = new Size(126, 23);
            TextNCNSS.TabIndex = 91;
            // 
            // NomMed
            // 
            NomMed.AutoSize = true;
            NomMed.BackColor = Color.OliveDrab;
            NomMed.ForeColor = Color.White;
            NomMed.Location = new Point(530, 27);
            NomMed.Name = "NomMed";
            NomMed.Size = new Size(83, 15);
            NomMed.TabIndex = 90;
            NomMed.Text = "Nom medecin";
            // 
            // TextNommedecin
            // 
            TextNommedecin.Location = new Point(522, 48);
            TextNommedecin.Name = "TextNommedecin";
            TextNommedecin.Size = new Size(117, 23);
            TextNommedecin.TabIndex = 89;
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.BackColor = Color.OliveDrab;
            Nom.ForeColor = Color.White;
            Nom.Location = new Point(346, 26);
            Nom.Name = "Nom";
            Nom.Size = new Size(91, 15);
            Nom.TabIndex = 88;
            Nom.Text = "Nom du patient";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.BackColor = Color.OliveDrab;
            Date.ForeColor = Color.White;
            Date.Location = new Point(716, 27);
            Date.Name = "Date";
            Date.Size = new Size(100, 15);
            Date.TabIndex = 95;
            Date.Text = "Date Ordonnance";
            // 
            // AjouterOrdonnance
            // 
            AjouterOrdonnance.BackColor = Color.OliveDrab;
            AjouterOrdonnance.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AjouterOrdonnance.ForeColor = Color.White;
            AjouterOrdonnance.Location = new Point(12, 26);
            AjouterOrdonnance.Name = "AjouterOrdonnance";
            AjouterOrdonnance.Size = new Size(104, 35);
            AjouterOrdonnance.TabIndex = 99;
            AjouterOrdonnance.Text = "Ajouter";
            AjouterOrdonnance.UseVisualStyleBackColor = false;
            AjouterOrdonnance.Click += AjouterOrdonnance_Click;
            // 
            // ModifierOrdonnance
            // 
            ModifierOrdonnance.BackColor = Color.OliveDrab;
            ModifierOrdonnance.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ModifierOrdonnance.ForeColor = Color.White;
            ModifierOrdonnance.Location = new Point(14, 86);
            ModifierOrdonnance.Name = "ModifierOrdonnance";
            ModifierOrdonnance.Size = new Size(102, 34);
            ModifierOrdonnance.TabIndex = 98;
            ModifierOrdonnance.Text = "Modifier";
            ModifierOrdonnance.UseVisualStyleBackColor = false;
            ModifierOrdonnance.Click += ModifierOrdonnance_Click;
            // 
            // SupprimerOrdonnance
            // 
            SupprimerOrdonnance.BackColor = Color.OliveDrab;
            SupprimerOrdonnance.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SupprimerOrdonnance.ForeColor = Color.White;
            SupprimerOrdonnance.Location = new Point(12, 153);
            SupprimerOrdonnance.Name = "SupprimerOrdonnance";
            SupprimerOrdonnance.Size = new Size(104, 39);
            SupprimerOrdonnance.TabIndex = 97;
            SupprimerOrdonnance.Text = "supprimer";
            SupprimerOrdonnance.UseVisualStyleBackColor = false;
            SupprimerOrdonnance.Click += SupprimerOrdonnance_Click;
            // 
            // ReinitialiserOrdonnance
            // 
            ReinitialiserOrdonnance.BackColor = Color.OliveDrab;
            ReinitialiserOrdonnance.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReinitialiserOrdonnance.ForeColor = Color.White;
            ReinitialiserOrdonnance.Location = new Point(14, 210);
            ReinitialiserOrdonnance.Name = "ReinitialiserOrdonnance";
            ReinitialiserOrdonnance.Size = new Size(102, 37);
            ReinitialiserOrdonnance.TabIndex = 96;
            ReinitialiserOrdonnance.Text = "Reinitialiser";
            ReinitialiserOrdonnance.UseVisualStyleBackColor = false;
            ReinitialiserOrdonnance.Click += ReinitialiserOrdonnance_Click;
            // 
            // TextDateOrd
            // 
            TextDateOrd.Format = DateTimePickerFormat.Short;
            TextDateOrd.Location = new Point(710, 49);
            TextDateOrd.Name = "TextDateOrd";
            TextDateOrd.Size = new Size(114, 23);
            TextDateOrd.TabIndex = 100;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(30, 368);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 101;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Ordonnances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(869, 460);
            Controls.Add(pictureBox4);
            Controls.Add(TextDateOrd);
            Controls.Add(AjouterOrdonnance);
            Controls.Add(ModifierOrdonnance);
            Controls.Add(SupprimerOrdonnance);
            Controls.Add(ReinitialiserOrdonnance);
            Controls.Add(Date);
            Controls.Add(TextNomdupatient);
            Controls.Add(CNSS);
            Controls.Add(TextNCNSS);
            Controls.Add(NomMed);
            Controls.Add(TextNommedecin);
            Controls.Add(Nom);
            Controls.Add(DataGridOrdonnances);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Ordonnances";
            Text = "Ordonnances";
            ((System.ComponentModel.ISupportInitialize)DataGridOrdonnances).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DataGridOrdonnances;
        private TextBox TextNomdupatient;
        private Label CNSS;
        private TextBox TextNCNSS;
        private Label NomMed;
        private TextBox TextNommedecin;
        private Label Nom;
        private Label Date;
        private Button AjouterOrdonnance;
        private Button ModifierOrdonnance;
        private Button SupprimerOrdonnance;
        private Button ReinitialiserOrdonnance;
        private DateTimePicker TextDateOrd;
        private PictureBox pictureBox4;
        private DataGridViewTextBoxColumn NumOrd;
        private DataGridViewTextBoxColumn NCNSS;
        private DataGridViewTextBoxColumn Nomdupatient;
        private DataGridViewTextBoxColumn Nommedecin;
        private DataGridViewTextBoxColumn DateOrd;
    }
}