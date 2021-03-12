using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereMari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numele meu este Szakacsi Ferenc-Adam");
            Console.WriteLine("Acest program face adunarea si scaderea numerelor mari");
            Console.WriteLine("Tastati numerele si operatia + sau -");
            CitireNum();
            Console.ReadKey();
        }
        private static void CitireNum()
        {
            try
            {
                string num1 = Console.ReadLine();
                string num2 = Console.ReadLine();
                char operation = char.Parse(Console.ReadLine());
                int[] num1Arr = new int[] { };
                int[] num2Arr = new int[] { };
                num1Arr = StringtoInt(num1);
                num2Arr = StringtoInt(num2);
                switch (operation)
                {
                    case '+':
                        Adunare(num1Arr, num2Arr);
                        break;
                    case '-':
                        Scadere(num1Arr, num2Arr);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Adunare(int[] a, int[] b)
        {
            int minLength, maxLength;
            try
            {
                if (a.Length > b.Length)
                {
                    minLength = b.Length;
                    maxLength = a.Length + 1;
                }
                else
                {
                    minLength = a.Length;
                    maxLength = b.Length + 1;
                }
                Array.Reverse(a);
                Array.Reverse(b);
                int[] sum = new int[maxLength];
                for (int i = 0; i < minLength; i++)
                {
                    if (sum[i] + a[i] + b[i] >= 10)
                    {
                        sum[i] = (sum[i] + a[i] + b[i]) % 10;
                        sum[i + 1]++;
                    }
                    else
                    {
                        sum[i] = (sum[i] + a[i] + b[i]) % 10;
                    }
                }
                if (a.Length != b.Length)
                {
                    for (int i = minLength; i < maxLength - 1; i++)
                    {
                        if (a.Length > b.Length)
                        {
                            if (sum[i] + a[i] >= 10)
                            {
                                sum[i] = (sum[i] + a[i]) % 10;
                                sum[i + 1]++;
                            }
                            else
                            {
                                sum[i] = (sum[i] + a[i]) % 10;
                            }
                        }
                        else
                        {
                            if (sum[i] + b[i] >= 10)
                            {
                                sum[i] = (sum[i] + b[i]) % 10;
                                sum[i + 1]++;
                            }
                            else
                            {
                                sum[i] = (sum[i] + b[i]) % 10;
                            }
                        }
                    }
                }
                Array.Reverse(sum);
                if (sum[0] != 0)
                {
                    for (int i = 0; i < sum.Length; i++)
                    {
                        Console.Write($"{sum[i]}");
                    }
                }
                else
                {
                    for (int i = 1; i < sum.Length; i++)
                    {
                        Console.Write($"{sum[i]}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Scadere(int[] a, int[] b)
        {
            int maxLength = 0;
            try
            {
                if (a.Length > b.Length)
                {
                    maxLength = a.Length;
                }
                else
                {
                    maxLength = b.Length;
                }
                int[] difer = new int[maxLength];
                bool maimare = true;
                if (MaiMare(a, b) == true)
                {
                    maimare = true;
                    Array.Reverse(a);
                    Array.Reverse(b);
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (a[i] >= b[i])
                        {
                            difer[i] = a[i] - b[i];
                        }
                        else
                        {
                            difer[i] = (a[i] + 10) - b[i];
                            a[i + 1]--;
                        }
                    }
                    for (int i = b.Length; i < a.Length; i++)
                    {
                        difer[i] = a[i];
                    }
                }
                else
                {
                    maimare = false;
                    Array.Reverse(a);
                    Array.Reverse(b);
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (b[i] >= a[i])
                        {
                            difer[i] = b[i] - a[i];
                        }
                        else
                        {
                            difer[i] = (b[i] + 10) - a[i];
                            b[i + 1]--;
                        }
                    }
                    for (int i = a.Length; i < b.Length; i++)
                    {
                        difer[i] = b[i];
                    }
                }
                Array.Reverse(difer);
                int j = 0;
                while (difer[j] == 0)
                {
                    j++;
                }
                if (maimare == false)
                {
                    Console.Write("-");
                }
                for (int k = j; k < maxLength; k++)
                {
                    Console.Write(difer[k]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static int[] StringtoInt(string stringArr)
        {
            int[] cons = new int[stringArr.Length];
            int i = 0;
            foreach (char digit in stringArr)
            {
                cons[i] = (int)digit - (int)'0';
                i++;
            }
            return cons;
        }
        private static bool MaiMare(int[] a, int[] b)
        {
            int inta = 0, intb = 0;
            for (int i = 0; i < a.Length; i++)
            {
                inta = inta * 10 + a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                intb = intb * 10 + b[i];
            }
            if (inta >= intb)
                return true;
            else
                return false;
        }
    }
}
