using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz
{
    internal interface IKerdes
    {
        public string Nehezseg { get; set; }
        public float Kategoria { get; set; }




        public bool Ellenorzes(string tipp);

        public List<string> Tartalom()
        {
            List<string> tartalom = new List<string>();
            return tartalom;

        }


    }



}
