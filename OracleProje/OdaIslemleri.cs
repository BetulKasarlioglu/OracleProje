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
    public partial class OdaIslemleri : Form
    {
        public OdaIslemleri()
        {
            InitializeComponent();
        }
        Yonetim yonetim = new Yonetim();
        String odaID;
        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            yonetim.OdaEkle(UpDownNumara.Value.ToString(), UpDownKat.Value.ToString(), txtOdaBlok.Text, UpDownKisi.Value.ToString(), comboOdaTipi.Text, "0", comboYurt.SelectedValue.ToString());
            odaID = yonetim.odaAra(UpDownNumara.Value.ToString());
            btnYatakEkle.Enabled = true;
            MessageBox.Show("Oda Ekleme İşlemi Yapılmıştır.");
        }

        private void btnYatakEkle_Click(object sender, EventArgs e)
        {
            if (comboOdaTipi.Text == "1 Kişilik")
            {
                yonetim.yatakEkle(txtYatak1.Text, "0", odaID);
            }
            else if (comboOdaTipi.Text == "2 Kişilik")
            {
                yonetim.yatakEkle(txtYatak1.Text, "0", odaID);
                yonetim.yatakEkle(txtYatak2.Text, "0", odaID);
            }
            else if (comboOdaTipi.Text == "3 Kişilik")
            {
                yonetim.yatakEkle(txtYatak1.Text, "0", odaID);
                yonetim.yatakEkle(txtYatak2.Text, "0", odaID);
                yonetim.yatakEkle(txtYatak3.Text, "0", odaID);
            }
            else if (comboOdaTipi.Text == "4 Kişilik")
            {
                yonetim.yatakEkle(txtYatak1.Text, "0", odaID);
                yonetim.yatakEkle(txtYatak2.Text, "0", odaID);
                yonetim.yatakEkle(txtYatak3.Text, "0", odaID);
                yonetim.yatakEkle(txtYatak4.Text, "0", odaID);
            }
            
        }

        private void OdaIslemleri_Load(object sender, EventArgs e)
        {
            comboOdaTipi.SelectedIndex = 0;
            comboYurt =  yonetim.YurtBilgileri(comboYurt);

        }

        private void comboOdaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboOdaTipi.Text == "1 Kişilik")
            {
                txtYatak1.Enabled = true;
            }
            else if (comboOdaTipi.Text == "2 Kişilik")
            {
                txtYatak2.Enabled = true;
            }
            else if (comboOdaTipi.Text == "3 Kişilik")
            {
                txtYatak3.Enabled = true;
            }
            else if (comboOdaTipi.Text == "4 Kişilik")
            {
                txtYatak4.Enabled = true;
            }
        }

        private void UpDownKisi_ValueChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(UpDownKisi.Value.ToString());


            if (i == 1)
            {
                txtYatak1.Visible = true;
                txtYatak2.Visible = false;
                txtYatak3.Visible = false;
                txtYatak4.Visible = false;
                comboOdaTipi.SelectedIndex = 0;
            }
            if (i == 2)
            {
                txtYatak1.Visible = true;
                txtYatak2.Visible = true;
                txtYatak3.Visible = false;
                txtYatak4.Visible = false;
                comboOdaTipi.SelectedIndex = 1;
            }
            if (i == 3)
            {
                txtYatak1.Visible = true;
                txtYatak2.Visible = true;
                txtYatak3.Visible = true;
                txtYatak4.Visible = false;
                comboOdaTipi.SelectedIndex = 2;
            }
            if (i == 4)
            {
                txtYatak1.Visible = true;
                txtYatak2.Visible = true;
                txtYatak3.Visible = true;
                txtYatak4.Visible = true;
                comboOdaTipi.SelectedIndex = 3;
            }         
        }
    }
}
