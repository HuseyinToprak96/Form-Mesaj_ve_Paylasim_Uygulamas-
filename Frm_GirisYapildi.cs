using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Frm_GirisYapildi : Form
    {
        public Frm_GirisYapildi()
        {
            InitializeComponent();
        }
        public int UyeID { get; set; }
        public string Kadi { get; set; }
        public string Sifre { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string Sehir { get; set; }
        public string GizliSoru { get; set; }
        public string G_Cevap { get; set; }
        public int Telefon { get; set; }
        public string Mail { get; set; }
        int tiklanan;
        Uye uye = new Uye();
        PaylasimManager PaylasimManager = new PaylasimManager();
        UyelerManager uyelerManager = new UyelerManager();
        UyeBilgileriController uyeBilgileriControl = new UyeBilgileriController();
        List<PaylasimGosterici> Resimler;
        //Giriş ekranı ve form load olduğunda olacak işlemler line37- arası
        private void Frm_GirisYapildi_Load(object sender, EventArgs e)
        {
            lb_cevrimici.Items.Add(Kadi);
            ResimGösterici(ResimId);
            UyeleriEklet();
            ToolStripMenuItem NewMenu = new ToolStripMenuItem();
            List<Kadi> M = new List<Kadi>();
            M = mesajlarManager.MesajAtanlar(UyeID);
            for (int i = 0; i < M.Count; i++)
            {
                NewMenu = new ToolStripMenuItem();
                NewMenu.Text = M[i].K_adi + "    " + M[i].Adet;
                NewMenu.Tag = M[i].M_A_ID;
                NewMenu.BackColor = Color.Transparent;
                NewMenu.Height = 15;
                TsMi_Mesajlar.DropDownItems.Add(NewMenu);
                TsMi_Mesajlar.DropDownItemClicked += TsMi_Mesajlar_DropDownItemClicked;
            }
            EskiMesajlar();
        }
        public void ResimGösterici(int rsID)
        {
            Resimler = PaylasimManager.Paylasimlar();

            if (rsID < 0)
                rsID = Resimler.Count - 1;
            else if (rsID < Resimler.Count)
            {
                pb_PaylasilmisResim.ImageLocation = PaylasimManager.Paylasimlar()[rsID].ToString();
                lbl_paylasanKadi.Text = Resimler[rsID].P_Kadi;
                lbl_Söz.Text = Resimler[rsID].P_Soz.ToString();
            }
            else
                ResimId = 0;
        } MesajlarManager mesajlarManager = new MesajlarManager();
       
        public void EskiMesajlar()
        {
            ToolStripSeparator toolStripSeparator = new ToolStripSeparator();
            TsMi_Mesajlar.DropDownItems.Add(toolStripSeparator);
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = "Eski Mesajlar İçin Tıkla...";
            item.Click += İtem_Click;
            TsMi_Mesajlar.DropDownItems.Add(item);
        }
        private void İtem_Click(object sender, EventArgs e)
        {
            pnl_MesajGonderme.Enabled = false;
            tp_GirisYapildi.SelectedTab = tp_Mesajlar;
            UyeButonuEkleme();
        }
        public void UyeButonuEkleme()
        {
            List<UyeLİSTE> Uyeler = uyelerManager.Listele(UyeID);
            int top = 0;
            Button button = new Button();
            for (int i = 0; i < Uyeler.Count; i++)
            {
                button = new Button();
                button.Height = 30;
                button.Width = pnl_UyeButonları.Width;
                button.Top = pnl_UyeButonları.Top + top;
                button.BackColor = Color.BurlyWood;
                button.FlatStyle = FlatStyle.Popup;
                button.Text = Uyeler[i].Kadi.ToString();
                button.Tag = Uyeler[i].UyeID;
                button.MouseClick += Button_MouseClick;
                pnl_UyeButonları.Controls.Add(button);
                top += 30;
            }
        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Controls.Clear();
            tiklanan = Convert.ToInt32(((Button)sender).Tag);
            panel1.Visible = true;
            pnl_MesajGonderme.Enabled = true;
            MesajListele(tiklanan);
        }

        private void TsMi_Mesajlar_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            panel1.Controls.Clear();
            tp_GirisYapildi.SelectedTab = tp_Mesajlar;
            x = Convert.ToInt32(e.ClickedItem.Tag);
            tiklanan = Convert.ToInt32(e.ClickedItem.Tag);
            GorulduYap(tiklanan);
            UyeButonuEkleme();
            MesajListele(tiklanan);
            TsMi_Mesajlar.DropDownItems.Remove(e.ClickedItem);
        }
        public void GorulduYap(int x)
        {
            mesajlarManager.GorulduYapma(x, UyeID);
        }
        int sayac=0;
        int sonkonum;
        public void MesajListele(int tiklanan)
        {
                Label label = new Label();
                List<mesajj> mesaj = mesajlarManager.b_mesajlar(UyeID, tiklanan);
                for (int i = 0; i < mesaj.Count; i++)
                {
                    label = new Label();
                    label.Text = mesaj[i].Mesaj;
                    label.Font = new Font("Arial", 12);
                    if (mesaj[i].Gonderen == Kadi)
                    {
                        label.Left = 175;
                        label.BackColor = Color.White;
                        label.Top = 20 + sayac * 20;
                        sayac++;
                    }
                    else
                    {
                        label.Left = 75;
                        label.BackColor = Color.LightGoldenrodYellow;
                        label.Top = 20 + sayac * 20;
                        sonkonum = label.Top;
                        sayac++;
                    }

                    panel1.Controls.Add(label);
                    tp_Mesajlar.Controls.Add(panel1);
                }
                panel1.AutoScrollPosition = new Point(0, panel1.VerticalScroll.Maximum);
    
        } 
        private void TsMi_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Giris frm_Giris = new Frm_Giris();
            frm_Giris.Visible = true;
        }

        private void TsMi_Anasayfa_Click(object sender, EventArgs e)
        {
            tp_GirisYapildi.SelectedTab = tp_anasayfa;
        }
        string Path;
        int ResimId=0;
        private void pb_geri_Click(object sender, EventArgs e)
        {
            ResimId--;
            ResimGösterici(ResimId);
        }

        private void pb_ileri_Click(object sender, EventArgs e)
        {
            ResimId++;
            ResimGösterici(ResimId);
        }
        PuanVermeManager puanVerme = new PuanVermeManager();
        public void PuanEkle(int id,int alanID,int puan)
        {
            puanVerme.PuanVerme(id,alanID,puan);

        }
        public void UyeleriEklet()
        {
            fLP_Uyeler.Controls.Clear();
            int top = 0;
            List<UyeLİSTE> uyeLİSTE = new List<UyeLİSTE>();
            List < int> Verilenler= new List<int>();
            Verilenler = puanVerme.PuanVerilenler(UyeID);
            uyeLİSTE = uyelerManager.Listele(UyeID); 
            for (int i = 0; i < uyeLİSTE.Count; i++)
            {  uyeBilgileriControl = new UyeBilgileriController();
                if (Verilenler.Contains(uyeLİSTE[i].UyeID))
                 uyeBilgileriControl.Enabled = false;
              else
                uyeBilgileriControl.Enabled = true;
                uyeBilgileriControl.KullaniciAdi = uyeLİSTE[i].Kadi;
                uyeBilgileriControl.ad = uyeLİSTE[i].Isim;
                uyeBilgileriControl.soyad = uyeLİSTE[i].SoyIsim;
                uyeBilgileriControl.sehir = uyeLİSTE[i].Sehir;
                uyeBilgileriControl.Path = uyeLİSTE[i].Resim;
                uyeBilgileriControl.cinsiyet = uyeLİSTE[i].Cinsiyet;
                uyeBilgileriControl.ListelenenID = uyeLİSTE[i].UyeID;
                uyeBilgileriControl.BakanID=UyeID;
                uyeBilgileriControl.Top += top;
                top += 200;
                if (!fLP_Uyeler.Controls.Contains(uyeBilgileriControl))
                fLP_Uyeler.Controls.Add(uyeBilgileriControl);
            }
        }
        int kontrol = 0;
        private void TsMi_Uyeler_Click(object sender, EventArgs e)
        {
            tp_GirisYapildi.SelectedTab = tp_Uyeler;
            if (kontrol == 0) {
           fLP_Uyeler.Controls.Clear();
            Top10Listesi(Siralama);
            tp_Uyeler.Controls.Add(fLP_Uyeler);
           
            UyeleriEklet();
                kontrol++;
            }
        }
        PuanVermeManager puan = new PuanVermeManager();
        public void Top10Listesi(int Siralama)
        {
         List<TOP10> tOPs= puan.Top10();
          if (tOPs!=null) { 

           PB_Top10.ImageLocation = tOPs[Siralama].Resim;
              Tmr_Top10.Enabled = true;
           }
        }
        int Siralama=0;
        private void TsMi_Hakkimizda_Click(object sender, EventArgs e)
        {
            tp_GirisYapildi.SelectedTab = tp_Hakkimizda;
        }

        private void TsMi_Iletisim_Click(object sender, EventArgs e)
        {
            tp_GirisYapildi.SelectedTab = tp_İletisim;

        }

        private void TsMi_Mesajlar_Click(object sender, EventArgs e)
        {
        
        }
        private void txt_Mesaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mesaj.GonderenID = UyeID;
                mesaj.AliciID = x;
                mesaj.mesaj = txt_Mesaj.Text;
                mesaj.GorulduMu = false;
                mesajlarManager.YeniMesajGonder(mesaj);
                txt_Mesaj.Text = "";
            }
        }
        public int mESAJaTİLAN(int gonderilen) 
        {
            return gonderilen;
        }
        int x;
        Mesaj mesaj = new Mesaj();
       

        private void tp_anasayfa_Click(object sender, EventArgs e)
        {

        }
        private void lbl_Tavsiye_MouseEnter(object sender, EventArgs e)
        {
            lbl_Tavsiye.Font = new Font("Arial", 10);
        }

        private void lbl_Tavsiye_MouseHover(object sender, EventArgs e)
        {
            lbl_Tavsiye.Font = new Font("Microsoft Sans Serif", 8);
        }

        private void lbl_Tavsiye_Click(object sender, EventArgs e)
        {
            FrmTavsiyeSozler frmTavsiyeSozler = new FrmTavsiyeSozler();
            frmTavsiyeSozler.Owner=this;
            frmTavsiyeSozler.ShowDialog();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tp_GirisYapildi.SelectedTab = tp_Hakkimizda;
        }
      

        private void btn_Youtube_Click(object sender, EventArgs e)
        {
            wB_SosyalMedya.Navigate("https://www.youtube.com/channel/UCV0wadB76HlyRLOCXAn-Mbw");
        }

        private void btn_Twitter_Click(object sender, EventArgs e)
        {
            wB_SosyalMedya.Navigate("https://twitter.com");
        }

        private void btn_Face_Click(object sender, EventArgs e)
        {
            wB_SosyalMedya.Navigate("https://www.facebook.com");
        }

        private void btn_instagram_Click(object sender, EventArgs e)
        {
         wB_SosyalMedya.Navigate("https://www.instagram.com/yazilim_ogrenelim/");
        }

        private void btn_ResimPaylas_Click(object sender, EventArgs e)
        {
            if (Pb_PaylasilacakResim.ImageLocation != null) { 
            Paylasim paylasim = new Paylasim();
            paylasim.PaylasanID = UyeID;
            paylasim.ResimPATH = Path;
            paylasim.Soz = txt_Soz.Text;
            paylasim.PaylasimZamani = DateTime.Now;
            PaylasimManager paylasimManager = new PaylasimManager();
            string DURUM = paylasimManager.PaylasimEkle(paylasim);
            MessageBox.Show(DURUM.ToString());}
        }

        private void btn_resimsec_Click(object sender, EventArgs e)
        {
            OFD_ResimSec.ShowDialog();
            Path = OFD_ResimSec.FileName;
            Pb_PaylasilacakResim.ImageLocation = OFD_ResimSec.FileName;
        }

        private void Btn_mesajGonder_Click(object sender, EventArgs e)
        {
            if (txt_Mesaj.Text != "" && txt_Mesaj.Text.Length < 11)
            {
                mesaj.GonderenID = UyeID;
                mesaj.AliciID = tiklanan;
                mesaj.mesaj = txt_Mesaj.Text;
                mesaj.GorulduMu = false;
                mesajlarManager.YeniMesajGonder(mesaj);
                Label label = new Label();
                label.Text = txt_Mesaj.Text;
                label.Font = new Font("Arial", 12);
                label.Left = 175;
                label.BackColor = Color.White;
                if (sonkonum != 0)
                    label.Top = sonkonum - 135;
                else
                {
                    label.Top = panel1.Top + 20;
                    sonkonum += 20;
                }
                panel1.Controls.Add(label);
                panel1.AutoScrollPosition = new Point(0, panel1.VerticalScroll.Maximum);
                txt_Mesaj.Text = "";
            }
            else lbl_mesajHatasi.Text = "1-10 karakterlik kısa mesajlar yazınız."+Environment.NewLine+"Anlayışınız için Teşekkür ederiz.";
        }
      
       

        private void Tmr_Top10_Tick(object sender, EventArgs e)
        {
            Siralama++;
            if (Siralama >= puan.Top10().Count)
            Siralama = 0;
            Top10Listesi(Siralama);
        }
    }
}
