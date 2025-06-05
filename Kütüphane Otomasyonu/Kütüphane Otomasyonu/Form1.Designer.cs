namespace Kütüphane_Otomasyonu
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            panelUst = new Panel();
            label2 = new Label();
            labelIsım = new Label();
            label1 = new Label();
            panelMenu = new Panel();
            groupBoxBilgi = new GroupBox();
            buttonCıkıs = new Button();
            labelYetki = new Label();
            labelZaman = new Label();
            groupBoxPersonelMenu = new GroupBox();
            buttonkitapGor = new Button();
            panelIcerik = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panelUst.SuspendLayout();
            panelMenu.SuspendLayout();
            groupBoxBilgi.SuspendLayout();
            groupBoxPersonelMenu.SuspendLayout();
            panelIcerik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelUst
            // 
            panelUst.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelUst.BackColor = SystemColors.Control;
            panelUst.Controls.Add(label2);
            panelUst.Controls.Add(labelIsım);
            panelUst.Controls.Add(label1);
            panelUst.Location = new Point(178, 12);
            panelUst.Name = "panelUst";
            panelUst.Size = new Size(610, 91);
            panelUst.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(453, 2);
            label2.Name = "label2";
            label2.Size = new Size(154, 44);
            label2.TabIndex = 2;
            label2.Text = "Merhaba ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelIsım
            // 
            labelIsım.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelIsım.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelIsım.Location = new Point(453, 44);
            labelIsım.Name = "labelIsım";
            labelIsım.Size = new Size(154, 46);
            labelIsım.TabIndex = 1;
            labelIsım.Text = "gsagasgasgasg";
            labelIsım.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Size = new Size(316, 89);
            label1.TabIndex = 0;
            label1.Text = "Kütüphane Otomasyonu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            panelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelMenu.BackColor = SystemColors.Control;
            panelMenu.Controls.Add(groupBoxBilgi);
            panelMenu.Controls.Add(groupBoxPersonelMenu);
            panelMenu.Location = new Point(9, 109);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(163, 329);
            panelMenu.TabIndex = 1;
            // 
            // groupBoxBilgi
            // 
            groupBoxBilgi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxBilgi.Controls.Add(buttonCıkıs);
            groupBoxBilgi.Controls.Add(labelYetki);
            groupBoxBilgi.Controls.Add(labelZaman);
            groupBoxBilgi.Location = new Point(3, 211);
            groupBoxBilgi.Name = "groupBoxBilgi";
            groupBoxBilgi.Size = new Size(157, 116);
            groupBoxBilgi.TabIndex = 0;
            groupBoxBilgi.TabStop = false;
            // 
            // buttonCıkıs
            // 
            buttonCıkıs.BackColor = Color.IndianRed;
            buttonCıkıs.Location = new Point(0, 14);
            buttonCıkıs.Name = "buttonCıkıs";
            buttonCıkıs.Size = new Size(157, 31);
            buttonCıkıs.TabIndex = 6;
            buttonCıkıs.Text = "Çıkış ";
            buttonCıkıs.UseVisualStyleBackColor = false;
            buttonCıkıs.Click += buttonCıkıs_Click;
            // 
            // labelYetki
            // 
            labelYetki.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelYetki.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelYetki.Location = new Point(0, 42);
            labelYetki.Name = "labelYetki";
            labelYetki.Size = new Size(157, 34);
            labelYetki.TabIndex = 2;
            labelYetki.Text = "1";
            labelYetki.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelZaman
            // 
            labelZaman.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelZaman.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelZaman.Location = new Point(0, 79);
            labelZaman.Name = "labelZaman";
            labelZaman.Size = new Size(157, 34);
            labelZaman.TabIndex = 1;
            labelZaman.Text = "1";
            labelZaman.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxPersonelMenu
            // 
            groupBoxPersonelMenu.Controls.Add(buttonkitapGor);
            groupBoxPersonelMenu.Enabled = false;
            groupBoxPersonelMenu.Location = new Point(-4, 2);
            groupBoxPersonelMenu.Name = "groupBoxPersonelMenu";
            groupBoxPersonelMenu.Size = new Size(174, 178);
            groupBoxPersonelMenu.TabIndex = 0;
            groupBoxPersonelMenu.TabStop = false;
            groupBoxPersonelMenu.Text = "Menü";
            groupBoxPersonelMenu.Visible = false;
            // 
            // buttonkitapGor
            // 
            buttonkitapGor.BackColor = SystemColors.GradientActiveCaption;
            buttonkitapGor.Location = new Point(7, 22);
            buttonkitapGor.Name = "buttonkitapGor";
            buttonkitapGor.Size = new Size(157, 27);
            buttonkitapGor.TabIndex = 0;
            buttonkitapGor.Text = "Kitap İşlemleri";
            buttonkitapGor.UseVisualStyleBackColor = false;
            buttonkitapGor.Click += buttonkitapGor_Click;
            // 
            // panelIcerik
            // 
            panelIcerik.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelIcerik.BackColor = SystemColors.Control;
            panelIcerik.Controls.Add(label3);
            panelIcerik.Location = new Point(178, 109);
            panelIcerik.Name = "panelIcerik";
            panelIcerik.Size = new Size(610, 329);
            panelIcerik.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(626, 32);
            label3.TabIndex = 0;
            label3.Text = "Hoşgeldiniz. Lütfen Yapmak İstediğiniz İşlemi Seçiniz.\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panelIcerik);
            Controls.Add(panelMenu);
            Controls.Add(panelUst);
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu";
            WindowState = FormWindowState.Maximized;
            Load += AnaForm_Load;
            panelUst.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            groupBoxBilgi.ResumeLayout(false);
            groupBoxPersonelMenu.ResumeLayout(false);
            panelIcerik.ResumeLayout(false);
            panelIcerik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUst;
        private Panel panelMenu;
        private Panel panelIcerik;
        private PictureBox pictureBox1;
        private Button buttonkitapGor;
        private GroupBox groupBoxPersonelMenu;
        private Label labelZaman;
        private Label label1;
        private Label labelIsım;
        private Label label2;
        private Label labelYetki;
        private Button buttonCıkıs;
        private GroupBox groupBoxBilgi;
        private Label label3;
    }
}
