namespace Kviz
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            kerdesBank k = new();
            if (FeladatTipusValaszt() == 1)
            {
                Console.WriteLine("Kérem adja meg hány kérdést szeretne a kvízben!");
                byte darabszam = Convert.ToByte(Console.ReadLine());
                k.KvizOszeallitas(darabszam);
            }
            else if (FeladatTipusValaszt() == 2)
            {
                Console.WriteLine("Kérem adja meg hány kérdést szeretne a kvízben!");
                Console.WriteLine("Kérem adja meg a kategóriát!");
                byte darabszam = Convert.ToByte(Console.ReadLine());
                string kategoria = Console.ReadLine();
                k.KvizOszeallitas(darabszam, kategoria);
            }
            else if (FeladatTipusValaszt() == 3)
            {
                Console.WriteLine("Kérem adja meg hány kérdést szeretne a kvízben!");
                Console.WriteLine("Kérem adja meg a nehézséget!");
                byte darabszam = Convert.ToByte(Console.ReadLine());
                byte nehezseg = Convert.ToByte(Console.ReadLine());
                k.KvizOszeallitas(darabszam, nehezseg, out List<IKerdes> KerdesSor);
            }
            else if (FeladatTipusValaszt() == 4)
            {
                Console.WriteLine("Kérem adja meg hány kérdést szeretne a kvízben!");
                Console.WriteLine("Kérem adja meg a kategóriát!");
                Console.WriteLine("Kérem adja meg a nehézséget!");
                byte darabszam = Convert.ToByte(Console.ReadLine());
                byte kategoria = Convert.ToByte( Console.ReadLine());
                string nehezseg = Console.ReadLine();
                k.KvizOszeallitas(darabszam, kategoria, nehezseg, out List<IKerdes> KerdesSor);

            }
        }

        public static int FeladatTipusValaszt()
        {
            byte feladatTipus;

            do
            {
                feladatTipus = 0;
                Console.WriteLine("Milyen módon szeretnél feladatokat összeállítani?");
                Console.WriteLine("1. Kérdésszám alapján");
                Console.WriteLine("2. Kérdésszán és Kategória alapján");
                Console.WriteLine("3. Kérdésszám és nehézség alapján");
                Console.WriteLine("4. Kérdésszám, Kategória és nehézség alapján");


                //tryparse feladatTipus
                try
                {
                    feladatTipus = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception)
                {
                }

                Console.Clear();

            } while (feladatTipus < 1 || feladatTipus > 4);
            return Convert.ToInt32( feladatTipus);
        }   
    }
}