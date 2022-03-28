using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mesaj_ve_Paylasim_Uygulaması.MODEL;
using Mesaj_ve_Paylasim_Uygulaması.DBMANAGER;
namespace Mesaj_ve_Paylasim_Uygulaması.DBMANAGER
{
    class PuanVermeManager
    {
        DBMANAGER dBMANAGER = new DBMANAGER();
        public void PuanVerme(int VerenID,int AlanID,int Puan)
        {
            dBMANAGER.BaglantiAc();
                SqlCommand cmd = new SqlCommand("insert into Puanlar values(@PuanVeren,@PuanAlan,@Puan)",dBMANAGER.Conn);
                cmd.Parameters.AddWithValue("@PuanVeren",VerenID);
                cmd.Parameters.AddWithValue("@PuanAlan",AlanID);
                cmd.Parameters.AddWithValue("@Puan", Puan);
                cmd.ExecuteNonQuery();
            dBMANAGER.BaglantiKapat();
        }
        TOP10 tOP10 = new TOP10();
        public List<TOP10> Top10()
        {
            List<TOP10> EnTop10 = new List<TOP10>();
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("select TOP(10) KullaniciAdi,Resim,UyeID from Puanlar inner join Uyeler on UyeID=PuanAlanID",dBMANAGER.Conn);
           // "(SELECT top(1) Count(*) FROM Puanlar group by PuanAlanID) as EnCokAlanınAdedi";
           //"select TOP(10) sum(*)/EnCokAlanınAdedi from Puanlar group by PuanAlanID ";
            SqlDataReader dr =cmd.ExecuteReader();
            while(dr.Read())
            {
               tOP10 = new TOP10();
               tOP10.Kadi= dr[0].ToString();
               tOP10.Resim = dr[1].ToString();
               tOP10.Puan =double.Parse( dr[2].ToString());//düzeltilecek
                EnTop10.Add(tOP10);
            }
            return EnTop10;
        }
        public List<int> PuanVerilenler(int UyeID)
        {
            List<int> puanVerdikleriniz = new List<int>();
            int verdiklerim = new int(); 
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("select PuanAlanID from Puanlar where PuanVerenID=@UyeID",dBMANAGER.Conn);
            cmd.Parameters.AddWithValue("@UyeID",UyeID);
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                verdiklerim = new int();
                verdiklerim = Convert.ToInt32(dr[0]);
                puanVerdikleriniz.Add(verdiklerim);
            }
            return puanVerdikleriniz;
        }
    }
}
