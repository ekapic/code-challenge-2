using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    public class ConsoleNumberSource: INumberSource
    {
        public IEnumerable<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            bool isDone = false;

            do
            {
                var input = GetInputFromUser();

                if (IsDone(input))
                {
                    isDone = true;
                    break;
                }

                if (IsValidNumber(input))
                {
                    numbers.Add(int.Parse(input));
                }
                else
                {
                    ShowErrorMessage();
                }
            } while (!isDone);


            return numbers;
        }

        private static bool IsDone(string input)
        {
            return input.ToLowerInvariant() == "done";
        }

        private void ShowErrorMessage()
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: El texto introducido no es un número válido (o 'done').");
            Console.ForegroundColor = oldColor;
        }

        private bool IsValidNumber(string input)
        {
            int temporaryNumber;
            var isNumber = int.TryParse(input, out temporaryNumber);
            var isAcceptableRange = temporaryNumber >= 0;
            return isNumber && isAcceptableRange;
        }

        private static string GetInputFromUser()
        {
            Console.Write("Introduzca un número: ");
            var input = Console.ReadLine();
            return input.Trim();
        }
    }
}
