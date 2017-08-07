
using OracleProje.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OracleProje
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        Yonetim yonetim = new Yonetim();
        private void Personel_Load(object sender, EventArgs e)
        {
            new DataGridDoldur().DataGridYurtlar(dataGridView1);
            yurtComboBox = yonetim.OgrenciBilgileri(yurtComboBox);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                yonetim.YurtGuncelle(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString());
                MessageBox.Show("Düzenleme Başarılı");
            }
            else if (e.ColumnIndex == 12)
            {
                yonetim.YurtSil(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Silme Başarılı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yonetim.PersonelEkle(adText.Text,soyadText.Text,kidemText.Text,telText.Text,AdresRichTextBox.Text,maasText.Text,yetkiComboBox.Text,sifreText.Text,yurtComboBox.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RaporSecenekleri r = new RaporSecenekleri();
            r.Show();
        }
    }
}
