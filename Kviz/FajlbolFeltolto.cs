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

        public FajlbolFeltolto(kerdesBank k)
        {
            this.k = k;
            TippelosFeltolt();
            ValasztosFeltolt();
        }

        private void TippelosFeltolt()
        {
            FileStream fs = new FileStream("tippeloskerdesek.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string sor;
            while (!sr.EndOfStream)
            {
                //example line for tippeloskerdesek.txt: matematika;1;Hány oldala van egy paralelogrammának?;4;0
                //split line by ';' and add to kerdesBank.KerdesFelvesz()
                sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                //        public Tippelos(byte nehezseg,string kategoria, string kerdesSzoveg,  float megoldas, float tolerancia)
                k.KerdesFelvesz(new Tippelos(adatok[0], byte.Parse(adatok[1]), adatok[2], float.Parse(adatok[3]), float.Parse(adatok[4])));



            }


        }

        private void ValasztosFeltolt()
        {
            FileStream fs = new FileStream("kerdesek.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string sor;
            List<string> valaszok = new List<string>();
            while (!sr.EndOfStream)
            {
                sor=sr.ReadLine();
                string[] adatok = sor.Split(';');
                //        public Valasztos(byte nehezseg,string kategoria, string kerdesSzoveg,  List<string>valaszok ) 
                
                for(int i=3; i < adatok.Length; i++)
                {
                    valaszok.Add(adatok[i]);
                }





                k.KerdesFelvesz(new Valasztos(adatok[0], byte.Parse(adatok[1]), adatok[2], valaszok));
            }


        }
    }
}
