namespace Logiciel_de_gestion_de_la_pharmacie
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DimGray;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(762, 54);
            button1.Name = "button1";
            button1.Size = new Size(205, 108);
            button1.TabIndex = 0;
            button1.Text = "Stocks";
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DimGray;
            button2.ImageAlign = ContentAlignment.BottomCenter;
            button2.Location = new Point(255, 358);
            button2.Name = "button2";
            button2.Size = new Size(205, 108);
            button2.TabIndex = 1;
            button2.Text = "Tableau de Bord";
            button2.TextAlign = ContentAlignment.BottomRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DimGray;
            button3.ImageAlign = ContentAlignment.BottomCenter;
            button3.Location = new Point(501, 207);
            button3.Name = "button3";
            button3.Size = new Size(205, 108);
            button3.TabIndex = 2;
            button3.Text = "Clients";
            button3.TextAlign = ContentAlignment.BottomRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.DimGray;
            button4.ImageAlign = ContentAlignment.BottomCenter;
            button4.Location = new Point(501, 359);
            button4.Name = "button4";
            button4.Size = new Size(205, 108);
            button4.TabIndex = 3;
            button4.Text = "Fournisseurs";
            button4.TextAlign = ContentAlignment.BottomRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.DimGray;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(255, 207);
            button5.Name = "button5";
            button5.Size = new Size(205, 108);
            button5.TabIndex = 4;
            button5.Text = "Fabricants";
            button5.TextAlign = ContentAlignment.BottomRight;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.DimGray;
            button6.ImageAlign = ContentAlignment.BottomCenter;
            button6.Location = new Point(501, 54);
            button6.Name = "button6";
            button6.Size = new Size(205, 108);
            button6.TabIndex = 5;
            button6.Text = "Medicaments";
            button6.TextAlign = ContentAlignment.BottomRight;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(pictureBox6);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 520);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(32, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(83, 49);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 39);
            panel2.TabIndex = 7;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.DimGray;
            button7.Location = new Point(255, 54);
            button7.Name = "button7";
            button7.Size = new Size(205, 108);
            button7.TabIndex = 4;
            button7.Text = "Utilisateur";
            button7.TextAlign = ContentAlignment.BottomRight;
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // button8
            // 
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.DimGray;
            button8.ImageAlign = ContentAlignment.BottomCenter;
            button8.Location = new Point(781, 207);
            button8.Name = "button8";
            button8.Size = new Size(205, 108);
            button8.TabIndex = 9;
            button8.Text = "Facture";
            button8.TextAlign = ContentAlignment.BottomRight;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.DimGray;
            button9.ImageAlign = ContentAlignment.BottomCenter;
            button9.Location = new Point(781, 359);
            button9.Name = "button9";
            button9.Size = new Size(205, 108);
            button9.TabIndex = 10;
            button9.Text = "Ordonnances";
            button9.TextAlign = ContentAlignment.BottomRight;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1041, 578);
            Controls.Add(button6);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Menu";
            Text = "TableauDeBord";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel1;
        private Panel panel2;
        private Button button7;
        private Button button8;
        private Button button9;
        private PictureBox pictureBox6;
    }
}