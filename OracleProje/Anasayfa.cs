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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public String kidem;
        private void btnOgrenciIsleri_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciSil ogrenciSil = new OgrenciSil();
            ogrenciSil.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YurtIslemleri yurt = new YurtIslemleri();
            yurt.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OdaIslemleri odaShow = new OdaIslemleri();
            odaShow.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Odeme odemeGir = new Odeme();
            odemeGir.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SilinmisOgrenciler git = new SilinmisOgrenciler();
            git.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Disiplin disiplin = new Disiplin();
            disiplin.ShowDialog();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            if (this.Text == "Memur")
            {
                yurtButonu.Enabled = false;
                personelButonu.Enabled = false;
            }
        }
    }
}
