using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mesaj_ve_Paylasim_Uygulaması.MODEL;
using Mesaj_ve_Paylasim_Uygulaması.DBMANAGER;
namespace Mesaj_ve_Paylasim_Uygulaması
{
    public partial class Frm_Giris : Form
    {
        public Frm_Giris()
        {
            InitializeComponent();
        }
       // public bool Onay { get; set; }
        public bool Onay { get { return cb_sozlesme.Checked; } set { cb_sozlesme.Checked = value; } }
        //CheckBox cb_sozlesme;
        Yonetici yonetici = new Yonetici();
        
        DBMANAGER.DBMANAGER db = new DBMANAGER.DBMANAGER();
        private void btn_GirisPaneliAc_Click(object sender, EventArgs e)
        {   
            pnl_Giris.Visible = true;
            
        }
        private void btn_uyeol_Click(object sender, EventArgs e)
        {
            pnl_Giris.Visible = true;
        }
        Uye GirisYapan;
        private void Btn_giris_Click(object sender, EventArgs e)
        {
           UyelerManager uyelerManager = new UyelerManager();
            GirisYapan = uyelerManager.Giris(txt_Giris_Kadi.Text, txt_Giris_Sifre.Text);
            
            if (GirisYapan != null)
            {
                this.Visible = false;
                txt_Giris_Kadi.Text = "";
                txt_Giris_Sifre.Text = "";
                Frm_GirisYapildi frm_GirisYapildi = new Frm_GirisYapildi();
               // frm_GirisYapildi.Tag= GirisYapan.UyeID;
                frm_GirisYapildi.Text = "HOŞGELDİN " + GirisYapan.Isim;
                frm_GirisYapildi.UyeID = GirisYapan.UyeID;
                frm_GirisYapildi.Kadi = GirisYapan.UyeKullaniciAdi;
                frm_GirisYapildi.Sifre = GirisYapan.Sifre; 
                frm_GirisYapildi.UyeAdi = GirisYapan.Isim;
                frm_GirisYapildi.UyeSoyadi = GirisYapan.Soyisim;
                frm_GirisYapildi.Sehir = GirisYapan.Sehir;
                frm_GirisYapildi.GizliSoru = GirisYapan.GizliSoru;
                frm_GirisYapildi.G_Cevap = GirisYapan.Cevap;
                frm_GirisYapildi.Telefon = GirisYapan.Telefon;
                frm_GirisYapildi.Mail = GirisYapan.Mail;
                frm_GirisYapildi.Show();
                if (GirisYapan.Yetki == 1)
                {
                    Frm_Yonetim frm_Yonetim = new Frm_Yonetim();
                    frm_Yonetim.Show();
                }
            }
            else
                lbl_girishatasi.Text = "Hatalı Kullanıcı Adı veya Şifre";

        }
        private void lbl_uyeoll_Click(object sender, EventArgs e)
        {
            LOGİN_PAGE_CONTROLLER.Visible = true;
            pnl_Giris.Visible = false;
            LOGİN_PAGE_CONTROLLER.SelectedTab = tp_UyeOL;
            
        }
        private void lbl_sifremiUnuttum_Click(object sender, EventArgs e)
        {
            LOGİN_PAGE_CONTROLLER.Visible = true;
            pnl_Giris.Visible = false;
            LOGİN_PAGE_CONTROLLER.SelectedTab = tp_SifremiUnuttum;
           
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Onay==true)
            {
                cb_sozlesme.Checked = true;
            }
            Frm_Giris frm_Giris = new Frm_Giris();
            frm_Giris.Show();
            pnl_Giris.Visible = false;
            cb__uo_Sehir.Items.Add("Kocaeli");
            cb__uo_Sehir.Items.Add("İstanbul");
            Frm_Sozlesme frm_Sozlesme = new Frm_Sozlesme();
         
        }
        Uye SifresiniUnutan;
      
     
        private void lbl_Sozlesme_Click(object sender, EventArgs e)
        {
            Frm_Sozlesme frm_Sozlesme = new Frm_Sozlesme();
            frm_Sozlesme.Owner = this;
            frm_Sozlesme.ShowDialog();
        }

        private void btn_uyeol_Click_2(object sender, EventArgs e)
        {
            if (cb_sozlesme.Checked == false)
            {
                Uye uyeler = new Uye();
                uyeler.UyeKullaniciAdi = txt_KullaniciAdi.Text;
                uyeler.Sifre = txt_uo_sifre.Text;
                string resimPath = pb_UyeOl_ProfilFotosu.ImageLocation;
                if (resimPath == " ")
                {
                    if (cb_cinsiyet.SelectedItem.ToString() == "Man")
                        resimPath = @"C:\Users\203AKSAM_HUSEYİN\Desktop\aaa\Erkek.png";
                    else if (cb_cinsiyet.SelectedItem.ToString() == "Woman")
                        resimPath = @"C:\Users\203AKSAM_HUSEYİN\Desktop\aaa\Kadin.png";
                }
                uyeler.Resim = resimPath;
                uyeler.Isim = txt_uo_Isim.Text;
                uyeler.Soyisim = txt_uo_Soyisim.Text;
                uyeler.Sehir = cb__uo_Sehir.Text;
                uyeler.Cinsiyet = cb_cinsiyet.SelectedItem.ToString();
                uyeler.Telefon = int.Parse(txt_telefon.Text);
                uyeler.Mail = txt_mail.Text + cb_mail.SelectedItem.ToString();
                uyeler.GizliSoru = cb_G_SORU.SelectedItem.ToString();
                uyeler.Cevap = TXT_g_soru_cevap.Text;
                UyelerManager uyelerManager = new UyelerManager();
                uyelerManager.UyeEkle(uyeler);
                MessageBox.Show("Sohbetin Kanalına Hoş Geldiniz.Mail Adresinizden Aktivasyon İşleminin Ardından Giriş Yapabilirsiniz.");
           
                LOGİN_PAGE_CONTROLLER.Visible = false;
                pnl_Giris.Visible = true;
            }
            else
                lbl_UyeOlHata.Text = "Öncelikle Sözleşmeyi Onaylamalısınız.";
        }
        public int Kontrol()
        {
            return 1;
        }
        private void btn_login_Click_1(object sender, EventArgs e)
        {
           
            LOGİN_PAGE_CONTROLLER.Visible = false;
            pnl_Giris.Visible = true;
        }
        private void Btn_signup_Click_1(object sender, EventArgs e)
        {
            LOGİN_PAGE_CONTROLLER.SelectedTab = tp_UyeOL;
        }
        private void UYEol_Next1_Click(object sender, EventArgs e)
        {
            if (pb_UyeOl_ProfilFotosu.ImageLocation!=""&&txt_KullaniciAdi.Text != "" && txt_uo_sifre.Text != "" && cb_G_SORU.SelectedItem != null && TXT_g_soru_cevap.Text != "")
            {
                if (txt_uo_sifre.Text == txt_uo_sifreTekrar.Text)
                    tbc_Uyelik.SelectedTab = tp_iletisim;
                else
                    lbl_UyeOlHata1.Text = "Şifreler Eşleşmiyor.";
            }
            else
                lbl_UyeOlHata1.Text = "Alanların Dolu Olduğundan Emin Olun.";

        }
        private void UyeOl_Next2_Click(object sender, EventArgs e)
        {
            if (cb_cinsiyet.SelectedItem!=null && cb__uo_Sehir.SelectedItem != null && txt_uo_Isim.Text != "" && txt_uo_Soyisim.Text != "" && txt_telefon.Text != "" && txt_mail.Text != "" && cb_mail.SelectedItem != null)
                tbc_Uyelik.SelectedTab = tp_sozlesme;
            else
                lbl_UyeOlHata2.Text = "Alanların Dolu Olduğundan Emin Olun.";
        }

        private void Profil_fotosuSec_Click(object sender, EventArgs e)
        {
            OfD_ProfilResmi.ShowDialog();
            pb_UyeOl_ProfilFotosu.ImageLocation= OfD_ProfilResmi.FileName;

        }
        private void btn_su_sorgula_Click_2(object sender, EventArgs e)
        {
            UyelerManager uyelerManager = new UyelerManager();
            if (txt_su_kadi.Text == "")
                lbl_sifremiUnuttumHata.Text = "Lütfen Kullanıcı Adınızı Giriniz.";
            else
                SifresiniUnutan = uyelerManager.SifremiUnuttum(txt_su_kadi.Text);
            if (SifresiniUnutan != null)
            {
                cb_su_gizliSoru.Text = SifresiniUnutan.GizliSoru;
                btn_su_devamet.Enabled = true;
                txt_su_cevap.Enabled = true;
            }
            else
                lbl_sifremiUnuttumHata.Text = "Hatalı Kullanıcı Adı.";
        }
        private void btn_su_devamet_Click(object sender, EventArgs e)
        {
            if (txt_su_cevap.Text == SifresiniUnutan.Cevap)
            {
                MessageBox.Show("Şifreniz:" + SifresiniUnutan.Sifre);
                pnl_Giris.Visible = true;
                LOGİN_PAGE_CONTROLLER.Visible = false;
            }
            txt_Giris_Kadi.Text = SifresiniUnutan.UyeKullaniciAdi;
        }
    }
}
