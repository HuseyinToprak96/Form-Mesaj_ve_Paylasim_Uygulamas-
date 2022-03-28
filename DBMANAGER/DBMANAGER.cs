using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mesaj_ve_Paylasim_Uygulaması.MODEL;
using Mesaj_ve_Paylasim_Uygulaması.DBMANAGER;
using System.Data.SqlClient;
namespace Mesaj_ve_Paylasim_Uygulaması.DBMANAGER
{
    class DBMANAGER
    {
        public string  yol { get; set; }
        public SqlConnection Conn { get; set; }
        public DBMANAGER()
        {
        yol = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString.ToString();
        }
        
        public void BaglantiAc()
        {
            Conn = new SqlConnection(yol);
            Conn.Open();

        }
        public void BaglantiKapat()
        {
            Conn.Close();
        }
    }
    
}
