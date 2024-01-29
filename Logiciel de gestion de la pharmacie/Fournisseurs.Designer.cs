namespace Logiciel_de_gestion_de_la_pharmacie
{
    partial class Fournisseurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fournisseurs));
            ComboboxICEFRs = new TextBox();
            ListeFournisseurs = new Label();
            DataGridFournisseurs = new Guna.UI2.WinForms.Guna2DataGridView();
            NumFRs = new DataGridViewTextBoxColumn();
            NomFRs = new DataGridViewTextBoxColumn();
            TeleFRs = new DataGridViewTextBoxColumn();
            IFFRs = new DataGridViewTextBoxColumn();
            ICEFRs = new DataGridViewTextBoxColumn();
            AdresseFRs = new DataGridViewTextBoxColumn();
            AjouterFRs = new Button();
            ModifierFRs = new Button();
            SupprimerFRs = new Button();
            ReinitialiserFRs = new Button();
            TextTelephoneFRs = new Label();
            ComboboxTeleFRs = new TextBox();
            AdresseClients = new Label();
            ComboboxAdresseFRs = new TextBox();
            IF = new Label();
            ComboboxIFFRs = new TextBox();
            ComboboxNomFRs = new TextBox();
            TextNomFRs = new Label();
            ICE = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DataGridFournisseurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // ComboboxICEFRs
            // 
            ComboboxICEFRs.Location = new Point(741, 45);
            ComboboxICEFRs.Name = "ComboboxICEFRs";
            ComboboxICEFRs.Size = new Size(115, 23);
            ComboboxICEFRs.TabIndex = 64;
            // 
            // ListeFournisseurs
            // 
            ListeFournisseurs.AutoSize = true;
            ListeFournisseurs.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListeFournisseurs.ForeColor = Color.ForestGreen;
            ListeFournisseurs.Location = new Point(533, 107);
            ListeFournisseurs.Name = "ListeFournisseurs";
            ListeFournisseurs.Size = new Size(171, 22);
            ListeFournisseurs.TabIndex = 63;
            ListeFournisseurs.Text = "ListeFournisseurs";
            // 
            // DataGridFournisseurs
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridFournisseurs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridFournisseurs.BackgroundColor = Color.Khaki;
            DataGridFournisseurs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridFournisseurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridFournisseurs.ColumnHeadersHeight = 20;
            DataGridFournisseurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridFournisseurs.Columns.AddRange(new DataGridViewColumn[] { NumFRs, NomFRs, TeleFRs, IFFRs, ICEFRs, AdresseFRs });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridFournisseurs.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridFournisseurs.GridColor = Color.FromArgb(231, 229, 255);
            DataGridFournisseurs.Location = new Point(141, 150);
            DataGridFournisseurs.Name = "DataGridFournisseurs";
            DataGridFournisseurs.RowHeadersVisible = false;
            DataGridFournisseurs.RowTemplate.Height = 25;
            DataGridFournisseurs.Size = new Size(880, 326);
            DataGridFournisseurs.TabIndex = 62;
            DataGridFournisseurs.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridFournisseurs.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridFournisseurs.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridFournisseurs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridFournisseurs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridFournisseurs.ThemeStyle.BackColor = Color.Khaki;
            DataGridFournisseurs.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridFournisseurs.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridFournisseurs.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridFournisseurs.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridFournisseurs.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridFournisseurs.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridFournisseurs.ThemeStyle.HeaderStyle.Height = 20;
            DataGridFournisseurs.ThemeStyle.ReadOnly = false;
            DataGridFournisseurs.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridFournisseurs.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridFournisseurs.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridFournisseurs.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridFournisseurs.ThemeStyle.RowsStyle.Height = 25;
            DataGridFournisseurs.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridFournisseurs.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridFournisseurs.CellContentClick += DataGridFournisseurs_CellContentClick;
            // 
            // NumFRs
            // 
            NumFRs.DataPropertyName = "NumFRs";
            NumFRs.HeaderText = "Numerofacture";
            NumFRs.Name = "NumFRs";
            NumFRs.Visible = false;
            // 
            // NomFRs
            // 
            NomFRs.DataPropertyName = "NomFRs";
            NomFRs.HeaderText = "Nom Fournisseur";
            NomFRs.Name = "NomFRs";
            // 
            // TeleFRs
            // 
            TeleFRs.DataPropertyName = "TeleFRs";
            TeleFRs.HeaderText = "Telephone";
            TeleFRs.Name = "TeleFRs";
            // 
            // IFFRs
            // 
            IFFRs.DataPropertyName = "IFFRs";
            IFFRs.HeaderText = "IF";
            IFFRs.Name = "IFFRs";
            // 
            // ICEFRs
            // 
            ICEFRs.DataPropertyName = "ICEFRs";
            ICEFRs.HeaderText = "ICE";
            ICEFRs.Name = "ICEFRs";
            // 
            // AdresseFRs
            // 
            AdresseFRs.DataPropertyName = "AdresseFRs";
            AdresseFRs.HeaderText = "Adresse";
            AdresseFRs.Name = "AdresseFRs";
            // 
            // AjouterFRs
            // 
            AjouterFRs.BackColor = Color.OliveDrab;
            AjouterFRs.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AjouterFRs.ForeColor = Color.White;
            AjouterFRs.Location = new Point(18, 22);
            AjouterFRs.Name = "AjouterFRs";
            AjouterFRs.Size = new Size(104, 35);
            AjouterFRs.TabIndex = 61;
            AjouterFRs.Text = "Ajouter";
            AjouterFRs.UseVisualStyleBackColor = false;
            AjouterFRs.Click += AjouterFRs_Click;
            // 
            // ModifierFRs
            // 
            ModifierFRs.BackColor = Color.OliveDrab;
            ModifierFRs.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ModifierFRs.ForeColor = Color.White;
            ModifierFRs.Location = new Point(20, 82);
            ModifierFRs.Name = "ModifierFRs";
            ModifierFRs.Size = new Size(102, 34);
            ModifierFRs.TabIndex = 60;
            ModifierFRs.Text = "Modifier";
            ModifierFRs.UseVisualStyleBackColor = false;
            ModifierFRs.Click += ModifierFRs_Click;
            // 
            // SupprimerFRs
            // 
            SupprimerFRs.BackColor = Color.OliveDrab;
            SupprimerFRs.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SupprimerFRs.ForeColor = Color.White;
            SupprimerFRs.Location = new Point(18, 149);
            SupprimerFRs.Name = "SupprimerFRs";
            SupprimerFRs.Size = new Size(104, 39);
            SupprimerFRs.TabIndex = 59;
            SupprimerFRs.Text = "supprimer";
            SupprimerFRs.UseVisualStyleBackColor = false;
            SupprimerFRs.Click += SupprimerFRs_Click;
            // 
            // ReinitialiserFRs
            // 
            ReinitialiserFRs.BackColor = Color.OliveDrab;
            ReinitialiserFRs.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReinitialiserFRs.ForeColor = Color.White;
            ReinitialiserFRs.Location = new Point(20, 206);
            ReinitialiserFRs.Name = "ReinitialiserFRs";
            ReinitialiserFRs.Size = new Size(102, 37);
            ReinitialiserFRs.TabIndex = 58;
            ReinitialiserFRs.Text = "Reinitialiser";
            ReinitialiserFRs.UseVisualStyleBackColor = false;
            ReinitialiserFRs.Click += ReinitialiserFRs_Click;
            // 
            // TextTelephoneFRs
            // 
            TextTelephoneFRs.AutoSize = true;
            TextTelephoneFRs.BackColor = Color.OliveDrab;
            TextTelephoneFRs.ForeColor = Color.White;
            TextTelephoneFRs.Location = new Point(457, 23);
            TextTelephoneFRs.Name = "TextTelephoneFRs";
            TextTelephoneFRs.Size = new Size(61, 15);
            TextTelephoneFRs.TabIndex = 57;
            TextTelephoneFRs.Text = "Telephone";
            // 
            // ComboboxTeleFRs
            // 
            ComboboxTeleFRs.Location = new Point(438, 45);
            ComboboxTeleFRs.Name = "ComboboxTeleFRs";
            ComboboxTeleFRs.Size = new Size(118, 23);
            ComboboxTeleFRs.TabIndex = 56;
            // 
            // AdresseClients
            // 
            AdresseClients.AutoSize = true;
            AdresseClients.BackColor = Color.OliveDrab;
            AdresseClients.ForeColor = Color.White;
            AdresseClients.Location = new Point(911, 23);
            AdresseClients.Name = "AdresseClients";
            AdresseClients.Size = new Size(48, 15);
            AdresseClients.TabIndex = 55;
            AdresseClients.Text = "Adresse";
            // 
            // ComboboxAdresseFRs
            // 
            ComboboxAdresseFRs.Location = new Point(889, 44);
            ComboboxAdresseFRs.Name = "ComboboxAdresseFRs";
            ComboboxAdresseFRs.Size = new Size(115, 23);
            ComboboxAdresseFRs.TabIndex = 54;
            // 
            // IF
            // 
            IF.AutoSize = true;
            IF.BackColor = Color.OliveDrab;
            IF.ForeColor = Color.White;
            IF.Location = new Point(625, 23);
            IF.Name = "IF";
            IF.Size = new Size(16, 15);
            IF.TabIndex = 53;
            IF.Text = "IF";
            // 
            // ComboboxIFFRs
            // 
            ComboboxIFFRs.Location = new Point(587, 44);
            ComboboxIFFRs.Name = "ComboboxIFFRs";
            ComboboxIFFRs.Size = new Size(117, 23);
            ComboboxIFFRs.TabIndex = 52;
            // 
            // ComboboxNomFRs
            // 
            ComboboxNomFRs.Location = new Point(267, 44);
            ComboboxNomFRs.Name = "ComboboxNomFRs";
            ComboboxNomFRs.Size = new Size(142, 23);
            ComboboxNomFRs.TabIndex = 51;
            // 
            // TextNomFRs
            // 
            TextNomFRs.AutoSize = true;
            TextNomFRs.BackColor = Color.OliveDrab;
            TextNomFRs.ForeColor = Color.White;
            TextNomFRs.Location = new Point(284, 23);
            TextNomFRs.Name = "TextNomFRs";
            TextNomFRs.Size = new Size(34, 15);
            TextNomFRs.TabIndex = 50;
            TextNomFRs.Text = "Nom";
            // 
            // ICE
            // 
            ICE.AutoSize = true;
            ICE.BackColor = Color.OliveDrab;
            ICE.ForeColor = Color.White;
            ICE.Location = new Point(773, 23);
            ICE.Name = "ICE";
            ICE.Size = new Size(24, 15);
            ICE.TabIndex = 49;
            ICE.Text = "ICE";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(32, 373);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 65;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Fournisseurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(1044, 469);
            Controls.Add(pictureBox4);
            Controls.Add(ComboboxICEFRs);
            Controls.Add(ListeFournisseurs);
            Controls.Add(DataGridFournisseurs);
            Controls.Add(AjouterFRs);
            Controls.Add(ModifierFRs);
            Controls.Add(SupprimerFRs);
            Controls.Add(ReinitialiserFRs);
            Controls.Add(TextTelephoneFRs);
            Controls.Add(ComboboxTeleFRs);
            Controls.Add(AdresseClients);
            Controls.Add(ComboboxAdresseFRs);
            Controls.Add(IF);
            Controls.Add(ComboboxIFFRs);
            Controls.Add(ComboboxNomFRs);
            Controls.Add(TextNomFRs);
            Controls.Add(ICE);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Fournisseurs";
            Text = "Fournisseurs";
            Load += Fournisseurs_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridFournisseurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ComboboxICEFRs;
        private Label ListeFournisseurs;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridFournisseurs;
        private Button AjouterFRs;
        private Button ModifierFRs;
        private Button SupprimerFRs;
        private Button ReinitialiserFRs;
        private Label TextTelephoneFRs;
        private TextBox ComboboxTeleFRs;
        private Label AdresseClients;
        private TextBox ComboboxAdresseFRs;
        private Label IF;
        private TextBox ComboboxIFFRs;
        private TextBox ComboboxNomFRs;
        private Label TextNomFRs;
        private Label ICE;
        private PictureBox pictureBox4;
        private DataGridViewTextBoxColumn NumFRs;
        private DataGridViewTextBoxColumn NomFRs;
        private DataGridViewTextBoxColumn TeleFRs;
        private DataGridViewTextBoxColumn IFFRs;
        private DataGridViewTextBoxColumn ICEFRs;
        private DataGridViewTextBoxColumn AdresseFRs;
    }
}