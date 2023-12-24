using System.Data;

namespace Beltek.HelloMVC.Models
{
    public class Ogretmen : HumanBase
    {
        public Ogretmen()
        {

        }

        public int Tckimlik { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime Dtarih { get; set; }
        public string Universite { get; set; }


        public Ogretmen(int tckimlik, string ad,String soyad,DateTime dtarih,string universite)
        {
            this.Tckimlik = tckimlik;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Dtarih = dtarih;
            this.Universite = universite;
        }

        public override string ToString()
        {
            return $"{this.Tckimlik} {this.Ad} {this.Soyad} {this.Dtarih} {this.Universite}"; 
        }

    }
}
