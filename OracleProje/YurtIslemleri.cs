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
    public partial class YurtIslemleri : Form
    {
        public YurtIslemleri()
        {
            InitializeComponent();
        }
        Yonetim yonetim = new Yonetim();
        private void YurtIslemleri_Load(object sender, EventArgs e)
        {
            new DataGridDoldur().DataGridYurtlar(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                yonetim.YurtGuncelle(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString());
                MessageBox.Show("Düzenleme Başarılı");
            }
            else if (e.ColumnIndex == 4)
            {
                yonetim.YurtSil(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Silme Başarılı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yonetim.YurtEkle(yurtText.Text,AdresrichTextBox.Text);
            MessageBox.Show("Ekleme başarılı...");
        }
    }
}
