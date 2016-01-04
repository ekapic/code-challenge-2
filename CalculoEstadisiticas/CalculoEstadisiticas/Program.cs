namespace CalculoEstadisiticas
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    class Program
    {
        private static void Main(string[] args)
        {            
            IEnumerable<float> numbers;
            string readLine = String.Empty;
            FileManager filemanager = new FileManager();
            int op = MainMenu();

            while (op > Constants.exitNumber)
            {
                switch (op)
                {
                    case 1:
                        numbers = InsertNumbers();
                        ShowResult(numbers);
                        filemanager.TextWriter(string.Join(Constants.textNumberSeparator, numbers), Constants.textfileRoute);
                        break;
                    case 2:
                        readLine = filemanager.TextReader(Constants.textfileRoute);
                        if(!string.IsNullOrEmpty(readLine))
                        {
                            var aux = readLine.Split('-');
                            numbers = aux.Select(x => float.Parse(x)).ToList();
                            ShowResult(numbers);
                        }
                        break;

                    default:
                        Console.WriteLine("Por favor entra un valor existente en el menú");
                        break;
                }
                op = MainMenu();
            }
        }

        private static int MainMenu()
        {
            string input = string.Empty;
            int option = 0;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1.-Introducción manual de datos");
            Console.WriteLine("2.-Lectura de fichero de datos");
            Console.WriteLine("0.-Salir");
            Console.WriteLine("-----------------------------------");

            input = Console.ReadLine();
            while (!InputValidator.IsInteger(input))
            {
                input = AskNumber();
            }
            option = int.Parse(input);

            return option;
        }

        private static List<float> InsertNumbers()
        {
            string stringInput = String.Empty;
            List<float> numArray = new List<float>();
            do
            {
                Console.WriteLine("Introduzca un número o escriba "+Constants.exitExpression+" para finalizar");
                stringInput = Console.ReadLine();
                if(stringInput != Constants.exitExpression)
                {
                    while(!InputValidator.IsDecimal(stringInput))
                    {
                        stringInput = AskNumber();
                    }
                    numArray.Add(float.Parse(stringInput));
                }
                
            } while (stringInput != Constants.exitExpression);

            return numArray;
        }

        private static void ShowResult(IEnumerable<float> numbers)
        {
            float averageresult = Operations.GetAverage(numbers);
            Console.WriteLine(string.Format("Los numeros introducidos son: {0}", String.Join("-",numbers)));
            Console.WriteLine("El promedio es: " + averageresult.ToString(Constants.decimalFormat));
            Console.WriteLine(Operations.GetMaxMin(numbers));
            Console.WriteLine(string.Format("La desviacion standard es: {0}", Operations.GetStandardDeviation(numbers, averageresult).ToString(Constants.decimalFormat)));
        }

        private static string AskNumber()
        {
            string readLine = string.Empty;
            Console.WriteLine("Introduce un numero valido");
            readLine = Console.ReadLine();
            return readLine;
        }
    }
}
