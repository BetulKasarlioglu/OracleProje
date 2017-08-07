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
    public partial class Disiplin : Form
    {
        public Disiplin()
        {
            InitializeComponent();
        }
        Yonetim yonetim = new Yonetim();
        private void Disiplin_Load(object sender, EventArgs e)
        {
            new DataGridDoldur().DisiplinDataGridDoldur(DisiplindataGridView);
            ogrComboBox = yonetim.OgrenciBilgileri(ogrComboBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yonetim.DisiplinEkle(ogrComboBox.SelectedValue.ToString(),disiplinText.Text);
            new DataGridDoldur().DisiplinDataGridDoldur(DisiplindataGridView);
        }
    }
}
