namespace Kütüphane_Otomasyonu
{
    partial class Gris
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
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonGris = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonGris);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 209);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(38, 86);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Text = "Şifre";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(21, 52);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonGris
            // 
            buttonGris.BackColor = SystemColors.Control;
            buttonGris.Location = new Point(113, 115);
            buttonGris.Name = "buttonGris";
            buttonGris.Size = new Size(100, 23);
            buttonGris.TabIndex = 0;
            buttonGris.Text = "Giriş";
            buttonGris.UseVisualStyleBackColor = false;
            buttonGris.Click += buttonGris_Click;
            // 
            // Gris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(294, 230);
            Controls.Add(panel1);
            Name = "Gris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gris";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonGris;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}