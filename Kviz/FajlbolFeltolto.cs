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
       
        public FajlbolFeltolto(kerdesBank kerdes)
        {
            k = kerdes;
           
          
        }

        private void TippelosFeltolt()
        {
            FileStream fs = new FileStream("tippeloskerdesek.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string sor;
            while (!sr.EndOfStream)
            {
                sor=sr.ReadLine();
                string[] adatok = sor.Split(';');

                k.KerdesFelvesz(new Tippelos(adatok[0], byte.Parse(adatok[1]), adatok[2], byte.Parse(adatok[3]), float.Parse(adatok[4])));
                

                
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
