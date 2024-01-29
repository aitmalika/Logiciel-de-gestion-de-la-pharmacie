namespace Logiciel_de_gestion_de_la_pharmacie
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            TextTelephone = new Label();
            TextTeleClient = new TextBox();
            AdresseClients = new Label();
            TextAdresseClient = new TextBox();
            IF = new Label();
            TextIFClient = new TextBox();
            TextNomClient = new TextBox();
            TextNomClients = new Label();
            ICE = new Label();
            AjouterClient = new Button();
            ModifierClient = new Button();
            SupprimerClient = new Button();
            ReinitialiserClient = new Button();
            DataGridClient = new Guna.UI2.WinForms.Guna2DataGridView();
            NumClient = new DataGridViewTextBoxColumn();
            NomClient = new DataGridViewTextBoxColumn();
            TeleClient = new DataGridViewTextBoxColumn();
            IFClient = new DataGridViewTextBoxColumn();
            ICEClient = new DataGridViewTextBoxColumn();
            AdresseClient = new DataGridViewTextBoxColumn();
            ListeClients = new Label();
            TextICEClient = new TextBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DataGridClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // TextTelephone
            // 
            TextTelephone.AutoSize = true;
            TextTelephone.BackColor = Color.OliveDrab;
            TextTelephone.ForeColor = Color.White;
            TextTelephone.Location = new Point(440, 30);
            TextTelephone.Name = "TextTelephone";
            TextTelephone.Size = new Size(61, 15);
            TextTelephone.TabIndex = 37;
            TextTelephone.Text = "Telephone";
            // 
            // TextTeleClient
            // 
            TextTeleClient.Location = new Point(421, 52);
            TextTeleClient.Name = "TextTeleClient";
            TextTeleClient.Size = new Size(118, 23);
            TextTeleClient.TabIndex = 36;
            // 
            // AdresseClients
            // 
            AdresseClients.AutoSize = true;
            AdresseClients.BackColor = Color.OliveDrab;
            AdresseClients.ForeColor = Color.White;
            AdresseClients.Location = new Point(894, 30);
            AdresseClients.Name = "AdresseClients";
            AdresseClients.Size = new Size(48, 15);
            AdresseClients.TabIndex = 35;
            AdresseClients.Text = "Adresse";
            AdresseClients.Click += AdresseClients_Click;
            // 
            // TextAdresseClient
            // 
            TextAdresseClient.Location = new Point(872, 51);
            TextAdresseClient.Name = "TextAdresseClient";
            TextAdresseClient.Size = new Size(115, 23);
            TextAdresseClient.TabIndex = 34;
            TextAdresseClient.TextChanged += TextAdresseClient_TextChanged;
            // 
            // IF
            // 
            IF.AutoSize = true;
            IF.BackColor = Color.OliveDrab;
            IF.ForeColor = Color.White;
            IF.Location = new Point(608, 30);
            IF.Name = "IF";
            IF.Size = new Size(16, 15);
            IF.TabIndex = 32;
            IF.Text = "IF";
            // 
            // TextIFClient
            // 
            TextIFClient.Location = new Point(570, 51);
            TextIFClient.Name = "TextIFClient";
            TextIFClient.Size = new Size(117, 23);
            TextIFClient.TabIndex = 31;
            // 
            // TextNomClient
            // 
            TextNomClient.Location = new Point(250, 51);
            TextNomClient.Name = "TextNomClient";
            TextNomClient.Size = new Size(142, 23);
            TextNomClient.TabIndex = 30;
            // 
            // TextNomClients
            // 
            TextNomClients.AutoSize = true;
            TextNomClients.BackColor = Color.OliveDrab;
            TextNomClients.ForeColor = Color.White;
            TextNomClients.Location = new Point(267, 30);
            TextNomClients.Name = "TextNomClients";
            TextNomClients.Size = new Size(34, 15);
            TextNomClients.TabIndex = 29;
            TextNomClients.Text = "Nom";
            // 
            // ICE
            // 
            ICE.AutoSize = true;
            ICE.BackColor = Color.OliveDrab;
            ICE.ForeColor = Color.White;
            ICE.Location = new Point(756, 30);
            ICE.Name = "ICE";
            ICE.Size = new Size(24, 15);
            ICE.TabIndex = 28;
            ICE.Text = "ICE";
            // 
            // AjouterClient
            // 
            AjouterClient.BackColor = Color.OliveDrab;
            AjouterClient.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AjouterClient.ForeColor = Color.White;
            AjouterClient.Location = new Point(27, 30);
            AjouterClient.Name = "AjouterClient";
            AjouterClient.Size = new Size(98, 50);
            AjouterClient.TabIndex = 45;
            AjouterClient.Text = "Ajouter";
            AjouterClient.UseVisualStyleBackColor = false;
            AjouterClient.Click += AjouterClient_Click;
            // 
            // ModifierClient
            // 
            ModifierClient.BackColor = Color.OliveDrab;
            ModifierClient.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ModifierClient.ForeColor = Color.White;
            ModifierClient.Location = new Point(27, 104);
            ModifierClient.Name = "ModifierClient";
            ModifierClient.Size = new Size(98, 50);
            ModifierClient.TabIndex = 44;
            ModifierClient.Text = "Modifier";
            ModifierClient.UseVisualStyleBackColor = false;
            ModifierClient.Click += ModifierClient_Click;
            // 
            // SupprimerClient
            // 
            SupprimerClient.BackColor = Color.OliveDrab;
            SupprimerClient.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SupprimerClient.ForeColor = Color.White;
            SupprimerClient.Location = new Point(27, 176);
            SupprimerClient.Name = "SupprimerClient";
            SupprimerClient.Size = new Size(98, 46);
            SupprimerClient.TabIndex = 43;
            SupprimerClient.Text = "supprimer";
            SupprimerClient.UseVisualStyleBackColor = false;
            SupprimerClient.Click += SupprimerClient_Click;
            // 
            // ReinitialiserClient
            // 
            ReinitialiserClient.BackColor = Color.OliveDrab;
            ReinitialiserClient.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReinitialiserClient.ForeColor = Color.White;
            ReinitialiserClient.Location = new Point(27, 242);
            ReinitialiserClient.Name = "ReinitialiserClient";
            ReinitialiserClient.Size = new Size(98, 46);
            ReinitialiserClient.TabIndex = 42;
            ReinitialiserClient.Text = "Reinitialiser";
            ReinitialiserClient.UseVisualStyleBackColor = false;
            ReinitialiserClient.Click += ReinitialiserClient_Click;
            // 
            // DataGridClient
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridClient.BackgroundColor = Color.Khaki;
            DataGridClient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridClient.ColumnHeadersHeight = 20;
            DataGridClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridClient.Columns.AddRange(new DataGridViewColumn[] { NumClient, NomClient, TeleClient, IFClient, ICEClient, AdresseClient });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridClient.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridClient.GridColor = Color.FromArgb(231, 229, 255);
            DataGridClient.Location = new Point(166, 188);
            DataGridClient.Name = "DataGridClient";
            DataGridClient.RowHeadersVisible = false;
            DataGridClient.RowTemplate.Height = 25;
            DataGridClient.Size = new Size(838, 267);
            DataGridClient.TabIndex = 46;
            DataGridClient.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridClient.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridClient.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridClient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridClient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridClient.ThemeStyle.BackColor = Color.Khaki;
            DataGridClient.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridClient.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridClient.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridClient.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridClient.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridClient.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridClient.ThemeStyle.HeaderStyle.Height = 20;
            DataGridClient.ThemeStyle.ReadOnly = false;
            DataGridClient.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridClient.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridClient.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridClient.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridClient.ThemeStyle.RowsStyle.Height = 25;
            DataGridClient.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridClient.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridClient.CellContentClick += DataGridClient_CellContentClick;
            // 
            // NumClient
            // 
            NumClient.DataPropertyName = "NumClient";
            NumClient.HeaderText = "Num";
            NumClient.Name = "NumClient";
            NumClient.Visible = false;
            // 
            // NomClient
            // 
            NomClient.DataPropertyName = "NomClient";
            NomClient.HeaderText = "Nom Client";
            NomClient.Name = "NomClient";
            // 
            // TeleClient
            // 
            TeleClient.DataPropertyName = "TeleClient";
            TeleClient.HeaderText = "Telephone";
            TeleClient.Name = "TeleClient";
            // 
            // IFClient
            // 
            IFClient.DataPropertyName = "IFClient";
            IFClient.HeaderText = "IF";
            IFClient.Name = "IFClient";
            // 
            // ICEClient
            // 
            ICEClient.DataPropertyName = "ICEClient";
            ICEClient.HeaderText = "ICE";
            ICEClient.Name = "ICEClient";
            // 
            // AdresseClient
            // 
            AdresseClient.DataPropertyName = "AdresseClient";
            AdresseClient.HeaderText = "Adresse";
            AdresseClient.Name = "AdresseClient";
            // 
            // ListeClients
            // 
            ListeClients.AutoSize = true;
            ListeClients.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListeClients.ForeColor = Color.ForestGreen;
            ListeClients.Location = new Point(532, 163);
            ListeClients.Name = "ListeClients";
            ListeClients.Size = new Size(117, 22);
            ListeClients.TabIndex = 47;
            ListeClients.Text = "ListeClients";
            // 
            // TextICEClient
            // 
            TextICEClient.Location = new Point(724, 52);
            TextICEClient.Name = "TextICEClient";
            TextICEClient.Size = new Size(115, 23);
            TextICEClient.TabIndex = 48;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(35, 363);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 49;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(1016, 467);
            Controls.Add(pictureBox4);
            Controls.Add(TextICEClient);
            Controls.Add(ListeClients);
            Controls.Add(DataGridClient);
            Controls.Add(AjouterClient);
            Controls.Add(ModifierClient);
            Controls.Add(SupprimerClient);
            Controls.Add(ReinitialiserClient);
            Controls.Add(TextTelephone);
            Controls.Add(TextTeleClient);
            Controls.Add(AdresseClients);
            Controls.Add(TextAdresseClient);
            Controls.Add(IF);
            Controls.Add(TextIFClient);
            Controls.Add(TextNomClient);
            Controls.Add(TextNomClients);
            Controls.Add(ICE);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Clients";
            Text = "Client";
            Load += Clients_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextTelephone;
        private TextBox TextTeleClient;
        private Label AdresseClients;
        private TextBox TextAdresseClient;
        private Label IF;
        private TextBox TextIFClient;
        private TextBox TextNomClient;
        private Label TextNomClients;
        private Label ICE;
        private Button AjouterClient;
        private Button ModifierClient;
        private Button SupprimerClient;
        private Button ReinitialiserClient;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridClient;
        private Label ListeClients;
        private TextBox TextICEClient;
        private PictureBox pictureBox4;
        private DataGridViewTextBoxColumn NumClient;
        private DataGridViewTextBoxColumn NomClient;
        private DataGridViewTextBoxColumn TeleClient;
        private DataGridViewTextBoxColumn IFClient;
        private DataGridViewTextBoxColumn ICEClient;
        private DataGridViewTextBoxColumn AdresseClient;
    }
}