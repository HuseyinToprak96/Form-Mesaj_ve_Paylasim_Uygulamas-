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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btn_UyeOlPaneliAC_Click(object sender, EventArgs e)
        {
            pnl_UyeOl.Visible = true;
            pnl_AcilisEkrani.Visible = false;
        }

        private void btn_GirisPaneliAc_Click(object sender, EventArgs e)
        {
            pnl_AcilisEkrani.Visible = false;
            pnl_Giris.Visible = true;
        }

        private void btn_uyeol_Click(object sender, EventArgs e)
        {
            pnl_UyeOl.Visible = false;
            pnl_Giris.Visible = true;
        }

        private void Btn_giris_Click(object sender, EventArgs e)
        {

        }

        private void btn_su_devamet_Click(object sender, EventArgs e)
        {
            pnl_sifremiUnuttum.Visible = false;
            pnl_Giris.Visible = true;
        }

        private void lbl_uyeoll_Click(object sender, EventArgs e)
        {
            pnl_UyeOl.Visible = true;
            pnl_Giris.Visible = false;
          
            
        }

        private void lbl_sifremiUnuttum_Click(object sender, EventArgs e)
        {
            pnl_Giris.Visible = false;
            pnl_sifremiUnuttum.Visible = true;
        }

        private void btn_uyeol_geri_Click(object sender, EventArgs e)
        {
            pnl_UyeOl.Visible = true;
            pnl_UyeOl2.Visible = false;
        }

        private void btn_uyeol_ileri_Click(object sender, EventArgs e)
        {
            pnl_UyeOl.Visible = false;
            pnl_AcilisEkrani.Visible = false;
            pnl_UyeOl2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl_Giris.Visible = false;
            pnl_UyeOl.Visible = false;
            pnl_UyeOl2.Visible = false;
            pnl_sifremiUnuttum.Visible = false;
            pnl_AcilisEkrani.Visible = true;
            cb__uo_Sehir.Items.Add("Kocaeli");
            cb__uo_Sehir.Items.Add("İstanbul");
            cb_uo_gizlisoru.Items.Add("En Sevdiği Hayvan?");
        }

        private void btn_uyeol_Click_1(object sender, EventArgs e)
        {
            if (txt_uo_sifre.Text == txt_uo_sifreTekrar.Text)
            {
                Uyeler uyeler = new Uyeler();
                uyeler.UyeKullaniciAdi = txt_KullaniciAdi.Text;
                uyeler.Sifre = txt_uo_sifre.Text;
                uyeler.Isim = txt_uo_Isim.Text;
                uyeler.Soyisim = txt_uo_Soyisim.Text;
                uyeler.Sehir = cb__uo_Sehir.Text;
                uyeler.Telefon = Convert.ToInt32(txt_telefon.Text);
                uyeler.Mail = txt_mail.Text;
                uyeler.GizliSoru = cb_uo_gizlisoru.Text;
                uyeler.Cevap = txt_uo_cevap.Text;
                UyelerManager uyelerManager = new UyelerManager();
                uyelerManager.UyeEkle(uyeler);
                pnl_Giris.Visible = true;
                pnl_UyeOl2.Visible = false;
            }
            else
                lbl_uo_sifreHatasi.Text = "Şifreler Eşleşmiyor.";
        }
    }
}
