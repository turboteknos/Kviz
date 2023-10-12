using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz
{
    internal class Valasztos :IKerdes
    {
        private string kerdesSzoveg, kategoria;
        private List<string> valaszok;
        private byte nehezseg;

        public Valasztos(string kategoria, byte nehezseg, string kerdesSzoveg,  List<string>valaszok ) 
        { 
            this.kerdesSzoveg = kerdesSzoveg;
            this.kategoria = kategoria;
            this.valaszok = valaszok;
            this.nehezseg = nehezseg;
        }

        public string Nehezseg { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Kategoria { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Ellenorzes(string tipp)
        {
            throw new NotImplementedException();
        }

        public void valasztas(string kerdesSzoveg,List<string>valaszokSzoveg){

        }

        public List<string> Tartalom()
        {
            List<string>x =new List<string>();
            x.Add(kerdesSzoveg);
            x.AddRange(valaszok);
            return x;
        }
    }
}
