using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegeaLuiMoore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numele meu este Szakacsi Ferenc-Adam");
            Console.WriteLine("Acest program rezolva problema legata de legea lui Moore");
            string consola;
            double cateori;
            try
            {
                while (true)
                {
                    Console.WriteLine("Introduceti un numar pentru a afla");
                    consola = Console.ReadLine();
                    if (double.TryParse(consola, out cateori))
                    {
                        double ani;
                        ani = 1.5 * Math.Log(cateori, 2);
                        Console.WriteLine($"Puterea de calcul va fi de {cateori} ori mai mare peste {ani} ani");
                        break;
                    }
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
