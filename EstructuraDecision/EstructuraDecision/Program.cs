using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresar texto");

            string text = Console.ReadLine();

            if(!string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Opciones: ");
                Console.WriteLine("1 - Texto en Mayúscula");
                Console.WriteLine("2 - Texto en Minúscula");
                Console.WriteLine("3 - Texto Original");

                char key = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (key)
                {

                    case '1':
                        Console.WriteLine(text.ToUpper());
                        break;
                    case '2':
                        Console.WriteLine(text.ToLower());
                        break;
                    case '3':
                        Console.WriteLine(text);
                        break;
                    default:
                        Console.WriteLine("Entrada no válida");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Error en la entrada de texto");
            }
            


        }
    }
}
