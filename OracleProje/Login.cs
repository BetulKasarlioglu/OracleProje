using OracleProje.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OracleProje
{
    public partial class Login : Form
    {
        Yonetim yonetim = new Yonetim();
        String yetki = "0";
        String personel = "0";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             yetki = yonetim.Login(textKullaniciAd.Text, textSifre.Text);
             personel = yonetim.PerAra(textKullaniciAd.Text, textSifre.Text);

             yetki = yonetim.yetki;
            if (yetki == "1")
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                anasayfa.kidem = personel;
                anasayfa.Text = personel;
                this.Hide();
            }
            else
            {
                textKullaniciAd.Text = "Hatalı Giriş Yaptınız !";
            }
            
        }
    }
}
