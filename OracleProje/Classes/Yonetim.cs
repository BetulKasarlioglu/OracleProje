using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using System.Windows.Forms;

namespace OracleProje.Classes
{
    class Yonetim : Baglanti
    {
        public String yetki,kidem;
        public String yatakId;
        public String ad, soyad, kan, tel, adres, mail, ogretim,ogr_id;
        String odaID;
        public String OGRENCI_ID, TOPLAM_FIYAT, TAKSIT, ODENEN, KALAN_PARA,ODEME_ID;
        /*------------------KULLANICI GİRİŞİ--------------------------------*/
        public string Login(String kullaniciAdi, String sifre)
        {           
            OracleCommand cmd = new OracleCommand("SELECT YETKI FROM PERSONEL WHERE PERSONELAD=:PERAD AND SIFRE=:PASSWORD", baglan);
            cmd.Parameters.Add(":PERAD", kullaniciAdi);
            cmd.Parameters.Add(":PASSWORD", sifre) ;
            baglantiAc();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                yetki = dr.GetString(0).ToString();

            }
            baglantiKapat();
            return yetki;
        }
        /*------------------------------------------------------------------*/
        /*------------------PERSONEL ARA--------------------------------*/
        public string PerAra(String kullaniciAdi, String sifre)
        {
            OracleCommand cmd = new OracleCommand("SELECT PERSONELKIDEM FROM PERSONEL WHERE PERSONELAD=:PERAD AND SIFRE=:PASSWORD", baglan);
            cmd.Parameters.Add(":PERAD", kullaniciAdi);
            cmd.Parameters.Add(":PASSWORD", sifre);
            baglantiAc();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kidem = dr.GetString(0).ToString();
            }
            baglantiKapat();
            return kidem;
        }
        /*------------------------------------------------------------------*/
        /*------------------YATAK GÖSTER--------------------------------*/
        public void YatakGoster()
        {
            baglantiAc();
            OracleCommand cmd = new OracleCommand(@"
          SELECT Y.YATAKID,Y.YATAKNUMRASI,O.ODANUMARASI,O.KISISAYISI FROM YATAK Y INNER JOIN ODA O ON Y.ODAID = O.ODAID 
            Where
            Y.YATAKDURUM = 0
          ", baglan);
            da = new OracleDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);    
        }
        /*------------------------------------------------------------------*/
        /*------------------ÖĞRENCİ EKLE--------------------------------*/
        public void ogrenciEkle(string ad, string soyad, string tc, string kangrubu, string tel, DateTime tarih, string adres, string mail, string ogretim, string odaId)
        {
            baglantiAc();
            OracleCommand cmd = new OracleCommand(@"PROC_OGR_EKLE", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Ogrenci_Ad", OracleDbType.NVarchar2).Value = ad;
            cmd.Parameters.Add("Ogrenci_Soyad", OracleDbType.NVarchar2).Value = soyad;
            cmd.Parameters.Add("Ogrenci_TC", OracleDbType.NVarchar2).Value = tc;
            cmd.Parameters.Add("Ogrenci_KanGrubu", OracleDbType.NVarchar2).Value = kangrubu;
            cmd.Parameters.Add("Ogrenci_Tel", OracleDbType.NVarchar2).Value = tel;
            cmd.Parameters.Add("Ogrenci_KayitTarihi", OracleDbType.Date).Value = tarih;
            cmd.Parameters.Add("Ogrenci_Adres", OracleDbType.NVarchar2).Value = adres;
            cmd.Parameters.Add("Ogrenci_Mail", OracleDbType.NVarchar2).Value = mail;
            cmd.Parameters.Add("Ogrenci_Ogretim", OracleDbType.NVarchar2).Value = ogretim;
            cmd.Parameters.Add("Yatak_ID", OracleDbType.Int16).Value = odaId;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ogrenci Başarıyla Eklenmiştir");           
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------ÖĞRENCİ GÜNCELLE--------------------------------*/
        public void ogrenciGuncelle(String ogr_id,string ad, string soyad, string tc, string kangrubu, string tel, string adres, string mail, string ogretim, string yatakID)
        {
            baglantiAc();
            OracleCommand cmd = new OracleCommand(@"PROC_OGR_GUNCELLE", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("OGRENCI_ID", OracleDbType.Int16).Value = ogr_id;
            cmd.Parameters.Add("Ogrenci_Ad", OracleDbType.NVarchar2).Value = ad;
            cmd.Parameters.Add("Ogrenci_Soyad", OracleDbType.NVarchar2).Value = soyad;
            cmd.Parameters.Add("Ogrenci_TC", OracleDbType.Varchar2).Value = tc;
            cmd.Parameters.Add("Ogrenci_KanGrubu", OracleDbType.NVarchar2).Value = kangrubu;
            cmd.Parameters.Add("Ogrenci_Tel", OracleDbType.NVarchar2).Value = tel;
            cmd.Parameters.Add("Ogrenci_Adres", OracleDbType.NVarchar2).Value = adres;
            cmd.Parameters.Add("Ogrenci_Mail", OracleDbType.NVarchar2).Value = mail;
            cmd.Parameters.Add("Ogrenci_Ogretim", OracleDbType.NVarchar2).Value = ogretim;
            cmd.Parameters.Add("Yatak_ID", OracleDbType.Int16).Value = yatakID;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Başarıyla Güncellendi");
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------ÖĞRENCİ ARA TC KİMLİK NUMARASINA GÖRE--------------------------------*/
        public void ara(String ogr_id)
        {
            OracleCommand cmd = new OracleCommand("OGRENCIARA", baglan);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("OGRENCI_TC", OracleDbType.NVarchar2).Value = ogr_id;
            cmd.Parameters.Add("OGRENCI_AD", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["OGRENCI_AD"].Size = 20;
            cmd.Parameters.Add("OGRENCI_SOYAD", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["OGRENCI_SOYAD"].Size = 20;
            cmd.Parameters.Add("OGRENCI_KANGRUBU", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["OGRENCI_KANGRUBU"].Size = 20;
            cmd.Parameters.Add("OGRENCI_TEL", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["OGRENCI_TEL"].Size = 20;
            cmd.Parameters.Add("OGRENCI_ADRES", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["OGRENCI_ADRES"].Size = 20;
            cmd.Parameters.Add("OGRENCI_MAIL", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["OGRENCI_MAIL"].Size = 20;
            cmd.Parameters.Add("OGRENCI_OGRETIM", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["OGRENCI_OGRETIM"].Size = 20;
            cmd.Parameters.Add("YATAK_ID", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["YATAK_ID"].Size = 20;
            //cmd.Parameters.Add("OGRENCI_ID", OracleDbType.Int16).Direction = ParameterDirection.Output;
            //cmd.Parameters["OGRENCI_ID"].Size = 20;
            baglantiAc();
            cmd.ExecuteNonQuery();
            ad = cmd.Parameters["OGRENCI_AD"].Value.ToString();
            soyad = cmd.Parameters["OGRENCI_SOYAD"].Value.ToString();
            kan = cmd.Parameters["OGRENCI_KANGRUBU"].Value.ToString();
            tel = cmd.Parameters["OGRENCI_TEL"].Value.ToString();
            adres = cmd.Parameters["OGRENCI_ADRES"].Value.ToString();
            mail = cmd.Parameters["OGRENCI_MAIL"].Value.ToString();
            ogretim = cmd.Parameters["OGRENCI_OGRETIM"].Value.ToString();
            yatakId = cmd.Parameters["YATAK_ID"].Value.ToString();
            //ogr_id = cmd.Parameters["OGRENCI_ID"].Value.ToString();
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/       
        /*------------------ÖĞRENCİ ARA TC KİMLİK NUMARASINA GÖRE--------------------------------*/
        public void OgrenciIDCek(String tc)
        {
            OracleCommand cmd = new OracleCommand("OGRENCI_ID_CEK", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("OGRENCI_TC", OracleDbType.NVarchar2).Value = tc;
            cmd.Parameters.Add("OGRENCI_ID", OracleDbType.Varchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["OGRENCI_ID"].Size = 20;
            baglantiAc();
            cmd.ExecuteNonQuery();
            ogr_id = cmd.Parameters["OGRENCI_ID"].Value.ToString();
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------ÖĞRENCİ ARA TC KİMLİK NUMARASINA GÖRE ÖĞRENCİ SİLME--------------------------------*/
        public void OgrenciSil(String tc)
        {
            OracleCommand cmd = new OracleCommand("DELETE FROM OGRENCI WHERE OGRENCITC=:TC", baglan);
            cmd.Parameters.Add(":TC",tc);       
            baglantiAc();
            cmd.ExecuteNonQuery();           
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------YURT ID'ye GÖRE ID ÇEKME--------------------------------*/
        public void YurtSil(String yurtID)
        {
            OracleCommand cmd = new OracleCommand("DELETE FROM YURT WHERE YURTID=:YurtID", baglan);
            cmd.Parameters.Add(":YurtID", yurtID);
            baglantiAc();
            cmd.ExecuteNonQuery();
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------YURT GÜNCELLEME--------------------------------*/
        public void YurtGuncelle(String yurtID,String yurtAd,String adres)
        {
            OracleCommand cmd = new OracleCommand("PROC_YURT_GUNCELLE", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("YURT_ID", OracleDbType.Int16).Value = yurtID;
            cmd.Parameters.Add("YURT_AD",OracleDbType.Varchar2).Value = yurtAd;
            cmd.Parameters.Add("YURT_ADRES", OracleDbType.Varchar2).Value = adres;
            baglantiAc();
            cmd.ExecuteNonQuery();
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------YURT EKLE--------------------------------*/
        public void YurtEkle(String yurtAd,String adres)
        {
            OracleCommand cmd = new OracleCommand("PROC_YURT_EKLE", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("YURT_AD", OracleDbType.NVarchar2).Value = yurtAd;
            cmd.Parameters.Add("YURT_ADRES", OracleDbType.NVarchar2).Value = adres;
            baglantiAc();
            cmd.ExecuteNonQuery();
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------ODA EKLE--------------------------------*/
        public void OdaEkle(String odano, String kat,String blok,String kisiSayisi,String odaTipi,String durum,String yurtID)
        {
            OracleCommand cmd = new OracleCommand("PROC_ODA_EKLE", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ODA_NUMARASI", OracleDbType.NVarchar2).Value = odano;
            cmd.Parameters.Add("ODA_KATI", OracleDbType.NVarchar2).Value = kat;
            cmd.Parameters.Add("ODA_BLOK", OracleDbType.NVarchar2).Value = blok;
            cmd.Parameters.Add("KISI_SAYISI", OracleDbType.NVarchar2).Value = kisiSayisi;
            cmd.Parameters.Add("ODA_TIPI", OracleDbType.NVarchar2).Value = odaTipi;
            cmd.Parameters.Add("ODA_DURUMU", OracleDbType.NVarchar2).Value = durum;
            cmd.Parameters.Add("YURT_ID", OracleDbType.NVarchar2).Value = yurtID;
            baglantiAc();
            cmd.ExecuteNonQuery();
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------ODA ID ARAMA--------------------------------*/
        public string odaAra(string ODANO)
        {
            OracleCommand cmd = new OracleCommand("SELECT ODAID FROM ODA WHERE ODANUMARASI=:ODANO", baglan);
            baglantiAc();
            cmd.Parameters.Add(":ODANO", ODANO);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                odaID = dr["ODAID"].ToString();
            }
            baglantiKapat();
            return odaID;
        }
        /*------------------------------------------------------------------*/
        /*------------------YATAK EKLE--------------------------------*/
        public void yatakEkle(string yataknumarasi,string yatakdurumu, string odaID)
        {
            baglantiAc();
            OracleCommand cmd = new OracleCommand("PROC_YATAK_EKLE", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("YATAK_NUMRASI", OracleDbType.NVarchar2).Value = yataknumarasi;
            cmd.Parameters.Add("ODA_ID", OracleDbType.Int16).Value = odaID;
            cmd.Parameters.Add("YATAK_DURUM", OracleDbType.Int16).Value = yatakdurumu;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yatak Başarıyla Eklenmiştir");            
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------YURT BİLGİLERİ--------------------------------*/
        public ComboBox YurtBilgileri(ComboBox combo)
        {
            baglantiAc();
            OracleCommand cmd = new OracleCommand("SELECT * FROM YURT", baglan);
            da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "YURT");
            combo.DisplayMember = "YURTAD";
            combo.ValueMember = "YURTID";
            combo.DataSource = ds.Tables["YURT"];
            baglantiKapat();
            return combo;
        }
        /*------------------------------------------------------------------*/
        /*------------------PERSONEL EKLE--------------------------------*/
        public void PersonelEkle(String Personel_Ad, String Personel_Soyad, String Personel_Kidem, String Personel_Tel, String Personel_Adres, String Personel_Maas, String Personel_Yetki, String Personel_Sifre, String Yurt_ID)
        {
            OracleCommand cmd = new OracleCommand("PROC_PER_EKLE", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Personel_Ad", OracleDbType.NVarchar2).Value = Personel_Ad;
            cmd.Parameters.Add("Personel_Soyad", OracleDbType.NVarchar2).Value = Personel_Soyad;
            cmd.Parameters.Add("Personel_Kidem", OracleDbType.NVarchar2).Value = Personel_Kidem;
            cmd.Parameters.Add("Personel_Tel", OracleDbType.NVarchar2).Value = Personel_Tel;
            cmd.Parameters.Add("Personel_Adres", OracleDbType.NVarchar2).Value = Personel_Adres;
            cmd.Parameters.Add("Personel_Maas", OracleDbType.NVarchar2).Value = Personel_Maas;
            cmd.Parameters.Add("Personel_Yetki", OracleDbType.NVarchar2).Value = Personel_Yetki;
            cmd.Parameters.Add("Personel_Sifre", OracleDbType.NVarchar2).Value = Personel_Sifre;
            cmd.Parameters.Add("Yurt_ID", OracleDbType.NVarchar2).Value = Yurt_ID;
            baglantiAc();
            cmd.ExecuteNonQuery();
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------PERSONEL SİL--------------------------------*/
        public void PersonelSil(String perID)
        {
            OracleCommand cmd = new OracleCommand("DELETE FROM PERSONEL WHERE PERSONELID=:PERID", baglan);
            cmd.Parameters.Add(":PERID", perID);
            baglantiAc();
            cmd.ExecuteNonQuery();
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------PERSONEL GÜNCELLEME--------------------------------*/
        public void PersonelGuncelle(String Personel_ID, String Personel_Ad, String Personel_Soyad, String Personel_Kidem, String Personel_Tel, String Personel_Adres, String Personel_Maas, String Personel_Yetki, String Personel_Sifre, String Yurt_ID)
        {
            OracleCommand cmd = new OracleCommand("PROC_PER_GUNCELLE", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Personel_ID", OracleDbType.Int16).Value = Personel_ID;
            cmd.Parameters.Add("Personel_Ad", OracleDbType.Varchar2).Value = Personel_Ad;
            cmd.Parameters.Add("Personel_Soyad", OracleDbType.Varchar2).Value = Personel_Soyad;
            cmd.Parameters.Add("Personel_Kidem", OracleDbType.Int16).Value = Personel_Kidem;
            cmd.Parameters.Add("Personel_Tel", OracleDbType.Varchar2).Value = Personel_Tel;
            cmd.Parameters.Add("Personel_Adres", OracleDbType.Varchar2).Value = Personel_Adres;
            cmd.Parameters.Add("Personel_Maas", OracleDbType.Int16).Value = Personel_Maas;
            cmd.Parameters.Add("Personel_Yetki", OracleDbType.Varchar2).Value = Personel_Yetki;
            cmd.Parameters.Add("Personel_Sifre", OracleDbType.Varchar2).Value = Personel_Sifre;
            cmd.Parameters.Add("Yurt_ID", OracleDbType.Int16).Value = Yurt_ID;
            baglantiAc();
            cmd.ExecuteNonQuery();
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------YATAK EKLE--------------------------------*/
        public void OdemeEkle(String ODEME_NO, String TAKSIT_SAYISI, String ODEME_P, String KALAN_P, String TOPLAM_P, String TARİH_P, String OGRENCI_ID, String PERSONEL_ID)
        {
            baglantiAc();
            OracleCommand cmd = new OracleCommand("PROC_ODEME_EKLE", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ODEME_NO", OracleDbType.Int64).Value = ODEME_NO;
            cmd.Parameters.Add("TAKSIT_SAYISI", OracleDbType.Int64).Value = TAKSIT_SAYISI;
            cmd.Parameters.Add("ODEME_P", OracleDbType.Int64).Value = ODEME_P;
            cmd.Parameters.Add("KALAN_P", OracleDbType.Int64).Value = KALAN_P;
            cmd.Parameters.Add("TOPLAM_P", OracleDbType.Int64).Value = TOPLAM_P;
            cmd.Parameters.Add("TARİH_P", OracleDbType.Varchar2).Value = TARİH_P;
            cmd.Parameters.Add("OGRENCI_ID", OracleDbType.Int64).Value = OGRENCI_ID;
            cmd.Parameters.Add("PERSONEL_ID", OracleDbType.Int64).Value = PERSONEL_ID;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ödeme Başarıyla Eklenmiştir");
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------YATAK EKLE--------------------------------*/
        public void OdemeGuncelle(String ODEME_ID, String TAKSIT_SAYISI, String ODEME_P, String KALAN_P, String TOPLAM_P )
        {
            baglantiAc();            
            OracleCommand cmd = new OracleCommand("PROC_ODEME_GUNCELLE", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ODEME_ID", OracleDbType.Int64).Value = ODEME_ID;
            cmd.Parameters.Add("TAKSIT_SAYISI", OracleDbType.Int64).Value = TAKSIT_SAYISI;
            cmd.Parameters.Add("ODEME_P", OracleDbType.Int64).Value = ODEME_P;
            cmd.Parameters.Add("KALAN_P", OracleDbType.Int64).Value = KALAN_P;
            cmd.Parameters.Add("TOPLAM_P", OracleDbType.Int64).Value = TOPLAM_P;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ödeme Başarıyla Güncellenmiştir.");
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------YATAK EKLE--------------------------------*/
        public void OdemeSil(String ODEME_ID)
        {
            baglantiAc();
            OracleCommand cmd = new OracleCommand("PROC_ODEME_SIL", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ODEME_ID", OracleDbType.NVarchar2).Value = ODEME_ID;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ödeme Başarıyla Silinmiştir.");
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------OGRENCI COMBOBOX BİLGİLERİ--------------------------------*/
        public ComboBox OgrenciBilgileri(ComboBox combo)
        {
            baglantiAc();
            OracleCommand cmd = new OracleCommand("SELECT * FROM OGRENCI", baglan);
            da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "OGRENCI");
            combo.DisplayMember = "OGRENCIAD";
            combo.ValueMember = "OGRENCIID";
            combo.DataSource = ds.Tables["OGRENCI"];
            baglantiKapat();
            return combo;
        }
        /*------------------------------------------------------------------*/
        /*------------------PERSONEL BİLGİLERİ--------------------------------*/
        public ComboBox PersonelBilgileri(ComboBox combo)
        {
            baglantiAc();
            OracleCommand cmd = new OracleCommand("SELECT * FROM PERSONEL", baglan);
            da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "PERSONEL");
            combo.DisplayMember = "PERSONELAD";
            combo.ValueMember = "PERSONELID";
            combo.DataSource = ds.Tables["PERSONEL"];
            baglantiKapat();
            return combo;
        }
        /*------------------------------------------------------------------*/
        /*------------------ÖĞRENCİ ÖDEME BİLGİSİ--------------------------------*/
        public void OgrenciOdemeBilgisi(String ogr_id)
        {
            OracleCommand cmd = new OracleCommand("OGRENCI_ODEME_ARA", baglan);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("OGRENCI_ID", OracleDbType.NVarchar2).Value = ogr_id;
            cmd.Parameters.Add("TOPLAM_FIYAT", OracleDbType.NVarchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["TOPLAM_FIYAT"].Size = 20;
            cmd.Parameters.Add("TAKSIT", OracleDbType.NVarchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["TAKSIT"].Size = 20;
            cmd.Parameters.Add("ODENEN", OracleDbType.NVarchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["ODENEN"].Size = 20;
            cmd.Parameters.Add("KALAN_PARA", OracleDbType.NVarchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["KALAN_PARA"].Size = 20;
            cmd.Parameters.Add("ODEME_ID", OracleDbType.NVarchar2).Direction = ParameterDirection.Output;
            cmd.Parameters["ODEME_ID"].Size = 20;
            baglantiAc();
            cmd.ExecuteNonQuery();
            TOPLAM_FIYAT = cmd.Parameters["TOPLAM_FIYAT"].Value.ToString();
            TAKSIT = cmd.Parameters["TAKSIT"].Value.ToString();
            ODENEN = cmd.Parameters["ODENEN"].Value.ToString();
            KALAN_PARA = cmd.Parameters["KALAN_PARA"].Value.ToString();
            ODEME_ID = cmd.Parameters["ODEME_ID"].Value.ToString();
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/
        /*------------------DİSİPLİN EKLE--------------------------------*/
        public void DisiplinEkle(String ogrID,String disiplin)
        {
            baglantiAc();
            OracleCommand cmd = new OracleCommand("PROC_DISIPLIN_EKLE", baglan);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("DISIPLIN", OracleDbType.Varchar2).Value = disiplin;
            cmd.Parameters.Add("OGRENCI_ID", OracleDbType.NVarchar2).Value = ogrID;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ödeme Başarıyla Eklenmiştir");
            baglantiKapat();
        }
        /*------------------------------------------------------------------*/

    }
}
