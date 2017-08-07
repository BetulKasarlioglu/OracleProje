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
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }
        Yonetim yonetim = new Yonetim();
        String yatakId,ogr_id;
        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            yonetim.YatakGoster();
            YatakDataGridView.DataSource = yonetim.dt;
            yatakId = yonetim.yatakId;
            yonetim.baglantiKapat();
        }

        private void YatakDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            yatakId = YatakDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            odaBilgi.Text = "Oda Seçiminiz   :" + YatakDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString() + " numaralı oda";
            yatakBilgi.Text = "Yatak Seçiminiz :" + YatakDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() + " numaralı yatak";
        }

        private void btnOgrAra_Click(object sender, EventArgs e)
        {
            ogrenciIslemleriButton.Text = "GÜNCELLE";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtMail.Text = "";
            txtTel.Text = "";
            txtKan.Text = "";
            txtOgretim.Text = "";
            txtAdres.Text = "";
            yonetim.ara(txtAra.Text);
            txtAd.Text = yonetim.ad;
            txtSoyad.Text = yonetim.soyad;
            txtTC.Text = txtAra.Text;
            txtKan.Text = yonetim.kan;
            txtTel.Text = yonetim.tel;
            txtAdres.Text = yonetim.adres;
            txtMail.Text = yonetim.mail;
            txtOgretim.Text = yonetim.ogretim;
            yatakId = yonetim.yatakId;
            yonetim.OgrenciIDCek(txtAra.Text);
            ogr_id = yonetim.ogr_id;
            

        }

        private void ogrenciIslemleriButton_Click(object sender, EventArgs e)
        {
            DateTime newDate = System.Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            String tarihP = dateTarih.Value.Date.ToString("dd/MM/yyyy");
            if (ogrenciIslemleriButton.Text == "EKLE")
            {

                yonetim.ogrenciEkle(txtAd.Text, txtSoyad.Text, txtTC.Text, txtKan.Text, txtTel.Text, newDate, txtAdres.Text, txtMail.Text, txtOgretim.Text, yatakId);
                yonetim.OgrenciIDCek(txtTC.Text);
                ogr_id = yonetim.ogr_id;
                Random r = new Random();
                int odemeno = r.Next() * 100;
                yonetim.OdemeEkle(odemeno.ToString(), "0", "0", "0", "0", tarihP, ogr_id, "1");
                Odeme odemeyap = new Odeme();
                odemeyap.ShowDialog();
        
            }
            else if (ogrenciIslemleriButton.Text == "GÜNCELLE")
            {
                yonetim.ogrenciGuncelle(ogr_id, txtAd.Text, txtSoyad.Text, txtTC.Text, txtKan.Text, txtTel.Text, txtAdres.Text, txtMail.Text, txtOgretim.Text, yatakId);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RaporSecenekleri r = new RaporSecenekleri();
            r.Show();

        }
    }
}
