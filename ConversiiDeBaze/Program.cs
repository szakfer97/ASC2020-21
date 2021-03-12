using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversiiDeBaze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numele meu este Szakacsi Ferenc-Adam");
            Console.WriteLine("Acest program face conversii in diferite baze de date");
            int numar, cifre = 0, i, baza;
            int[] bazacif = new int[20];
            try
            {
                Console.WriteLine("Introduceti un numar in baza 10:");
                numar = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti baza de conversie:");
                baza = int.Parse(Console.ReadLine());
                while (numar != 0)
                {
                    bazacif[cifre] = numar % baza;
                    numar /= baza;
                    cifre++;
                }
                Console.WriteLine($"Reprezentarea in baza {baza} a numarului este:");
                for (i = cifre - 1; i >= 0; i--)
                    Console.Write(bazacif[i]);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
