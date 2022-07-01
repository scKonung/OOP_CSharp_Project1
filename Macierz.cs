using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektnr1_Chalyi_59022
{
    class Macierz
    {
        private float[,] scmacierz;
        
        //deklaracja konstruktorska
        public Macierz(ushort scliczbaWierzy, ushort scliczbaKolumn)
        {
            scmacierz = new float[scliczbaWierzy, scliczbaKolumn];
        }
        //deklaracja właściwości klasy Macierz
        public ushort scLiczbaWierzy
        {
            get { return (ushort)scmacierz.GetLength(0); }
        }
        public ushort scLiczbaKolumn
        {
            get { return (ushort)scmacierz.GetLength(1); }
        }
        public float this[ushort scNrWiersza, ushort scNrKolumny]
        {
            set
            {
                if ((scNrWiersza >= 0) && (scNrWiersza < scmacierz.GetLength(0)) &&
                    (scNrKolumny >= 0) && (scNrKolumny < scmacierz.GetLength(1)))
                    scmacierz[scNrWiersza, scNrKolumny] = value;
                else//wypisanie blędu
                    throw new IndexOutOfRangeException("ERROR: wartość jednego z indeksów" +
                        "macierzy wykracza poza dozwolonych zekres");
            }
            get
            {
                if ((scNrWiersza >= 0) && (scNrWiersza < scmacierz.GetLength(0)) &&
                   (scNrKolumny >= 0) && (scNrKolumny < scmacierz.GetLength(1)))
                    return scmacierz[scNrWiersza, scNrKolumny];
                else//wypisanie blędu
                    throw new IndexOutOfRangeException("ERROR: wartość jednego z indeksów" +
                        "macierzy wykracza poza dozwolonych zekres");
            }
        }
        public static Macierz operator +(Macierz sca, Macierz scb)
        {
            if (sca.scLiczbaWierzy != scb.scLiczbaWierzy ||
            sca.scLiczbaKolumn != scb.scLiczbaKolumn)
                throw new ArgumentException("Zły rozmiar macierzy");
            Macierz scc = new Macierz(sca.scLiczbaWierzy, sca.scLiczbaKolumn);
            for (ushort sci = 0; sci < sca.scLiczbaWierzy;sci++)
            {
                for (ushort scj = 0; scj < sca.scLiczbaKolumn; scj++)
                {
                    scc.scmacierz[sci, scj] = sca.scmacierz[sci, scj] + scb.scmacierz[sci, scj];
                }
            }
            return scc;
        }
        public static Macierz operator -(Macierz sca, Macierz scb)
        {
            if (sca.scLiczbaWierzy != scb.scLiczbaWierzy ||
            sca.scLiczbaKolumn != scb.scLiczbaKolumn)
                throw new ArgumentException("Zły rozmiar macierzy");
            Macierz scc = new Macierz(sca.scLiczbaWierzy, sca.scLiczbaKolumn);
            for (ushort sci = 0; sci < sca.scLiczbaWierzy; sci++)
            {
                for (ushort scj = 0; scj < sca.scLiczbaKolumn; scj++)
                {
                    scc.scmacierz[sci, scj] = sca.scmacierz[sci, scj] - scb.scmacierz[sci, scj];
                }
            }
            return scc;
        }

        public static Macierz operator *(Macierz sca, Macierz scb)
        {
            if (sca.scLiczbaWierzy != scb.scLiczbaWierzy ||
            sca.scLiczbaKolumn != scb.scLiczbaKolumn)
                throw new ArgumentException("Zły rozmiar macierzy");
            Macierz scc = new Macierz(sca.scLiczbaWierzy, scb.scLiczbaKolumn);
            for (ushort sci = 0; sci < sca.scLiczbaWierzy; sci++)
            {
                for (ushort scj = 0; scj < scb.scLiczbaKolumn; scj++)
                {
                    scc.scmacierz[sci, scj] = 0;
                    for(ushort sck = 0; sck < scb.scLiczbaWierzy; sck++)
                    {
                        scc.scmacierz[sci, scj] += sca.scmacierz[sci, sck] * scb.scmacierz[sck, scj];
                    }
                }
                
            }
            return scc;
        }
        public static Macierz operator /(Macierz sca, Macierz scb)
        {
            if (sca.scLiczbaWierzy != scb.scLiczbaWierzy ||
            sca.scLiczbaKolumn != scb.scLiczbaKolumn)
                throw new ArgumentException("Zły rozmiar macierzy");
            Macierz scc = new Macierz(sca.scLiczbaWierzy, scb.scLiczbaKolumn);
            for (ushort sci = 0; sci < sca.scLiczbaWierzy; sci++)
            {
                for (ushort scj = 0; scj < scb.scLiczbaKolumn; scj++)
                {
                    scc.scmacierz[sci, scj] = 0;
                    for (ushort sck = 0; sck < scb.scLiczbaWierzy; sck++)
                    {
                        scc.scmacierz[sci, scj] += sca.scmacierz[sci, sck] / scb.scmacierz[sck, scj];
                    }
                }

            }
            return scc;
        }
        public static Macierz operator *(Macierz sca, float scLiczba)
        {
            Macierz scc = new Macierz(sca.scLiczbaWierzy, sca.scLiczbaKolumn);
            for (ushort sci = 0; sci < sca.scLiczbaWierzy; sci++)
            {
                for (ushort scj = 0; scj < sca.scLiczbaKolumn; scj++)
                {
                    scc.scmacierz[sci, scj] = scLiczba * sca.scmacierz[sci, scj]; 
                }
            }
            return scc;
        }
        public static bool operator ==(Macierz sca, Macierz scb)
        {
            if (sca.scLiczbaWierzy == scb.scLiczbaWierzy &&
                sca.scLiczbaKolumn == scb.scLiczbaKolumn)
            {
                for (ushort sci = 0; sci < sca.scLiczbaWierzy; sci++)
                    for (ushort scj = 0; scj < scb.scLiczbaKolumn; scj++)
                        if (sca.scmacierz[sci, scj] != scb.scmacierz[sci, scj])
                            return false;
                        return true;
            }
            else
                return false;
            
        }
        public static bool operator !=(Macierz sca, Macierz scb)
        {
            return !(sca == scb);
        }
        public override bool Equals(object scobj)
        {
            //sparwdzenie parametru scobj
            if ((scobj is null)||(!(scobj is Macierz)))
                    return false;
            //pomocnicza deklaracja
            Macierz scm = (Macierz)scobj;
            //sprawdzenie danego elementu
            for (ushort sci = 0; sci < scm.scLiczbaWierzy; sci++)
                for (ushort scj = 0; scj < scm.scLiczbaKolumn; scj++)
                    if (this.scmacierz[sci,scj] != scm[sci,scj])
                    return false;
            return true;
        }
        public override int GetHashCode()
        {
            return this.scmacierz.GetHashCode();
        }
        //deklaracja operatora konwersji dla klasy Macierz
        public static explicit operator Macierz (float scx)
        {
            Macierz scc = new Macierz(1, 1);
            //wpisanie wartośći parametru x do macierzy c
            scc.scmacierz[0, 0] = scx;
            //zwrócenie wyniku
            return scc;
        }
    }
    
}
