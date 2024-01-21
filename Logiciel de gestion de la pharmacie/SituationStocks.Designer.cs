namespace Logiciel_de_gestion_de_la_pharmacie
{
    partial class SituationStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SituationStocks));
            textQuantiteStock = new TextBox();
            Mednumero = new Label();
            Date = new Label();
            quantité = new Label();
            Reinitialiserstocks = new Button();
            Affichierstocks = new Button();
            DataGridStocks = new Guna.UI2.WinForms.Guna2DataGridView();
            TextMedNume = new ComboBox();
            TextDateEntre = new DateTimePicker();
            pictureBox4 = new PictureBox();
            IdStock = new DataGridViewTextBoxColumn();
            QuantiteStock = new DataGridViewTextBoxColumn();
            DateEntre = new DataGridViewTextBoxColumn();
            MedNume = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGridStocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // textQuantiteStock
            // 
            textQuantiteStock.Location = new Point(460, 59);
            textQuantiteStock.Name = "textQuantiteStock";
            textQuantiteStock.Size = new Size(115, 23);
            textQuantiteStock.TabIndex = 54;
            // 
            // Mednumero
            // 
            Mednumero.AutoSize = true;
            Mednumero.BackColor = Color.ForestGreen;
            Mednumero.ForeColor = Color.White;
            Mednumero.Location = new Point(618, 37);
            Mednumero.Name = "Mednumero";
            Mednumero.Size = new Size(126, 15);
            Mednumero.TabIndex = 53;
            Mednumero.Text = "Numéro Medicaments";
            Mednumero.Click += Mednumero_Click;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.BackColor = Color.ForestGreen;
            Date.ForeColor = Color.White;
            Date.Location = new Point(315, 37);
            Date.Name = "Date";
            Date.Size = new Size(67, 15);
            Date.TabIndex = 51;
            Date.Text = "Date Entrée";
            // 
            // quantité
            // 
            quantité.AutoSize = true;
            quantité.BackColor = Color.ForestGreen;
            quantité.ForeColor = Color.White;
            quantité.Location = new Point(480, 37);
            quantité.Name = "quantité";
            quantité.Size = new Size(53, 15);
            quantité.TabIndex = 49;
            quantité.Text = "Quantité";
            // 
            // Reinitialiserstocks
            // 
            Reinitialiserstocks.BackColor = Color.ForestGreen;
            Reinitialiserstocks.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Reinitialiserstocks.ForeColor = Color.White;
            Reinitialiserstocks.Location = new Point(19, 80);
            Reinitialiserstocks.Name = "Reinitialiserstocks";
            Reinitialiserstocks.Size = new Size(98, 33);
            Reinitialiserstocks.TabIndex = 85;
            Reinitialiserstocks.Text = "Reinitialiser";
            Reinitialiserstocks.UseVisualStyleBackColor = false;
            Reinitialiserstocks.Click += Reinitialiserstocks_Click;
            // 
            // Affichierstocks
            // 
            Affichierstocks.BackColor = Color.ForestGreen;
            Affichierstocks.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Affichierstocks.ForeColor = Color.White;
            Affichierstocks.Location = new Point(21, 23);
            Affichierstocks.Name = "Affichierstocks";
            Affichierstocks.Size = new Size(90, 29);
            Affichierstocks.TabIndex = 84;
            Affichierstocks.Text = "Afficher";
            Affichierstocks.UseVisualStyleBackColor = false;
            Affichierstocks.Click += Affichierstocks_Click;
            // 
            // DataGridStocks
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridStocks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridStocks.ColumnHeadersHeight = 20;
            DataGridStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridStocks.Columns.AddRange(new DataGridViewColumn[] { IdStock, QuantiteStock, DateEntre, MedNume });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridStocks.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridStocks.GridColor = Color.FromArgb(231, 229, 255);
            DataGridStocks.Location = new Point(112, 117);
            DataGridStocks.Name = "DataGridStocks";
            DataGridStocks.RowHeadersVisible = false;
            DataGridStocks.RowTemplate.Height = 25;
            DataGridStocks.Size = new Size(754, 327);
            DataGridStocks.TabIndex = 86;
            DataGridStocks.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridStocks.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridStocks.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridStocks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridStocks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridStocks.ThemeStyle.BackColor = Color.White;
            DataGridStocks.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridStocks.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridStocks.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridStocks.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridStocks.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridStocks.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridStocks.ThemeStyle.HeaderStyle.Height = 20;
            DataGridStocks.ThemeStyle.ReadOnly = false;
            DataGridStocks.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridStocks.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridStocks.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridStocks.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridStocks.ThemeStyle.RowsStyle.Height = 25;
            DataGridStocks.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridStocks.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridStocks.CellContentClick += DataGridStocks_CellContentClick;
            // 
            // TextMedNume
            // 
            TextMedNume.FormattingEnabled = true;
            TextMedNume.Location = new Point(623, 59);
            TextMedNume.Name = "TextMedNume";
            TextMedNume.Size = new Size(121, 23);
            TextMedNume.TabIndex = 87;
            // 
            // TextDateEntre
            // 
            TextDateEntre.Format = DateTimePickerFormat.Short;
            TextDateEntre.Location = new Point(289, 59);
            TextDateEntre.Name = "TextDateEntre";
            TextDateEntre.Size = new Size(114, 23);
            TextDateEntre.TabIndex = 88;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(30, 370);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 89;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // IdStock
            // 
            IdStock.DataPropertyName = "IdStock";
            IdStock.HeaderText = "ID";
            IdStock.Name = "IdStock";
            IdStock.Visible = false;
            // 
            // QuantiteStock
            // 
            QuantiteStock.DataPropertyName = "QuantiteStock";
            QuantiteStock.HeaderText = "quantite";
            QuantiteStock.Name = "QuantiteStock";
            // 
            // DateEntre
            // 
            DateEntre.DataPropertyName = "DateEntre";
            DateEntre.HeaderText = "dateentree";
            DateEntre.Name = "DateEntre";
            // 
            // MedNume
            // 
            MedNume.DataPropertyName = "MedNume";
            MedNume.HeaderText = "NumeroMedicament";
            MedNume.Name = "MedNume";
            // 
            // SituationStocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 455);
            Controls.Add(pictureBox4);
            Controls.Add(TextDateEntre);
            Controls.Add(TextMedNume);
            Controls.Add(DataGridStocks);
            Controls.Add(Reinitialiserstocks);
            Controls.Add(Affichierstocks);
            Controls.Add(textQuantiteStock);
            Controls.Add(Mednumero);
            Controls.Add(Date);
            Controls.Add(quantité);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "SituationStocks";
            Text = "SituationStocks";
            Load += SituationStocks_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridStocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textQuantiteStock;
        private Label Mednumero;
        private Label Date;
        private Label quantité;
        private Button Reinitialiserstocks;
        private Button Affichierstocks;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridStocks;
        private ComboBox TextMedNume;
        private DateTimePicker TextDateEntre;
        private PictureBox pictureBox4;
        private DataGridViewTextBoxColumn IdStock;
        private DataGridViewTextBoxColumn QuantiteStock;
        private DataGridViewTextBoxColumn DateEntre;
        private DataGridViewTextBoxColumn MedNume;
    }
}