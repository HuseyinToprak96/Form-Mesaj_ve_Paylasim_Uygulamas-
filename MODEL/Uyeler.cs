﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesaj_ve_Paylasim_Uygulaması.MODEL
{
    class Uyeler
    {
        public int UyeID { get; set; }
        public String UyeKullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Sehir { get; set; }
        public string  GizliSoru{ get; set; }
        public string Cevap { get; set; }
        public int Telefon { get; set; }
        public string Mail { get; set; }
    }
}
