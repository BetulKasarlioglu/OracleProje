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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        Yonetim yonetim = new Yonetim();
        private void Odeme_Load(object sender, EventArgs e)
        {
            new DataGridDoldur().DataGridOdeme(dataGridView1);
            //ogr.SelectedIndex = 0;
            ogr = yonetim.OgrenciBilgileri(ogr);
            per = yonetim.PersonelBilgileri(per);
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 7)
            {
                yonetim.OdemeGuncelle(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString());
                MessageBox.Show("Düzenleme Başarılı");
            }
            else if (e.ColumnIndex == 8)
            {
                yonetim.YurtSil(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Silme Başarılı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random r = new Random();
            //int odemeno = r.Next();
            //odemeno = Math.Abs(odemeno);
          // String newDate = tarihPicker.Value.Date.ToString("dd/MM/yyyy");
            Double kalan = Convert.ToInt16(toplamFiyat.Text) - Convert.ToInt16(odemeTutar.Text);
         //   yonetim.OdemeEkle(odemeno.ToString(), taksitSayisi.Text, odemeTutar.Text, kalan.ToString(), toplamFiyat.Text, newDate, ogr.SelectedValue.ToString(), per.SelectedValue.ToString());
            
            yonetim.OdemeGuncelle(odemeID,taksitSayisi.Text,odemeTutar.Text,kalan.ToString(),toplamFiyat.Text);
            MessageBox.Show("Düzenleme Başarılı");  
        }
        public String odemeID;
        private void ogr_SelectedIndexChanged(object sender, EventArgs e)
        {
            yonetim.OgrenciOdemeBilgisi(ogr.SelectedValue.ToString());
            toplamFiyat.Text = yonetim.TOPLAM_FIYAT;
            taksitSayisi.Text = yonetim.TAKSIT;
            KALAN_LABEL.Text = yonetim.KALAN_PARA;
            odemeTutar.Text = yonetim.ODENEN;
            odemeID = yonetim.ODEME_ID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RaporSecenekleri rp = new RaporSecenekleri();
            rp.Show();
        }

      
    }
}

















