namespace Logiciel_de_gestion_de_la_pharmacie
{
    partial class FABRICANTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FABRICANTS));
            ListeDesFabricants = new Guna.UI2.WinForms.Guna2DataGridView();
            FabNum = new DataGridViewTextBoxColumn();
            FabNom = new DataGridViewTextBoxColumn();
            FabAdres = new DataGridViewTextBoxColumn();
            FabDescription = new DataGridViewTextBoxColumn();
            FabTel = new DataGridViewTextBoxColumn();
            ListeFabricant = new Label();
            AjouterFabricant = new Button();
            ModifierFabricant = new Button();
            SupprimerFabricant = new Button();
            ReinitialiserFabricant = new Button();
            TextDescriptionFabricant = new Label();
            DescriptionFabicant = new TextBox();
            TextAdresseFabicant = new Label();
            Nomfabriant = new TextBox();
            TextNomFabicant = new Label();
            AdresseFabicant = new TextBox();
            TextTelephoneFabricant = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            TextTableauDeBord = new Label();
            pictureTableauDeBord = new PictureBox();
            label3 = new Label();
            pictureFacture = new PictureBox();
            TextMedicamant = new Label();
            picturMedicament = new PictureBox();
            label1 = new Label();
            TextFacture = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            TelephoneFabricant = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ListeDesFabricants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTableauDeBord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFacture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturMedicament).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // ListeDesFabricants
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ListeDesFabricants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ListeDesFabricants.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListeDesFabricants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListeDesFabricants.ColumnHeadersHeight = 20;
            ListeDesFabricants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ListeDesFabricants.Columns.AddRange(new DataGridViewColumn[] { FabNum, FabNom, FabAdres, FabDescription, FabTel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ListeDesFabricants.DefaultCellStyle = dataGridViewCellStyle3;
            ListeDesFabricants.GridColor = Color.FromArgb(231, 229, 255);
            ListeDesFabricants.Location = new Point(215, 325);
            ListeDesFabricants.Name = "ListeDesFabricants";
            ListeDesFabricants.RowHeadersVisible = false;
            ListeDesFabricants.RowTemplate.Height = 25;
            ListeDesFabricants.Size = new Size(831, 210);
            ListeDesFabricants.TabIndex = 82;
            ListeDesFabricants.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ListeDesFabricants.ThemeStyle.AlternatingRowsStyle.Font = null;
            ListeDesFabricants.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ListeDesFabricants.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ListeDesFabricants.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ListeDesFabricants.ThemeStyle.BackColor = Color.White;
            ListeDesFabricants.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ListeDesFabricants.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ListeDesFabricants.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            ListeDesFabricants.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ListeDesFabricants.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ListeDesFabricants.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ListeDesFabricants.ThemeStyle.HeaderStyle.Height = 20;
            ListeDesFabricants.ThemeStyle.ReadOnly = false;
            ListeDesFabricants.ThemeStyle.RowsStyle.BackColor = Color.White;
            ListeDesFabricants.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListeDesFabricants.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ListeDesFabricants.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ListeDesFabricants.ThemeStyle.RowsStyle.Height = 25;
            ListeDesFabricants.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ListeDesFabricants.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ListeDesFabricants.CellContentClick += ListeDesFabricants_CellContentClick;
            // 
            // FabNum
            // 
            FabNum.DataPropertyName = "FabNum";
            FabNum.HeaderText = "NUM";
            FabNum.Name = "FabNum";
            FabNum.Visible = false;
            // 
            // FabNom
            // 
            FabNom.DataPropertyName = "FabNom";
            FabNom.HeaderText = "Nom";
            FabNom.Name = "FabNom";
            // 
            // FabAdres
            // 
            FabAdres.DataPropertyName = "FabAdres";
            FabAdres.HeaderText = "Adresse";
            FabAdres.Name = "FabAdres";
            // 
            // FabDescription
            // 
            FabDescription.DataPropertyName = "FabDescription";
            FabDescription.HeaderText = "Description";
            FabDescription.Name = "FabDescription";
            // 
            // FabTel
            // 
            FabTel.DataPropertyName = "FabTel";
            FabTel.HeaderText = "Telephone";
            FabTel.Name = "FabTel";
            // 
            // ListeFabricant
            // 
            ListeFabricant.AutoSize = true;
            ListeFabricant.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListeFabricant.ForeColor = Color.ForestGreen;
            ListeFabricant.Location = new Point(507, 210);
            ListeFabricant.Name = "ListeFabricant";
            ListeFabricant.Size = new Size(196, 22);
            ListeFabricant.TabIndex = 80;
            ListeFabricant.Text = "Liste Des Fabricants";
            ListeFabricant.Click += label20_Click;
            // 
            // AjouterFabricant
            // 
            AjouterFabricant.BackColor = Color.ForestGreen;
            AjouterFabricant.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AjouterFabricant.ForeColor = Color.White;
            AjouterFabricant.Location = new Point(398, 178);
            AjouterFabricant.Name = "AjouterFabricant";
            AjouterFabricant.Size = new Size(90, 29);
            AjouterFabricant.TabIndex = 79;
            AjouterFabricant.Text = "Ajouter";
            AjouterFabricant.UseVisualStyleBackColor = false;
            AjouterFabricant.Click += button3_Click;
            // 
            // ModifierFabricant
            // 
            ModifierFabricant.BackColor = Color.ForestGreen;
            ModifierFabricant.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ModifierFabricant.ForeColor = Color.White;
            ModifierFabricant.Location = new Point(494, 179);
            ModifierFabricant.Name = "ModifierFabricant";
            ModifierFabricant.Size = new Size(83, 28);
            ModifierFabricant.TabIndex = 78;
            ModifierFabricant.Text = "Modifier";
            ModifierFabricant.UseVisualStyleBackColor = false;
            ModifierFabricant.Click += ModifierFabricant_Click;
            // 
            // SupprimerFabricant
            // 
            SupprimerFabricant.BackColor = Color.ForestGreen;
            SupprimerFabricant.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SupprimerFabricant.ForeColor = Color.White;
            SupprimerFabricant.Location = new Point(594, 179);
            SupprimerFabricant.Name = "SupprimerFabricant";
            SupprimerFabricant.Size = new Size(84, 28);
            SupprimerFabricant.TabIndex = 77;
            SupprimerFabricant.Text = "supprimer";
            SupprimerFabricant.UseVisualStyleBackColor = false;
            SupprimerFabricant.Click += SupprimerFabricant_Click;
            // 
            // ReinitialiserFabricant
            // 
            ReinitialiserFabricant.BackColor = Color.ForestGreen;
            ReinitialiserFabricant.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReinitialiserFabricant.ForeColor = Color.White;
            ReinitialiserFabricant.Location = new Point(693, 178);
            ReinitialiserFabricant.Name = "ReinitialiserFabricant";
            ReinitialiserFabricant.Size = new Size(98, 28);
            ReinitialiserFabricant.TabIndex = 76;
            ReinitialiserFabricant.Text = "Reinitialiser";
            ReinitialiserFabricant.UseVisualStyleBackColor = false;
            ReinitialiserFabricant.Click += ReinitialiserFabricant_Click;
            // 
            // TextDescriptionFabricant
            // 
            TextDescriptionFabricant.AutoSize = true;
            TextDescriptionFabricant.BackColor = SystemColors.Control;
            TextDescriptionFabricant.Location = new Point(625, 82);
            TextDescriptionFabricant.Name = "TextDescriptionFabricant";
            TextDescriptionFabricant.Size = new Size(67, 15);
            TextDescriptionFabricant.TabIndex = 54;
            TextDescriptionFabricant.Text = "Description";
            TextDescriptionFabricant.Click += TextDescriptionFabricant_Click;
            // 
            // DescriptionFabicant
            // 
            DescriptionFabicant.Location = new Point(625, 103);
            DescriptionFabicant.Multiline = true;
            DescriptionFabicant.Name = "DescriptionFabicant";
            DescriptionFabicant.Size = new Size(146, 69);
            DescriptionFabicant.TabIndex = 53;
            // 
            // TextAdresseFabicant
            // 
            TextAdresseFabicant.AutoSize = true;
            TextAdresseFabicant.BackColor = SystemColors.Control;
            TextAdresseFabicant.Location = new Point(432, 82);
            TextAdresseFabicant.Name = "TextAdresseFabicant";
            TextAdresseFabicant.Size = new Size(48, 15);
            TextAdresseFabicant.TabIndex = 52;
            TextAdresseFabicant.Text = "Adresse";
            TextAdresseFabicant.Click += TextAdresseFabicant_Click;
            // 
            // Nomfabriant
            // 
            Nomfabriant.Location = new Point(221, 103);
            Nomfabriant.Name = "Nomfabriant";
            Nomfabriant.Size = new Size(142, 23);
            Nomfabriant.TabIndex = 51;
            Nomfabriant.TextChanged += Nomfabriant_TextChanged;
            // 
            // TextNomFabicant
            // 
            TextNomFabicant.AutoSize = true;
            TextNomFabicant.BackColor = SystemColors.Control;
            TextNomFabicant.Location = new Point(238, 82);
            TextNomFabicant.Name = "TextNomFabicant";
            TextNomFabicant.Size = new Size(34, 15);
            TextNomFabicant.TabIndex = 50;
            TextNomFabicant.Text = "Nom";
            TextNomFabicant.Click += TextNomFabicant_Click;
            // 
            // AdresseFabicant
            // 
            AdresseFabicant.Location = new Point(416, 103);
            AdresseFabicant.Multiline = true;
            AdresseFabicant.Name = "AdresseFabicant";
            AdresseFabicant.Size = new Size(146, 69);
            AdresseFabicant.TabIndex = 49;
            AdresseFabicant.TextChanged += AdresseFabicant_TextChanged;
            // 
            // TextTelephoneFabricant
            // 
            TextTelephoneFabricant.AutoSize = true;
            TextTelephoneFabricant.BackColor = SystemColors.Control;
            TextTelephoneFabricant.Location = new Point(841, 82);
            TextTelephoneFabricant.Name = "TextTelephoneFabricant";
            TextTelephoneFabricant.Size = new Size(61, 15);
            TextTelephoneFabricant.TabIndex = 48;
            TextTelephoneFabricant.Text = "Telephone";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1025, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(27, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 47;
            pictureBox5.TabStop = false;
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
            // TextTableauDeBord
            // 
            TextTableauDeBord.AutoSize = true;
            TextTableauDeBord.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextTableauDeBord.ForeColor = Color.Black;
            TextTableauDeBord.Location = new Point(63, 304);
            TextTableauDeBord.Name = "TextTableauDeBord";
            TextTableauDeBord.Size = new Size(128, 17);
            TextTableauDeBord.TabIndex = 7;
            TextTableauDeBord.Text = "Tableau de Bord";
            TextTableauDeBord.Click += TextTableauDeBord_Click;
            // 
            // pictureTableauDeBord
            // 
            pictureTableauDeBord.Image = (Image)resources.GetObject("pictureTableauDeBord.Image");
            pictureTableauDeBord.Location = new Point(3, 276);
            pictureTableauDeBord.Name = "pictureTableauDeBord";
            pictureTableauDeBord.Size = new Size(51, 56);
            pictureTableauDeBord.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTableauDeBord.TabIndex = 6;
            pictureTableauDeBord.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(568, 49);
            label3.Name = "label3";
            label3.Size = new Size(136, 22);
            label3.TabIndex = 46;
            label3.Text = "FABRICANTS";
            // 
            // pictureFacture
            // 
            pictureFacture.Image = (Image)resources.GetObject("pictureFacture.Image");
            pictureFacture.Location = new Point(0, 191);
            pictureFacture.Name = "pictureFacture";
            pictureFacture.Size = new Size(54, 44);
            pictureFacture.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFacture.TabIndex = 4;
            pictureFacture.TabStop = false;
            // 
            // TextMedicamant
            // 
            TextMedicamant.AutoSize = true;
            TextMedicamant.BackColor = Color.DarkGray;
            TextMedicamant.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextMedicamant.ForeColor = Color.Black;
            TextMedicamant.Location = new Point(60, 123);
            TextMedicamant.Name = "TextMedicamant";
            TextMedicamant.Size = new Size(120, 17);
            TextMedicamant.TabIndex = 3;
            TextMedicamant.Text = "MEDICAMENTS";
            TextMedicamant.Click += TextMedicamant_Click;
            // 
            // picturMedicament
            // 
            picturMedicament.Image = (Image)resources.GetObject("picturMedicament.Image");
            picturMedicament.Location = new Point(3, 108);
            picturMedicament.Name = "picturMedicament";
            picturMedicament.Size = new Size(51, 44);
            picturMedicament.SizeMode = PictureBoxSizeMode.Zoom;
            picturMedicament.TabIndex = 0;
            picturMedicament.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(532, 13);
            label1.Name = "label1";
            label1.Size = new Size(227, 24);
            label1.TabIndex = 45;
            label1.Text = "PHARMACIE MALIKA";
            // 
            // TextFacture
            // 
            TextFacture.AutoSize = true;
            TextFacture.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextFacture.ForeColor = Color.Black;
            TextFacture.Location = new Point(60, 203);
            TextFacture.Name = "TextFacture";
            TextFacture.Size = new Size(90, 17);
            TextFacture.TabIndex = 5;
            TextFacture.Text = "FACTURES";
            TextFacture.Click += TextFacture_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(TextTableauDeBord);
            panel1.Controls.Add(pictureTableauDeBord);
            panel1.Controls.Add(TextFacture);
            panel1.Controls.Add(pictureFacture);
            panel1.Controls.Add(TextMedicamant);
            panel1.Controls.Add(picturMedicament);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 506);
            panel1.TabIndex = 44;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(65, 380);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // TelephoneFabricant
            // 
            TelephoneFabricant.Location = new Point(799, 108);
            TelephoneFabricant.Name = "TelephoneFabricant";
            TelephoneFabricant.Size = new Size(142, 23);
            TelephoneFabricant.TabIndex = 82;
            TelephoneFabricant.TextChanged += textBox1_TextChanged;
            // 
            // FABRICANTS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 506);
            Controls.Add(TelephoneFabricant);
            Controls.Add(ListeDesFabricants);
            Controls.Add(ListeFabricant);
            Controls.Add(AjouterFabricant);
            Controls.Add(ModifierFabricant);
            Controls.Add(SupprimerFabricant);
            Controls.Add(ReinitialiserFabricant);
            Controls.Add(TextDescriptionFabricant);
            Controls.Add(DescriptionFabicant);
            Controls.Add(TextAdresseFabicant);
            Controls.Add(Nomfabriant);
            Controls.Add(TextNomFabicant);
            Controls.Add(AdresseFabicant);
            Controls.Add(TextTelephoneFabricant);
            Controls.Add(pictureBox5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FABRICANTS";
            Text = "FABRICANTS";
            Load += FABRICANTS_Load;
            ((System.ComponentModel.ISupportInitialize)ListeDesFabricants).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTableauDeBord).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFacture).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturMedicament).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView ListeDesFabricants;
        private Label ListeFabricant;
        private Button AjouterFabricant;
        private Button ModifierFabricant;
        private Button SupprimerFabricant;
        private Button ReinitialiserFabricant;
        private Label TextDescriptionFabricant;
        private TextBox DescriptionFabicant;
        private Label TextAdresseFabicant;
        private TextBox Nomfabriant;
        private Label TextNomFabicant;
        private TextBox AdresseFabicant;
        private Label TextTelephoneFabricant;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label TextTableauDeBord;
        private PictureBox pictureTableauDeBord;
        private Label label3;
        private PictureBox pictureFacture;
        private Label TextMedicamant;
        private PictureBox picturMedicament;
        private Label label1;
        private Label TextFacture;
        private Panel panel1;
        private TextBox TelephoneFabricant;
        private DataGridViewTextBoxColumn FabNum;
        private DataGridViewTextBoxColumn FabNom;
        private DataGridViewTextBoxColumn FabAdres;
        private DataGridViewTextBoxColumn FabDescription;
        private DataGridViewTextBoxColumn FabTel;
        private PictureBox pictureBox4;
    }
}