namespace Kütüphane_Otomasyonu
{
    partial class KitapIslemler
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
            kitaplarıGörüntüleToolStripMenuItem = new ToolStripMenuItem();
            kitapÖdünçTeslimİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            kitapEkleSilİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            panelKitapGoruntule = new Panel();
            dataGridView1 = new DataGridView();
            Yazar = new DataGridViewTextBoxColumn();
            İsim = new DataGridViewTextBoxColumn();
            CıkısYılı = new DataGridViewTextBoxColumn();
            Tur = new DataGridViewTextBoxColumn();
            Isbn = new DataGridViewTextBoxColumn();
            Durum = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            panelOduncTeslım = new Panel();
            panel2 = new Panel();
            comboBoxOduncKullanıcı = new ComboBox();
            buttonOdunc = new Button();
            comboBoxOduncKitap = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            buttonTeslim = new Button();
            comboBoxTeskimKullanıcı = new ComboBox();
            label4 = new Label();
            panelEkleSil = new Panel();
            panel4 = new Panel();
            label11 = new Label();
            comboBoxSil = new ComboBox();
            buttonSİL = new Button();
            panel5 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            buttonEkle = new Button();
            menuStrip1.SuspendLayout();
            panelKitapGoruntule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelOduncTeslım.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelEkleSil.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { kitaplarıGörüntüleToolStripMenuItem, kitapÖdünçTeslimİşlemleriToolStripMenuItem, kitapEkleSilİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1562, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kitaplarıGörüntüleToolStripMenuItem
            // 
            kitaplarıGörüntüleToolStripMenuItem.Name = "kitaplarıGörüntüleToolStripMenuItem";
            kitaplarıGörüntüleToolStripMenuItem.Size = new Size(118, 20);
            kitaplarıGörüntüleToolStripMenuItem.Text = "Kitapları Görüntüle";
            kitaplarıGörüntüleToolStripMenuItem.Click += kitaplarıGörüntüleToolStripMenuItem_Click;
            // 
            // kitapÖdünçTeslimİşlemleriToolStripMenuItem
            // 
            kitapÖdünçTeslimİşlemleriToolStripMenuItem.Name = "kitapÖdünçTeslimİşlemleriToolStripMenuItem";
            kitapÖdünçTeslimİşlemleriToolStripMenuItem.Size = new Size(171, 20);
            kitapÖdünçTeslimİşlemleriToolStripMenuItem.Text = "Kitap Ödünç/Teslim İşlemleri";
            kitapÖdünçTeslimİşlemleriToolStripMenuItem.Click += kitapÖdünçTeslimİşlemleriToolStripMenuItem_Click;
            // 
            // kitapEkleSilİşlemleriToolStripMenuItem
            // 
            kitapEkleSilİşlemleriToolStripMenuItem.Name = "kitapEkleSilİşlemleriToolStripMenuItem";
            kitapEkleSilİşlemleriToolStripMenuItem.Size = new Size(134, 20);
            kitapEkleSilİşlemleriToolStripMenuItem.Text = "Kitap Ekle/Sil İşlemleri";
            kitapEkleSilİşlemleriToolStripMenuItem.Click += kitapEkleSilİşlemleriToolStripMenuItem_Click;
            // 
            // panelKitapGoruntule
            // 
            panelKitapGoruntule.BackColor = SystemColors.Control;
            panelKitapGoruntule.Controls.Add(dataGridView1);
            panelKitapGoruntule.Enabled = false;
            panelKitapGoruntule.Location = new Point(0, 24);
            panelKitapGoruntule.Margin = new Padding(10);
            panelKitapGoruntule.Name = "panelKitapGoruntule";
            panelKitapGoruntule.Size = new Size(426, 253);
            panelKitapGoruntule.TabIndex = 1;
            panelKitapGoruntule.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Yazar, İsim, CıkısYılı, Tur, Isbn, Durum, Stok });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(426, 253);
            dataGridView1.TabIndex = 0;
            // 
            // Yazar
            // 
            Yazar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Yazar.HeaderText = "Yazar";
            Yazar.Name = "Yazar";
            Yazar.ReadOnly = true;
            // 
            // İsim
            // 
            İsim.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            İsim.HeaderText = "İsim";
            İsim.Name = "İsim";
            İsim.ReadOnly = true;
            // 
            // CıkısYılı
            // 
            CıkısYılı.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CıkısYılı.HeaderText = "Çıkış Yılı";
            CıkısYılı.Name = "CıkısYılı";
            CıkısYılı.ReadOnly = true;
            // 
            // Tur
            // 
            Tur.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tur.HeaderText = "Tür";
            Tur.Name = "Tur";
            Tur.ReadOnly = true;
            // 
            // Isbn
            // 
            Isbn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Isbn.HeaderText = "ISBN";
            Isbn.Name = "Isbn";
            Isbn.ReadOnly = true;
            // 
            // Durum
            // 
            Durum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Durum.HeaderText = "Durum";
            Durum.Name = "Durum";
            Durum.ReadOnly = true;
            // 
            // Stok
            // 
            Stok.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Stok.HeaderText = "Stok Adedi";
            Stok.Name = "Stok";
            Stok.ReadOnly = true;
            // 
            // panelOduncTeslım
            // 
            panelOduncTeslım.Controls.Add(panel2);
            panelOduncTeslım.Controls.Add(panel1);
            panelOduncTeslım.Enabled = false;
            panelOduncTeslım.Location = new Point(439, 27);
            panelOduncTeslım.Name = "panelOduncTeslım";
            panelOduncTeslım.Size = new Size(700, 250);
            panelOduncTeslım.TabIndex = 2;
            panelOduncTeslım.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(comboBoxOduncKullanıcı);
            panel2.Controls.Add(buttonOdunc);
            panel2.Controls.Add(comboBoxOduncKitap);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(180, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 291);
            panel2.TabIndex = 1;
            // 
            // comboBoxOduncKullanıcı
            // 
            comboBoxOduncKullanıcı.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxOduncKullanıcı.FormattingEnabled = true;
            comboBoxOduncKullanıcı.Location = new Point(55, 39);
            comboBoxOduncKullanıcı.Name = "comboBoxOduncKullanıcı";
            comboBoxOduncKullanıcı.Size = new Size(430, 23);
            comboBoxOduncKullanıcı.TabIndex = 7;
            // 
            // buttonOdunc
            // 
            buttonOdunc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonOdunc.Location = new Point(119, 124);
            buttonOdunc.Name = "buttonOdunc";
            buttonOdunc.Size = new Size(252, 23);
            buttonOdunc.TabIndex = 4;
            buttonOdunc.Text = "Ödünç";
            buttonOdunc.UseVisualStyleBackColor = true;
            buttonOdunc.Click += buttonOdunc_Click;
            // 
            // comboBoxOduncKitap
            // 
            comboBoxOduncKitap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxOduncKitap.Location = new Point(55, 68);
            comboBoxOduncKitap.Name = "comboBoxOduncKitap";
            comboBoxOduncKitap.Size = new Size(430, 23);
            comboBoxOduncKitap.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Kitap";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 42);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(buttonTeslim);
            panel1.Controls.Add(comboBoxTeskimKullanıcı);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 291);
            panel1.TabIndex = 0;
            // 
            // buttonTeslim
            // 
            buttonTeslim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonTeslim.Location = new Point(161, 124);
            buttonTeslim.Name = "buttonTeslim";
            buttonTeslim.Size = new Size(252, 23);
            buttonTeslim.TabIndex = 9;
            buttonTeslim.Text = "Teslim";
            buttonTeslim.UseVisualStyleBackColor = true;
            buttonTeslim.Click += buttonTeslim_Click;
            // 
            // comboBoxTeskimKullanıcı
            // 
            comboBoxTeskimKullanıcı.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxTeskimKullanıcı.FormattingEnabled = true;
            comboBoxTeskimKullanıcı.Location = new Point(75, 44);
            comboBoxTeskimKullanıcı.Name = "comboBoxTeskimKullanıcı";
            comboBoxTeskimKullanıcı.Size = new Size(392, 23);
            comboBoxTeskimKullanıcı.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(26, 47);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Bilgiler";
            // 
            // panelEkleSil
            // 
            panelEkleSil.BackColor = SystemColors.ActiveCaption;
            panelEkleSil.Controls.Add(panel4);
            panelEkleSil.Controls.Add(panel5);
            panelEkleSil.Enabled = false;
            panelEkleSil.Location = new Point(12, 283);
            panelEkleSil.Name = "panelEkleSil";
            panelEkleSil.Size = new Size(1240, 605);
            panelEkleSil.TabIndex = 3;
            panelEkleSil.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(comboBoxSil);
            panel4.Controls.Add(buttonSİL);
            panel4.Location = new Point(3, 7);
            panel4.Name = "panel4";
            panel4.Size = new Size(610, 367);
            panel4.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(220, 11);
            label11.Name = "label11";
            label11.Size = new Size(90, 30);
            label11.TabIndex = 14;
            label11.Text = "Kitap Sil";
            // 
            // comboBoxSil
            // 
            comboBoxSil.FormattingEnabled = true;
            comboBoxSil.Location = new Point(39, 86);
            comboBoxSil.Name = "comboBoxSil";
            comboBoxSil.Size = new Size(464, 23);
            comboBoxSil.TabIndex = 1;
            // 
            // buttonSİL
            // 
            buttonSİL.Location = new Point(240, 164);
            buttonSİL.Name = "buttonSİL";
            buttonSİL.Size = new Size(75, 23);
            buttonSİL.TabIndex = 0;
            buttonSİL.Text = "Sil";
            buttonSİL.UseVisualStyleBackColor = true;
            buttonSİL.Click += buttonSİL_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = SystemColors.GradientActiveCaption;
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(textBox6);
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(buttonEkle);
            panel5.Location = new Point(619, 7);
            panel5.Name = "panel5";
            panel5.Size = new Size(610, 367);
            panel5.TabIndex = 1;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(220, 5);
            label10.Name = "label10";
            label10.Size = new Size(107, 30);
            label10.TabIndex = 2;
            label10.Text = "Kitap Ekle";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(353, 90);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 13;
            label9.Text = "Stok";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(345, 49);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 12;
            label8.Text = "ISBN";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(189, 94);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 11;
            label7.Text = "Tür";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(182, 49);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 10;
            label6.Text = "Yazar";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(7, 90);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Çıkış Yılı";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(26, 49);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 8;
            label3.Text = "İsim";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(389, 86);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(389, 46);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(220, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(61, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(220, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(61, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // buttonEkle
            // 
            buttonEkle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEkle.Location = new Point(220, 164);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(100, 23);
            buttonEkle.TabIndex = 0;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = true;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // KitapIslemler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1562, 967);
            Controls.Add(panelEkleSil);
            Controls.Add(panelOduncTeslım);
            Controls.Add(panelKitapGoruntule);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "KitapIslemler";
            Text = "KitapIslemler";
            Load += KitapIslemler_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelKitapGoruntule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelOduncTeslım.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelEkleSil.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kitaplarıGörüntüleToolStripMenuItem;
        private ToolStripMenuItem kitapÖdünçTeslimİşlemleriToolStripMenuItem;
        private ToolStripMenuItem kitapEkleSilİşlemleriToolStripMenuItem;
        private Panel panelKitapGoruntule;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Yazar;
        private DataGridViewTextBoxColumn İsim;
        private DataGridViewTextBoxColumn CıkısYılı;
        private DataGridViewTextBoxColumn Tur;
        private DataGridViewTextBoxColumn Isbn;
        private DataGridViewTextBoxColumn Durum;
        private DataGridViewTextBoxColumn Stok;
        private Panel panelOduncTeslım;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxOduncKitap;
        private Button buttonOdunc;
        private Button buttonTeslim;
        private ComboBox comboBoxTeskimKullanıcı;
        private Label label4;
        private ComboBox comboBoxOduncKullanıcı;
        private Panel panel2;
        private Panel panel1;
        private Panel panelEkleSil;
        private Panel panel4;
        private ComboBox comboBoxSil;
        private Button buttonSİL;
        private Label label11;
        private Panel panel5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button buttonEkle;
    }
}