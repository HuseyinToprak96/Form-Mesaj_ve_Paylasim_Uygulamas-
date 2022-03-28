
namespace Mesaj_ve_Paylasim_Uygulaması
{
    partial class Frm_Sozlesme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sozlesme));
            this.rtb_sozlesme = new System.Windows.Forms.RichTextBox();
            this.btn_onaylama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_sozlesme
            // 
            this.rtb_sozlesme.Location = new System.Drawing.Point(39, 12);
            this.rtb_sozlesme.Name = "rtb_sozlesme";
            this.rtb_sozlesme.Size = new System.Drawing.Size(491, 270);
            this.rtb_sozlesme.TabIndex = 0;
            this.rtb_sozlesme.Text = resources.GetString("rtb_sozlesme.Text");
            // 
            // btn_onaylama
            // 
            this.btn_onaylama.Location = new System.Drawing.Point(171, 288);
            this.btn_onaylama.Name = "btn_onaylama";
            this.btn_onaylama.Size = new System.Drawing.Size(237, 23);
            this.btn_onaylama.TabIndex = 1;
            this.btn_onaylama.Text = "OKUDUM ve ONAYLIYORUM";
            this.btn_onaylama.UseVisualStyleBackColor = true;
            this.btn_onaylama.Click += new System.EventHandler(this.btn_onaylama_Click);
            // 
            // Frm_Sozlesme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 332);
            this.Controls.Add(this.btn_onaylama);
            this.Controls.Add(this.rtb_sozlesme);
            this.Name = "Frm_Sozlesme";
            this.Text = "Frm_Sozlesme";
            this.Load += new System.EventHandler(this.Frm_Sozlesme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_sozlesme;
        private System.Windows.Forms.Button btn_onaylama;
    }
}