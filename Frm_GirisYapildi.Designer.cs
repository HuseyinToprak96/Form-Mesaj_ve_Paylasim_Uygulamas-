
namespace Mesaj_ve_Paylasim_Uygulaması
{
    partial class Frm_GirisYapildi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GirisYapildi));
            this.Tmr_Top10 = new System.Windows.Forms.Timer(this.components);
            this.OFD_ResimSec = new System.Windows.Forms.OpenFileDialog();
            this.tp_GirisYapildi = new System.Windows.Forms.TabControl();
            this.tp_anasayfa = new System.Windows.Forms.TabPage();
            this.lbl_tiklanan = new System.Windows.Forms.Label();
            this.pnl_paylasimlar = new System.Windows.Forms.Panel();
            this.lbl_Söz = new System.Windows.Forms.Label();
            this.pb_geri = new System.Windows.Forms.PictureBox();
            this.PAYLASIMBASLIGI = new System.Windows.Forms.Label();
            this.pb_ileri = new System.Windows.Forms.PictureBox();
            this.pb_PaylasilmisResim = new System.Windows.Forms.PictureBox();
            this.lbl_paylasanKadi = new System.Windows.Forms.Label();
            this.GB_YeniResimEkle = new System.Windows.Forms.GroupBox();
            this.lbl_Tavsiye = new System.Windows.Forms.Label();
            this.txt_Soz = new System.Windows.Forms.TextBox();
            this.lbl_soz = new System.Windows.Forms.Label();
            this.lbl_paylasimHata = new System.Windows.Forms.Label();
            this.btn_ResimPaylas = new System.Windows.Forms.Button();
            this.btn_resimsec = new System.Windows.Forms.Button();
            this.Pb_PaylasilacakResim = new System.Windows.Forms.PictureBox();
            this.tp_Mesajlar = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_cevrimici = new System.Windows.Forms.ListBox();
            this.pnl_MesajGonderme = new System.Windows.Forms.Panel();
            this.Btn_mesajGonder = new System.Windows.Forms.Button();
            this.txt_Mesaj = new System.Windows.Forms.TextBox();
            this.pnl_UyeButonları = new System.Windows.Forms.Panel();
            this.tp_Uyeler = new System.Windows.Forms.TabPage();
            this.PB_Top10 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fLP_Uyeler = new System.Windows.Forms.FlowLayoutPanel();
            this.tp_İletisim = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Youtube = new System.Windows.Forms.Button();
            this.btn_Twitter = new System.Windows.Forms.Button();
            this.btn_Face = new System.Windows.Forms.Button();
            this.wB_SosyalMedya = new System.Windows.Forms.WebBrowser();
            this.btn_instagram = new System.Windows.Forms.Button();
            this.tp_Hakkimizda = new System.Windows.Forms.TabPage();
            this.TsMi_Anasayfa = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMi_Mesajlar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMi_Uyeler = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMi_Iletisim = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMi_Cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_GirisYapildi = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_mesajHatasi = new System.Windows.Forms.Label();
            this.tp_GirisYapildi.SuspendLayout();
            this.tp_anasayfa.SuspendLayout();
            this.pnl_paylasimlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_geri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PaylasilmisResim)).BeginInit();
            this.GB_YeniResimEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PaylasilacakResim)).BeginInit();
            this.tp_Mesajlar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnl_MesajGonderme.SuspendLayout();
            this.tp_Uyeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top10)).BeginInit();
            this.tp_İletisim.SuspendLayout();
            this.MS_GirisYapildi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tmr_Top10
            // 
            this.Tmr_Top10.Interval = 1000;
            this.Tmr_Top10.Tick += new System.EventHandler(this.Tmr_Top10_Tick);
            // 
            // OFD_ResimSec
            // 
            this.OFD_ResimSec.FileName = "openFileDialog1";
            // 
            // tp_GirisYapildi
            // 
            this.tp_GirisYapildi.Controls.Add(this.tp_anasayfa);
            this.tp_GirisYapildi.Controls.Add(this.tp_Mesajlar);
            this.tp_GirisYapildi.Controls.Add(this.tp_Uyeler);
            this.tp_GirisYapildi.Controls.Add(this.tp_İletisim);
            this.tp_GirisYapildi.Controls.Add(this.tp_Hakkimizda);
            this.tp_GirisYapildi.Location = new System.Drawing.Point(0, -20);
            this.tp_GirisYapildi.Name = "tp_GirisYapildi";
            this.tp_GirisYapildi.SelectedIndex = 0;
            this.tp_GirisYapildi.Size = new System.Drawing.Size(597, 443);
            this.tp_GirisYapildi.TabIndex = 7;
            this.tp_GirisYapildi.Tag = "";
            // 
            // tp_anasayfa
            // 
            this.tp_anasayfa.BackColor = System.Drawing.Color.Black;
            this.tp_anasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tp_anasayfa.BackgroundImage")));
            this.tp_anasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tp_anasayfa.Controls.Add(this.lbl_tiklanan);
            this.tp_anasayfa.Controls.Add(this.pnl_paylasimlar);
            this.tp_anasayfa.Controls.Add(this.GB_YeniResimEkle);
            this.tp_anasayfa.Location = new System.Drawing.Point(4, 22);
            this.tp_anasayfa.Name = "tp_anasayfa";
            this.tp_anasayfa.Padding = new System.Windows.Forms.Padding(3);
            this.tp_anasayfa.Size = new System.Drawing.Size(589, 417);
            this.tp_anasayfa.TabIndex = 0;
            // 
            // lbl_tiklanan
            // 
            this.lbl_tiklanan.AutoSize = true;
            this.lbl_tiklanan.BackColor = System.Drawing.Color.Maroon;
            this.lbl_tiklanan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_tiklanan.Location = new System.Drawing.Point(4, 7);
            this.lbl_tiklanan.Name = "lbl_tiklanan";
            this.lbl_tiklanan.Size = new System.Drawing.Size(13, 13);
            this.lbl_tiklanan.TabIndex = 8;
            this.lbl_tiklanan.Text = "0";
            this.lbl_tiklanan.Visible = false;
            // 
            // pnl_paylasimlar
            // 
            this.pnl_paylasimlar.BackColor = System.Drawing.Color.Wheat;
            this.pnl_paylasimlar.Controls.Add(this.lbl_Söz);
            this.pnl_paylasimlar.Controls.Add(this.pb_geri);
            this.pnl_paylasimlar.Controls.Add(this.PAYLASIMBASLIGI);
            this.pnl_paylasimlar.Controls.Add(this.pb_ileri);
            this.pnl_paylasimlar.Controls.Add(this.pb_PaylasilmisResim);
            this.pnl_paylasimlar.Controls.Add(this.lbl_paylasanKadi);
            this.pnl_paylasimlar.Location = new System.Drawing.Point(61, 151);
            this.pnl_paylasimlar.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_paylasimlar.Name = "pnl_paylasimlar";
            this.pnl_paylasimlar.Size = new System.Drawing.Size(361, 236);
            this.pnl_paylasimlar.TabIndex = 7;
            // 
            // lbl_Söz
            // 
            this.lbl_Söz.AutoSize = true;
            this.lbl_Söz.Location = new System.Drawing.Point(13, 215);
            this.lbl_Söz.Name = "lbl_Söz";
            this.lbl_Söz.Size = new System.Drawing.Size(25, 13);
            this.lbl_Söz.TabIndex = 4;
            this.lbl_Söz.Text = "Söz";
            this.lbl_Söz.Visible = false;
            // 
            // pb_geri
            // 
            this.pb_geri.Image = ((System.Drawing.Image)(resources.GetObject("pb_geri.Image")));
            this.pb_geri.Location = new System.Drawing.Point(16, 89);
            this.pb_geri.Margin = new System.Windows.Forms.Padding(2);
            this.pb_geri.Name = "pb_geri";
            this.pb_geri.Size = new System.Drawing.Size(38, 67);
            this.pb_geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_geri.TabIndex = 3;
            this.pb_geri.TabStop = false;
            // 
            // PAYLASIMBASLIGI
            // 
            this.PAYLASIMBASLIGI.AutoSize = true;
            this.PAYLASIMBASLIGI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.PAYLASIMBASLIGI.Location = new System.Drawing.Point(104, 1);
            this.PAYLASIMBASLIGI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PAYLASIMBASLIGI.Name = "PAYLASIMBASLIGI";
            this.PAYLASIMBASLIGI.Size = new System.Drawing.Size(167, 26);
            this.PAYLASIMBASLIGI.TabIndex = 2;
            this.PAYLASIMBASLIGI.Text = "PAYLAŞIMLAR";
            // 
            // pb_ileri
            // 
            this.pb_ileri.Image = ((System.Drawing.Image)(resources.GetObject("pb_ileri.Image")));
            this.pb_ileri.Location = new System.Drawing.Point(307, 89);
            this.pb_ileri.Margin = new System.Windows.Forms.Padding(2);
            this.pb_ileri.Name = "pb_ileri";
            this.pb_ileri.Size = new System.Drawing.Size(39, 67);
            this.pb_ileri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ileri.TabIndex = 2;
            this.pb_ileri.TabStop = false;
            // 
            // pb_PaylasilmisResim
            // 
            this.pb_PaylasilmisResim.Location = new System.Drawing.Point(58, 33);
            this.pb_PaylasilmisResim.Margin = new System.Windows.Forms.Padding(2);
            this.pb_PaylasilmisResim.Name = "pb_PaylasilmisResim";
            this.pb_PaylasilmisResim.Size = new System.Drawing.Size(244, 166);
            this.pb_PaylasilmisResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PaylasilmisResim.TabIndex = 1;
            this.pb_PaylasilmisResim.TabStop = false;
            // 
            // lbl_paylasanKadi
            // 
            this.lbl_paylasanKadi.AutoSize = true;
            this.lbl_paylasanKadi.Location = new System.Drawing.Point(13, 10);
            this.lbl_paylasanKadi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_paylasanKadi.Name = "lbl_paylasanKadi";
            this.lbl_paylasanKadi.Size = new System.Drawing.Size(64, 13);
            this.lbl_paylasanKadi.TabIndex = 0;
            this.lbl_paylasanKadi.Text = "Kullanıcı Adı";
            // 
            // GB_YeniResimEkle
            // 
            this.GB_YeniResimEkle.BackColor = System.Drawing.Color.MistyRose;
            this.GB_YeniResimEkle.Controls.Add(this.lbl_Tavsiye);
            this.GB_YeniResimEkle.Controls.Add(this.txt_Soz);
            this.GB_YeniResimEkle.Controls.Add(this.lbl_soz);
            this.GB_YeniResimEkle.Controls.Add(this.lbl_paylasimHata);
            this.GB_YeniResimEkle.Controls.Add(this.btn_ResimPaylas);
            this.GB_YeniResimEkle.Controls.Add(this.btn_resimsec);
            this.GB_YeniResimEkle.Controls.Add(this.Pb_PaylasilacakResim);
            this.GB_YeniResimEkle.Location = new System.Drawing.Point(61, 5);
            this.GB_YeniResimEkle.Margin = new System.Windows.Forms.Padding(2);
            this.GB_YeniResimEkle.Name = "GB_YeniResimEkle";
            this.GB_YeniResimEkle.Padding = new System.Windows.Forms.Padding(2);
            this.GB_YeniResimEkle.Size = new System.Drawing.Size(361, 146);
            this.GB_YeniResimEkle.TabIndex = 5;
            this.GB_YeniResimEkle.TabStop = false;
            this.GB_YeniResimEkle.Text = "Yeni Resim Ekle";
            // 
            // lbl_Tavsiye
            // 
            this.lbl_Tavsiye.AutoSize = true;
            this.lbl_Tavsiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Tavsiye.Location = new System.Drawing.Point(267, 56);
            this.lbl_Tavsiye.Name = "lbl_Tavsiye";
            this.lbl_Tavsiye.Size = new System.Drawing.Size(55, 13);
            this.lbl_Tavsiye.TabIndex = 6;
            this.lbl_Tavsiye.Text = "Tavsiyeler";
            this.lbl_Tavsiye.Click += new System.EventHandler(this.lbl_Tavsiye_Click);
            this.lbl_Tavsiye.MouseEnter += new System.EventHandler(this.lbl_Tavsiye_MouseEnter);
            this.lbl_Tavsiye.MouseHover += new System.EventHandler(this.lbl_Tavsiye_MouseHover);
            // 
            // txt_Soz
            // 
            this.txt_Soz.Location = new System.Drawing.Point(175, 18);
            this.txt_Soz.Multiline = true;
            this.txt_Soz.Name = "txt_Soz";
            this.txt_Soz.Size = new System.Drawing.Size(181, 35);
            this.txt_Soz.TabIndex = 5;
            // 
            // lbl_soz
            // 
            this.lbl_soz.AutoSize = true;
            this.lbl_soz.Location = new System.Drawing.Point(175, 2);
            this.lbl_soz.Name = "lbl_soz";
            this.lbl_soz.Size = new System.Drawing.Size(49, 13);
            this.lbl_soz.TabIndex = 4;
            this.lbl_soz.Text = "Söz Ekle";
            // 
            // lbl_paylasimHata
            // 
            this.lbl_paylasimHata.AutoSize = true;
            this.lbl_paylasimHata.Location = new System.Drawing.Point(172, 131);
            this.lbl_paylasimHata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_paylasimHata.Name = "lbl_paylasimHata";
            this.lbl_paylasimHata.Size = new System.Drawing.Size(45, 13);
            this.lbl_paylasimHata.TabIndex = 3;
            this.lbl_paylasimHata.Text = "Hata:00";
            // 
            // btn_ResimPaylas
            // 
            this.btn_ResimPaylas.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_ResimPaylas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ResimPaylas.Location = new System.Drawing.Point(175, 96);
            this.btn_ResimPaylas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ResimPaylas.Name = "btn_ResimPaylas";
            this.btn_ResimPaylas.Size = new System.Drawing.Size(69, 32);
            this.btn_ResimPaylas.TabIndex = 2;
            this.btn_ResimPaylas.Text = "Paylaş";
            this.btn_ResimPaylas.UseVisualStyleBackColor = false;
            this.btn_ResimPaylas.Click += new System.EventHandler(this.btn_ResimPaylas_Click);
            // 
            // btn_resimsec
            // 
            this.btn_resimsec.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_resimsec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_resimsec.Location = new System.Drawing.Point(175, 58);
            this.btn_resimsec.Margin = new System.Windows.Forms.Padding(2);
            this.btn_resimsec.Name = "btn_resimsec";
            this.btn_resimsec.Size = new System.Drawing.Size(69, 32);
            this.btn_resimsec.TabIndex = 1;
            this.btn_resimsec.Text = "Resim Seç";
            this.btn_resimsec.UseVisualStyleBackColor = false;
            this.btn_resimsec.Click += new System.EventHandler(this.btn_resimsec_Click);
            // 
            // Pb_PaylasilacakResim
            // 
            this.Pb_PaylasilacakResim.Location = new System.Drawing.Point(35, 17);
            this.Pb_PaylasilacakResim.Margin = new System.Windows.Forms.Padding(2);
            this.Pb_PaylasilacakResim.Name = "Pb_PaylasilacakResim";
            this.Pb_PaylasilacakResim.Size = new System.Drawing.Size(127, 111);
            this.Pb_PaylasilacakResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_PaylasilacakResim.TabIndex = 0;
            this.Pb_PaylasilacakResim.TabStop = false;
            // 
            // tp_Mesajlar
            // 
            this.tp_Mesajlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tp_Mesajlar.BackgroundImage")));
            this.tp_Mesajlar.Controls.Add(this.panel1);
            this.tp_Mesajlar.Controls.Add(this.groupBox1);
            this.tp_Mesajlar.Controls.Add(this.pnl_MesajGonderme);
            this.tp_Mesajlar.Controls.Add(this.pnl_UyeButonları);
            this.tp_Mesajlar.Location = new System.Drawing.Point(4, 22);
            this.tp_Mesajlar.Name = "tp_Mesajlar";
            this.tp_Mesajlar.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Mesajlar.Size = new System.Drawing.Size(589, 417);
            this.tp_Mesajlar.TabIndex = 1;
            this.tp_Mesajlar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(114, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 325);
            this.panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_cevrimici);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Location = new System.Drawing.Point(435, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 170);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çevrimİçi Kişiler";
            // 
            // lb_cevrimici
            // 
            this.lb_cevrimici.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cevrimici.FormattingEnabled = true;
            this.lb_cevrimici.ItemHeight = 14;
            this.lb_cevrimici.Items.AddRange(new object[] {
            "ÇEVRİM İÇİ KİŞİLER"});
            this.lb_cevrimici.Location = new System.Drawing.Point(6, 21);
            this.lb_cevrimici.Name = "lb_cevrimici";
            this.lb_cevrimici.Size = new System.Drawing.Size(136, 130);
            this.lb_cevrimici.TabIndex = 9;
            // 
            // pnl_MesajGonderme
            // 
            this.pnl_MesajGonderme.BackColor = System.Drawing.Color.Chocolate;
            this.pnl_MesajGonderme.Controls.Add(this.lbl_mesajHatasi);
            this.pnl_MesajGonderme.Controls.Add(this.Btn_mesajGonder);
            this.pnl_MesajGonderme.Controls.Add(this.txt_Mesaj);
            this.pnl_MesajGonderme.Location = new System.Drawing.Point(114, 327);
            this.pnl_MesajGonderme.Name = "pnl_MesajGonderme";
            this.pnl_MesajGonderme.Size = new System.Drawing.Size(483, 78);
            this.pnl_MesajGonderme.TabIndex = 8;
            // 
            // Btn_mesajGonder
            // 
            this.Btn_mesajGonder.BackColor = System.Drawing.Color.Goldenrod;
            this.Btn_mesajGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_mesajGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_mesajGonder.Location = new System.Drawing.Point(370, 14);
            this.Btn_mesajGonder.Name = "Btn_mesajGonder";
            this.Btn_mesajGonder.Size = new System.Drawing.Size(97, 39);
            this.Btn_mesajGonder.TabIndex = 1;
            this.Btn_mesajGonder.Text = "GÖNDER";
            this.Btn_mesajGonder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_mesajGonder.UseVisualStyleBackColor = false;
            this.Btn_mesajGonder.Click += new System.EventHandler(this.Btn_mesajGonder_Click);
            // 
            // txt_Mesaj
            // 
            this.txt_Mesaj.Location = new System.Drawing.Point(210, 15);
            this.txt_Mesaj.Multiline = true;
            this.txt_Mesaj.Name = "txt_Mesaj";
            this.txt_Mesaj.Size = new System.Drawing.Size(154, 37);
            this.txt_Mesaj.TabIndex = 0;
            // 
            // pnl_UyeButonları
            // 
            this.pnl_UyeButonları.Location = new System.Drawing.Point(-4, 0);
            this.pnl_UyeButonları.Name = "pnl_UyeButonları";
            this.pnl_UyeButonları.Size = new System.Drawing.Size(117, 382);
            this.pnl_UyeButonları.TabIndex = 7;
            // 
            // tp_Uyeler
            // 
            this.tp_Uyeler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tp_Uyeler.BackgroundImage")));
            this.tp_Uyeler.Controls.Add(this.PB_Top10);
            this.tp_Uyeler.Controls.Add(this.label5);
            this.tp_Uyeler.Controls.Add(this.fLP_Uyeler);
            this.tp_Uyeler.Location = new System.Drawing.Point(4, 22);
            this.tp_Uyeler.Name = "tp_Uyeler";
            this.tp_Uyeler.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Uyeler.Size = new System.Drawing.Size(589, 417);
            this.tp_Uyeler.TabIndex = 2;
            this.tp_Uyeler.UseVisualStyleBackColor = true;
            // 
            // PB_Top10
            // 
            this.PB_Top10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Top10.BackgroundImage")));
            this.PB_Top10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Top10.Location = new System.Drawing.Point(435, 197);
            this.PB_Top10.Name = "PB_Top10";
            this.PB_Top10.Size = new System.Drawing.Size(154, 121);
            this.PB_Top10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Top10.TabIndex = 2;
            this.PB_Top10.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(460, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "TOP 10";
            // 
            // fLP_Uyeler
            // 
            this.fLP_Uyeler.AutoScroll = true;
            this.fLP_Uyeler.BackColor = System.Drawing.Color.PeachPuff;
            this.fLP_Uyeler.Location = new System.Drawing.Point(41, 1);
            this.fLP_Uyeler.Name = "fLP_Uyeler";
            this.fLP_Uyeler.Size = new System.Drawing.Size(388, 410);
            this.fLP_Uyeler.TabIndex = 0;
            // 
            // tp_İletisim
            // 
            this.tp_İletisim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tp_İletisim.BackgroundImage")));
            this.tp_İletisim.Controls.Add(this.label4);
            this.tp_İletisim.Controls.Add(this.label3);
            this.tp_İletisim.Controls.Add(this.label2);
            this.tp_İletisim.Controls.Add(this.label1);
            this.tp_İletisim.Controls.Add(this.btn_Youtube);
            this.tp_İletisim.Controls.Add(this.btn_Twitter);
            this.tp_İletisim.Controls.Add(this.btn_Face);
            this.tp_İletisim.Controls.Add(this.wB_SosyalMedya);
            this.tp_İletisim.Controls.Add(this.btn_instagram);
            this.tp_İletisim.Location = new System.Drawing.Point(4, 22);
            this.tp_İletisim.Name = "tp_İletisim";
            this.tp_İletisim.Padding = new System.Windows.Forms.Padding(3);
            this.tp_İletisim.Size = new System.Drawing.Size(589, 417);
            this.tp_İletisim.TabIndex = 3;
            this.tp_İletisim.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hüseyin TOPRAK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Adres:Gebze";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mail:h@hotmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Telefon:05369404868";
            // 
            // btn_Youtube
            // 
            this.btn_Youtube.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Youtube.BackgroundImage")));
            this.btn_Youtube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Youtube.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Youtube.Location = new System.Drawing.Point(166, 6);
            this.btn_Youtube.Name = "btn_Youtube";
            this.btn_Youtube.Size = new System.Drawing.Size(55, 50);
            this.btn_Youtube.TabIndex = 13;
            this.btn_Youtube.UseVisualStyleBackColor = true;
            this.btn_Youtube.Click += new System.EventHandler(this.btn_Youtube_Click);
            // 
            // btn_Twitter
            // 
            this.btn_Twitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Twitter.BackgroundImage")));
            this.btn_Twitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Twitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Twitter.Location = new System.Drawing.Point(112, 6);
            this.btn_Twitter.Name = "btn_Twitter";
            this.btn_Twitter.Size = new System.Drawing.Size(55, 50);
            this.btn_Twitter.TabIndex = 12;
            this.btn_Twitter.UseVisualStyleBackColor = true;
            this.btn_Twitter.Click += new System.EventHandler(this.btn_Twitter_Click);
            // 
            // btn_Face
            // 
            this.btn_Face.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Face.BackgroundImage")));
            this.btn_Face.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Face.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Face.Location = new System.Drawing.Point(58, 6);
            this.btn_Face.Name = "btn_Face";
            this.btn_Face.Size = new System.Drawing.Size(55, 50);
            this.btn_Face.TabIndex = 11;
            this.btn_Face.UseVisualStyleBackColor = true;
            this.btn_Face.Click += new System.EventHandler(this.btn_Face_Click);
            // 
            // wB_SosyalMedya
            // 
            this.wB_SosyalMedya.Location = new System.Drawing.Point(221, 0);
            this.wB_SosyalMedya.MinimumSize = new System.Drawing.Size(20, 20);
            this.wB_SosyalMedya.Name = "wB_SosyalMedya";
            this.wB_SosyalMedya.Size = new System.Drawing.Size(374, 326);
            this.wB_SosyalMedya.TabIndex = 10;
            // 
            // btn_instagram
            // 
            this.btn_instagram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_instagram.BackgroundImage")));
            this.btn_instagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_instagram.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_instagram.Location = new System.Drawing.Point(5, 6);
            this.btn_instagram.Name = "btn_instagram";
            this.btn_instagram.Size = new System.Drawing.Size(55, 50);
            this.btn_instagram.TabIndex = 9;
            this.btn_instagram.UseVisualStyleBackColor = true;
            this.btn_instagram.Click += new System.EventHandler(this.btn_instagram_Click);
            // 
            // tp_Hakkimizda
            // 
            this.tp_Hakkimizda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tp_Hakkimizda.BackgroundImage")));
            this.tp_Hakkimizda.Location = new System.Drawing.Point(4, 22);
            this.tp_Hakkimizda.Name = "tp_Hakkimizda";
            this.tp_Hakkimizda.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Hakkimizda.Size = new System.Drawing.Size(589, 417);
            this.tp_Hakkimizda.TabIndex = 4;
            this.tp_Hakkimizda.UseVisualStyleBackColor = true;
            // 
            // TsMi_Anasayfa
            // 
            this.TsMi_Anasayfa.Name = "TsMi_Anasayfa";
            this.TsMi_Anasayfa.Size = new System.Drawing.Size(79, 20);
            this.TsMi_Anasayfa.Text = "&ANASAYFA";
            this.TsMi_Anasayfa.Click += new System.EventHandler(this.TsMi_Anasayfa_Click);
            // 
            // TsMi_Mesajlar
            // 
            this.TsMi_Mesajlar.Name = "TsMi_Mesajlar";
            this.TsMi_Mesajlar.Size = new System.Drawing.Size(75, 20);
            this.TsMi_Mesajlar.Text = "&MESAJLAR";
            this.TsMi_Mesajlar.Click += new System.EventHandler(this.TsMi_Mesajlar_Click);
            // 
            // TsMi_Uyeler
            // 
            this.TsMi_Uyeler.Name = "TsMi_Uyeler";
            this.TsMi_Uyeler.Size = new System.Drawing.Size(59, 20);
            this.TsMi_Uyeler.Text = "&UYELER";
            this.TsMi_Uyeler.Click += new System.EventHandler(this.TsMi_Uyeler_Click);
            // 
            // TsMi_Iletisim
            // 
            this.TsMi_Iletisim.Name = "TsMi_Iletisim";
            this.TsMi_Iletisim.Size = new System.Drawing.Size(64, 20);
            this.TsMi_Iletisim.Text = "&İLETİŞİM";
            this.TsMi_Iletisim.Click += new System.EventHandler(this.TsMi_Iletisim_Click);
            // 
            // TsMi_Cikis
            // 
            this.TsMi_Cikis.Name = "TsMi_Cikis";
            this.TsMi_Cikis.Size = new System.Drawing.Size(46, 20);
            this.TsMi_Cikis.Text = "ÇIKI&Ş";
            this.TsMi_Cikis.Click += new System.EventHandler(this.TsMi_Cikis_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.hakkımızdaToolStripMenuItem.Text = "HAKKIMIZDA";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // MS_GirisYapildi
            // 
            this.MS_GirisYapildi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_GirisYapildi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMi_Anasayfa,
            this.TsMi_Mesajlar,
            this.TsMi_Uyeler,
            this.TsMi_Iletisim,
            this.hakkımızdaToolStripMenuItem,
            this.TsMi_Cikis});
            this.MS_GirisYapildi.Location = new System.Drawing.Point(0, 0);
            this.MS_GirisYapildi.Name = "MS_GirisYapildi";
            this.MS_GirisYapildi.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MS_GirisYapildi.Size = new System.Drawing.Size(600, 24);
            this.MS_GirisYapildi.TabIndex = 0;
            this.MS_GirisYapildi.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tp_GirisYapildi);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 425);
            this.panel2.TabIndex = 9;
            // 
            // lbl_mesajHatasi
            // 
            this.lbl_mesajHatasi.AutoSize = true;
            this.lbl_mesajHatasi.Location = new System.Drawing.Point(5, 15);
            this.lbl_mesajHatasi.Name = "lbl_mesajHatasi";
            this.lbl_mesajHatasi.Size = new System.Drawing.Size(0, 13);
            this.lbl_mesajHatasi.TabIndex = 2;
            // 
            // Frm_GirisYapildi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MS_GirisYapildi);
            this.MainMenuStrip = this.MS_GirisYapildi;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_GirisYapildi";
            this.Text = "H";
            this.Load += new System.EventHandler(this.Frm_GirisYapildi_Load);
            this.tp_GirisYapildi.ResumeLayout(false);
            this.tp_anasayfa.ResumeLayout(false);
            this.tp_anasayfa.PerformLayout();
            this.pnl_paylasimlar.ResumeLayout(false);
            this.pnl_paylasimlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_geri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PaylasilmisResim)).EndInit();
            this.GB_YeniResimEkle.ResumeLayout(false);
            this.GB_YeniResimEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PaylasilacakResim)).EndInit();
            this.tp_Mesajlar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnl_MesajGonderme.ResumeLayout(false);
            this.pnl_MesajGonderme.PerformLayout();
            this.tp_Uyeler.ResumeLayout(false);
            this.tp_Uyeler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top10)).EndInit();
            this.tp_İletisim.ResumeLayout(false);
            this.tp_İletisim.PerformLayout();
            this.MS_GirisYapildi.ResumeLayout(false);
            this.MS_GirisYapildi.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Tmr_Top10;
        private System.Windows.Forms.OpenFileDialog OFD_ResimSec;
        private System.Windows.Forms.TabControl tp_GirisYapildi;
        private System.Windows.Forms.TabPage tp_anasayfa;
        private System.Windows.Forms.Panel pnl_paylasimlar;
        private System.Windows.Forms.PictureBox pb_geri;
        private System.Windows.Forms.Label PAYLASIMBASLIGI;
        private System.Windows.Forms.PictureBox pb_ileri;
        private System.Windows.Forms.PictureBox pb_PaylasilmisResim;
        private System.Windows.Forms.Label lbl_paylasanKadi;
        private System.Windows.Forms.GroupBox GB_YeniResimEkle;
        private System.Windows.Forms.Label lbl_paylasimHata;
        private System.Windows.Forms.Button btn_ResimPaylas;
        private System.Windows.Forms.Button btn_resimsec;
        private System.Windows.Forms.PictureBox Pb_PaylasilacakResim;
        private System.Windows.Forms.TabPage tp_Mesajlar;
        private System.Windows.Forms.TabPage tp_Uyeler;
        private System.Windows.Forms.TabPage tp_İletisim;
        private System.Windows.Forms.TabPage tp_Hakkimizda;
        private System.Windows.Forms.ToolStripMenuItem TsMi_Anasayfa;
        private System.Windows.Forms.ToolStripMenuItem TsMi_Mesajlar;
        private System.Windows.Forms.ToolStripMenuItem TsMi_Uyeler;
        private System.Windows.Forms.ToolStripMenuItem TsMi_Iletisim;
        private System.Windows.Forms.ToolStripMenuItem TsMi_Cikis;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MS_GirisYapildi;
        private System.Windows.Forms.Panel pnl_UyeButonları;
        private System.Windows.Forms.Label lbl_Söz;
        private System.Windows.Forms.Label lbl_Tavsiye;
        private System.Windows.Forms.Label lbl_soz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Youtube;
        private System.Windows.Forms.Button btn_Twitter;
        private System.Windows.Forms.Button btn_Face;
        private System.Windows.Forms.WebBrowser wB_SosyalMedya;
        private System.Windows.Forms.Button btn_instagram;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_MesajGonderme;
        private System.Windows.Forms.Button Btn_mesajGonder;
        private System.Windows.Forms.TextBox txt_Mesaj;
        private System.Windows.Forms.Label lbl_tiklanan;
        public System.Windows.Forms.TextBox txt_Soz;
        private System.Windows.Forms.FlowLayoutPanel fLP_Uyeler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_cevrimici;
        private System.Windows.Forms.PictureBox PB_Top10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_mesajHatasi;
    }
}