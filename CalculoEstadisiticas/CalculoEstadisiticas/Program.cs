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
        const int exitNumber = 0;
        const string exitExpression = "done";

        static void Main(string[] args)
        {            
            IEnumerable<int> numbers;
            int op = MainMenu();

            while (op > exitNumber)
            {
                switch (op)
                {
                    case 1:
                        numbers = InsertNumbers();
                        Operations.GetMedia(numbers);
                        break;
                    case 2:
                        break;

                    default:
                        Console.WriteLine("Por favor entra un valor existente en el menú");
                        break;
                }
                op = MainMenu();
                Console.Clear();
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
            option = InputValidator.GetNumeric(Console.ReadLine());
            return option;
        }

        static List<int> InsertNumbers()
        {
            string stringInput = String.Empty;
            List<int> numArray = new List<int>();
            do
            {
                Console.WriteLine("Introduzca un número o ponga 'done' para finalizar");
                stringInput = Console.ReadLine();
                if(stringInput != exitExpression)
                {
                    numArray.Add(InputValidator.GetNumeric(stringInput));
                }
                
            } while (stringInput != exitExpression);
            return numArray;
        }
    }
}
