namespace Logiciel_de_gestion_de_la_pharmacie
{
    partial class Facture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            TextNomClient = new Label();
            TextQuantite = new TextBox();
            QuantiteFAC = new Label();
            Date = new Label();
            TextHT = new TextBox();
            HTfacture = new Label();
            Numero = new Label();
            TextTva = new TextBox();
            TVAfacture = new Label();
            TextDesginationMed = new TextBox();
            Desgination = new Label();
            TextTTC = new TextBox();
            TTCfacture = new Label();
            TextPU = new TextBox();
            PUfacture = new Label();
            TextTauxTVA = new TextBox();
            TauxFacture = new Label();
            DataGridFacture = new Guna.UI2.WinForms.Guna2DataGridView();
            NumFacture = new DataGridViewTextBoxColumn();
            MedNum = new DataGridViewTextBoxColumn();
            NumClient = new DataGridViewTextBoxColumn();
            DateFacture = new DataGridViewTextBoxColumn();
            DesginationMed = new DataGridViewTextBoxColumn();
            Quantite = new DataGridViewTextBoxColumn();
            HT = new DataGridViewTextBoxColumn();
            Tva = new DataGridViewTextBoxColumn();
            TTC = new DataGridViewTextBoxColumn();
            PU = new DataGridViewTextBoxColumn();
            TauxTva = new DataGridViewTextBoxColumn();
            TextNumFacture = new TextBox();
            numerofacture = new Label();
            AjouterFacture = new Button();
            ModifierFacture = new Button();
            SupprimerFacture = new Button();
            ReinitialiserFacture = new Button();
            TextDateFacture = new DateTimePicker();
            TextNumClient = new ComboBox();
            TextMedNum = new ComboBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DataGridFacture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // TextNomClient
            // 
            TextNomClient.AutoSize = true;
            TextNomClient.BackColor = Color.ForestGreen;
            TextNomClient.ForeColor = Color.White;
            TextNomClient.Location = new Point(723, 69);
            TextNomClient.Name = "TextNomClient";
            TextNomClient.Size = new Size(68, 15);
            TextNomClient.TabIndex = 52;
            TextNomClient.Text = "Nom Client";
            // 
            // TextQuantite
            // 
            TextQuantite.Location = new Point(552, 151);
            TextQuantite.Name = "TextQuantite";
            TextQuantite.Size = new Size(142, 23);
            TextQuantite.TabIndex = 55;
            // 
            // QuantiteFAC
            // 
            QuantiteFAC.AutoSize = true;
            QuantiteFAC.BackColor = Color.ForestGreen;
            QuantiteFAC.ForeColor = Color.White;
            QuantiteFAC.Location = new Point(569, 130);
            QuantiteFAC.Name = "QuantiteFAC";
            QuantiteFAC.Size = new Size(53, 15);
            QuantiteFAC.TabIndex = 54;
            QuantiteFAC.Text = "Quantite";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.BackColor = Color.ForestGreen;
            Date.ForeColor = Color.White;
            Date.Location = new Point(552, 9);
            Date.Name = "Date";
            Date.Size = new Size(73, 15);
            Date.TabIndex = 56;
            Date.Text = "Date Facture";
            // 
            // TextHT
            // 
            TextHT.Location = new Point(535, 90);
            TextHT.Name = "TextHT";
            TextHT.Size = new Size(142, 23);
            TextHT.TabIndex = 61;
            // 
            // HTfacture
            // 
            HTfacture.AutoSize = true;
            HTfacture.BackColor = Color.ForestGreen;
            HTfacture.ForeColor = Color.White;
            HTfacture.Location = new Point(552, 69);
            HTfacture.Name = "HTfacture";
            HTfacture.Size = new Size(22, 15);
            HTfacture.TabIndex = 60;
            HTfacture.Text = "HT";
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.BackColor = Color.ForestGreen;
            Numero.ForeColor = Color.White;
            Numero.Location = new Point(356, 9);
            Numero.Name = "Numero";
            Numero.Size = new Size(126, 15);
            Numero.TabIndex = 62;
            Numero.Text = "Numero Medicaments";
            // 
            // TextTva
            // 
            TextTva.Location = new Point(356, 90);
            TextTva.Name = "TextTva";
            TextTva.Size = new Size(142, 23);
            TextTva.TabIndex = 65;
            // 
            // TVAfacture
            // 
            TVAfacture.AutoSize = true;
            TVAfacture.BackColor = Color.ForestGreen;
            TVAfacture.ForeColor = Color.White;
            TVAfacture.Location = new Point(373, 69);
            TVAfacture.Name = "TVAfacture";
            TVAfacture.Size = new Size(27, 15);
            TVAfacture.TabIndex = 64;
            TVAfacture.Text = "TVA";
            // 
            // TextDesginationMed
            // 
            TextDesginationMed.Location = new Point(185, 30);
            TextDesginationMed.Name = "TextDesginationMed";
            TextDesginationMed.Size = new Size(142, 23);
            TextDesginationMed.TabIndex = 67;
            // 
            // Desgination
            // 
            Desgination.AutoSize = true;
            Desgination.BackColor = Color.ForestGreen;
            Desgination.ForeColor = Color.White;
            Desgination.Location = new Point(202, 9);
            Desgination.Name = "Desgination";
            Desgination.Size = new Size(70, 15);
            Desgination.TabIndex = 66;
            Desgination.Text = "Designation";
            // 
            // TextTTC
            // 
            TextTTC.Location = new Point(184, 90);
            TextTTC.Name = "TextTTC";
            TextTTC.Size = new Size(142, 23);
            TextTTC.TabIndex = 69;
            // 
            // TTCfacture
            // 
            TTCfacture.AutoSize = true;
            TTCfacture.BackColor = Color.ForestGreen;
            TTCfacture.ForeColor = Color.White;
            TTCfacture.Location = new Point(201, 69);
            TTCfacture.Name = "TTCfacture";
            TTCfacture.Size = new Size(26, 15);
            TTCfacture.TabIndex = 68;
            TTCfacture.Text = "TTC";
            // 
            // TextPU
            // 
            TextPU.Location = new Point(373, 151);
            TextPU.Name = "TextPU";
            TextPU.Size = new Size(142, 23);
            TextPU.TabIndex = 71;
            // 
            // PUfacture
            // 
            PUfacture.AutoSize = true;
            PUfacture.BackColor = Color.ForestGreen;
            PUfacture.ForeColor = Color.White;
            PUfacture.Location = new Point(390, 130);
            PUfacture.Name = "PUfacture";
            PUfacture.Size = new Size(22, 15);
            PUfacture.TabIndex = 70;
            PUfacture.Text = "PU";
            // 
            // TextTauxTVA
            // 
            TextTauxTVA.Location = new Point(178, 151);
            TextTauxTVA.Name = "TextTauxTVA";
            TextTauxTVA.Size = new Size(142, 23);
            TextTauxTVA.TabIndex = 73;
            TextTauxTVA.TextChanged += TauxTVA_TextChanged;
            // 
            // TauxFacture
            // 
            TauxFacture.AutoSize = true;
            TauxFacture.BackColor = Color.ForestGreen;
            TauxFacture.ForeColor = Color.White;
            TauxFacture.Location = new Point(195, 130);
            TauxFacture.Name = "TauxFacture";
            TauxFacture.Size = new Size(31, 15);
            TauxFacture.TabIndex = 72;
            TauxFacture.Text = "Taux";
            // 
            // DataGridFacture
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridFacture.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridFacture.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridFacture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridFacture.ColumnHeadersHeight = 20;
            DataGridFacture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridFacture.Columns.AddRange(new DataGridViewColumn[] { NumFacture, MedNum, NumClient, DateFacture, DesginationMed, Quantite, HT, Tva, TTC, PU, TauxTva });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridFacture.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridFacture.GridColor = Color.FromArgb(231, 229, 255);
            DataGridFacture.Location = new Point(108, 180);
            DataGridFacture.Name = "DataGridFacture";
            DataGridFacture.RowHeadersVisible = false;
            DataGridFacture.RowTemplate.Height = 25;
            DataGridFacture.Size = new Size(754, 265);
            DataGridFacture.TabIndex = 74;
            DataGridFacture.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridFacture.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridFacture.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridFacture.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridFacture.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridFacture.ThemeStyle.BackColor = Color.White;
            DataGridFacture.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridFacture.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridFacture.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridFacture.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridFacture.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridFacture.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridFacture.ThemeStyle.HeaderStyle.Height = 20;
            DataGridFacture.ThemeStyle.ReadOnly = false;
            DataGridFacture.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridFacture.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridFacture.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridFacture.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridFacture.ThemeStyle.RowsStyle.Height = 25;
            DataGridFacture.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridFacture.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridFacture.CellContentClick += DataGridFacture_CellContentClick;
            // 
            // NumFacture
            // 
            NumFacture.DataPropertyName = "NumFacture";
            NumFacture.HeaderText = "Numero facture";
            NumFacture.Name = "NumFacture";
            NumFacture.Visible = false;
            // 
            // MedNum
            // 
            MedNum.DataPropertyName = "MedNum";
            MedNum.HeaderText = "Numero Medicament";
            MedNum.Name = "MedNum";
            // 
            // NumClient
            // 
            NumClient.DataPropertyName = "NumClient";
            NumClient.HeaderText = "Numero Client";
            NumClient.Name = "NumClient";
            // 
            // DateFacture
            // 
            DateFacture.DataPropertyName = "DateFacture";
            DateFacture.HeaderText = "Date Facture";
            DateFacture.Name = "DateFacture";
            // 
            // DesginationMed
            // 
            DesginationMed.DataPropertyName = "DesginationMed";
            DesginationMed.HeaderText = "Designation";
            DesginationMed.Name = "DesginationMed";
            // 
            // Quantite
            // 
            Quantite.DataPropertyName = "Quantite";
            Quantite.HeaderText = "Quantite";
            Quantite.Name = "Quantite";
            // 
            // HT
            // 
            HT.DataPropertyName = "HT";
            HT.HeaderText = "HT";
            HT.Name = "HT";
            // 
            // Tva
            // 
            Tva.DataPropertyName = "Tva";
            Tva.HeaderText = "Tva";
            Tva.Name = "Tva";
            // 
            // TTC
            // 
            TTC.DataPropertyName = "TTC";
            TTC.HeaderText = "TTC";
            TTC.Name = "TTC";
            // 
            // PU
            // 
            PU.DataPropertyName = "PU";
            PU.HeaderText = "PU";
            PU.Name = "PU";
            // 
            // TauxTva
            // 
            TauxTva.DataPropertyName = "TauxTva";
            TauxTva.HeaderText = "Taux";
            TauxTva.Name = "TauxTva";
            // 
            // TextNumFacture
            // 
            TextNumFacture.Location = new Point(706, 30);
            TextNumFacture.Name = "TextNumFacture";
            TextNumFacture.Size = new Size(142, 23);
            TextNumFacture.TabIndex = 76;
            // 
            // numerofacture
            // 
            numerofacture.AutoSize = true;
            numerofacture.BackColor = Color.ForestGreen;
            numerofacture.ForeColor = Color.White;
            numerofacture.Location = new Point(723, 9);
            numerofacture.Name = "numerofacture";
            numerofacture.Size = new Size(93, 15);
            numerofacture.TabIndex = 75;
            numerofacture.Text = "Numéro Facture";
            // 
            // AjouterFacture
            // 
            AjouterFacture.BackColor = Color.ForestGreen;
            AjouterFacture.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AjouterFacture.ForeColor = Color.White;
            AjouterFacture.Location = new Point(7, 12);
            AjouterFacture.Name = "AjouterFacture";
            AjouterFacture.Size = new Size(90, 29);
            AjouterFacture.TabIndex = 80;
            AjouterFacture.Text = "Ajouter";
            AjouterFacture.UseVisualStyleBackColor = false;
            AjouterFacture.Click += AjouterFacture_Click;
            // 
            // ModifierFacture
            // 
            ModifierFacture.BackColor = Color.ForestGreen;
            ModifierFacture.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ModifierFacture.ForeColor = Color.White;
            ModifierFacture.Location = new Point(8, 60);
            ModifierFacture.Name = "ModifierFacture";
            ModifierFacture.Size = new Size(88, 30);
            ModifierFacture.TabIndex = 79;
            ModifierFacture.Text = "Modifier";
            ModifierFacture.UseVisualStyleBackColor = false;
            ModifierFacture.Click += ModifierFacture_Click;
            // 
            // SupprimerFacture
            // 
            SupprimerFacture.BackColor = Color.ForestGreen;
            SupprimerFacture.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SupprimerFacture.ForeColor = Color.White;
            SupprimerFacture.Location = new Point(8, 117);
            SupprimerFacture.Name = "SupprimerFacture";
            SupprimerFacture.Size = new Size(87, 34);
            SupprimerFacture.TabIndex = 78;
            SupprimerFacture.Text = "supprimer";
            SupprimerFacture.UseVisualStyleBackColor = false;
            SupprimerFacture.Click += SupprimerFacture_Click;
            // 
            // ReinitialiserFacture
            // 
            ReinitialiserFacture.BackColor = Color.ForestGreen;
            ReinitialiserFacture.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReinitialiserFacture.ForeColor = Color.White;
            ReinitialiserFacture.Location = new Point(4, 180);
            ReinitialiserFacture.Name = "ReinitialiserFacture";
            ReinitialiserFacture.Size = new Size(98, 33);
            ReinitialiserFacture.TabIndex = 77;
            ReinitialiserFacture.Text = "Reinitialiser";
            ReinitialiserFacture.UseVisualStyleBackColor = false;
            ReinitialiserFacture.Click += ReinitialiserFacture_Click;
            // 
            // TextDateFacture
            // 
            TextDateFacture.Format = DateTimePickerFormat.Short;
            TextDateFacture.Location = new Point(535, 31);
            TextDateFacture.Name = "TextDateFacture";
            TextDateFacture.Size = new Size(142, 23);
            TextDateFacture.TabIndex = 81;
            TextDateFacture.ValueChanged += DateFacture_ValueChanged;
            // 
            // TextNumClient
            // 
            TextNumClient.FormattingEnabled = true;
            TextNumClient.Location = new Point(706, 100);
            TextNumClient.Name = "TextNumClient";
            TextNumClient.Size = new Size(121, 23);
            TextNumClient.TabIndex = 82;
            // 
            // TextMedNum
            // 
            TextMedNum.FormattingEnabled = true;
            TextMedNum.Location = new Point(356, 31);
            TextMedNum.Name = "TextMedNum";
            TextMedNum.Size = new Size(121, 23);
            TextMedNum.TabIndex = 83;
            TextMedNum.SelectedIndexChanged += TextMedNum_SelectedIndexChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(21, 378);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 84;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Facture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(874, 464);
            Controls.Add(pictureBox4);
            Controls.Add(TextMedNum);
            Controls.Add(TextNumClient);
            Controls.Add(TextDateFacture);
            Controls.Add(AjouterFacture);
            Controls.Add(ModifierFacture);
            Controls.Add(SupprimerFacture);
            Controls.Add(ReinitialiserFacture);
            Controls.Add(TextNumFacture);
            Controls.Add(numerofacture);
            Controls.Add(DataGridFacture);
            Controls.Add(TextTauxTVA);
            Controls.Add(TauxFacture);
            Controls.Add(TextPU);
            Controls.Add(PUfacture);
            Controls.Add(TextTTC);
            Controls.Add(TTCfacture);
            Controls.Add(TextDesginationMed);
            Controls.Add(Desgination);
            Controls.Add(TextTva);
            Controls.Add(TVAfacture);
            Controls.Add(Numero);
            Controls.Add(TextHT);
            Controls.Add(HTfacture);
            Controls.Add(Date);
            Controls.Add(TextQuantite);
            Controls.Add(QuantiteFAC);
            Controls.Add(TextNomClient);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Facture";
            Text = "Facture";
            Load += Facture_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridFacture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TextNomClient;
        private TextBox TextQuantite;
        private Label QuantiteFAC;
        private DateTimePicker TextDateFacture;
        private Label Date;
        private TextBox TextHT;
        private Label HTfacture;
        //private TextBox NumMedi;
        private Label Numero;
        private TextBox TextTva;
        private Label TVAfacture;
        private TextBox TextDesginationMed;
        private Label Desgination;
        private TextBox TextTTC;
        private Label TTCfacture;
        private TextBox TextPU;
        private Label PUfacture;
        private TextBox TextTauxTVA;
        private Label TauxFacture;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridFacture;
        private TextBox TextNumFacture;
        private Label numerofacture;
        private Button AjouterFacture;
        private Button ModifierFacture;
        private Button SupprimerFacture;
        private Button ReinitialiserFacture;
        private DateTimePicker DateExpirationMedicament;
        private ComboBox TextNumClient;
        private ComboBox FabricantMedicament;
        private ComboBox TextMedNum;
        private PictureBox pictureBox4;
        private DataGridViewTextBoxColumn NumFacture;
        private DataGridViewTextBoxColumn MedNum;
        private DataGridViewTextBoxColumn NumClient;
        private DataGridViewTextBoxColumn DateFacture;
        private DataGridViewTextBoxColumn DesginationMed;
        private DataGridViewTextBoxColumn Quantite;
        private DataGridViewTextBoxColumn HT;
        private DataGridViewTextBoxColumn Tva;
        private DataGridViewTextBoxColumn TTC;
        private DataGridViewTextBoxColumn PU;
        private DataGridViewTextBoxColumn TauxTva;
    }
}