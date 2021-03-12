using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AutomatDeVanzare
{
    class Program
    {
        static int monede = 0;
        static int rest = 0;
        static char g = 'O';
        static void Main(string[] args)
        {
            a();
        }
        private static void Write()
        {
            Console.WriteLine("Numele meu este Szakacsi Ferenc-Adam");
            Console.WriteLine("Acest program simuleaza un automat de vanzare");
            Console.WriteLine($"Ai {monede} centi in automat.");
            Console.WriteLine("Care moneda doresti sa introduci?");
            Console.WriteLine("n - nickel (5 centi)");
            Console.WriteLine("d - dime (10 centi)");
            Console.WriteLine("q - quarter (25 centi)");
        }
        private static void GetCoins()
        {
            g = char.Parse(Console.ReadLine());
            Console.Clear();
        }
        private static void a()
        {
            try
            {
                if (monede < 20)
                {

                    Write();
                    GetCoins();
                    switch (g)
                    {
                        case 'n':
                            monede += 5;
                            b();
                            break;
                        case 'd':
                            monede += 10;
                            c();
                            break;
                        case 'q':
                            monede += 25;
                            a();
                            break;
                        default:
                            Console.WriteLine("Nu ai introdus corect monedele. Mai incearca!");
                            a();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Va rog asteptati!Masina va pregateste produsul.");
                    Thread.Sleep(500);
                    Console.WriteLine("Ati primit produsul!");
                    rest = monede - 20;
                    if (rest > 0) Rest();
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void b()
        {
            try
            {
                if (monede <= 20)
                {

                    Write();
                    GetCoins();
                    switch (g)
                    {
                        case 'n':
                            monede += 5;
                            c();
                            break;
                        case 'd':
                            monede += 10;
                            d();
                            break;
                        case 'q':
                            monede += 25;
                            a();
                            break;
                        default:
                            Console.WriteLine("Nu ai introdus corect monedele.Mai incearca!");
                            b();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Va rog asteptati!Masina va pregateste produsul.");
                    Thread.Sleep(500);
                    Console.WriteLine("Ati primit produsul!");
                    rest = monede - 20;
                    if (rest > 0) Rest();
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void c()
        {
            Write();
            GetCoins();
            try
            {
                switch (g)
                {
                    case 'n':
                        monede += 5;
                        d();
                        break;
                    case 'd':
                        monede += 10;
                        a();
                        break;
                    case 'q':
                        monede += 25;
                        a();
                        break;
                    default:
                        Console.WriteLine("Nu ai introdus corect monedele.Mai incearca!");
                        c();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void d()
        {
            Write();
            GetCoins();
            try
            {
                switch (g)
                {
                    case 'n':
                        monede += 5;
                        a();
                        break;
                    case 'd':
                        monede += 10;
                        a();
                        break;
                    case 'q':
                        monede += 25;
                        b();
                        break;
                    default:
                        Console.WriteLine("Nu ai introdus corect monedele.Mai incearca!");
                        d();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Rest()
        {
            monede -= 20;
            try
            {
                switch (rest)
                {
                    case 5:
                        Console.WriteLine("Primesti inapoi un nickel");
                        monede -= 5;
                        break;
                    case 10:
                        Console.WriteLine("Primesti inapoi un dime");
                        monede -= 10;
                        break;
                    case 15:
                        Console.WriteLine("Primesti inapoi un nickel si un dime");
                        monede -= 15;
                        break;
                    case 20:
                        Console.WriteLine("Primesti inapoi doi dime");
                        monede -= 20;
                        b();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
    }
}
