using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektnr1_Chalyi_59022
{
    class LiczbaZespolona
    {
        //część rzeczywista liczby zespolonej
        private double scRe;
        //częśż urojona liczby zespolonej
        private double scIm;
        //deklaracja konstruktorska bezparametrowego
        public LiczbaZespolona()
        {//domyśłne ustanawenie wartośći części rzeczywistej i urojonej
            this.scRe = 0.0;
            this.scIm = 0.0;
        }
        //deklaracja konstruktorska dwuargumentowego
        public LiczbaZespolona(double scre, double scim)
        {
            this.scRe = scre;
            this.scIm = scim;
        }
        //deklaracja konstruktorska jednoagumentowego
        public LiczbaZespolona(double scre)
        {
            this.scRe = scre;
            this.scIm = 0.0;
        }
        //deklracja właściwości
        public double scre
        {
            set { scRe = value; }
            get { return scRe; }
        }
        public double scim
        {
            set { scIm = value; }
            get { return scIm; }
        }
        //indeksera
        public double this[int sci]
        {
            get { //sprawdzenie dozwolonej wartości indeksu
                if ((sci < 0) || (sci > 1))
                    throw new System.IndexOutOfRangeException
                        ("ERROR:wykroczenie indeksu poza zakres");
                if (sci == 0)
                    return scRe;
                else
                    return scIm;
            }
            set
            {//sprawdzenie dozwolonej wartości indeksu
                if ((sci < 0) || (sci > 1))
                    throw new System.IndexOutOfRangeException
                        ("ERROR: wykroczenie indeksu poza zakres");
                if (sci == 0)
                    scRe = value;
                else
                    scIm = value;
            }
        }
        //przeciążanie operatorów jednoargumentowych
        public static LiczbaZespolona operator +(LiczbaZespolona scz)
        { return scz; }
        public static LiczbaZespolona operator -(LiczbaZespolona scz)
        { return new LiczbaZespolona(-scz.scre, -scz.scim); }
        //operator ~ wyznacza liczbę sprzężoną
        public static LiczbaZespolona operator ~(LiczbaZespolona scz)
        { return new LiczbaZespolona(scz.scre, -scz.scim); }
        //operator ! wyznacza modul
        public static double operator !(LiczbaZespolona scz)
        { return Math.Sqrt(scz.scre * scz.scre + scz.scim * scz.scim); }
        //przeciążanie operatorów dwuchargumentowych
        public static LiczbaZespolona operator +(LiczbaZespolona scz1, LiczbaZespolona scz2)
        { return new LiczbaZespolona(scz1.scre + scz2.scre, scz1.scim + scz2.scim); }
        public static LiczbaZespolona operator -(LiczbaZespolona scz1, LiczbaZespolona scz2)
        { return new LiczbaZespolona(scz1.scre - scz2.scre, scz1.scim - scz2.scim); }
        public static LiczbaZespolona operator *(LiczbaZespolona scz1, LiczbaZespolona scz2)
        { return new LiczbaZespolona((scz1.scre * scz2.scre) - (scz1.scim * scz2.scim), (scz1.scre * scz2.scim) + (scz2.scre * scz1.scim)); }
        public static LiczbaZespolona operator /(LiczbaZespolona scz1, LiczbaZespolona scz2)
        { return new LiczbaZespolona((((scz1.scre * scz2.scre) - (scz1.scim * scz2.scim)) / ((scz2.scre * scz2.scre) + (scz2.scim * scz2.scim))),
           (((scz1.scim * scz2.scre) - (scz1.scre * scz2.scim)) / ((scz2.scre * scz2.scre) + (scz2.scim * scz2.scim)))); }
        public override bool Equals(object scobj)
        {
            if (scobj is null || (scobj is LiczbaZespolona))
                return false;
            LiczbaZespolona scz = (LiczbaZespolona)scobj;
            return this.scRe == scz.scre && this.scIm == scz.scim;
        }
        public override int GetHashCode()
        {
            return scRe.GetHashCode() ^ scIm.GetHashCode();

        }
        //operatory konwersji
        public static implicit operator LiczbaZespolona(double scL)
        { return new LiczbaZespolona(scL, 0.0); }
        public static explicit operator double(LiczbaZespolona scz)
        {
            if (scz.scim == 0.0)
                return scz.scre;
            else
                throw new Exception("ERROR: konwersja liczby zespolonej" +
                    "na wartośc double jest niemożliwia");
        }
    }
}
