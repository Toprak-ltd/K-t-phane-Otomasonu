using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Kütüphane_Otomasyonu
{
    public partial class KitapIslemler : Form
    {
        public KitapIslemler()
        {
            InitializeComponent();
        }

        private  void PanelDüzelt(Panel pnl)
        {
            pnl.Dock = DockStyle.Fill;
            pnl.Visible = true;
            pnl.BringToFront();
            pnl.Enabled = true;
        }

        private void kitapEkle()
        {
            comboBoxOduncKitap.Items.Clear();
            comboBoxSil.Items.Clear();
            if (!File.Exists(AnaForm.KitapYol)) return;
            string[] kitaplar = File.ReadAllLines(AnaForm.KitapYol);
            foreach (string satır in kitaplar)
            {
                string[] parcalar = satır.Split(';');
                if (parcalar.Length > 6)
                {
                    comboBoxOduncKitap.Items.Add($"{parcalar[1].Trim()} | {parcalar[4].Trim()} | {parcalar[6].Trim()}");
                    comboBoxSil.Items.Add($"{parcalar[1].Trim()} | {parcalar[2].Trim()} | {parcalar[3].Trim()} | {parcalar[4].Trim()} | {parcalar[5].Trim()} | {parcalar[6].Trim()}");
                }
            }
        }

        private void Kullanıcıekle()
        {
            comboBoxOduncKullanıcı.Items.Clear();
            if (!File.Exists(AnaForm.KullanıcıYol)) return;
            string[] kullanıcılar = File.ReadAllLines(AnaForm.KullanıcıYol);
            foreach (string satır in kullanıcılar)
            {
                string[] parcalar = satır.Split(';');
                if (parcalar.Length > 1)
                    comboBoxOduncKullanıcı.Items.Add($"{parcalar[0].Trim()} | {parcalar[1].Trim()}");
            }
        }

        private void OduncEkle()
        {
            comboBoxTeskimKullanıcı.Items.Clear();
            if (!File.Exists(AnaForm.OduncYol)) return;
            string[] Odunc = File.ReadAllLines(AnaForm.OduncYol);
            foreach (string satır in Odunc)
            {
                string[] parcalar = satır.Split(';');
                if (parcalar.Length >= 5)
                {
                    comboBoxTeskimKullanıcı.Items.Add($"{parcalar[0].Trim()} | {parcalar[1].Trim()} | {parcalar[2].Trim()} | {parcalar[4].Trim()}");
                }
            }
        }

        //İşlemleri kaydetme
        private void IslemiKaydet(string kullanici, string islem, string aciklama)
        {
            // İşlemler.csv dosyasının yolu
            string islemlerYol = AnaForm.IslemlerYOl;
            // Kayıt formatı: Tarih;Kullanıcı;İşlem;Açıklama
            string kayit = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss};{kullanici};{islem};{aciklama}";
            File.AppendAllLines(islemlerYol, new string[] { kayit });
        }


        // Kitap Görüntüleme
        private void kitaplarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelDüzelt(panelKitapGoruntule);

            if (!File.Exists(AnaForm.KitapYol)) return;
            string[] Kitaplar = File.ReadAllLines(AnaForm.KitapYol);

            dataGridView1.Rows.Clear();
            foreach (string Satır in Kitaplar)
            {
                string[] Parcalar = Satır.Split(';');
                if (Parcalar.Length > 6)
                    dataGridView1.Rows.Add(Parcalar[0], Parcalar[1], Parcalar[2], Parcalar[3], Parcalar[4], Parcalar[5], Parcalar[6]);
            }
        }

        // Panel açmaca
        private void kitapÖdünçTeslimİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelDüzelt(panelOduncTeslım);
        }

        // Yüklendiğinde kitap ve kullanıcıları combobox'a ekleme
        private void KitapIslemler_Load(object sender, EventArgs e)
        {
            kitapEkle();
            Kullanıcıekle();
            OduncEkle();
        }

        // Ödünç verme işlemi
        private void buttonOdunc_Click(object sender, EventArgs e)
        {
            if (comboBoxOduncKullanıcı.SelectedItem == null || comboBoxOduncKitap.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kullanıcı ve kitap seçimi yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] kullanıcıCombobox = comboBoxOduncKullanıcı.SelectedItem.ToString().Split(new string[] { " | " }, StringSplitOptions.None);
            if (kullanıcıCombobox.Length < 2)
            {
                MessageBox.Show("Kullanıcı bilgisi hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string kullanıcıAdı = kullanıcıCombobox[0].Trim();
            string kullanıcıTCKN = kullanıcıCombobox[1].Trim();

            string[] kitapCombobox = comboBoxOduncKitap.SelectedItem.ToString().Split(new string[] { " | " }, StringSplitOptions.None);
            if (kitapCombobox.Length < 3)
            {
                MessageBox.Show("Kitap bilgisi hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string kitapIsbn = kitapCombobox[1].Trim();
            string kitapStokStr = kitapCombobox[2].Trim();

            if (string.IsNullOrWhiteSpace(kullanıcıAdı) || string.IsNullOrWhiteSpace(kullanıcıTCKN) || string.IsNullOrWhiteSpace(kitapIsbn))
            {
                MessageBox.Show("Bilgiler eksik. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(kitapStokStr, out int kitapStokSayısı))
            {
                MessageBox.Show("Kitap stok sayısı hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (kitapStokSayısı <= 0)
            {
                MessageBox.Show("Bu kitabın stoğu kalmamış, ödünç verilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string oduncSatir = $"{kullanıcıAdı};{kullanıcıTCKN};{DateTime.Now:yyyy-MM-dd};{DateTime.Now.AddDays(30):yyyy-MM-dd};{kitapIsbn}{Environment.NewLine}";
            File.AppendAllText(AnaForm.OduncYol, oduncSatir);

            if (!File.Exists(AnaForm.KitapYol)) return;
            string[] kitaplar = File.ReadAllLines(AnaForm.KitapYol);
            bool kitapBulundu = false;
            for (int i = 0; i < kitaplar.Length; i++)
            {
                string[] parcalar = kitaplar[i].Split(';');
                if (parcalar.Length > 6 && parcalar[4].Trim() == kitapIsbn)
                {
                    if (int.TryParse(parcalar[6], out int mevcutStok) && mevcutStok > 0)
                    {
                        mevcutStok--;
                        parcalar[6] = mevcutStok.ToString();
                        kitaplar[i] = string.Join(";", parcalar);
                        kitapBulundu = true;
                    }
                    break;
                }
            }
            if (kitapBulundu)
            {
                File.WriteAllLines(AnaForm.KitapYol, kitaplar);
                MessageBox.Show("Ödünç verme işlemi başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxOduncKullanıcı.Text = "";
                comboBoxOduncKitap.Text = "";
                kitapEkle();
                Kullanıcıekle();
                OduncEkle();
            }
            else
            {
                MessageBox.Show("Kitap stok bilgisi güncellenemedi. Lütfen kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            IslemiKaydet( kullanıcıAdı,"Kitap Ödünç Verildi", $"TCKN: {kullanıcıTCKN}, ISBN: {kitapIsbn}");
        }

        // Teslim alma işlemi
        private void buttonTeslim_Click(object sender, EventArgs e)
        {
            if (comboBoxTeskimKullanıcı.SelectedItem == null)
            {
                MessageBox.Show("Lütfen teslim edilecek kitabı seçiniz!", "Uyarı");
                return;
            }

            string seciliStr = comboBoxTeskimKullanıcı.SelectedItem.ToString();
            string[] oduncParca = seciliStr.Split(new string[] { " | " }, StringSplitOptions.None);

            if (oduncParca.Length < 4)
            {
                MessageBox.Show("Seçili ödünç formatı hatalı!", "Hata");
                return;
            }
            string teslimTckn = oduncParca[1].Trim();
            string teslimIsbn = oduncParca[3].Trim();

            // 1. Ödünç dosyasından teslim edilen kaydı sil
            string oduncDosya = AnaForm.OduncYol;
            if (!File.Exists(oduncDosya))
            {
                MessageBox.Show("Ödünç dosyası bulunamadı!", "Hata");
                return;
            }

            string tempOdunc = Path.GetTempFileName();
            bool bulundu = false;
            using (var sr = new StreamReader(oduncDosya))
            using (var sw = new StreamWriter(tempOdunc))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parcalar = line.Split(';');
                    if (parcalar.Length >= 5 &&
                        parcalar[1].Trim() == teslimTckn &&
                        parcalar[4].Trim() == teslimIsbn)
                    {
                        bulundu = true;
                        continue;
                    }
                    sw.WriteLine(line);
                }
            }
            File.Delete(oduncDosya);
            File.Move(tempOdunc, oduncDosya);

            if (!bulundu)
            {
                MessageBox.Show("Kayıt bulunamadı, işlem yapılmadı.", "Bilgi");
                return;
            }

            // 2. Kitap dosyasından stok artır
            string kitapDosya = AnaForm.KitapYol;
            if (!File.Exists(kitapDosya))
            {
                MessageBox.Show("Kitap dosyası bulunamadı.", "Hata");
                return;
            }
            string[] kitaplar = File.ReadAllLines(kitapDosya);
            for (int i = 0; i < kitaplar.Length; i++)
            {
                string[] kitapParca = kitaplar[i].Split(';');
                if (kitapParca.Length > 6 && kitapParca[4].Trim() == teslimIsbn)
                {
                    if (int.TryParse(kitapParca[6], out int stok))
                    {
                        stok++;
                        kitapParca[6] = stok.ToString();
                        kitaplar[i] = string.Join(";", kitapParca);
                    }
                    break;
                }
            }
            File.WriteAllLines(kitapDosya, kitaplar);

            IslemiKaydet( teslimTckn,"Kitap Teslim Alındı",$"ISBN: {teslimIsbn}");
            MessageBox.Show("Kitap başarıyla teslim alındı ve stok güncellendi.", "Başarılı");
            comboBoxTeskimKullanıcı.Text = "";
            OduncEkle();
            kitapEkle();
        }
        //Kitap ekle/sil Panel getirme
        private void kitapEkleSilİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelDüzelt(panelEkleSil);
        }
        //Kitap silme işlemi
        private void buttonSİL_Click(object sender, EventArgs e)
        {
            string seciliKitapBilgi = comboBoxSil.SelectedItem.ToString();
            string[] seciliKitapISbnParcala = seciliKitapBilgi.Split("|");
            string seciliKitapISBN = seciliKitapISbnParcala[3].Trim();

            //Ödünçmü sorgulama
            foreach (string oduncSatir in File.ReadAllLines(AnaForm.OduncYol))
            {
                string[] oduncParcalar = oduncSatir.Split(';');
                if (oduncParcalar[4].Trim() == seciliKitapISBN)
                {
                    MessageBox.Show("Bu kitap ödünç verilmiş, silme işlemi yapılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            //dosyaya yazdırma
            string[] kitapDosya = File.ReadAllLines(AnaForm.KitapYol);
            List<string> yeniKitapDosya = new List<string>();

            foreach (string satır in kitapDosya)
            {
                string[] parcalar = satır.Split(';');
                if (parcalar[4].Trim() != seciliKitapISBN)
                {
                    yeniKitapDosya.Add(satır);
                }
            }
            File.WriteAllLines(AnaForm.KitapYol, yeniKitapDosya);
            IslemiKaydet("Yönetici","Kitap Silindi",$"ISBN: {seciliKitapISBN}");
            MessageBox.Show("Kitap başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBoxSil.Items.Remove(seciliKitapBilgi);








        }
        //Kitap ekleme işlemi
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string Ekleİsim = textBox1.Text.ToString();
            string EkleYazar = textBox2.Text.ToString();
            string EkleISBN = textBox5.Text.ToString();
            string EkleCıkısYılı = textBox3.Text.ToString();
            string EkleTur = textBox4.Text.ToString();
            string EkleStok = textBox6.Text.ToString();

            File.AppendAllLines(AnaForm.KitapYol, new string[] { $"{EkleYazar};{Ekleİsim};{EkleCıkısYılı};{EkleTur};{EkleISBN};kütüphanede;{EkleStok}"});

            textBox1.Text="";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            IslemiKaydet("Yönetici","Kitap Eklendi",$"ISBN: {EkleISBN}, İsim: {Ekleİsim}");
            MessageBox.Show("Kitap başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            kitapEkle();
            OduncEkle();
            Kullanıcıekle();

        }
    }
}