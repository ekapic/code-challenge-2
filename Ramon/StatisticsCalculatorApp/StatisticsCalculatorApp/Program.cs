using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Resource.Apptitle);
            var inputValue = string.Empty;
            var numberList = new List<int>();

            while(true)
            {
                AskForValue(Resource.EnterValue, ref inputValue);
               
                while (!InputValidator.Validate(InputTypes.Number, inputValue))
                {
                    if (isAppFinished(inputValue))
                    {
                        goto skipProcess;
                    }

                    AskForValue(Resource.EnterValidValue, ref inputValue);                  
                }

                numberList.Add(int.Parse(inputValue));
            }

            skipProcess: AskToContinue();

            if (isListEmpty(numberList))
            {
                PrintResult(Resource.NoValuesMsg);
                goto end;
            }

            PrintResult(Resource.NumbersMsg, String.Join(", ", numberList));
            PrintResult(Resource.AverageMsg, numberList.ArithmeticMean().ToString());
            PrintResult(Resource.MaximumMsg, numberList.Maximum().ToString());
            PrintResult(Resource.MinimumMsg, numberList.Minimum().ToString());
            PrintResult(Resource.StdDeviationMsg, numberList.StandardDeviation().ToString());

            end: Console.ReadKey();
        }

        #region Private Methods
        private static bool isAppFinished(string value)
        {
            return value.ToLower().Equals(Resource.Done);
        }

        private static bool isListEmpty(List<int> list)
        {
            return list.Count == 0;
        }

        private static void PrintResult(string message, string result = null)
        {
            Console.WriteLine(String.Format(message + "{0}", result));
        }

        private static void AskForValue(string questionMsg, ref string value )
        {
            Console.WriteLine(Resource.EnterValue);
            value = Console.ReadLine();
        }

        private static void AskToContinue()
        {
            Console.WriteLine(Resource.EnterKeyToContinue);
            Console.ReadKey();
            Console.Clear();
        }

        #endregion
    }
}
