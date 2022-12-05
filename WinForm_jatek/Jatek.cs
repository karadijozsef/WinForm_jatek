using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_jatek
{
    internal class Jatek
    {
        int id;
        string nev;
        DateTime datum;
        string mufaj;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Mufaj { get => mufaj; set => mufaj = value; }

        public Jatek(int id, string nev, DateTime datum, string mufaj)
        {
            Id = id;
            Nev = nev;
            Datum = datum;
            Mufaj = mufaj;
        }
    }
}
