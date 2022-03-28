using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesaj_ve_Paylasim_Uygulaması
{
    public partial class Frm_Sozlesme : Form
    {
        public Frm_Sozlesme()
        {
            InitializeComponent();
        }
        public bool onay { get; set; } = false;
        private void btn_onaylama_Click(object sender, EventArgs e)
        {
            (this.Owner as Frm_Giris).Onay = true;
           this.Close();
        }

        private void Frm_Sozlesme_Load(object sender, EventArgs e)
        {
           
           
        }
    }
}
