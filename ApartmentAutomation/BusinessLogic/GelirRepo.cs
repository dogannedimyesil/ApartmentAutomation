using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation.BusinessLogic
{
    class GelirRepo
    {
        public static void GelirEkle(Gelir yeniGelir)
        {
            SqlParameter p1 = new SqlParameter("DaireNO", yeniGelir.DaireNo);
            SqlParameter p2 = new SqlParameter("Tutar", yeniGelir.Tutar);
            SqlParameter p4 = new SqlParameter("Tarih", yeniGelir.Tarih);
            Program.SqlHelper.ExecuteProc("sp_GelirEkle", p1, p2, p4);
        }
        public static List<Gelir> GelirListesiniGetir()
        {
            List<Gelir> list = new List<Gelir>();
            DataTable dt = Program.SqlHelper.GetTable("SELECT * FROM tbl_Gelirler");
            foreach (DataRow row in dt.Rows)
            {
                Gelir b = new Gelir();
                b.ID = (int)row["ID"]; 
                b.DaireNo = (int)row["DaireNo"];
                b.Tarih = (DateTime)row["Tarih"];
                b.Tutar = (decimal)row["Tutar"];
                list.Add(b);
            }
            return list;
        }
    }
}
