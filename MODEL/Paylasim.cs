using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesaj_ve_Paylasim_Uygulaması.MODEL
{
    class Paylasim
    {
        public int PaylasimID { get; set; }
        public int PaylasanID { get; set; }
        public string ResimPATH { get; set; }
        public string Soz { get; set; }
        public DateTime PaylasimZamani { get; set; }
    
    }
}
