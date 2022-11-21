using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyumolcsWinForm
{
    internal class Gyumolcs
    {
        int id;
        string nev;
        int ar;
        int db;
        DateTime datum;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Db { get => db; set => db = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public Gyumolcs(int azonosito, string nev, int ar, int db, DateTime datum)
        {
            Id = id;
            Nev = nev;
            Ar = ar;
            Db = db;
            Datum = datum;
        }
        public override string ToString()
        {
            return nev;
        }
    }
}
