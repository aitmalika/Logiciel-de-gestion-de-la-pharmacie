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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SituationStocks));
            textQuantitedepart = new TextBox();
            Mednumero = new Label();
            Date = new Label();
            quantité = new Label();
            Reinitialiserstocks = new Button();
            DataGridStocks = new Guna.UI2.WinForms.Guna2DataGridView();
            IdStock = new DataGridViewTextBoxColumn();
            QuantiteDepart = new DataGridViewTextBoxColumn();
            QuantiteAchat = new DataGridViewTextBoxColumn();
            QuantiteVente = new DataGridViewTextBoxColumn();
            StockFinal = new DataGridViewTextBoxColumn();
            DateEntre = new DataGridViewTextBoxColumn();
            MedNume = new DataGridViewTextBoxColumn();
            TextMedNume = new ComboBox();
            TextDateEntre = new DateTimePicker();
            pictureBox4 = new PictureBox();
            textquantiteVente = new TextBox();
            label1 = new Label();
            textquantiteachat = new TextBox();
            label2 = new Label();
            textstocksfinal = new TextBox();
            label3 = new Label();
            AjouterFacture = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridStocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // textQuantitedepart
            // 
            textQuantitedepart.Location = new Point(114, 70);
            textQuantitedepart.Name = "textQuantitedepart";
            textQuantitedepart.Size = new Size(115, 23);
            textQuantitedepart.TabIndex = 54;
            // 
            // Mednumero
            // 
            Mednumero.AutoSize = true;
            Mednumero.BackColor = Color.OliveDrab;
            Mednumero.ForeColor = Color.White;
            Mednumero.Location = new Point(740, 48);
            Mednumero.Name = "Mednumero";
            Mednumero.Size = new Size(126, 15);
            Mednumero.TabIndex = 53;
            Mednumero.Text = "Numéro Medicaments";
            Mednumero.Click += Mednumero_Click;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.BackColor = Color.OliveDrab;
            Date.ForeColor = Color.White;
            Date.Location = new Point(641, 48);
            Date.Name = "Date";
            Date.Size = new Size(67, 15);
            Date.TabIndex = 51;
            Date.Text = "Date Entrée";
            // 
            // quantité
            // 
            quantité.AutoSize = true;
            quantité.BackColor = Color.OliveDrab;
            quantité.ForeColor = Color.White;
            quantité.Location = new Point(123, 48);
            quantité.Name = "quantité";
            quantité.Size = new Size(90, 15);
            quantité.TabIndex = 49;
            quantité.Text = "Quantité depart";
            // 
            // Reinitialiserstocks
            // 
            Reinitialiserstocks.BackColor = Color.OliveDrab;
            Reinitialiserstocks.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Reinitialiserstocks.ForeColor = Color.White;
            Reinitialiserstocks.Location = new Point(8, 134);
            Reinitialiserstocks.Name = "Reinitialiserstocks";
            Reinitialiserstocks.Size = new Size(98, 37);
            Reinitialiserstocks.TabIndex = 85;
            Reinitialiserstocks.Text = "Reinitialiser";
            Reinitialiserstocks.UseVisualStyleBackColor = false;
            Reinitialiserstocks.Click += Reinitialiserstocks_Click;
            // 
            // DataGridStocks
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            DataGridStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGridStocks.BackgroundColor = Color.Khaki;
            DataGridStocks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridStocks.ColumnHeadersHeight = 20;
            DataGridStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridStocks.Columns.AddRange(new DataGridViewColumn[] { IdStock, QuantiteDepart, QuantiteAchat, QuantiteVente, StockFinal, DateEntre, MedNume });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataGridStocks.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridStocks.GridColor = Color.FromArgb(231, 229, 255);
            DataGridStocks.Location = new Point(112, 117);
            DataGridStocks.Name = "DataGridStocks";
            DataGridStocks.RowHeadersVisible = false;
            DataGridStocks.RowTemplate.Height = 25;
            DataGridStocks.Size = new Size(763, 327);
            DataGridStocks.TabIndex = 86;
            DataGridStocks.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridStocks.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridStocks.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridStocks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridStocks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridStocks.ThemeStyle.BackColor = Color.Khaki;
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
            // IdStock
            // 
            IdStock.DataPropertyName = "IdStock";
            IdStock.HeaderText = "ID";
            IdStock.Name = "IdStock";
            IdStock.Visible = false;
            // 
            // QuantiteDepart
            // 
            QuantiteDepart.DataPropertyName = "QuantiteDepart";
            QuantiteDepart.HeaderText = "quantite depart";
            QuantiteDepart.Name = "QuantiteDepart";
            // 
            // QuantiteAchat
            // 
            QuantiteAchat.DataPropertyName = "QuantiteAchat";
            QuantiteAchat.HeaderText = "Quantite Achat";
            QuantiteAchat.Name = "QuantiteAchat";
            // 
            // QuantiteVente
            // 
            QuantiteVente.DataPropertyName = "QuantiteVente";
            QuantiteVente.HeaderText = "Quantite Vente";
            QuantiteVente.Name = "QuantiteVente";
            // 
            // StockFinal
            // 
            StockFinal.DataPropertyName = "StockFinal";
            StockFinal.HeaderText = "Stock Final";
            StockFinal.Name = "StockFinal";
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
            // TextMedNume
            // 
            TextMedNume.FormattingEnabled = true;
            TextMedNume.Location = new Point(745, 70);
            TextMedNume.Name = "TextMedNume";
            TextMedNume.Size = new Size(121, 23);
            TextMedNume.TabIndex = 87;
            TextMedNume.SelectedIndexChanged += TextMedNume_SelectedIndexChanged;
            // 
            // TextDateEntre
            // 
            TextDateEntre.Format = DateTimePickerFormat.Short;
            TextDateEntre.Location = new Point(615, 70);
            TextDateEntre.Name = "TextDateEntre";
            TextDateEntre.Size = new Size(114, 23);
            TextDateEntre.TabIndex = 88;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(22, 366);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 89;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // textquantiteVente
            // 
            textquantiteVente.Location = new Point(356, 70);
            textquantiteVente.Name = "textquantiteVente";
            textquantiteVente.Size = new Size(115, 23);
            textquantiteVente.TabIndex = 91;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OliveDrab;
            label1.ForeColor = Color.White;
            label1.Location = new Point(363, 48);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 90;
            label1.Text = "Quantité vente";
            label1.Click += label1_Click;
            // 
            // textquantiteachat
            // 
            textquantiteachat.Location = new Point(235, 70);
            textquantiteachat.Name = "textquantiteachat";
            textquantiteachat.Size = new Size(115, 23);
            textquantiteachat.TabIndex = 93;
            textquantiteachat.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OliveDrab;
            label2.ForeColor = Color.White;
            label2.Location = new Point(244, 48);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 92;
            label2.Text = "Quantité Achat";
            // 
            // textstocksfinal
            // 
            textstocksfinal.Location = new Point(485, 70);
            textstocksfinal.Name = "textstocksfinal";
            textstocksfinal.Size = new Size(115, 23);
            textstocksfinal.TabIndex = 95;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.OliveDrab;
            label3.ForeColor = Color.White;
            label3.Location = new Point(492, 48);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 94;
            label3.Text = "Stock Final";
            // 
            // AjouterFacture
            // 
            AjouterFacture.BackColor = Color.OliveDrab;
            AjouterFacture.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AjouterFacture.ForeColor = Color.White;
            AjouterFacture.Location = new Point(8, 59);
            AjouterFacture.Name = "AjouterFacture";
            AjouterFacture.Size = new Size(95, 42);
            AjouterFacture.TabIndex = 96;
            AjouterFacture.Text = "Ajouter";
            AjouterFacture.UseVisualStyleBackColor = false;
            AjouterFacture.Click += AjouterFacture_Click;
            // 
            // SituationStocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(878, 455);
            Controls.Add(AjouterFacture);
            Controls.Add(textstocksfinal);
            Controls.Add(label3);
            Controls.Add(textquantiteachat);
            Controls.Add(label2);
            Controls.Add(textquantiteVente);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(TextDateEntre);
            Controls.Add(TextMedNume);
            Controls.Add(DataGridStocks);
            Controls.Add(Reinitialiserstocks);
            Controls.Add(textQuantitedepart);
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

        private TextBox textQuantitedepart;
        private Label Mednumero;
        private Label Date;
        private Label quantité;
        private Button Reinitialiserstocks;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridStocks;
        private ComboBox TextMedNume;
        private DateTimePicker TextDateEntre;
        private PictureBox pictureBox4;
        private TextBox textquantiteVente;
        private Label label1;
        private TextBox textquantiteachat;
        private Label label2;
        private TextBox textstocksfinal;
        private Label label3;
        private DataGridViewTextBoxColumn IdStock;
        private DataGridViewTextBoxColumn QuantiteDepart;
        private DataGridViewTextBoxColumn QuantiteAchat;
        private DataGridViewTextBoxColumn QuantiteVente;
        private DataGridViewTextBoxColumn StockFinal;
        private DataGridViewTextBoxColumn DateEntre;
        private DataGridViewTextBoxColumn MedNume;
        private Button AjouterFacture;
    }
}