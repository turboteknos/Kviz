using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

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


        public List<IKerdes> KvizOszeallitas(byte darabszam)
        {
            // Számláló, hogy nyomon kövessük hány elemet írtunk ki eddig
            byte counter = 0;

            // Lista, ami tartalmazza a kiírandó kérdéseket
            List<IKerdes> Kerdessor = new List<IKerdes>();

            // Véletlenszám-generátor létrehozása
            Random rng = new Random();

            // Másoljuk a feladatok listát, hogy véletlenszerűen tudjuk kezelni
            List<IKerdes> feladatokMasolat = new List<IKerdes>(feladatok);

            // kérdések kiírása darabszám alapján konzolra
            while (feladatokMasolat.Count > 0 && counter < darabszam)
            {
                // Véletlenszerű index kiválasztása
                int randomIndex = rng.Next(feladatokMasolat.Count);

                // Kiválasztjuk az adott indexű kérdést
                IKerdes k = feladatokMasolat[randomIndex];

                List<string> tartalom = k.Tartalom();
                for (int j = 0; j < tartalom.Count; j++)
                {
                    // Ha elérjük a darabszám limitet, kilépünk a ciklusból
                    if (counter >= darabszam)
                    {
                        return Kerdessor;
                    }

                    Console.WriteLine(tartalom[j]);
                    counter++;  // Növeljük a számlálót
                }

                // Hozzáadjuk a kiírt kérdést a Kerdessor listájához
                Kerdessor.Add(k);

                // Eltávolítjuk a már kiválasztott kérdést a másolat listából
                feladatokMasolat.RemoveAt(randomIndex);
            }

            return Kerdessor;
        }



        public List<IKerdes> KvizOszeallitas(byte darabszam, string kategoria)
        {
            throw new NotImplementedException();
            
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
