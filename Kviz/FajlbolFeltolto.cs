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
            TippelosFajlnev = "tippeloskerdesek.txt";
            ValasztosFajlnev = "kerdesek.txt";
            this.k = k;
            TippelosFeltolt();
            ValasztosFeltolt();
        }

        private void TippelosFeltolt()
        {
            FileStream fs = new FileStream(TippelosFajlnev, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string sor;
            while (!sr.EndOfStream)
            {
               
                sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                k.KerdesFelvesz(new Tippelos(adatok[0], byte.Parse(adatok[1]), adatok[2], float.Parse(adatok[3]), float.Parse(adatok[4])));



            }

            sr.Close();
            fs.Close();
        }

        private void ValasztosFeltolt()
        {
            FileStream fs = new FileStream(ValasztosFajlnev, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string sor;
            List<string> valaszok = new List<string>();
            while (!sr.EndOfStream)
            {
                sor=sr.ReadLine();
                string[] adatok = sor.Split(';');
                
                for(int i=3; i < adatok.Length; i++)
                {
                    valaszok.Add(adatok[i]);
                }





                k.KerdesFelvesz(new Valasztos(adatok[0], byte.Parse(adatok[1]), adatok[2], valaszok));
            }
            sr.Close();
            fs.Close();


        }


       
    }
}
