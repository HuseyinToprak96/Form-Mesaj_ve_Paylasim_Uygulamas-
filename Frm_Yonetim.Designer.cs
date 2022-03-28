
namespace Mesaj_ve_Paylasim_Uygulaması
{
    partial class Frm_Yonetim
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
            this.DGW_uyeler = new System.Windows.Forms.DataGridView();
            this.DGW_Gonderiler = new System.Windows.Forms.DataGridView();
            this.lbl_Uyeler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pasif = new System.Windows.Forms.Button();
            this.btn_aktif = new System.Windows.Forms.Button();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.lbl_tumUyeler = new System.Windows.Forms.Label();
            this.lbl_Aktif = new System.Windows.Forms.Label();
            this.lbl_Pasif = new System.Windows.Forms.Label();
            this.cb_sehirler = new System.Windows.Forms.ComboBox();
            this.Cb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.lbl_siralama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_uyeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Gonderiler)).BeginInit();
            this.SuspendLayout();
            // 
            // DGW_uyeler
            // 
            this.DGW_uyeler.BackgroundColor = System.Drawing.Color.Coral;
            this.DGW_uyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_uyeler.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DGW_uyeler.Location = new System.Drawing.Point(16, 89);
            this.DGW_uyeler.Margin = new System.Windows.Forms.Padding(4);
            this.DGW_uyeler.Name = "DGW_uyeler";
            this.DGW_uyeler.RowHeadersWidth = 51;
            this.DGW_uyeler.Size = new System.Drawing.Size(545, 333);
            this.DGW_uyeler.TabIndex = 0;
            this.DGW_uyeler.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_uyeler_CellEndEdit);
            // 
            // DGW_Gonderiler
            // 
            this.DGW_Gonderiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW_Gonderiler.Location = new System.Drawing.Point(559, 58);
            this.DGW_Gonderiler.Margin = new System.Windows.Forms.Padding(4);
            this.DGW_Gonderiler.Name = "DGW_Gonderiler";
            this.DGW_Gonderiler.RowHeadersWidth = 51;
            this.DGW_Gonderiler.Size = new System.Drawing.Size(505, 364);
            this.DGW_Gonderiler.TabIndex = 1;
            this.DGW_Gonderiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGW_Gonderiler_CellClick);
            // 
            // lbl_Uyeler
            // 
            this.lbl_Uyeler.AutoSize = true;
            this.lbl_Uyeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Uyeler.ForeColor = System.Drawing.Color.Azure;
            this.lbl_Uyeler.Location = new System.Drawing.Point(163, 18);
            this.lbl_Uyeler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Uyeler.Name = "lbl_Uyeler";
            this.lbl_Uyeler.Size = new System.Drawing.Size(142, 36);
            this.lbl_Uyeler.TabIndex = 2;
            this.lbl_Uyeler.Text = "UYELER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(703, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "GÖNDERİLER";
            // 
            // btn_pasif
            // 
            this.btn_pasif.BackColor = System.Drawing.Color.Red;
            this.btn_pasif.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pasif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_pasif.Location = new System.Drawing.Point(244, 430);
            this.btn_pasif.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pasif.Name = "btn_pasif";
            this.btn_pasif.Size = new System.Drawing.Size(100, 28);
            this.btn_pasif.TabIndex = 4;
            this.btn_pasif.Text = "PASİF YAP";
            this.btn_pasif.UseVisualStyleBackColor = false;
            // 
            // btn_aktif
            // 
            this.btn_aktif.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_aktif.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_aktif.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aktif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_aktif.Location = new System.Drawing.Point(136, 430);
            this.btn_aktif.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aktif.Name = "btn_aktif";
            this.btn_aktif.Size = new System.Drawing.Size(100, 28);
            this.btn_aktif.TabIndex = 5;
            this.btn_aktif.Text = "AKTİF YAP";
            this.btn_aktif.UseVisualStyleBackColor = false;
            // 
            // btn_onayla
            // 
            this.btn_onayla.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_onayla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_onayla.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btn_onayla.Location = new System.Drawing.Point(709, 430);
            this.btn_onayla.Margin = new System.Windows.Forms.Padding(4);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(100, 28);
            this.btn_onayla.TabIndex = 6;
            this.btn_onayla.Text = "ONAYLA";
            this.btn_onayla.UseVisualStyleBackColor = false;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_sil.Location = new System.Drawing.Point(817, 430);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 28);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            // 
            // lbl_tumUyeler
            // 
            this.lbl_tumUyeler.AutoSize = true;
            this.lbl_tumUyeler.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tumUyeler.Location = new System.Drawing.Point(16, 65);
            this.lbl_tumUyeler.Name = "lbl_tumUyeler";
            this.lbl_tumUyeler.Size = new System.Drawing.Size(81, 17);
            this.lbl_tumUyeler.TabIndex = 8;
            this.lbl_tumUyeler.Text = "Tüm Üyeler";
            this.lbl_tumUyeler.Click += new System.EventHandler(this.lbl_tumUyeler_Click);
            // 
            // lbl_Aktif
            // 
            this.lbl_Aktif.AutoSize = true;
            this.lbl_Aktif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Aktif.Location = new System.Drawing.Point(120, 65);
            this.lbl_Aktif.Name = "lbl_Aktif";
            this.lbl_Aktif.Size = new System.Drawing.Size(80, 17);
            this.lbl_Aktif.TabIndex = 9;
            this.lbl_Aktif.Text = "Aktif Üyeler";
            this.lbl_Aktif.Click += new System.EventHandler(this.lbl_Aktif_Click);
            // 
            // lbl_Pasif
            // 
            this.lbl_Pasif.AutoSize = true;
            this.lbl_Pasif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Pasif.Location = new System.Drawing.Point(231, 65);
            this.lbl_Pasif.Name = "lbl_Pasif";
            this.lbl_Pasif.Size = new System.Drawing.Size(84, 17);
            this.lbl_Pasif.TabIndex = 10;
            this.lbl_Pasif.Text = "Pasif Üyeler";
            this.lbl_Pasif.Click += new System.EventHandler(this.lbl_Pasif_Click);
            // 
            // cb_sehirler
            // 
            this.cb_sehirler.FormattingEnabled = true;
            this.cb_sehirler.Items.AddRange(new object[] {
            "Kocaeli",
            "İstanbul"});
            this.cb_sehirler.Location = new System.Drawing.Point(341, 62);
            this.cb_sehirler.Name = "cb_sehirler";
            this.cb_sehirler.Size = new System.Drawing.Size(86, 24);
            this.cb_sehirler.TabIndex = 11;
            this.cb_sehirler.Text = "    Şehirler";
            this.cb_sehirler.SelectedIndexChanged += new System.EventHandler(this.cb_sehirler_SelectedIndexChanged);
            // 
            // Cb_Cinsiyet
            // 
            this.Cb_Cinsiyet.FormattingEnabled = true;
            this.Cb_Cinsiyet.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.Cb_Cinsiyet.Location = new System.Drawing.Point(444, 62);
            this.Cb_Cinsiyet.Name = "Cb_Cinsiyet";
            this.Cb_Cinsiyet.Size = new System.Drawing.Size(81, 24);
            this.Cb_Cinsiyet.TabIndex = 12;
            this.Cb_Cinsiyet.Text = "  Cinsiyet";
            this.Cb_Cinsiyet.SelectedIndexChanged += new System.EventHandler(this.Cb_Cinsiyet_SelectedIndexChanged);
            // 
            // lbl_siralama
            // 
            this.lbl_siralama.AutoSize = true;
            this.lbl_siralama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_siralama.Location = new System.Drawing.Point(531, 44);
            this.lbl_siralama.Name = "lbl_siralama";
            this.lbl_siralama.Size = new System.Drawing.Size(17, 17);
            this.lbl_siralama.TabIndex = 13;
            this.lbl_siralama.Text = "A";
            this.lbl_siralama.Click += new System.EventHandler(this.lbl_siralama_Click);
            // 
            // Frm_Yonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbl_siralama);
            this.Controls.Add(this.Cb_Cinsiyet);
            this.Controls.Add(this.cb_sehirler);
            this.Controls.Add(this.lbl_Pasif);
            this.Controls.Add(this.lbl_Aktif);
            this.Controls.Add(this.lbl_tumUyeler);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_onayla);
            this.Controls.Add(this.btn_aktif);
            this.Controls.Add(this.btn_pasif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Uyeler);
            this.Controls.Add(this.DGW_Gonderiler);
            this.Controls.Add(this.DGW_uyeler);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Yonetim";
            this.Text = "Frm_Yonetim";
            this.Load += new System.EventHandler(this.Frm_Yonetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGW_uyeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW_Gonderiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGW_uyeler;
        private System.Windows.Forms.DataGridView DGW_Gonderiler;
        private System.Windows.Forms.Label lbl_Uyeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pasif;
        private System.Windows.Forms.Button btn_aktif;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label lbl_tumUyeler;
        private System.Windows.Forms.Label lbl_Aktif;
        private System.Windows.Forms.Label lbl_Pasif;
        private System.Windows.Forms.ComboBox cb_sehirler;
        private System.Windows.Forms.ComboBox Cb_Cinsiyet;
        private System.Windows.Forms.Label lbl_siralama;
    }
}