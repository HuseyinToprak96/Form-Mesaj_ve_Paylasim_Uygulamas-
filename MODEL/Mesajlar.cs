using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesaj_ve_Paylasim_Uygulaması.MODEL
{
    class Mesajlar
    {
        public int MesajID { get; set; }
        public int GonderenID { get; set; }
        public int AliciID { get; set; }
        public string Mesaj { get; set; }
        public bool GorulduMu { get; set; }
        public DateTime MesajZamani { get; set; }
    }
}
