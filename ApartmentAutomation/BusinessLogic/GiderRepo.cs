using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation.BusinessLogic
{
    class GiderRepo
    {
        public static void GiderEkle(Gider yeniGider)
        {
            SqlParameter p1 = new SqlParameter("Tutar", yeniGider.Tutar);
            SqlParameter p2 = new SqlParameter("Tarih", yeniGider.Tarih);
            SqlParameter p3 = new SqlParameter("GiderTuru", yeniGider.GiderTurleri);
            Program.SqlHelper.ExecuteProc("sp_GiderEkle", p1, p2, p3);
        }
        public static List<Gider> GiderListesiniGetir()
        {
            List<Gider> list = new List<Gider>();
            DataTable dt = Program.SqlHelper.GetTable("SELECT * FROM tbl_Giderler");
            foreach (DataRow row in dt.Rows)
            {
                Gider b = new Gider();
                b.Tarih = (DateTime)row["Tarih"];
                b.Tutar = (decimal)row["Tutar"];
                b.GiderTurleri = (string)row["GiderTuru"];
                list.Add(b);
            }
            return list;
        }
    }
}
