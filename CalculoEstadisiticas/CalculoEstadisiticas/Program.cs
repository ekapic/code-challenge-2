using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoEstadisiticas
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        const int exitProgram = 0;

        static void Main(string[] args)
        {
            int op = MainMenu();
            while (op > 0)
            {
                switch (op)
                {
                    case 1:
                        break;
                    case 2:
                        break;

                    default:
                        Console.WriteLine("Por favor entra un valor existente en el menú");
                        break;
                }
            }
        }

        static int MainMenu()
        {
            int option = 0;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1.-Introducción manual de datos");
            Console.WriteLine("2.-Lectura de fichero de datos");
            Console.WriteLine("0.-Salir");
            Console.WriteLine("-----------------------------------");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
