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
    public partial class OgrenciSil : Form
    {
        public OgrenciSil()
        {
            InitializeComponent();
        }
        Yonetim yonetim = new Yonetim();
        private void OgrenciSil_Load(object sender, EventArgs e)
        {
            new DataGridDoldur().DataGrid(dataGridView1);
            new DataGridDoldur().DataGridSilinmisOgrenci(dataGridView2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                yonetim.OgrenciSil(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                MessageBox.Show("Silinen Kullanıcı : " + dataGridView1.CurrentRow.Cells[2].Value.ToString(), "Butondan Detay");
                new DataGridDoldur().DataGridSilinmisOgrenci(dataGridView2);
                new DataGridDoldur().DataGrid(dataGridView1);
            }
        }
    }
}
