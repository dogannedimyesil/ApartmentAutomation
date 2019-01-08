using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentAutomation
{
    
    class Gelir 
    {
        public decimal Tutar { get; set; }
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public int DaireNo { get; set; }
    }
    class Gider
    {
        public decimal Tutar { get; set; }
        public DateTime Tarih { get; set; }
        public string GiderTurleri { get; set; }
    }
    enum GiderTurleri
    {
        Elektrik,
        Su,
        Doğalgaz,
        Asansör
    }
}
