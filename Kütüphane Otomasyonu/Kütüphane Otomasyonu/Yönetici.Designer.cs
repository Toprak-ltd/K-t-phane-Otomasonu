namespace Kütüphane_Otomasyonu
{
    partial class Yönetici
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
            menuStrip1 = new MenuStrip();
            kullanıcıEkleSilToolStripMenuItem = new ToolStripMenuItem();
            personelEkleSilToolStripMenuItem = new ToolStripMenuItem();
            raporlamaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            TarihSaat = new DataGridViewTextBoxColumn();
            Kullanıcı = new DataGridViewTextBoxColumn();
            İşlemTipi = new DataGridViewTextBoxColumn();
            Açıklama = new DataGridViewTextBoxColumn();
            panelKullanıcıEkleSil = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            buttonEkle = new Button();
            panel3 = new Panel();
            buttonSil = new Button();
            comboBoxSil = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            buttonPersonelEkle = new Button();
            panel5 = new Panel();
            label9 = new Label();
            buttonPesonelsil = new Button();
            comboBox1 = new ComboBox();
            panelrapor = new Panel();
            label10 = new Label();
            label11 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelKullanıcıEkleSil.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { kullanıcıEkleSilToolStripMenuItem, personelEkleSilToolStripMenuItem, raporlamaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1394, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıEkleSilToolStripMenuItem
            // 
            kullanıcıEkleSilToolStripMenuItem.Name = "kullanıcıEkleSilToolStripMenuItem";
            kullanıcıEkleSilToolStripMenuItem.Size = new Size(105, 20);
            kullanıcıEkleSilToolStripMenuItem.Text = "Kullanıcı Ekle/Sil";
            kullanıcıEkleSilToolStripMenuItem.Click += kullanıcıEkleSilToolStripMenuItem_Click;
            // 
            // personelEkleSilToolStripMenuItem
            // 
            personelEkleSilToolStripMenuItem.Name = "personelEkleSilToolStripMenuItem";
            personelEkleSilToolStripMenuItem.Size = new Size(105, 20);
            personelEkleSilToolStripMenuItem.Text = "Personel Ekle/Sil";
            personelEkleSilToolStripMenuItem.Click += personelEkleSilToolStripMenuItem_Click;
            // 
            // raporlamaToolStripMenuItem
            // 
            raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            raporlamaToolStripMenuItem.Size = new Size(73, 20);
            raporlamaToolStripMenuItem.Text = "raporlama";
            raporlamaToolStripMenuItem.Click += raporlamaToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Enabled = false;
            panel1.Location = new Point(32, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 219);
            panel1.TabIndex = 1;
            panel1.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TarihSaat, Kullanıcı, İşlemTipi, Açıklama });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(430, 219);
            dataGridView1.TabIndex = 0;
            // 
            // TarihSaat
            // 
            TarihSaat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TarihSaat.HeaderText = "Tarih/Saat";
            TarihSaat.Name = "TarihSaat";
            TarihSaat.ReadOnly = true;
            // 
            // Kullanıcı
            // 
            Kullanıcı.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kullanıcı.HeaderText = "Kullanıcı";
            Kullanıcı.Name = "Kullanıcı";
            Kullanıcı.ReadOnly = true;
            // 
            // İşlemTipi
            // 
            İşlemTipi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            İşlemTipi.HeaderText = "İşlem Tipi";
            İşlemTipi.Name = "İşlemTipi";
            İşlemTipi.ReadOnly = true;
            // 
            // Açıklama
            // 
            Açıklama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Açıklama.HeaderText = "Açıklama";
            Açıklama.Name = "Açıklama";
            Açıklama.ReadOnly = true;
            // 
            // panelKullanıcıEkleSil
            // 
            panelKullanıcıEkleSil.Controls.Add(panel4);
            panelKullanıcıEkleSil.Controls.Add(panel3);
            panelKullanıcıEkleSil.Enabled = false;
            panelKullanıcıEkleSil.Location = new Point(32, 279);
            panelKullanıcıEkleSil.Name = "panelKullanıcıEkleSil";
            panelKullanıcıEkleSil.Size = new Size(815, 279);
            panelKullanıcıEkleSil.TabIndex = 2;
            panelKullanıcıEkleSil.Visible = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(buttonEkle);
            panel4.Location = new Point(373, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(439, 273);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(162, 10);
            label5.Name = "label5";
            label5.Size = new Size(135, 30);
            label5.TabIndex = 7;
            label5.Text = "Kullanıcı Ekle";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(331, 62);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Telefon No";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(209, 60);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "TCKN";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(55, 60);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "İsim Soyisim";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(316, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(181, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(44, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // buttonEkle
            // 
            buttonEkle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEkle.Location = new Point(181, 177);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(103, 23);
            buttonEkle.TabIndex = 0;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonSil);
            panel3.Controls.Add(comboBoxSil);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(364, 273);
            panel3.TabIndex = 0;
            // 
            // buttonSil
            // 
            buttonSil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSil.Location = new Point(104, 110);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(108, 23);
            buttonSil.TabIndex = 2;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // comboBoxSil
            // 
            comboBoxSil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSil.FormattingEnabled = true;
            comboBoxSil.Location = new Point(3, 54);
            comboBoxSil.Name = "comboBoxSil";
            comboBoxSil.Size = new Size(358, 23);
            comboBoxSil.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(94, 10);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Sil";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(32, 561);
            panel2.Name = "panel2";
            panel2.Size = new Size(830, 282);
            panel2.TabIndex = 3;
            panel2.Visible = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(comboBox2);
            panel6.Controls.Add(textBox6);
            panel6.Controls.Add(textBox5);
            panel6.Controls.Add(buttonPersonelEkle);
            panel6.Location = new Point(374, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(450, 273);
            panel6.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(362, 49);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 7;
            label8.Text = "Şifre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(208, 49);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 6;
            label7.Text = "Kullanıcı Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 49);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Mevki";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Personel", "Yönetici" });
            comboBox2.Location = new Point(43, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(330, 73);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(196, 73);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 2;
            // 
            // buttonPersonelEkle
            // 
            buttonPersonelEkle.Location = new Point(210, 171);
            buttonPersonelEkle.Name = "buttonPersonelEkle";
            buttonPersonelEkle.Size = new Size(75, 23);
            buttonPersonelEkle.TabIndex = 0;
            buttonPersonelEkle.Text = "Ekle";
            buttonPersonelEkle.UseVisualStyleBackColor = true;
            buttonPersonelEkle.Click += buttonPersonelEkle_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(buttonPesonelsil);
            panel5.Controls.Add(comboBox1);
            panel5.Location = new Point(4, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(364, 273);
            panel5.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(155, 19);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 2;
            // 
            // buttonPesonelsil
            // 
            buttonPesonelsil.Location = new Point(143, 170);
            buttonPesonelsil.Name = "buttonPesonelsil";
            buttonPesonelsil.Size = new Size(75, 23);
            buttonPesonelsil.TabIndex = 1;
            buttonPesonelsil.Text = "sil";
            buttonPesonelsil.UseVisualStyleBackColor = true;
            buttonPesonelsil.Click += buttonPesonelsil_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(5, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(355, 23);
            comboBox1.TabIndex = 0;
            // 
            // panelrapor
            // 
            panelrapor.Location = new Point(883, 64);
            panelrapor.Name = "panelrapor";
            panelrapor.Size = new Size(483, 339);
            panelrapor.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(114, 26);
            label10.Name = "label10";
            label10.Size = new Size(120, 30);
            label10.TabIndex = 3;
            label10.Text = "Personel Sil";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(176, 11);
            label11.Name = "label11";
            label11.Size = new Size(137, 30);
            label11.TabIndex = 8;
            label11.Text = "Personel Ekle";
            // 
            // Yönetici
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1394, 903);
            Controls.Add(panelrapor);
            Controls.Add(panel2);
            Controls.Add(panelKullanıcıEkleSil);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Yönetici";
            Text = "Yönetici";
            Load += Yönetici_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelKullanıcıEkleSil.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TarihSaat;
        private DataGridViewTextBoxColumn Kullanıcı;
        private DataGridViewTextBoxColumn İşlemTipi;
        private DataGridViewTextBoxColumn Açıklama;
        private ToolStripMenuItem kullanıcıEkleSilToolStripMenuItem;
        private Panel panelKullanıcıEkleSil;
        private Panel panel4;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button buttonEkle;
        private Button buttonSil;
        private ComboBox comboBoxSil;
        private Label label1;
        private Label label5;
        private ToolStripMenuItem personelEkleSilToolStripMenuItem;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private ComboBox comboBox1;
        private Button buttonPesonelsil;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox comboBox2;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button buttonPersonelEkle;
        private ToolStripMenuItem raporlamaToolStripMenuItem;
        private Panel panelrapor;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}