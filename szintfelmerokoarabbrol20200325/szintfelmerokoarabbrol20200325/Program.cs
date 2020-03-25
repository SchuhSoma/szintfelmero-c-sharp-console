using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szintfelmerokoarabbrol20200325
{
    class Program
    {
        static Random rnd = new Random(); 
        static void Main(string[] args)
        {
            //Feladat1();
            //Feladat2();
            //Feladat3();
           // Feladat3Alternativa();
            //Feladat4Dobokocka();
            //Feladat5();
            Feladat5Alternativ();
            Console.ReadKey();
        }

        private static void Feladat5Alternativ()
        {
            Console.WriteLine("5.Feladat: Ha egy szám osztható 3-al és 5-el akkor osztható 15-el is");
            int Szam = 0;
            int db = 0;
            do
            { 
                Szam ++;
                if(Szam%3==0 && Szam%5==0)
                {
                    Console.Write("{0} , ", Szam);
                    db++;
                }                                      
            } while (db < 30);
        }

        private static void Feladat5()
        {
            Console.WriteLine("5.Feladat: Ha egy szám osztható 3-al és 5-el akkor osztható 15-el is");
            Console.WriteLine("Ennek az az oka, hogy a 3 és az 5 relatív prím vagyis nincs közös osztójuk, csak az 1");
            int Szam;
            for (int i = 1; i <=30; i++)
            {
                Szam = i * 15;
                Console.Write("{0} , ", Szam);
            }
        }

        private static void Feladat4Dobokocka()
        {
            Console.WriteLine("4.Feladat: Dobókocka");
            int Osszeg = 0;
            double Atlag =0;
            int db = 0;//leszámlálási tétel
            int db6 = 0;
            for(int i=1; i<=100;i++)
            {
                int KockaSzam = rnd.Next(1, 7);
                Console.WriteLine("{0:000} dobás := {1}", i, KockaSzam);
                Osszeg += KockaSzam; //Összegzési tétel
                Atlag = (double)Osszeg / 100; //átlagolási té
                if(KockaSzam%2==0)
                {
                    db++;
                }
                if(KockaSzam==6)
                {
                    db6++;
                }
            }
            Console.WriteLine("\n\tA dobások összege: {0}", Osszeg);
            Console.WriteLine("\n\tA dobott számok átlaga: {0:0.00}", Atlag);
            Console.WriteLine("\n\tEnnyi páros dobás volt a listában: {0}", db);
            Console.WriteLine("\n\tEnnyi hatos dobás volt a listában: {0}", db6);
            
        }

        private static void Feladat3Alternativa()
        {
            Console.WriteLine("3.Feladat: Melyik évszak");
            int HonapSorszama = 0;
            do
            {
                Console.Write("Kérem adja meg egy hónap sorszámát: ");
                int HonapSorszama2 = int.Parse(Console.ReadLine());
                HonapSorszama = HonapSorszama2;
            } 
            while (HonapSorszama < 1 || HonapSorszama > 12);
            if (HonapSorszama == 12 || HonapSorszama == 1 || HonapSorszama == 2)
            {
                Console.WriteLine("Ez egy téli hónap");
            }
            if (HonapSorszama == 3 || HonapSorszama == 4 || HonapSorszama == 5)
            {
                Console.WriteLine("Ez egy tavaszi hónap");
            }
            if (HonapSorszama == 6 || HonapSorszama == 7 || HonapSorszama == 8)
            {
                Console.WriteLine("Ez egy nyári hónap");
            }
            if (HonapSorszama == 9 || HonapSorszama == 10 || HonapSorszama == 11)
            {
                Console.WriteLine("Ez egy őszi hónap");
            }
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat: Melyik évszak");
            eleje:
            Console.Write("Kérem adja meg egy hónap sorszámát: ");
            int HonapSorszama = int.Parse(Console.ReadLine());

            if(0<HonapSorszama && HonapSorszama<13)
            {
                if(HonapSorszama==12 || HonapSorszama==1|| HonapSorszama==2)
                {
                    Console.WriteLine("Ez egy téli hónap");
                }
                if(HonapSorszama == 3 || HonapSorszama == 4 || HonapSorszama == 5)
                {
                    Console.WriteLine("Ez egy tavaszi hónap");
                }
                if (HonapSorszama == 6 || HonapSorszama == 7 || HonapSorszama == 8)
                {
                    Console.WriteLine("Ez egy nyári hónap");
                }
                if (HonapSorszama == 9 || HonapSorszama == 10 || HonapSorszama == 11)
                {
                    Console.WriteLine("Ez egy őszi hónap");
                }
            }
            else
            {
                Console.WriteLine("Sajnálom rossz számot adott meg");
                goto eleje;
            }
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat: megtett út költsége");
            Console.Write("Kérem adja meg az autó fogyasztását 100km-en literben: ");
            double FogyasztasSzazon = double.Parse(Console.ReadLine());
            double FogyasztasEgyKm = FogyasztasSzazon / 100;
            Console.Write("Kérem adja meg 1 liter benzin árát: ");
            int BenzinAra = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg az út hosszát : ");
            double UtHossza= double.Parse(Console.ReadLine());
            double Koltseg = (UtHossza * FogyasztasEgyKm) + UtHossza * 6;
            double Koltseg2 = (UtHossza * FogyasztasSzazon/100) + UtHossza * 6;
            Console.WriteLine("Az Ön utazási költsége: {0:0.00} Ft", Koltseg);
            Console.WriteLine("Az Ön utazási költsége: {0:0.00} Ft", Koltseg2);
        }

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat: Pithagorasz tétel");
            Console.Write("Kérem adja meg az első befogót: ");
            double A_Befogo = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg az második befogót: ");
            double B_Befogo = double.Parse(Console.ReadLine());
            double PithagorszNegyzet = Math.Pow(A_Befogo, 2) + Math.Pow(B_Befogo, 2);
            double C_Atfog = Math.Sqrt(PithagorszNegyzet);
            Console.WriteLine("Az átfogó hossza := {0:0.00}", C_Atfog);
        }
    }
}
