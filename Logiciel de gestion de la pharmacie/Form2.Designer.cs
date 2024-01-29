namespace Logiciel_de_gestion_de_la_pharmacie
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            BardeProgression = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            Pourcentage = new Label();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            BardeProgression.SuspendLayout();
            SuspendLayout();
            // 
            // BardeProgression
            // 
            BardeProgression.BackColor = Color.OliveDrab;
            BardeProgression.Controls.Add(Pourcentage);
            BardeProgression.FillColor = Color.ForestGreen;
            BardeProgression.FillThickness = 10;
            BardeProgression.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BardeProgression.ForeColor = Color.ForestGreen;
            BardeProgression.InnerColor = Color.OliveDrab;
            BardeProgression.Location = new Point(157, 46);
            BardeProgression.Minimum = 0;
            BardeProgression.Name = "BardeProgression";
            BardeProgression.ProgressColor = Color.White;
            BardeProgression.ProgressColor2 = Color.White;
            BardeProgression.ProgressThickness = 10;
            BardeProgression.ShadowDecoration.CustomizableEdges = customizableEdges1;
            BardeProgression.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            BardeProgression.Size = new Size(150, 150);
            BardeProgression.TabIndex = 0;
            BardeProgression.Text = "guna2CircleProgressBar1";
            BardeProgression.ValueChanged += BardeProgression_ValueChanged;
            // 
            // Pourcentage
            // 
            Pourcentage.AutoSize = true;
            Pourcentage.BackColor = Color.Khaki;
            Pourcentage.Location = new Point(65, 58);
            Pourcentage.Name = "Pourcentage";
            Pourcentage.Size = new Size(23, 21);
            Pourcentage.TabIndex = 3;
            Pourcentage.Text = "%";
            Pourcentage.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(86, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 28);
            label1.TabIndex = 1;
            label1.Text = "PHARMACIE MALIKA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(86, 210);
            label2.Name = "label2";
            label2.Size = new Size(306, 17);
            label2.TabIndex = 2;
            label2.Text = "DEVELOPPER PAR AIT-ES-SAIH MALIKA";
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(528, 269);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BardeProgression);
            ForeColor = Color.Coral;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            BardeProgression.ResumeLayout(false);
            BardeProgression.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar BardeProgression;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label Pourcentage;
    }
}