using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz
{
    class FajlbolFeltolto
    {
        string TippelosFajlnev, ValasztosFajlnev;
        kerdesBank k;
        public FajlbolFeltolto()
        {

        }

        private void TippelosFeltolt()
        {
            FileStream fs = new FileStream("tippeloskerdesek.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string sor;
            while (!sr.EndOfStream)
            {
                sor= sr.ReadLine();
                string[] adatok = sor.Split(';');

                
            }   
           

        }

        private void ValasztosFeltolt()
        {

        }
    }
}
