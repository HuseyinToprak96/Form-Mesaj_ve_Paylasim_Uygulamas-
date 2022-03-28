using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesaj_ve_Paylasim_Uygulaması.MODEL
{
    class Mesaj
    {
        public int MesajID { get; set; }
        public int GonderenID { get; set; }
        public int AliciID { get; set; }
       // public string GonderenKadi { get; set; }
       // public string AliciKadi { get; set; }
       // public string GonderenAdi { get; set; }
       // public string AliciAdi { get; set; }
        public string mesaj { get; set; }
        public bool GorulduMu { get; set; }
        //public DateTime MesajZamani { get; set; }
    }
}
