using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;


namespace OracleProje.Classes
{
    class Baglanti
    {
        public OracleConnection baglan = new OracleConnection("DATA SOURCE =localhost:1521/xe;PASSWORD=hr;PERSIST SECURITY INFO= True; USER ID=HR");
        public OracleCommand cmd;
        public int rowsUpdate = 0;
        public string mesaj = "mesaj";
        public OracleDataReader dr;
        public DataTable dt = new DataTable();
        public OracleDataAdapter da;

        public void baglantiAc()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
        }

        public void baglantiKapat()
        {
            if (baglan.State == ConnectionState.Open)
            {
                baglan.Close();
            }
        }
    }
}
