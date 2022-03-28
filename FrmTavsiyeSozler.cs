using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesaj_ve_Paylasim_Uygulaması
{
    public partial class FrmTavsiyeSozler : Form
    {
        public FrmTavsiyeSozler()
        {
            InitializeComponent();
        }

        private void btn_SozSec_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                (this.Owner as Frm_GirisYapildi).txt_Soz.Text = listBox1.SelectedItem.ToString();
                this.Close();
            }
        }
    }
}
