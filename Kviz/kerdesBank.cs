using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz
{
    internal class kerdesBank
    {
        FajlbolFeltolto f;
        List<IKerdes> feladatok;
        public kerdesBank()
        {
            feladatok=new List<IKerdes>();
            f= new FajlbolFeltolto(this);
        }

        public void KerdesFelvesz(IKerdes k)
        {
            feladatok.Add(k);


        }

        public void feladatokKiirasa()
        {
            foreach (IKerdes k in feladatok)
            {
                foreach (string s in k.Tartalom())
                {
                    Console.WriteLine(s);
                }
            }
        }


        public void KvizOszeallitas(byte darabszam)
        {
            //kérdések kiírása darabszám alapján konzolra
            foreach (IKerdes k in feladatok)
            {
                foreach (string s in k.Tartalom())
                {
                    Console.WriteLine(s);
                }
            }
            
            
            


        }

        public void KvizOszeallitas(byte darabszam, string kategoria,  out List<IKerdes> KerdesSor)
        {
            KerdesSor = new List<IKerdes>();
            // Ide jöhet a függvény logika
        }

        public void KvizOszeallitas(byte darabszam, byte nehezseg, out List<IKerdes> KerdesSor)
        {
            KerdesSor = new List<IKerdes>();
            // Ide jöhet a függvény logika
        }

        public void KvizOszeallitas(byte darabszam, byte nehezseg, string kategoria, out List<IKerdes> KerdesSor)
        {
            KerdesSor = new List<IKerdes>();
            // Ide jöhet a függvény logika
        }
    }
}
