﻿using System.Data;

namespace Beltek.HelloMVC.Models
{
    public class Ogretmen 
    {
        public Ogretmen() //bu counstructor metot yapıcı metto yanı default olarak yazılır.
        {

        }

        public string Tckimlik { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime Dtarih { get; set; }
        public string Alan { get; set; }


        public Ogretmen(string id, string ad,String soyad,DateTime dtarih,string alan)
        {
            this.Tckimlik = id;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Dtarih = dtarih;
            this.Alan = alan;
        }

        public override string ToString()
        {
            return $"{this.Tckimlik} {this.Ad} {this.Soyad} {this.Dtarih} {this.Alan}"; 
        }
    }
}
