using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz
{

    internal class Tippelos:IKerdes
    {

        private string kerdesSzoveg, kategoria;
        private float megoldas, tolerancia;
        private byte nehezseg;  

        public Tippelos(string kategoria, byte nehezseg, string kerdesSzoveg,  float megoldas, float tolerancia) { 
            
            this.kerdesSzoveg = kerdesSzoveg;
            this.kategoria = kategoria;
            this.megoldas = megoldas;
            this.tolerancia = tolerancia;
            this.nehezseg = nehezseg;
        }

        public string Nehezseg { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Kategoria { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Ellenorzes(string tipp)
        {
            throw new NotImplementedException();
        }

        public List<string> Tartalom()
        {
          
            return new List<string>() { kerdesSzoveg };
        }
        
    }


}
