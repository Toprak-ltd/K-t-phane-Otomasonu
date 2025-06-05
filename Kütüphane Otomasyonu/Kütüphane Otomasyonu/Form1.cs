using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        public static bool GirisYapildiMi = false;
        public static string PersonelYol = @"C:\Users\Arcgl\Desktop\Çalışma\kütüphane\Kütüphane son\Veriler\Personel.csv";
        public static string KitapYol = @"C:\Users\Arcgl\Desktop\Çalışma\kütüphane\Kütüphane son\Veriler\Kitaplar.csv";
        public static string KullanıcıYol = @"C:\Users\Arcgl\Desktop\Çalışma\kütüphane\Kütüphane son\Veriler\Kullanıcılar.csv";
        public static string OduncYol = @"C:\Users\Arcgl\Desktop\Çalışma\kütüphane\Kütüphane son\Veriler\Ödünç.csv";
        public static string IslemlerYOl = @"C:\Users\Arcgl\Desktop\Çalışma\kütüphane\Kütüphane son\Veriler\İşlemler.csv";


                


        // Anaform İsim Alma

        public static bool yoneticiSorgu = false;
        // Anaform Yüklenme Olayı
        private void AnaForm_Load(object sender, EventArgs e)
        {

            //Zamanı gösterme
            labelZaman.Text = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //personel İsim Gösterme
            labelIsım.Text = Gris.PersonelIsim;
            //Personel Yetki Gösterme
            labelYetki.Text = Gris.PersonelYetki;
            //GirisYapildiMi kontrolü
            if (GirisYapildiMi == false)
            {
                this.Hide();
                Form Giris = new Gris();
                Giris.ShowDialog();
            }
            //Yetki Sorgulama
            if (Gris.PersonelYetki == "Yönetici")
            {
                yoneticiSorgu = true;
            }
            else if (Gris.PersonelYetki == "Personel")
            {
                groupBoxPersonelMenu.Visible = true;
                groupBoxPersonelMenu.Enabled = true;
            }
            else
            {
                MessageBox.Show("Yetkiniz bulunmamaktadır.");
                Application.Exit();
            }


            if (yoneticiSorgu == true)
            {
                try
                {
                    PanelIcındeFormAc(new Yönetici());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


        }

        //panel içinde form açma metodu
        private void PanelIcındeFormAc(Form frm)
        {
            panelIcerik.Controls.Clear();             // Paneli temizle
            frm.TopLevel = false;                // Form ana pencere olmayacak
            frm.FormBorderStyle = FormBorderStyle.None; // Kenarlık olmasın
            frm.Dock = DockStyle.Fill;           // Panele tam otursun
            panelIcerik.Controls.Add(frm);            // Panelin içine ekle
            frm.Show();                          // Göster
        }


        //Kitap İşlemleri Buttonu
        private void buttonkitapGor_Click(object sender, EventArgs e)
        {
            PanelIcındeFormAc(new KitapIslemler());
        }

        //Çıkış Buttonu
        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
