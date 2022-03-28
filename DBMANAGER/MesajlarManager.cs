using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Mesaj_ve_Paylasim_Uygulaması.MODEL;
namespace Mesaj_ve_Paylasim_Uygulaması.DBMANAGER
{
    class Kadi
    {
        public string K_adi { get; set; }
        public int Adet { get; set; }
        public int M_A_ID { get; set; }
    }
    class MesajlarManager
    {
        DBMANAGER dBMANAGER = new DBMANAGER();

        public object DateTme { get; private set; }

        public List<Mesaj> Listele(int GonderenID,int AliciID)
        {
            return new List<Mesaj>();
        }
        public void GorulduYapma(int Gonderen,int Alan)
        {
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("update Mesajlar set Iletim_Durumu=@durum where GonderenID=@GonderenID and AliciID=@AliciID and Iletim_Durumu=0",dBMANAGER.Conn);
            cmd.Parameters.AddWithValue("@durum", true);
            cmd.Parameters.AddWithValue("@GonderenID",Gonderen);
            cmd.Parameters.AddWithValue("@AliciID",Alan);
            cmd.ExecuteNonQuery();
            dBMANAGER.BaglantiKapat();
        }
        public List<Kadi> MesajAtanlar(int A_ID)//,out int G_ID)
                  {
          
            Kadi kadi = new Kadi();
            List<Kadi> MesajGonderenler = new List<Kadi>();
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("Select KullaniciAdi,GonderenID,COUNT(GonderenID) from Uyeler u inner join Mesajlar m on u.UyeID=m.GonderenID where ALiciID=@A_ID AND Iletim_Durumu=@Durum group by KullaniciAdi,GonderenID ", dBMANAGER.Conn);
            cmd.Parameters.AddWithValue("@A_ID", A_ID);
            cmd.Parameters.AddWithValue("@Durum", "False");

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kadi = new Kadi();
                kadi.K_adi = dr[0].ToString();
                kadi.Adet = Convert.ToInt32(dr[2].ToString());
                kadi.M_A_ID = Convert.ToInt32(dr[1].ToString());
                MesajGonderenler.Add(kadi);
            }
            dBMANAGER.BaglantiKapat();
            return MesajGonderenler;
        }
        public List<MesajlasmaBilgileri> Mesajlarınız(int Giren_ID,int Gonderen_ID)
        {
           int tutucu = Gonderen_ID;
            string gonderen;
            List<String> MSJ = new List<string>();
            List<Mesaj> mesajlasmaBilgileri = new List<Mesaj>(); 
            MesajlasmaBilgileri mesajlasma = new MesajlasmaBilgileri();
            List<MesajlasmaBilgileri> bilgileri = new List<MesajlasmaBilgileri>();
            Mesaj mesaj = new Mesaj();
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("Select u1.KullaniciAdi,u1.UyeID,m.Mesaj,u2.KullaniciAdi from Uyeler u1 inner join Mesajlar m on u1.UyeID=m.GonderenID inner join Uyeler u2 on u2.UyeID=m.AliciID where m.GonderenID=@G_ID AND m.AliciID=@A_ID or m.GonderenID=@A_ID AND m.AliciID=@G_ID ", dBMANAGER.Conn);
            cmd.Parameters.AddWithValue("@G_ID", Giren_ID);
            cmd.Parameters.AddWithValue("@A_ID", Gonderen_ID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               
                if (Convert.ToInt32(dr[1].ToString())== tutucu)
                {
                    mesajlasma = new MesajlasmaBilgileri();
                    gonderen = dr[0].ToString();
                    mesajlasma.G_ADI = gonderen.ToString();
                    mesajlasma.MESAJ = MSJ;
                    bilgileri.Add(mesajlasma);
                    //MSJ.Clear();
                    MSJ = new List<string>();
                    if (tutucu==Giren_ID)
                    tutucu =Gonderen_ID;
                    else
                    tutucu=Giren_ID;
                }
                else
                MSJ.Add(dr[2].ToString());
            }
         dBMANAGER.BaglantiKapat();
            return bilgileri;
            
        }
       List<mesajj> Mesaj = new List<mesajj>();
        public List<mesajj> b_mesajlar(int giren,int diger)
        {
            mesajj m = new mesajj();
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("Select KullaniciAdi,Mesaj from Mesajlar inner join Uyeler on GonderenID=UyeID where AliciID=@Giren and GonderenID=@diger or AliciID=@diger and GonderenID=@Giren", dBMANAGER.Conn);
            cmd.Parameters.AddWithValue("@Giren", giren);
            cmd.Parameters.AddWithValue("@diger", diger);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            while(dr.Read())
            {
                m = new mesajj();
                m.Gonderen = dr[0].ToString();
                m.Mesaj = dr[1].ToString();
                Mesaj.Add(m);
            }
            dBMANAGER.BaglantiKapat();
            return Mesaj;
        }
        public void YeniMesajGonder(Mesaj mesaj)
        {
            dBMANAGER.BaglantiAc();
            SqlCommand cmd = new SqlCommand("insert into Mesajlar  values(@Gonderici,@Alici,@Mesaj,@Durumu,@zaman)",dBMANAGER.Conn);
            cmd.Parameters.AddWithValue("@Gonderici", mesaj.GonderenID);
            cmd.Parameters.AddWithValue("@Alici", mesaj.AliciID);
            cmd.Parameters.AddWithValue("@Mesaj",mesaj.mesaj);
            cmd.Parameters.AddWithValue("@Durumu",mesaj.GorulduMu);
            cmd.Parameters.AddWithValue("@zaman", "2012 - 12 - 12 00:00:00.000 ");
            cmd.ExecuteNonQuery();
            dBMANAGER.BaglantiKapat();
        }
    }
}
