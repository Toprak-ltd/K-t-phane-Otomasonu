using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class Yönetici : Form
    {
        KitapIslemler kitapIslemler;
        ComboBox comboBoxRaporTuru;
        DataGridView dataGridViewRapor;

        public Yönetici()
        {
            InitializeComponent();
        }

        // Panel düzenle
        private void PanelDüzelt(Panel pnl)
        {
            pnl.Dock = DockStyle.Fill;
            pnl.Visible = true;
            pnl.BringToFront();
            pnl.Enabled = true;
        }

        // Kullanıcıları silme ComboBox'ına doldurur
        private void Kullanıcıekle()
        {
            comboBoxSil.Items.Clear();
            if (!File.Exists(AnaForm.KullanıcıYol)) return;
            string[] kullanıcılar = File.ReadAllLines(AnaForm.KullanıcıYol);
            foreach (string satır in kullanıcılar)
            {
                string[] parcalar = satır.Split(';');
                if (parcalar.Length >= 4)
                    comboBoxSil.Items.Add($"{parcalar[0].Trim()} | {parcalar[1].Trim()} | {parcalar[2].Trim()} | {parcalar[3].Trim()}");
            }
        }

        // Personel silme ComboBox'ına doldurur
        private void PersonelEkle()
        {
            comboBox1.Items.Clear();
            string PersonelYol = AnaForm.PersonelYol;
            if (!File.Exists(PersonelYol))
            {
                MessageBox.Show("Personel dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] personelListesi = File.ReadAllLines(PersonelYol);
            foreach (string personel in personelListesi)
            {
                string[] parcalar = personel.Split(';');
                if (parcalar.Length >= 3)
                {
                    string personelBilgisi = $"{parcalar[0].Trim()} | {parcalar[1].Trim()} | {parcalar[2].Trim()}";
                    comboBox1.Items.Add(personelBilgisi);
                }
            }
        }

        // İşlem kaydı görüntüle menüsü
        private void işlemKaydıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelDüzelt(panel1);

            string islemlerYol = AnaForm.IslemlerYOl;
            if (!File.Exists(islemlerYol))
            {
                MessageBox.Show("İşlem kaydı dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("TarihSaat", "Tarih/Saat");
            dataGridView1.Columns.Add("Kullanici", "Kullanıcı");
            dataGridView1.Columns.Add("IslemTipi", "İşlem Tipi");
            dataGridView1.Columns.Add("Aciklama", "Açıklama");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AllowUserToAddRows = false;

            var satirlar = File.ReadAllLines(islemlerYol);

            foreach (string satir in satirlar)
            {
                string[] parca = satir.Split(';');
                string tarih = parca.Length > 0 ? parca[0] : "";
                string kullanici = parca.Length > 1 ? parca[1] : "";
                string islemTipi = parca.Length > 2 ? parca[2] : "";
                string aciklama = "";

                if (parca.Length > 3)
                    aciklama = string.Join(";", parca.Skip(3));

                dataGridView1.Rows.Add(tarih, kullanici, islemTipi, aciklama);
            }

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView1.RowHeadersVisible = false;
        }

        // Menüden kullanıcı ekle/sil paneli açılır
        private void kullanıcıEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelDüzelt(panelKullanıcıEkleSil);
            Kullanıcıekle();
        }

        // Form yüklenince
        private void Yönetici_Load(object sender, EventArgs e)
        {
            Kullanıcıekle();
            PersonelEkle();
        }

        // Kullanıcı Sil
        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (comboBoxSil.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek için bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seciliKullanici = comboBoxSil.SelectedItem.ToString();
            string[] kullaniciParca = seciliKullanici.Split('|');
            if (kullaniciParca.Length < 2)
            {
                MessageBox.Show("Kullanıcı bilgisi hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string silinecekKullaniciTCKN = kullaniciParca[1].Trim();

            string[] tumKullanicilar = File.ReadAllLines(AnaForm.KullanıcıYol);
            List<string> yeniKullanicilar = new List<string>();
            bool bulundu = false;
            foreach (string satir in tumKullanicilar)
            {
                string[] parca = satir.Split(';');
                if (parca.Length > 1 && parca[1].Trim() == silinecekKullaniciTCKN)
                {
                    bulundu = true;
                    continue;
                }
                yeniKullanicilar.Add(satir);
            }

            if (!bulundu)
            {
                MessageBox.Show("Kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            File.WriteAllLines(AnaForm.KullanıcıYol, yeniKullanicilar);

            string islemlerYol = AnaForm.IslemlerYOl;
            string kayit = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss};Yönetici;Kullanıcı Silindi;TCKN: {silinecekKullaniciTCKN}";
            File.AppendAllLines(islemlerYol, new string[] { kayit });

            MessageBox.Show("Kullanıcı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBoxSil.Items.Remove(seciliKullanici);
        }

        // Kullanıcı ekle
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string Ekleİsim = textBox1.Text.Trim();
            string EkleTckn = textBox2.Text.Trim();
            string EkleTElefon = textBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(Ekleİsim) || string.IsNullOrWhiteSpace(EkleTckn) || string.IsNullOrWhiteSpace(EkleTElefon))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (EkleTckn.Length != 11 || !EkleTckn.All(char.IsDigit))
            {
                MessageBox.Show("TCKN 11 haneli ve sayısal olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mevcutKullanicilar = File.Exists(AnaForm.KullanıcıYol) ? File.ReadAllLines(AnaForm.KullanıcıYol) : new string[0];
            if (mevcutKullanicilar.Any(x => x.Split(';').Length > 1 && x.Split(';')[1].Trim() == EkleTckn))
            {
                MessageBox.Show("Bu TCKN ile kayıtlı bir kullanıcı zaten var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string yeniKayit = $"{Ekleİsim};{EkleTckn};{EkleTElefon};{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            File.AppendAllLines(AnaForm.KullanıcıYol, new string[] { yeniKayit });

            string kayitIslem = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss};Yönetici;Kullanıcı Eklendi;İsim: {Ekleİsim}, TCKN: {EkleTckn}, Telefon: {EkleTElefon}";
            File.AppendAllLines(AnaForm.IslemlerYOl, new string[] { kayitIslem });

            MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            Kullanıcıekle();
        }

        // Personel sil
        private void buttonPesonelsil_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek için bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seciliPersonel = comboBox1.SelectedItem.ToString();
            string[] personelParca = seciliPersonel.Split('|');
            if (personelParca.Length < 2)
            {
                MessageBox.Show("Personel bilgisi hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string silinecekPersonelTCKN = personelParca[1].Trim();

            string[] tumPersoneller = File.ReadAllLines(AnaForm.PersonelYol);
            List<string> yeniPersoneller = new List<string>();
            bool bulundu = false;
            foreach (string satir in tumPersoneller)
            {
                string[] parca = satir.Split(';');
                if (parca.Length > 1 && parca[1].Trim() == silinecekPersonelTCKN)
                {
                    bulundu = true;
                    continue;
                }
                yeniPersoneller.Add(satir);
            }

            if (!bulundu)
            {
                MessageBox.Show("Personel bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            File.WriteAllLines(AnaForm.PersonelYol, yeniPersoneller);

            string islemlerYol = AnaForm.IslemlerYOl;
            string kayit = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss};Yönetici;Personel Silindi;TCKN: {silinecekPersonelTCKN}";
            File.AppendAllLines(islemlerYol, new string[] { kayit });

            MessageBox.Show("Personel başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBox1.Items.Remove(seciliPersonel);
            PersonelEkle();
        }

        // Personel sil/ekle paneli açılır
        private void personelEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelDüzelt(panel2);
            PersonelEkle();
        }

        // Personel ekle
        private void buttonPersonelEkle_Click(object sender, EventArgs e)
        {
            string EkleMevki = comboBox2.Text.Trim();
            string Ekleİsim = textBox5.Text.Trim();
            string EkleŞifre = textBox6.Text.Trim();

            if (string.IsNullOrWhiteSpace(EkleMevki) || string.IsNullOrWhiteSpace(Ekleİsim) || string.IsNullOrWhiteSpace(EkleŞifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            File.AppendAllLines(AnaForm.PersonelYol, new string[] { $"{EkleMevki};{Ekleİsim};{EkleŞifre}" });

            comboBox2.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            string islemlerYol = AnaForm.IslemlerYOl;
            string kayit = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss};Yönetici;Personel Eklendi;İsim: {Ekleİsim}, Mevki: {EkleMevki}";
            File.AppendAllLines(islemlerYol, new string[] { kayit });

            MessageBox.Show("Personel başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelEkle();
        }

        // Raporlama paneli açılır
        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelDüzelt(panelrapor);
            PanelRaporHazirla();
        }

        // panelrapor: Dinamik olarak ComboBox ve DataGridView ekle ve raporları doldur
        private void PanelRaporHazirla()
        {
            panelrapor.Controls.Clear();

            comboBoxRaporTuru = new ComboBox();
            comboBoxRaporTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRaporTuru.Font = new Font("Segoe UI", 10);
            comboBoxRaporTuru.Items.AddRange(new string[]
            {
                "Kullanıcılar", "Personeller", "Kitaplar", "Ödünç Kitaplar", "İşlem Geçmişi", "İstatistikler"
            });
            comboBoxRaporTuru.SelectedIndex = 0;
            comboBoxRaporTuru.Width = 250;
            comboBoxRaporTuru.Location = new Point(20, 20);
            comboBoxRaporTuru.SelectedIndexChanged += ComboBoxRaporTuru_SelectedIndexChanged;
            panelrapor.Controls.Add(comboBoxRaporTuru);

            dataGridViewRapor = new DataGridView();
            dataGridViewRapor.Location = new Point(20, 60);
            dataGridViewRapor.Size = new Size(panelrapor.Width - 40, panelrapor.Height - 80);
            dataGridViewRapor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewRapor.BackgroundColor = Color.White;
            dataGridViewRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRapor.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridViewRapor.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewRapor.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewRapor.DefaultCellStyle.BackColor = Color.White;
            dataGridViewRapor.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewRapor.RowHeadersVisible = false;
            panelrapor.Controls.Add(dataGridViewRapor);

            RaporDoldur(comboBoxRaporTuru.SelectedItem.ToString());
        }

        private void ComboBoxRaporTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenRapor = comboBoxRaporTuru.SelectedItem.ToString();
            RaporDoldur(secilenRapor);
        }

        private void RaporDoldur(string raporTuru)
        {
            dataGridViewRapor.Rows.Clear();
            dataGridViewRapor.Columns.Clear();

            if (raporTuru == "Kullanıcılar")
            {
                if (!File.Exists(AnaForm.KullanıcıYol)) return;
                string[] satirlar = File.ReadAllLines(AnaForm.KullanıcıYol);
                dataGridViewRapor.Columns.Add("AdSoyad", "Ad Soyad");
                dataGridViewRapor.Columns.Add("TCKN", "TCKN");
                dataGridViewRapor.Columns.Add("Telefon", "Telefon");
                dataGridViewRapor.Columns.Add("KayıtTarihi", "Kayıt Tarihi");
                foreach (string s in satirlar)
                {
                    string[] p = s.Split(';');
                    if (p.Length >= 4)
                        dataGridViewRapor.Rows.Add(p[0], p[1], p[2], p[3]);
                }
            }
            else if (raporTuru == "Personeller")
            {
                if (!File.Exists(AnaForm.PersonelYol)) return;
                string[] satirlar = File.ReadAllLines(AnaForm.PersonelYol);
                dataGridViewRapor.Columns.Add("Mevki", "Mevki");
                dataGridViewRapor.Columns.Add("AdSoyad", "Ad Soyad");
                dataGridViewRapor.Columns.Add("Şifre", "Şifre");
                foreach (string s in satirlar)
                {
                    string[] p = s.Split(';');
                    if (p.Length >= 3)
                        dataGridViewRapor.Rows.Add(p[0], p[1], p[2]);
                }
            }
            else if (raporTuru == "Kitaplar")
            {
                if (!File.Exists(AnaForm.KitapYol)) return;
                string[] satirlar = File.ReadAllLines(AnaForm.KitapYol);
                dataGridViewRapor.Columns.Add("KitapAdı", "Kitap Adı");
                dataGridViewRapor.Columns.Add("Yazar", "Yazar");
                dataGridViewRapor.Columns.Add("Durum", "Durum");
                foreach (string s in satirlar)
                {
                    string[] p = s.Split(';');
                    if (p.Length >= 3)
                        dataGridViewRapor.Rows.Add(p[0], p[1], p[2]);
                }
            }
            else if (raporTuru == "Ödünç Kitaplar")
            {
                if (!File.Exists(AnaForm.OduncYol)) return;
                string[] satirlar = File.ReadAllLines(AnaForm.OduncYol);
                dataGridViewRapor.Columns.Add("KitapID", "Kitap ID");
                dataGridViewRapor.Columns.Add("KullanıcıTCKN", "Kullanıcı TCKN");
                dataGridViewRapor.Columns.Add("AlışTarihi", "Alış Tarihi");
                dataGridViewRapor.Columns.Add("TeslimTarihi", "Teslim Tarihi");
                foreach (string s in satirlar)
                {
                    string[] p = s.Split(';');
                    if (p.Length >= 4)
                        dataGridViewRapor.Rows.Add(p[0], p[1], p[2], p[3]);
                }
            }
            else if (raporTuru == "İşlem Geçmişi")
            {
                if (!File.Exists(AnaForm.IslemlerYOl)) return;
                string[] satirlar = File.ReadAllLines(AnaForm.IslemlerYOl);
                dataGridViewRapor.Columns.Add("Tarih", "Tarih");
                dataGridViewRapor.Columns.Add("Kim", "Kim");
                dataGridViewRapor.Columns.Add("İşlem", "İşlem");
                dataGridViewRapor.Columns.Add("Açıklama", "Açıklama");
                foreach (string s in satirlar)
                {
                    string[] p = s.Split(';');
                    if (p.Length >= 4)
                        dataGridViewRapor.Rows.Add(p[0], p[1], p[2], p[3]);
                }
            }
            else if (raporTuru == "İstatistikler")
            {
                int toplamKullanici = File.Exists(AnaForm.KullanıcıYol) ? File.ReadAllLines(AnaForm.KullanıcıYol).Length : 0;
                int toplamPersonel = File.Exists(AnaForm.PersonelYol) ? File.ReadAllLines(AnaForm.PersonelYol).Length : 0;
                int toplamKitap = File.Exists(AnaForm.KitapYol) ? File.ReadAllLines(AnaForm.KitapYol).Length : 0;
                int oduncKitap = File.Exists(AnaForm.OduncYol) ? File.ReadAllLines(AnaForm.OduncYol).Length : 0;
                dataGridViewRapor.Columns.Add("Bilgi", "Bilgi");
                dataGridViewRapor.Columns.Add("Sayı", "Sayı");
                dataGridViewRapor.Rows.Add("Toplam Kullanıcı", toplamKullanici);
                dataGridViewRapor.Rows.Add("Toplam Personel", toplamPersonel);
                dataGridViewRapor.Rows.Add("Toplam Kitap", toplamKitap);
                dataGridViewRapor.Rows.Add("Ödünçteki Kitaplar", oduncKitap);
            }
        }
    }
}