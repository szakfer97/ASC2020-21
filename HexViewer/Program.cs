using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HexViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numele meu este Szakacsi Ferenc-Adam");
            Console.WriteLine("Acest program functioneaza ca un Hexviewer");
            Console.WriteLine("Introduceti calea fisierului pentru vizualizare Hex:");
            try
            {
                string path = Console.ReadLine();
                Console.WriteLine("Stabiliti numarul octetilor pentru o linie:");
                int octeti = int.Parse(Console.ReadLine());
                Console.WriteLine();
                char[] caracterepentrueliminare = new char[] { ' ', '"' };
                path = path.Trim(caracterepentrueliminare);
                FileStream file = new FileStream(path, FileMode.Open);
                byte[] byteBlock = new byte[octeti];
                int index = 0;
                int actual;
                while ((actual = file.Read(byteBlock, 0, octeti)) > 0)
                {
                    string hex = BitConverter.ToString(byteBlock, 0, actual);
                    string text = "";
                    for (int i = 0; i < actual; i++)
                        text += byteBlock[i] < ' ' || byteBlock[i] == 127 ? "." : ((char)byteBlock[i]).ToString();
                    Console.WriteLine($" {index:X8} : {hex.PadRight(octeti * 3 - 1)}  | {text}");
                    index += octeti;
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
