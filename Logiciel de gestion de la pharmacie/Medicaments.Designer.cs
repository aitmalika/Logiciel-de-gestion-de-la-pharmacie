namespace Logiciel_de_gestion_de_la_pharmacie
{
    partial class Medicaments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicaments));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            TitreTableaudeBordMedicament = new Label();
            pictureTableauDeBordMedicament = new PictureBox();
            TitreFactureMedicament = new Label();
            pictureFactureMedicament = new PictureBox();
            TitreFabricantMedicament = new Label();
            pictureFabricantMedicament = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            PrixAchatMedicament = new TextBox();
            TextFabricantMedicament = new Label();
            NomMedicament = new TextBox();
            TextNomMedicament = new Label();
            QuantiteDisponibleMedicament = new TextBox();
            TextPrixAchatMedicament = new Label();
            TextQuantiteDisponibleMedicament = new Label();
            FabricantMedicament = new ComboBox();
            TextDateExpirationMedicament = new Label();
            DateExpirationMedicament = new DateTimePicker();
            TextQuantiteMinimaleMedicament = new Label();
            QuantiteMinimaleMedicament = new TextBox();
            TextDesignationMedicament = new Label();
            DesignationMedicament = new TextBox();
            TextUtilisationsMedicament = new Label();
            UtilisationsMedicament = new TextBox();
            TextContreIndicationMedicament = new Label();
            ContreIndicationMedicament = new TextBox();
            TextEffetsSecondairesMedicament = new Label();
            EffetsSecondairesMedicament = new TextBox();
            TextTauxDePriseEnChargeMedicament = new Label();
            TauxDePriseEnChargeMedicament = new TextBox();
            TextCodeABarresMedicament = new Label();
            CodeABarresMedicament = new TextBox();
            ReinitialiserMedicament = new Button();
            SupprimerMedicament = new Button();
            ModifierMedicamaent = new Button();
            AjouterMedicament = new Button();
            StockMedicament = new Label();
            DgvMedicament = new Guna.UI2.WinForms.Guna2DataGridView();
            textMedPrixV = new TextBox();
            PrixV = new Label();
            MedNum = new DataGridViewTextBoxColumn();
            MedNom = new DataGridViewTextBoxColumn();
            MedPrixA = new DataGridViewTextBoxColumn();
            MedQteM = new DataGridViewTextBoxColumn();
            MedExp = new DataGridViewTextBoxColumn();
            MedDesig = new DataGridViewTextBoxColumn();
            MedQteD = new DataGridViewTextBoxColumn();
            MedUtili = new DataGridViewTextBoxColumn();
            MedContInd = new DataGridViewTextBoxColumn();
            MedEffet = new DataGridViewTextBoxColumn();
            MedTpc = new DataGridViewTextBoxColumn();
            MedCodBa = new DataGridViewTextBoxColumn();
            IdFabrican = new DataGridViewTextBoxColumn();
            MedPrixV = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTableauDeBordMedicament).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFactureMedicament).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFabricantMedicament).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvMedicament).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(TitreTableaudeBordMedicament);
            panel1.Controls.Add(pictureTableauDeBordMedicament);
            panel1.Controls.Add(TitreFactureMedicament);
            panel1.Controls.Add(pictureFactureMedicament);
            panel1.Controls.Add(TitreFabricantMedicament);
            panel1.Controls.Add(pictureFabricantMedicament);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 547);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(39, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(83, 49);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(53, 412);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // TitreTableaudeBordMedicament
            // 
            TitreTableaudeBordMedicament.AutoSize = true;
            TitreTableaudeBordMedicament.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitreTableaudeBordMedicament.ForeColor = Color.OliveDrab;
            TitreTableaudeBordMedicament.Location = new Point(63, 304);
            TitreTableaudeBordMedicament.Name = "TitreTableaudeBordMedicament";
            TitreTableaudeBordMedicament.Size = new Size(128, 17);
            TitreTableaudeBordMedicament.TabIndex = 7;
            TitreTableaudeBordMedicament.Text = "Tableau de Bord";
            TitreTableaudeBordMedicament.Click += label5_Click;
            // 
            // pictureTableauDeBordMedicament
            // 
            pictureTableauDeBordMedicament.Image = (Image)resources.GetObject("pictureTableauDeBordMedicament.Image");
            pictureTableauDeBordMedicament.Location = new Point(3, 279);
            pictureTableauDeBordMedicament.Name = "pictureTableauDeBordMedicament";
            pictureTableauDeBordMedicament.Size = new Size(51, 53);
            pictureTableauDeBordMedicament.SizeMode = PictureBoxSizeMode.Zoom;
            pictureTableauDeBordMedicament.TabIndex = 6;
            pictureTableauDeBordMedicament.TabStop = false;
            pictureTableauDeBordMedicament.Click += pictureBox3_Click;
            // 
            // TitreFactureMedicament
            // 
            TitreFactureMedicament.AutoSize = true;
            TitreFactureMedicament.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitreFactureMedicament.ForeColor = Color.OliveDrab;
            TitreFactureMedicament.Location = new Point(60, 203);
            TitreFactureMedicament.Name = "TitreFactureMedicament";
            TitreFactureMedicament.Size = new Size(90, 17);
            TitreFactureMedicament.TabIndex = 5;
            TitreFactureMedicament.Text = "FACTURES";
            TitreFactureMedicament.Click += label4_Click;
            // 
            // pictureFactureMedicament
            // 
            pictureFactureMedicament.Image = (Image)resources.GetObject("pictureFactureMedicament.Image");
            pictureFactureMedicament.Location = new Point(0, 191);
            pictureFactureMedicament.Name = "pictureFactureMedicament";
            pictureFactureMedicament.Size = new Size(54, 44);
            pictureFactureMedicament.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFactureMedicament.TabIndex = 4;
            pictureFactureMedicament.TabStop = false;
            pictureFactureMedicament.Click += pictureBox2_Click;
            // 
            // TitreFabricantMedicament
            // 
            TitreFabricantMedicament.AutoSize = true;
            TitreFabricantMedicament.BackColor = Color.Khaki;
            TitreFabricantMedicament.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitreFabricantMedicament.ForeColor = Color.OliveDrab;
            TitreFabricantMedicament.Location = new Point(60, 123);
            TitreFabricantMedicament.Name = "TitreFabricantMedicament";
            TitreFabricantMedicament.Size = new Size(107, 17);
            TitreFabricantMedicament.TabIndex = 3;
            TitreFabricantMedicament.Text = "FABRICANTS";
            TitreFabricantMedicament.Click += label2_Click;
            // 
            // pictureFabricantMedicament
            // 
            pictureFabricantMedicament.Image = (Image)resources.GetObject("pictureFabricantMedicament.Image");
            pictureFabricantMedicament.Location = new Point(3, 108);
            pictureFabricantMedicament.Name = "pictureFabricantMedicament";
            pictureFabricantMedicament.Size = new Size(51, 44);
            pictureFabricantMedicament.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFabricantMedicament.TabIndex = 0;
            pictureFabricantMedicament.TabStop = false;
            pictureFabricantMedicament.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(526, 13);
            label1.Name = "label1";
            label1.Size = new Size(227, 24);
            label1.TabIndex = 2;
            label1.Text = "PHARMACIE MALIKA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(562, 49);
            label3.Name = "label3";
            label3.Size = new Size(155, 22);
            label3.TabIndex = 4;
            label3.Text = "MEDICAMENTS";
            // 
            // PrixAchatMedicament
            // 
            PrixAchatMedicament.Location = new Point(467, 108);
            PrixAchatMedicament.Name = "PrixAchatMedicament";
            PrixAchatMedicament.Size = new Size(120, 23);
            PrixAchatMedicament.TabIndex = 11;
            PrixAchatMedicament.TextChanged += PrixAchatMedicament_TextChanged;
            // 
            // TextFabricantMedicament
            // 
            TextFabricantMedicament.AutoSize = true;
            TextFabricantMedicament.BackColor = Color.OliveDrab;
            TextFabricantMedicament.ForeColor = Color.White;
            TextFabricantMedicament.Location = new Point(804, 87);
            TextFabricantMedicament.Name = "TextFabricantMedicament";
            TextFabricantMedicament.Size = new Size(56, 15);
            TextFabricantMedicament.TabIndex = 10;
            TextFabricantMedicament.Text = "Fabricant";
            // 
            // NomMedicament
            // 
            NomMedicament.Location = new Point(315, 108);
            NomMedicament.Name = "NomMedicament";
            NomMedicament.Size = new Size(135, 23);
            NomMedicament.TabIndex = 13;
            NomMedicament.TextChanged += NomMedicament_TextChanged;
            // 
            // TextNomMedicament
            // 
            TextNomMedicament.AutoSize = true;
            TextNomMedicament.BackColor = Color.OliveDrab;
            TextNomMedicament.ForeColor = Color.White;
            TextNomMedicament.Location = new Point(325, 87);
            TextNomMedicament.Name = "TextNomMedicament";
            TextNomMedicament.Size = new Size(34, 15);
            TextNomMedicament.TabIndex = 12;
            TextNomMedicament.Text = "Nom";
            TextNomMedicament.Click += label7_Click;
            // 
            // QuantiteDisponibleMedicament
            // 
            QuantiteDisponibleMedicament.Location = new Point(619, 108);
            QuantiteDisponibleMedicament.Name = "QuantiteDisponibleMedicament";
            QuantiteDisponibleMedicament.Size = new Size(117, 23);
            QuantiteDisponibleMedicament.TabIndex = 15;
            // 
            // TextPrixAchatMedicament
            // 
            TextPrixAchatMedicament.AutoSize = true;
            TextPrixAchatMedicament.BackColor = Color.OliveDrab;
            TextPrixAchatMedicament.ForeColor = Color.White;
            TextPrixAchatMedicament.Location = new Point(483, 87);
            TextPrixAchatMedicament.Name = "TextPrixAchatMedicament";
            TextPrixAchatMedicament.Size = new Size(61, 15);
            TextPrixAchatMedicament.TabIndex = 14;
            TextPrixAchatMedicament.Text = "Prix Achat";
            TextPrixAchatMedicament.Click += label8_Click;
            // 
            // TextQuantiteDisponibleMedicament
            // 
            TextQuantiteDisponibleMedicament.AutoSize = true;
            TextQuantiteDisponibleMedicament.BackColor = Color.OliveDrab;
            TextQuantiteDisponibleMedicament.ForeColor = Color.White;
            TextQuantiteDisponibleMedicament.Location = new Point(619, 87);
            TextQuantiteDisponibleMedicament.Name = "TextQuantiteDisponibleMedicament";
            TextQuantiteDisponibleMedicament.Size = new Size(112, 15);
            TextQuantiteDisponibleMedicament.TabIndex = 16;
            TextQuantiteDisponibleMedicament.Text = "Quantité Disponible";
            // 
            // FabricantMedicament
            // 
            FabricantMedicament.FormattingEnabled = true;
            FabricantMedicament.Location = new Point(780, 108);
            FabricantMedicament.Name = "FabricantMedicament";
            FabricantMedicament.Size = new Size(121, 23);
            FabricantMedicament.TabIndex = 18;
            FabricantMedicament.SelectedIndexChanged += FabricantMedicament_SelectedIndexChanged;
            // 
            // TextDateExpirationMedicament
            // 
            TextDateExpirationMedicament.AutoSize = true;
            TextDateExpirationMedicament.BackColor = Color.OliveDrab;
            TextDateExpirationMedicament.ForeColor = Color.White;
            TextDateExpirationMedicament.Location = new Point(585, 142);
            TextDateExpirationMedicament.Name = "TextDateExpirationMedicament";
            TextDateExpirationMedicament.Size = new Size(87, 15);
            TextDateExpirationMedicament.TabIndex = 19;
            TextDateExpirationMedicament.Text = "Date Expiration";
            TextDateExpirationMedicament.Click += label10_Click;
            // 
            // DateExpirationMedicament
            // 
            DateExpirationMedicament.Format = DateTimePickerFormat.Short;
            DateExpirationMedicament.Location = new Point(574, 164);
            DateExpirationMedicament.Name = "DateExpirationMedicament";
            DateExpirationMedicament.Size = new Size(114, 23);
            DateExpirationMedicament.TabIndex = 20;
            DateExpirationMedicament.ValueChanged += DateExpirationMedicament_ValueChanged;
            // 
            // TextQuantiteMinimaleMedicament
            // 
            TextQuantiteMinimaleMedicament.AutoSize = true;
            TextQuantiteMinimaleMedicament.BackColor = Color.OliveDrab;
            TextQuantiteMinimaleMedicament.ForeColor = Color.White;
            TextQuantiteMinimaleMedicament.Location = new Point(932, 87);
            TextQuantiteMinimaleMedicament.Name = "TextQuantiteMinimaleMedicament";
            TextQuantiteMinimaleMedicament.Size = new Size(106, 15);
            TextQuantiteMinimaleMedicament.TabIndex = 25;
            TextQuantiteMinimaleMedicament.Text = "Quantité Minimale";
            // 
            // QuantiteMinimaleMedicament
            // 
            QuantiteMinimaleMedicament.Location = new Point(930, 108);
            QuantiteMinimaleMedicament.Name = "QuantiteMinimaleMedicament";
            QuantiteMinimaleMedicament.Size = new Size(115, 23);
            QuantiteMinimaleMedicament.TabIndex = 24;
            // 
            // TextDesignationMedicament
            // 
            TextDesignationMedicament.AutoSize = true;
            TextDesignationMedicament.BackColor = Color.OliveDrab;
            TextDesignationMedicament.ForeColor = Color.White;
            TextDesignationMedicament.Location = new Point(731, 143);
            TextDesignationMedicament.Name = "TextDesignationMedicament";
            TextDesignationMedicament.Size = new Size(70, 15);
            TextDesignationMedicament.TabIndex = 27;
            TextDesignationMedicament.Text = "Désignation";
            TextDesignationMedicament.Click += TextDesignationMedicament_Click;
            // 
            // DesignationMedicament
            // 
            DesignationMedicament.Location = new Point(712, 165);
            DesignationMedicament.Name = "DesignationMedicament";
            DesignationMedicament.Size = new Size(118, 23);
            DesignationMedicament.TabIndex = 26;
            DesignationMedicament.TextChanged += DesignationMedicament_TextChanged;
            // 
            // TextUtilisationsMedicament
            // 
            TextUtilisationsMedicament.AutoSize = true;
            TextUtilisationsMedicament.BackColor = Color.OliveDrab;
            TextUtilisationsMedicament.ForeColor = Color.White;
            TextUtilisationsMedicament.Location = new Point(861, 148);
            TextUtilisationsMedicament.Name = "TextUtilisationsMedicament";
            TextUtilisationsMedicament.Size = new Size(65, 15);
            TextUtilisationsMedicament.TabIndex = 29;
            TextUtilisationsMedicament.Text = "Utilisations";
            // 
            // UtilisationsMedicament
            // 
            UtilisationsMedicament.Location = new Point(846, 166);
            UtilisationsMedicament.Name = "UtilisationsMedicament";
            UtilisationsMedicament.Size = new Size(115, 23);
            UtilisationsMedicament.TabIndex = 28;
            UtilisationsMedicament.TextChanged += UtilisationsMedicament_TextChanged;
            // 
            // TextContreIndicationMedicament
            // 
            TextContreIndicationMedicament.AutoSize = true;
            TextContreIndicationMedicament.BackColor = Color.OliveDrab;
            TextContreIndicationMedicament.ForeColor = Color.White;
            TextContreIndicationMedicament.Location = new Point(407, 212);
            TextContreIndicationMedicament.Name = "TextContreIndicationMedicament";
            TextContreIndicationMedicament.Size = new Size(106, 15);
            TextContreIndicationMedicament.TabIndex = 31;
            TextContreIndicationMedicament.Text = "Contre-indications";
            // 
            // ContreIndicationMedicament
            // 
            ContreIndicationMedicament.Location = new Point(402, 235);
            ContreIndicationMedicament.Name = "ContreIndicationMedicament";
            ContreIndicationMedicament.Size = new Size(122, 23);
            ContreIndicationMedicament.TabIndex = 30;
            // 
            // TextEffetsSecondairesMedicament
            // 
            TextEffetsSecondairesMedicament.AutoSize = true;
            TextEffetsSecondairesMedicament.BackColor = Color.OliveDrab;
            TextEffetsSecondairesMedicament.ForeColor = Color.White;
            TextEffetsSecondairesMedicament.Location = new Point(552, 211);
            TextEffetsSecondairesMedicament.Name = "TextEffetsSecondairesMedicament";
            TextEffetsSecondairesMedicament.Size = new Size(104, 15);
            TextEffetsSecondairesMedicament.TabIndex = 33;
            TextEffetsSecondairesMedicament.Text = " Effets secondaires";
            // 
            // EffetsSecondairesMedicament
            // 
            EffetsSecondairesMedicament.Location = new Point(537, 233);
            EffetsSecondairesMedicament.Name = "EffetsSecondairesMedicament";
            EffetsSecondairesMedicament.Size = new Size(142, 23);
            EffetsSecondairesMedicament.TabIndex = 32;
            // 
            // TextTauxDePriseEnChargeMedicament
            // 
            TextTauxDePriseEnChargeMedicament.AutoSize = true;
            TextTauxDePriseEnChargeMedicament.BackColor = Color.OliveDrab;
            TextTauxDePriseEnChargeMedicament.ForeColor = Color.White;
            TextTauxDePriseEnChargeMedicament.Location = new Point(709, 211);
            TextTauxDePriseEnChargeMedicament.Name = "TextTauxDePriseEnChargeMedicament";
            TextTauxDePriseEnChargeMedicament.Size = new Size(130, 15);
            TextTauxDePriseEnChargeMedicament.TabIndex = 35;
            TextTauxDePriseEnChargeMedicament.Text = "Taux de prise en charge";
            // 
            // TauxDePriseEnChargeMedicament
            // 
            TauxDePriseEnChargeMedicament.Location = new Point(704, 233);
            TauxDePriseEnChargeMedicament.Name = "TauxDePriseEnChargeMedicament";
            TauxDePriseEnChargeMedicament.Size = new Size(142, 23);
            TauxDePriseEnChargeMedicament.TabIndex = 34;
            // 
            // TextCodeABarresMedicament
            // 
            TextCodeABarresMedicament.AutoSize = true;
            TextCodeABarresMedicament.BackColor = Color.OliveDrab;
            TextCodeABarresMedicament.ForeColor = Color.White;
            TextCodeABarresMedicament.Location = new Point(888, 211);
            TextCodeABarresMedicament.Name = "TextCodeABarresMedicament";
            TextCodeABarresMedicament.Size = new Size(79, 15);
            TextCodeABarresMedicament.TabIndex = 37;
            TextCodeABarresMedicament.Text = "Code à barres";
            // 
            // CodeABarresMedicament
            // 
            CodeABarresMedicament.Location = new Point(871, 230);
            CodeABarresMedicament.Name = "CodeABarresMedicament";
            CodeABarresMedicament.Size = new Size(142, 23);
            CodeABarresMedicament.TabIndex = 36;
            // 
            // ReinitialiserMedicament
            // 
            ReinitialiserMedicament.BackColor = Color.OliveDrab;
            ReinitialiserMedicament.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReinitialiserMedicament.ForeColor = Color.White;
            ReinitialiserMedicament.Location = new Point(215, 225);
            ReinitialiserMedicament.Name = "ReinitialiserMedicament";
            ReinitialiserMedicament.Size = new Size(98, 33);
            ReinitialiserMedicament.TabIndex = 38;
            ReinitialiserMedicament.Text = "Reinitialiser";
            ReinitialiserMedicament.UseVisualStyleBackColor = false;
            ReinitialiserMedicament.Click += button_connexion_Click;
            // 
            // SupprimerMedicament
            // 
            SupprimerMedicament.BackColor = Color.OliveDrab;
            SupprimerMedicament.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SupprimerMedicament.ForeColor = Color.White;
            SupprimerMedicament.Location = new Point(214, 169);
            SupprimerMedicament.Name = "SupprimerMedicament";
            SupprimerMedicament.Size = new Size(99, 33);
            SupprimerMedicament.TabIndex = 39;
            SupprimerMedicament.Text = "supprimer";
            SupprimerMedicament.UseVisualStyleBackColor = false;
            SupprimerMedicament.Click += button1_Click;
            // 
            // ModifierMedicamaent
            // 
            ModifierMedicamaent.BackColor = Color.OliveDrab;
            ModifierMedicamaent.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ModifierMedicamaent.ForeColor = Color.White;
            ModifierMedicamaent.Location = new Point(215, 112);
            ModifierMedicamaent.Name = "ModifierMedicamaent";
            ModifierMedicamaent.Size = new Size(94, 40);
            ModifierMedicamaent.TabIndex = 40;
            ModifierMedicamaent.Text = "Modifier";
            ModifierMedicamaent.UseVisualStyleBackColor = false;
            ModifierMedicamaent.Click += ModifierMedicamaent_Click;
            // 
            // AjouterMedicament
            // 
            AjouterMedicament.BackColor = Color.OliveDrab;
            AjouterMedicament.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AjouterMedicament.ForeColor = Color.White;
            AjouterMedicament.Location = new Point(214, 62);
            AjouterMedicament.Name = "AjouterMedicament";
            AjouterMedicament.Size = new Size(95, 31);
            AjouterMedicament.TabIndex = 41;
            AjouterMedicament.Text = "Ajouter";
            AjouterMedicament.UseVisualStyleBackColor = false;
            AjouterMedicament.Click += AjouterMedicament_Click;
            // 
            // StockMedicament
            // 
            StockMedicament.AutoSize = true;
            StockMedicament.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            StockMedicament.ForeColor = Color.ForestGreen;
            StockMedicament.Location = new Point(537, 279);
            StockMedicament.Name = "StockMedicament";
            StockMedicament.Size = new Size(176, 22);
            StockMedicament.TabIndex = 42;
            StockMedicament.Text = "ListeMedicaments";
            // 
            // DgvMedicament
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            DgvMedicament.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvMedicament.BackgroundColor = Color.Khaki;
            DgvMedicament.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvMedicament.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvMedicament.ColumnHeadersHeight = 20;
            DgvMedicament.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvMedicament.Columns.AddRange(new DataGridViewColumn[] { MedNum, MedNom, MedPrixA, MedQteM, MedExp, MedDesig, MedQteD, MedUtili, MedContInd, MedEffet, MedTpc, MedCodBa, IdFabrican, MedPrixV });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvMedicament.DefaultCellStyle = dataGridViewCellStyle3;
            DgvMedicament.GridColor = Color.FromArgb(231, 229, 255);
            DgvMedicament.Location = new Point(215, 304);
            DgvMedicament.MultiSelect = false;
            DgvMedicament.Name = "DgvMedicament";
            DgvMedicament.ReadOnly = true;
            DgvMedicament.RowHeadersVisible = false;
            DgvMedicament.RowTemplate.Height = 25;
            DgvMedicament.Size = new Size(840, 240);
            DgvMedicament.TabIndex = 82;
            DgvMedicament.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DgvMedicament.ThemeStyle.AlternatingRowsStyle.Font = null;
            DgvMedicament.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DgvMedicament.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DgvMedicament.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DgvMedicament.ThemeStyle.BackColor = Color.Khaki;
            DgvMedicament.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DgvMedicament.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DgvMedicament.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            DgvMedicament.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DgvMedicament.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DgvMedicament.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvMedicament.ThemeStyle.HeaderStyle.Height = 20;
            DgvMedicament.ThemeStyle.ReadOnly = true;
            DgvMedicament.ThemeStyle.RowsStyle.BackColor = Color.White;
            DgvMedicament.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvMedicament.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DgvMedicament.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DgvMedicament.ThemeStyle.RowsStyle.Height = 25;
            DgvMedicament.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DgvMedicament.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DgvMedicament.CellContentClick += DgvMedicament_CellContentClick;
            // 
            // textMedPrixV
            // 
            textMedPrixV.Location = new Point(396, 164);
            textMedPrixV.Name = "textMedPrixV";
            textMedPrixV.Size = new Size(142, 23);
            textMedPrixV.TabIndex = 84;
            textMedPrixV.TextChanged += MedPrixV_TextChanged;
            // 
            // PrixV
            // 
            PrixV.AutoSize = true;
            PrixV.BackColor = Color.OliveDrab;
            PrixV.ForeColor = Color.White;
            PrixV.Location = new Point(413, 143);
            PrixV.Name = "PrixV";
            PrixV.Size = new Size(59, 15);
            PrixV.TabIndex = 83;
            PrixV.Text = "Prix Vente";
            PrixV.Click += PrixV_Click;
            // 
            // MedNum
            // 
            MedNum.DataPropertyName = "MedNum";
            MedNum.HeaderText = "ID";
            MedNum.Name = "MedNum";
            MedNum.ReadOnly = true;
            MedNum.Visible = false;
            // 
            // MedNom
            // 
            MedNom.DataPropertyName = "MedNom";
            MedNom.HeaderText = "Nom";
            MedNom.Name = "MedNom";
            MedNom.ReadOnly = true;
            // 
            // MedPrixA
            // 
            MedPrixA.DataPropertyName = "MedPrixA";
            MedPrixA.HeaderText = "Prix Achat";
            MedPrixA.Name = "MedPrixA";
            MedPrixA.ReadOnly = true;
            // 
            // MedQteM
            // 
            MedQteM.DataPropertyName = "MedQteM";
            MedQteM.HeaderText = "Quantité Minimale";
            MedQteM.Name = "MedQteM";
            MedQteM.ReadOnly = true;
            // 
            // MedExp
            // 
            MedExp.DataPropertyName = "MedExp";
            MedExp.HeaderText = "Date Expiration";
            MedExp.Name = "MedExp";
            MedExp.ReadOnly = true;
            // 
            // MedDesig
            // 
            MedDesig.DataPropertyName = "MedDesig";
            MedDesig.HeaderText = "Désignation";
            MedDesig.Name = "MedDesig";
            MedDesig.ReadOnly = true;
            // 
            // MedQteD
            // 
            MedQteD.DataPropertyName = "MedQteD";
            MedQteD.HeaderText = "Quantité Disponible";
            MedQteD.Name = "MedQteD";
            MedQteD.ReadOnly = true;
            // 
            // MedUtili
            // 
            MedUtili.DataPropertyName = "MedUtili";
            MedUtili.HeaderText = "Utilisations";
            MedUtili.Name = "MedUtili";
            MedUtili.ReadOnly = true;
            // 
            // MedContInd
            // 
            MedContInd.DataPropertyName = "MedContInd";
            MedContInd.HeaderText = "Contre-indications";
            MedContInd.Name = "MedContInd";
            MedContInd.ReadOnly = true;
            // 
            // MedEffet
            // 
            MedEffet.DataPropertyName = "MedEffet";
            MedEffet.HeaderText = "Effets secondaires";
            MedEffet.Name = "MedEffet";
            MedEffet.ReadOnly = true;
            // 
            // MedTpc
            // 
            MedTpc.DataPropertyName = "MedTpc";
            MedTpc.HeaderText = "Taux de prise en charge";
            MedTpc.Name = "MedTpc";
            MedTpc.ReadOnly = true;
            // 
            // MedCodBa
            // 
            MedCodBa.DataPropertyName = "MedCodBa";
            MedCodBa.HeaderText = "Code à barres";
            MedCodBa.Name = "MedCodBa";
            MedCodBa.ReadOnly = true;
            // 
            // IdFabrican
            // 
            IdFabrican.DataPropertyName = "IdFabrican";
            IdFabrican.HeaderText = "Fabricant";
            IdFabrican.Name = "IdFabrican";
            IdFabrican.ReadOnly = true;
            // 
            // MedPrixV
            // 
            MedPrixV.DataPropertyName = "MedPrixV";
            MedPrixV.HeaderText = "Prix vente";
            MedPrixV.Name = "MedPrixV";
            MedPrixV.ReadOnly = true;
            // 
            // Medicaments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(1069, 547);
            Controls.Add(textMedPrixV);
            Controls.Add(PrixV);
            Controls.Add(DgvMedicament);
            Controls.Add(StockMedicament);
            Controls.Add(AjouterMedicament);
            Controls.Add(ModifierMedicamaent);
            Controls.Add(SupprimerMedicament);
            Controls.Add(ReinitialiserMedicament);
            Controls.Add(TextCodeABarresMedicament);
            Controls.Add(CodeABarresMedicament);
            Controls.Add(TextTauxDePriseEnChargeMedicament);
            Controls.Add(TauxDePriseEnChargeMedicament);
            Controls.Add(TextEffetsSecondairesMedicament);
            Controls.Add(EffetsSecondairesMedicament);
            Controls.Add(TextContreIndicationMedicament);
            Controls.Add(ContreIndicationMedicament);
            Controls.Add(TextUtilisationsMedicament);
            Controls.Add(UtilisationsMedicament);
            Controls.Add(TextDesignationMedicament);
            Controls.Add(DesignationMedicament);
            Controls.Add(TextQuantiteMinimaleMedicament);
            Controls.Add(QuantiteMinimaleMedicament);
            Controls.Add(DateExpirationMedicament);
            Controls.Add(TextDateExpirationMedicament);
            Controls.Add(FabricantMedicament);
            Controls.Add(TextQuantiteDisponibleMedicament);
            Controls.Add(QuantiteDisponibleMedicament);
            Controls.Add(TextPrixAchatMedicament);
            Controls.Add(NomMedicament);
            Controls.Add(TextNomMedicament);
            Controls.Add(PrixAchatMedicament);
            Controls.Add(TextFabricantMedicament);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Medicaments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicaments";
            Load += Medicaments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTableauDeBordMedicament).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFactureMedicament).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFabricantMedicament).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvMedicament).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureFabricantMedicament;
        private Label TitreFabricantMedicament;
        private Label TitreFactureMedicament;
        private PictureBox pictureFactureMedicament;
        private Label label3;
        private Label TitreTableaudeBordMedicament;
        private PictureBox pictureTableauDeBordMedicament;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private TextBox PrixAchatMedicament;
        private Label TextFabricantMedicament;
        private TextBox NomMedicament;
        private Label TextNomMedicament;
        private TextBox QuantiteDisponibleMedicament;
        private Label TextPrixAchatMedicament;
        //private TextBox PhotoMedicament;
        private Label TextQuantiteDisponibleMedicament;
        private ComboBox FabricantMedicament;
        private Label TextDateExpirationMedicament;
        private DateTimePicker DateExpirationMedicament;
        private Label label11;
        //private TextBox textBox4;
        //private Label label12;
        private Label TextQuantiteMinimaleMedicament;
        private TextBox QuantiteMinimaleMedicament;
        private Label TextDesignationMedicament;
        private TextBox DesignationMedicament;
        private Label TextUtilisationsMedicament;
        private TextBox UtilisationsMedicament;
        private Label TextContreIndicationMedicament;
        private TextBox ContreIndicationMedicament;
        private Label TextEffetsSecondairesMedicament;
        private TextBox EffetsSecondairesMedicament;
        private Label TextTauxDePriseEnChargeMedicament;
        private TextBox TauxDePriseEnChargeMedicament;
        private Label TextCodeABarresMedicament;
        private TextBox CodeABarresMedicament;
        private Button ReinitialiserMedicament;
        private Button SupprimerMedicament;
        private Button ModifierMedicamaent;
        private Button AjouterMedicament;
        private Label StockMedicament;
        private Guna.UI2.WinForms.Guna2DataGridView DgvMedicament;
        private TextBox textMedPrixV;
        private Label PrixV;
        private DataGridViewTextBoxColumn MedNum;
        private DataGridViewTextBoxColumn MedNom;
        private DataGridViewTextBoxColumn MedPrixA;
        private DataGridViewTextBoxColumn MedQteM;
        private DataGridViewTextBoxColumn MedExp;
        private DataGridViewTextBoxColumn MedDesig;
        private DataGridViewTextBoxColumn MedQteD;
        private DataGridViewTextBoxColumn MedUtili;
        private DataGridViewTextBoxColumn MedContInd;
        private DataGridViewTextBoxColumn MedEffet;
        private DataGridViewTextBoxColumn MedTpc;
        private DataGridViewTextBoxColumn MedCodBa;
        private DataGridViewTextBoxColumn IdFabrican;
        private DataGridViewTextBoxColumn MedPrixV;
        //private Label label2;
        //private PictureBox insertionPictureMedicament;
    }
}