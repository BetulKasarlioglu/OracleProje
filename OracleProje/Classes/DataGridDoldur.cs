using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using System.Drawing;

namespace OracleProje.Classes
{
    class DataGridDoldur : Yonetim
    {
        public void DataGrid(DataGridView dg)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new OracleCommand("select * from OGRENCI order by OGRENCIID desc", baglan);
            da = new OracleDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].Visible = false;
            baglan.Close();
            dataGridSilButonu(dg);
        }
        void dataGridEkleButonu(DataGridView dg)
        {
            DataGridViewButtonColumn dbuton = new DataGridViewButtonColumn();
            dbuton.HeaderText = "";
            dbuton.Text = "Düzenle";
            dbuton.UseColumnTextForButtonValue = true;
            dbuton.DefaultCellStyle.BackColor = Color.Blue;
            dbuton.DefaultCellStyle.SelectionBackColor = Color.Red;
            dbuton.Width = 70;
            dg.Columns.Add(dbuton);
        }
        void dataGridSilButonu(DataGridView dg)
        {
            DataGridViewButtonColumn dbuton = new DataGridViewButtonColumn();
            dbuton = new DataGridViewButtonColumn();
            dbuton.HeaderText = "";
            dbuton.Text = "Sil";
            dbuton.UseColumnTextForButtonValue = true;
            dbuton.DefaultCellStyle.BackColor = Color.Blue;
            dbuton.DefaultCellStyle.SelectionBackColor = Color.Red;
            dbuton.Width = 70;
            dg.Columns.Add(dbuton);
        }

        /**********************SİLİNMİŞ ÖĞRENCİLER COMBOBOX***********************************************/
        public void DataGridSilinmisOgrenci(DataGridView dg)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new OracleCommand("select * from SILINMISOGRENCI order by SOGRENCIID desc", baglan);
            da = new OracleDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].Visible = false;
            baglan.Close();
            //dataGridEkleButonu(dg);
            dataGridSilButonu(dg);
        }
        /************************************************************************/
        /**************************YURTLAR*******************************************/
        public void DataGridPersonel(DataGridView dg)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new OracleCommand("select * from YURT order by YURTAD desc", baglan);
            da = new OracleDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].Visible = true;
            baglan.Close();
            dataGridEkleButonu(dg);
            dataGridSilButonu(dg);
        }
        /************************************************************************/
        public void DataGridYurtlar(DataGridView dg)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new OracleCommand("select * from PERSONEL order by PERSONELID desc", baglan);
            da = new OracleDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].Visible = true;
            baglan.Close();
            dataGridEkleButonu(dg);
            dataGridSilButonu(dg);
        }
        /************************************************************************/
        /************************************************************************/
        public void DataGridOdeme(DataGridView dg)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new OracleCommand("SELECT o.ODEMEID,ogr.OgrenciAd,ogr.ogrenciSoyad,o.TAKSITSAYISI,o.ODEME,o.KALAN,o.TOPLAM from odeme o inner join OGRENCI ogr on o.ogrenciid=ogr.ogrenciid order by PERSONELID desc", baglan);
            da = new OracleDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].Visible = false;
            baglan.Close();
            dataGridEkleButonu(dg);
            dataGridSilButonu(dg);
        }
        /************************************************************************/
        /************************************************************************/
        public void SilinmisDataGridDoldur(DataGridView dg)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new OracleCommand("SELECT * FROM SILINMISOGRENCI order by SILINMISOGRENCIID desc", baglan);
            da = new OracleDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].Visible = false;
            baglan.Close();
            //dataGridEkleButonu(dg);
            //dataGridSilButonu(dg);
        }
        /************************************************************************/
        /************************************************************************/
        public void DisiplinDataGridDoldur(DataGridView dg)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new OracleCommand("select o.ogrenciad,d.ogrencidisiplindurum from ogrencidisiplin d join ogrenci o on d.ogrenciid=o.ogrenciid order by o.OGRENCIID desc", baglan);
            da = new OracleDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].Visible = true;
            baglan.Close();
            //dataGridEkleButonu(dg);
            //dataGridSilButonu(dg);
        }
        /************************************************************************/
        /************************************************************************/
        public void Raporla(DataGridView dg,String sqlsorgu)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new OracleCommand("PROC_ODEME_RAPORU", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("OGRENCI_AD", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["OGRENCI_AD"].Size = 20;
            cmd.Parameters.Add("OGRENCI_SOYAD", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["OGRENCI_SOYAD"].Size = 20;
            cmd.Parameters.Add("OGRENCI_TC", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["OGRENCI_TC"].Size = 20;
            cmd.Parameters.Add("ODEME_TOPLAM", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["ODEME_TOPLAM"].Size = 20;
            cmd.Parameters.Add("ODEME_KALAN", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["ODEME_KALAN"].Size = 20;
            cmd.ExecuteNonQuery();
            da = new OracleDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].Visible = true;
            baglan.Close();
            //dataGridEkleButonu(dg);
            //dataGridSilButonu(dg);
        }
        /************************************************************************/
        /************************************************************************/
        public void OdemeEskiKayitlar(DataGridView dg)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new OracleCommand("SELECT o.ODEMEID,ogr.OgrenciAd,ogr.ogrenciSoyad,o.TAKSITSAYISI,o.ODEME,o.KALAN,o.TOPLAM from ODEME_KAYITLARI o inner join OGRENCI ogr on o.ogrenciid=ogr.ogrenciid order by TARIH desc", baglan);
            da = new OracleDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt);
            dg.DataSource = dt;
            dg.Columns[0].Visible = false;
            baglan.Close();
            dataGridEkleButonu(dg);
            dataGridSilButonu(dg);
        }
        /************************************************************************/
        /************************************************************************/
        public String ad;
        public void OdemeKayitlari(DataGridView dg)
        {
            dg.Columns.Clear();
            baglan.Open();
            cmd = new OracleCommand("PROC_ODEME_RAPORU.ODEME", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("ODEME", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleParameter output = cmd.Parameters.Add("ODEME",OracleDbType.RefCursor);
            output.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            OracleDataReader da = ((OracleRefCursor)output.Value).GetDataReader();
            while (dr.Read())
            {
                ad = dr.GetString(0).ToString();
            }
            cmd.Parameters.Clear();
            baglan.Close();
        }
        /************************************************************************/
    }
}
