using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mesaj_ve_Paylasim_Uygulaması.MODEL;
using Mesaj_ve_Paylasim_Uygulaması.DBMANAGER;
using System.Configuration;

namespace Mesaj_ve_Paylasim_Uygulaması
{
    class Yonetici
    {
        public UyelerManager Uyeler { get; set; }
        public MesajlarManager Mesajlar { get; set; }
        public PaylasimManager Paylasimlar { get; set; }

        public Yonetici()
        {
            string yol = ConfigurationManager.ConnectionStrings["ConnStr"].ToString();
        }
        
    }
}
