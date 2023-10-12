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
        
    }
}
