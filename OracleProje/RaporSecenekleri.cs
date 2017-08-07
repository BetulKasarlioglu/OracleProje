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
    public partial class RaporSecenekleri : Form
    {
        public RaporSecenekleri()
        {
            InitializeComponent();
        }
        Yonetim yonetim = new Yonetim();
        private void RaporSecenekleri_Load(object sender, EventArgs e)
        {
            //new DataGridDoldur().Raporla(raporGridView,"");
            ////ogr.SelectedIndex = 0;
            //raporGridView = yonetim.OgrenciBilgileri(raporGridView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raporGridView.Controls.Clear();
            new DataGridDoldur().OdemeEskiKayitlar(raporGridView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
