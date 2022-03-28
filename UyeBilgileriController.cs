using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mesaj_ve_Paylasim_Uygulaması.DBMANAGER;
using Mesaj_ve_Paylasim_Uygulaması.MODEL;
namespace Mesaj_ve_Paylasim_Uygulaması
{
    public partial class UyeBilgileriController : UserControl
    {
        public UyeBilgileriController()
        {
            InitializeComponent();
        }
        public string KullaniciAdi { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string sehir { get; set; }
        public string cinsiyet { get; set; }
        public string Path { get; set; }
        public int puan { get; set; }
        public int ListelenenID { get; set; }
        public int BakanID { get; set; }
        private void UyeBilgileri_Load(object sender, EventArgs e)
        {
           // UyeBilgileriController uyeBilgileriController = new UyeBilgileriController();
           // uyeBilgileriController.Tag = UyeID;
            this.Tag = ListelenenID;
            groupBox1.Text = KullaniciAdi;
            label1.Text = ad;
            label2.Text = soyad;
            label3.Text = sehir;
            label4.Text = cinsiyet;
            pictureBox1.ImageLocation = Path;
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {Frm_GirisYapildi girisYapildi = new Frm_GirisYapildi();
                puan = int.Parse(comboBox1.SelectedItem.ToString());
               // MessageBox.Show((this.Tag).ToString());
               girisYapildi.PuanEkle(BakanID,ListelenenID,Convert.ToInt32(comboBox1.SelectedItem.ToString()));
                this.Enabled = false;
            }
            else
                MessageBox.Show("Lütfen Puan Seçiniz.");
            MessageBox.Show(this.Tag.ToString());
            
        }

       
    }
}
