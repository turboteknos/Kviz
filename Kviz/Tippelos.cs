using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz
{
    internal class Tippelos
    {

        private string kerdesSzoveg, kategoria;
        private float megoldas, tolerancia;
        private byte nehezseg;  

        public Tippelos(string kerdesSzoveg, string kategoria, float megoldas, float tolerancia, byte nehezseg) { 
            
            this.kerdesSzoveg = kerdesSzoveg;
            this.kategoria = kategoria;
            this.megoldas = megoldas;
            this.tolerancia = tolerancia;
            this.nehezseg = nehezseg;
        }

    }


}
