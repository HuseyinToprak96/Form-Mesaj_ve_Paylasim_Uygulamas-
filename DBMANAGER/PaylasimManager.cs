using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mesaj_ve_Paylasim_Uygulaması.MODEL;
using System.Data;

namespace Mesaj_ve_Paylasim_Uygulaması.DBMANAGER
{
    class PaylasimManager
    {
        DBMANAGER dBMANAGER = new DBMANAGER();
        public DataTable Listele()
        {
            dBMANAGER.BaglantiAc();
        SqlDataAdapter da = new SqlDataAdapter("Select * from Paylasimlar",dBMANAGER.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ResimKontrol(int id,string path)
        {
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("Select * from Paylasimlar WHERE PaylasanID=@PaylasanID and PaylasilanResim=@PaylasilanResim", dBMANAGER.Conn);
            cmd.Parameters.AddWithValue("@PaylasanID", id);
            cmd.Parameters.AddWithValue("@PaylasilanResim",path);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows) { 
            dBMANAGER.BaglantiKapat();
                return 1;}
            else
                return 0;
            
        }
        public string PaylasimEkle(Paylasim paylasim)
        {
           int Kontrol= ResimKontrol(paylasim.PaylasanID, paylasim.ResimPATH);
            if (Kontrol == 0)
            {
                dBMANAGER.BaglantiAc();

                SqlCommand cmd = new SqlCommand("insert into Paylasimlar values(@PaylasanID,@Path,@Tarih,@Soz)", dBMANAGER.Conn);
                cmd.Parameters.AddWithValue("@PaylasanID", paylasim.PaylasanID);
                cmd.Parameters.AddWithValue("@Path", paylasim.ResimPATH);
                cmd.Parameters.AddWithValue("@Tarih", paylasim.PaylasimZamani);
                cmd.Parameters.AddWithValue("@Soz", paylasim.Soz);
                cmd.ExecuteNonQuery();
                dBMANAGER.BaglantiKapat();
                return "Paylaşımınız Başarılı Bir Şekilde Gerçekleşmiştir.";
            }
            else
                return "Aynı Resmi Tekrar Paylaşamazsınız.";
        }
        public void PaylasimSil(Paylasim paylasim)
        {

        }
        public PaylasimManager()
        {
            Resimler = new List<string>();
        }List<PaylasimGosterici> paylasimlar = new List<PaylasimGosterici>();
        public List<string> Resimler { get; set; }
        public List<PaylasimGosterici> Paylasimlar()
        {
            PaylasimGosterici paylasimGosterici = new PaylasimGosterici();
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("SELECT u.KullaniciAdi,p.PaylasilanResim,p.Soz FROM Paylasimlar p inner join Uyeler u on p.PaylasanID=u.UyeID", dBMANAGER.Conn);
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
           {
                paylasimGosterici = new PaylasimGosterici();
                paylasimGosterici.P_Kadi = dr[0].ToString();
                paylasimGosterici.Path = dr[1].ToString();
                paylasimGosterici.P_Soz = dr[2].ToString();
                paylasimlar.Add(paylasimGosterici);
           }
           
          
            dBMANAGER.BaglantiKapat();
          

            // Resim = dr[1].ToString();
            return paylasimlar;
            
        }
        public void PaylasimOnay(int P_ID,int onay)
        {
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("update Paylasim set(Onay=@Onay) where PaylasimID=@P_ID");
            cmd.Parameters.AddWithValue("@Onay",onay);
            cmd.Parameters.AddWithValue("@P_ID",P_ID);
            cmd.ExecuteNonQuery();
            dBMANAGER.BaglantiKapat();
        }
    }
}
