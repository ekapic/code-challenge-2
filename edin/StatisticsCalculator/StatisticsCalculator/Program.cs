using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    public class Program
    {
        static void Main(string[] args)
        {
            InputType inputType = GetInputTypeFromUser();
            
            INumberSource numbersSource = NumberProviderFactory.MakeNumberSource(inputType);

            IEnumerable<int> numbersToProcess = numbersSource.GetNumbers();
            DisplayNumbers(numbersToProcess);
            var calculator = new StatisticsCalculator();
            var statistics = calculator.CalculateStatistics(numbersToProcess);
            DisplayStatistics(statistics);

            Console.ReadLine();
        }

        private static InputType GetInputTypeFromUser()
        {
            InputType result = InputType.Manual;
            bool isValidInput = false;
            string userResponse = String.Empty;
            do
            {
                Console.Write("¿Desea introducir los números manualmente (M) o mediante un fichero (F)?");
                userResponse = Console.ReadLine();
                isValidInput = ValidateInputType(userResponse);

            } while (!isValidInput);

            switch (userResponse.ToLowerInvariant())
            {
                case "m":
                    result = InputType.Manual;
                    break;
                case "f":
                    result = InputType.File;
                    break;
            }

            return result;
        }

        private static bool ValidateInputType(string userResponse)
        {
            var isValid = false;
            if (userResponse.ToLowerInvariant() == "m" || userResponse.ToLowerInvariant() == "f")
            {
                isValid = true;
            }
            return isValid;
        }


        private static void DisplayStatistics(StatisticsResult statistics)
        {
            var avgText = statistics.Average.ToString();
            var minText = statistics.Min.ToString();
            var maxText = statistics.Max.ToString();
            var stdText = statistics.StandardDeviation.ToString();

            Console.WriteLine("El promedio es {0}.", avgText);
            Console.WriteLine("El mínimo es {0}.", minText);
            Console.WriteLine("El máximo es {0}.", maxText);
            Console.WriteLine("La desviación estándar es {0}.", stdText);
        }

        private static void DisplayNumbers(IEnumerable<int> numbersToProcess)
        {
            bool isFirst = true;

            Console.Write("Números: ");
            foreach (var number in numbersToProcess)
            {
                if (!isFirst)
                {
                    Console.Write(", ");
                }
                
                string numberToDisplay = number.ToString();
                Console.Write(numberToDisplay);

                isFirst = false;
            }
            Console.WriteLine();
        }
    }
}
