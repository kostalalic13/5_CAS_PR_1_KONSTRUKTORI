using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _5_CAS_PR_1_KONSTRUKTORI
{
    internal class Program
    {
        // Deklaracija strukture
        struct Racionalan
        {
            public int brojilac;
            public int imenilac;

            // Konstruktor s parametrima
            public Racionalan(int brojilac, int imenilac)
            {
                this.brojilac = brojilac;
                this.imenilac = imenilac;
            }
            // Metoda unutar strukture za jednostavan ispis
            public void Ispisi()
            {
                Console.WriteLine($"{brojilac}/{imenilac}");
            }
        }
        static void Main(string[] args)
        {
            // 1. Podrazumevani konstruktor (kompjuter postavlja polja na 0)
            Racionalan r1 = new Racionalan();
            r1.brojilac = 1;
            r1.imenilac = 3;
            // 2. Korisnicki konstruktor sa parametrima
            Racionalan r2 = new Racionalan(1, 2);
            // 3. Inicijalizator objekta (implicitno poziva podrazumevani konstruktor)
            Racionalan r3 = new Racionalan
            {
                brojilac = 2,
                imenilac = 5
            };
            // 4. Rucna inicijalizacija bez 'new' (moraju se popuniti SVA polja pre upotrebe)
            Racionalan r4;
            r4.brojilac = 4;
            r4.imenilac = 7;
            Console.WriteLine("Prikaz razlomaka: ");
            Console.Write("r1 = "); 
            r1.Ispisi();
            Console.Write("r2 = ");
            r2.Ispisi();
            Console.Write("r3 = ");
            r3.Ispisi();
            Console.Write("r4 = ");
            r4.Ispisi();
        }
    }
}
