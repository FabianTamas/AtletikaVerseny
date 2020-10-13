using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtletikaiVerseny
{
    class Program
    {
        static List<Atleta> atletak = new List<Atleta>();
        static List<string> egyesulet = new List<string>();

        static void Beolvas()
        {
            Console.WriteLine("1. feladat: adatok beolvasása");
            StreamReader file = new StreamReader("tavol.csv");
            while (!file.EndOfStream)
            {
                atletak.Add(new Atleta(file.ReadLine()));
            }
            file.Close();
        }

        static void feladat2()
        {
            Console.WriteLine("2. feladat: Nevek és ugrások");
            foreach (var a in atletak)
            {
                Console.WriteLine("{0} {1}",a.Nev, a.Ugras);
            }
        }

        static void feladat3()
        {
            Console.WriteLine("3.feladat: Egyesületek:");
            foreach (var a in atletak)
            {
                if (!egyesulet.Contains(a.Egyesulet))
                {
                    egyesulet.Add(a.Egyesulet);
                    Console.WriteLine(a.Egyesulet);
                }
            }
        }

        static void feladat4()
        {
            Console.WriteLine("4. feladat: Legnagyobb ugrás:");
            int max = 0;
            foreach (var a in atletak)
            {
                if (a.Ugras > max)
                {
                    max = a.Ugras;
                }
            }

            foreach (var a in atletak)
            {
                if (max == a.Ugras)
                {
                    Console.WriteLine($"{a.Nev}: {a.Ugras} cm");
                }
            }
        }

        static void feladat5()
        {
            int osszeg = 0;
            int db = 0;
            foreach (var a in atletak)
            {
                osszeg += a.Ugras;
                db++;
            }
            double atlag = osszeg / db;

            int darab = 0;
            foreach (var a in atletak)
            {
                if (atlag>a.Ugras)
                {
                    darab++;
                }
            }
            Console.WriteLine("5. feladat: Átlag alatt lévő ugrások száma: {0}",darab);
        }

        static void feladat6()
        {
            Console.WriteLine("6. feladat: Adatok fájlba írása");
            StreamWriter file = new StreamWriter("versenyzok.txt");
            foreach (var a in atletak)
            {
                file.WriteLine("{0};{1}",a.Rajtszam, a.Nev);
            }
            file.Close();
        }

        static void Main(string[] args)
        {
            Beolvas();
            feladat2();
            feladat3();
            feladat4();
            feladat5();
            feladat6();

            Console.ReadKey();
        }
    }
}
