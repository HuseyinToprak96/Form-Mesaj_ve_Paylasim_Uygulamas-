
namespace Mesaj_ve_Paylasim_Uygulaması
{
    partial class FrmTavsiyeSozler
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_SozSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Kimse geçmişini satın alabilecek kadar zengin değildir. Oscar Wilde ",
            "Peşinden gidecek cesaretin varsa, bütün rüyalar gerçek olabilir. Walt Disney ",
            "Mutluluk bir ömür değil anlıktır, çok uzak değil aslında iki adımlıktır. ",
            "Yaşadığın yeri cennet yapamıyorsan, gittiğin her yer sana cehennemdir. ",
            "Bir kalbi kaybetme ile kazanmanın arasında ince bir çizgi var, adı üslup. ",
            "Dilek tuttuğun yıldızlar bile senin olsun sevgili, sen bana sevmeyi öğrettin. ",
            "Bir sürgünüm ben bu dünyada. Bir sürgünüm ve kimse anlamıyor ruhumun dilinden. ",
            "İnsan iyiliği kadar taşlanır, merhameti kadar dışlanır, kulluğu kadar da sınanır." +
                " ",
            "Üzülme Senin için yazılmış olan kader Yazarların En Mükemmeli tarafından yazılmış" +
                "tır. ",
            "Dünya çok acı çekiyor, kötü insanların şiddetinden değil, iyi insanların sessizli" +
                "ğinden. ",
            "Yarin hatırası aşkın bir damlasından daha güzeldir. ",
            "Aşkın ateşi yaşamaktan daha güzeldir. Ben duanın kabul edilmemesi kaygısı taşımam" +
                ". ",
            "İçimde dua etme isteğinin olmaması kaygısı taşırım. ",
            "Hayatımıza giren herkes değerlidir ama herkes özel değildir. ",
            "Saygı hepsine, sevgi layık olana verilir. Şimdi, diyorum. Şimdi.",
            "Bir deniz, denizde vapur gökyüzünde martı semaverde çay olmalı, bir de çaya yaren" +
                ". ",
            "Olduğum şeyle olmadığım şey arasında, hayal ettiğim şeyle hayatın beni yaptığı şe" +
                "y arasında bir boşluğum. ",
            "Şarkı söylemek istersen yüksek sesle şarkını söyle. ",
            "Elbet dünyanın bir yerinde sana eşlik eden biri olur. ",
            "ALLAH’ım bize “inşALLAH olur” diye, dua edip hayalini kurduğumuz her şeyin “Çok ş" +
                "ükür oldu” sevincini yaşat 💖 Âmin. ",
            "Beni anlamalısın, çünkü ben kitap değilim, çünkü ben öldükten sonra kimse beni ok" +
                "uyamaz, yaşarken anlaşılmaya mecburum. ",
            "Dünyanın gösterişli halleri, yapmacık çıkarcı insanları çekmiyor dikkatimi. ",
            "Bana bir parça, yüreği güzel, samimi insan lazım. ",
            "İyi bir insan mıyım bilmiyorum ama kötü biri olmadığıma eminim. ",
            "O yüzden ben belki kazanamam ama siz mutlaka kaybedeceksiniz. ",
            "Olumlu düşün, iyilik yap, işini en iyi yap, önce kendini düzelt ve geliştir, kıym" +
                "et bil, şükret, spor yap, sürpriz yap, kötüye mesafeli ol!"});
            this.listBox1.Location = new System.Drawing.Point(-1, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(596, 277);
            this.listBox1.TabIndex = 0;
            // 
            // btn_SozSec
            // 
            this.btn_SozSec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SozSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SozSec.Location = new System.Drawing.Point(233, 309);
            this.btn_SozSec.Name = "btn_SozSec";
            this.btn_SozSec.Size = new System.Drawing.Size(75, 23);
            this.btn_SozSec.TabIndex = 1;
            this.btn_SozSec.Text = "Onayla";
            this.btn_SozSec.UseVisualStyleBackColor = false;
            this.btn_SozSec.Click += new System.EventHandler(this.btn_SozSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listeden Bir Söz Seçerek Onayla Butonuna Tıklayınız.";
            // 
            // FrmTavsiyeSozler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(595, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SozSec);
            this.Controls.Add(this.listBox1);
            this.Name = "FrmTavsiyeSozler";
            this.Text = "FrmTavsiyeSozler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_SozSec;
        private System.Windows.Forms.Label label1;
    }
}