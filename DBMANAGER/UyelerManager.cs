using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mesaj_ve_Paylasim_Uygulaması.MODEL;
using System.Data;

namespace Mesaj_ve_Paylasim_Uygulaması.DBMANAGER
{
    class UyelerManager
    {
        Uye uye = new Uye();
        DBMANAGER dBMANAGER = new DBMANAGER();
        UyeLİSTE uyeLİSTE = new UyeLİSTE();
          List<UyeLİSTE> UyeListesi = new List<UyeLİSTE>();
        public DataTable UyeSorgula(string sorgu)
        {
            dBMANAGER.BaglantiAc();
            SqlDataAdapter da = new SqlDataAdapter(sorgu,dBMANAGER.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dBMANAGER.BaglantiKapat();
            return dt;
            
        }
        public void AdminYap(int uyeID,int onay)
        {
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("update  Uyeler set Yetki=@Onay where UyeID=@UyeID",dBMANAGER.Conn);
            cmd.Parameters.AddWithValue("@UyeID",uyeID);
            cmd.Parameters.AddWithValue("@Onay",onay);
            cmd.ExecuteNonQuery();
        }
        public List<UyeLİSTE> Listele(int UyeID)
        {
            UyeListesi.Clear();
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("select KullaniciAdi,UyeAdi,UyeSoyadi,SehirAdi,UyeID,Resim,Cinsiyet,UyeID from Uyeler where UyeID!=@UyeID",dBMANAGER.Conn);
            cmd.Parameters.AddWithValue("@UyeID", UyeID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                uyeLİSTE = new UyeLİSTE();
                uyeLİSTE.Kadi = dr[0].ToString();
                uyeLİSTE.Isim = dr[1].ToString();
                uyeLİSTE.SoyIsim = dr[2].ToString();
                uyeLİSTE.Sehir = dr[3].ToString();
                uyeLİSTE.UyeID = Convert.ToInt32(dr[4]);
                uyeLİSTE.Resim = dr[5].ToString();
                uyeLİSTE.Cinsiyet=dr[6].ToString();
                uyeLİSTE.UyeID = Convert.ToInt32(dr[7]);
                 UyeListesi.Add(uyeLİSTE);
            }
            dBMANAGER.BaglantiKapat();
            return UyeListesi;
            
           
        }
       
        public void UyeEkle(Uye uye)
        {
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("Gp_UyeEkle", dBMANAGER.Conn);
            cmd.CommandType =System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Resim", uye.Resim);
            cmd.Parameters.AddWithValue("@KullaniciAdi",uye.UyeKullaniciAdi);
            cmd.Parameters.AddWithValue("@Sifre", uye.Sifre);
            cmd.Parameters.AddWithValue("@UyeAdi", uye.Isim);
            cmd.Parameters.AddWithValue("@UyeSoyadi",uye.Soyisim);
            cmd.Parameters.AddWithValue("@SehirAdi", uye.Sehir);
            cmd.Parameters.AddWithValue("Cinsiyet", uye.Cinsiyet);
            cmd.Parameters.AddWithValue("@GizliSoru",uye.GizliSoru);
            cmd.Parameters.AddWithValue("@Cevap", uye.Cevap);
            cmd.Parameters.AddWithValue("@Telefon",uye.Telefon);
            cmd.Parameters.AddWithValue("@Mail", uye.Mail);
            cmd.ExecuteNonQuery();
            dBMANAGER.BaglantiKapat();
        } 
        
        public Uye Giris(string Kadi,string sifre)
        {
           
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("Select * from Uyeler where KullaniciAdi=@Kadi and Sifre=@sifre", dBMANAGER.Conn);
            cmd.Parameters.AddWithValue("@Kadi", Kadi);
            cmd.Parameters.AddWithValue("@sifre",sifre);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                uye.UyeID = Convert.ToInt32(dr[0]);
                uye.Yetki = Convert.ToInt32(dr[1]);
                uye.UyeKullaniciAdi = dr[2].ToString();
                uye.Resim = dr[3].ToString();
                uye.Sifre = dr[4].ToString();
                uye.Isim = dr[5].ToString();
                uye.Soyisim = dr[6].ToString();
                uye.Sehir = dr[7].ToString();
                uye.Cinsiyet = dr[8].ToString();
                uye.GizliSoru = dr[9].ToString();
                uye.Cevap = dr[10].ToString();
                uye.Telefon =Convert.ToInt16(dr[11].ToString());
                uye.Mail = dr[12].ToString();
                dBMANAGER.BaglantiKapat();
            }
            else 
           uye=null;
            return uye;
        }

        public Uye SifremiUnuttum(string Kadi)
        {
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("Select * from Uyeler where KullaniciAdi=@Kadi", dBMANAGER.Conn);
            cmd.Parameters.AddWithValue("@Kadi", Kadi);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                uye.UyeID = Convert.ToInt32(dr[0]);
                uye.Yetki = Convert.ToInt32(dr[1]);
                uye.UyeKullaniciAdi = dr[2].ToString();
                uye.Resim = dr[3].ToString();
                uye.Sifre = dr[4].ToString();
                uye.Isim = dr[5].ToString();
                uye.Soyisim = dr[6].ToString();
                uye.Sehir = dr[7].ToString();
                uye.Cinsiyet = dr[8].ToString();
                uye.GizliSoru = dr[9].ToString();
                uye.Cevap = dr[10].ToString();
                uye.Telefon = Convert.ToInt32(dr[11].ToString());
                uye.Mail = dr[12].ToString();
                dBMANAGER.BaglantiKapat();
            }
            else
                return uye = null;
            return uye;
           
        }
        public void Guncelle(int id)
        {
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("gp_UyeBilgisiGuncelleme", dBMANAGER.Conn);
            //cmd.Parameters.AddWithValue("");
            //cmd.Parameters.AddWithValue("");
            //cmd.Parameters.AddWithValue("");
            //cmd.Parameters.AddWithValue("");
            //cmd.Parameters.AddWithValue("");
            //cmd.Parameters.AddWithValue("");
            //cmd.Parameters.AddWithValue("");
            //cmd.Parameters.AddWithValue("");
            //cmd.Parameters.AddWithValue("");



            cmd.ExecuteNonQuery();
        }
        public string Varmi(string Kullaniciadi)
        {
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("select * from Uyeler where KullaniciAdi=@KullaniciAdi",dBMANAGER.Conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
                return "Böyle Bir Kullanıcı Adı Zaten Var.";
            else
                return "HoşGeldiniz..İletişim Bilgilerinizi Girerek Üyelik İşlemlerine Devam Edebilirsiniz.";
        }

    }
}
