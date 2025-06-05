using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    

    public partial class Gris : Form
    {
        public Gris()
        {
            InitializeComponent();
        }
        Form Anaform;
       public static string PersonelIsim = "";
        public static string PersonelYetki = "";
        bool DogruMu = false; 

        private void buttonGris_Click(object sender, EventArgs e)
        {
            string GirilenKullanıcıadı = textBox1.Text;
            string GirilenSifre = textBox2.Text;

            string[] Personel = File.ReadAllLines(AnaForm.PersonelYol);
            foreach (string satir in Personel)
            {
                string[] Parcalar = satir.Split(';');
                if (Parcalar[1] == GirilenKullanıcıadı && Parcalar[2] == GirilenSifre)
                {
                    DogruMu = true; 
                    PersonelYetki = Parcalar[0];
                    PersonelIsim = Parcalar[1]; 
                    AnaForm.GirisYapildiMi = true;
                    //anaformu gösterme
                    Anaform = new AnaForm();
                    Anaform.Show();
                    //giriş formunu kapatma
                    this.Close(); 
                }

            }

            if (DogruMu == false)
            {
               MessageBox.Show("Kullanıcı adı veya şifre yanlış. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
