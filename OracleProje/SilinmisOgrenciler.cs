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
    public partial class SilinmisOgrenciler : Form
    {
        public SilinmisOgrenciler()
        {
            InitializeComponent();
        }
        Yonetim yonetim = new Yonetim();
        private void SilinmisOgrenciler_Load(object sender, EventArgs e)
        {
            new DataGridDoldur().SilinmisDataGridDoldur(SilinmisdataGridView);
        }
    }
}
