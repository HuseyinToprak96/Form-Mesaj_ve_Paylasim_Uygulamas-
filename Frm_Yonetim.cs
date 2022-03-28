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
    public partial class Frm_Yonetim : Form
    {
        public Frm_Yonetim()
        {
            InitializeComponent();
        }
        UyelerManager uyelerManager = new UyelerManager();
        PaylasimManager paylasimManager = new PaylasimManager();
        private void Frm_Yonetim_Load(object sender, EventArgs e)
        {
            DGW_uyeler.AllowUserToDeleteRows = false;
            DGW_Gonderiler.AllowUserToDeleteRows = false;
            lbl_siralama.Text = "A\n-\nZ";
            DGW_uyeler.DataSource = uyelerManager.UyeSorgula("select * from Uyeler");
            DGW_Gonderiler.DataSource = paylasimManager.Listele();
        }

        private void lbl_tumUyeler_Click(object sender, EventArgs e)
        {
            DGW_uyeler.DataSource = uyelerManager.UyeSorgula("select * from Uyeler");
        }

        private void lbl_Aktif_Click(object sender, EventArgs e)
        {
            DGW_uyeler.DataSource = uyelerManager.UyeSorgula("select * from Uyeler");
        }

        private void lbl_Pasif_Click(object sender, EventArgs e)
        {
           // DGW_uyeler.DataSource = uyelerManager.UyeSorgula("select * from Uyeler");
        }

        private void cb_sehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_sehirler.SelectedItem!=null) { 
           string sehir=cb_sehirler.SelectedItem.ToString();
            string sorgu = "select * from Uyeler";
           // DataTable dtt = new DataTable();
           System.Data.DataTable dt = uyelerManager.UyeSorgula(sorgu);
                dt.DefaultView.RowFilter = "SehirAdi='" + cb_sehirler.SelectedItem.ToString() + "'";
            DGW_uyeler.DataSource = dt;}
        }

        private void Cb_Cinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cb_Cinsiyet.SelectedItem != null)
            {
                string cinsiyet = Cb_Cinsiyet.SelectedItem.ToString();
                string sorgu = "select * from Uyeler";
                DataTable DT = uyelerManager.UyeSorgula(sorgu);
                DT.DefaultView.RowFilter = "Cinsiyet='" + Cb_Cinsiyet.SelectedItem.ToString() + "'";
                DGW_uyeler.DataSource = DT;
            }
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            
        }

        private void DGW_Gonderiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmResimOnaylama frmResimOnaylama = new FrmResimOnaylama();
            frmResimOnaylama.ShowDialog();
        }

        private void lbl_siralama_Click(object sender, EventArgs e)
        {
            if (lbl_siralama.Text == "A\n-\nZ")
                lbl_siralama.Text = "Z\n-\nA";
            else if (lbl_siralama.Text == "Z\n-\nA")
                lbl_siralama.Text = "A\n-\nZ";
        }

        private void DGW_uyeler_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
uyelerManager.AdminYap(int.Parse(DGW_uyeler.Rows[e.RowIndex].Cells[0].Value.ToString()),int.Parse(DGW_uyeler.Rows[e.RowIndex].Cells[1].Value.ToString()));
     
        }
    }
}
