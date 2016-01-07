namespace CalculoEstadisticas.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Helpers
    {
        public bool CheckValues(string value, List<int> list, string error)
        {
            if (value.ToUpper().Equals(Constants.Done)) { return false; }

            if (value.IsIntegerAndGreaterThanZero())
            {
                list.Add(int.Parse(value));
                return true;
            }
            else
            {
                Console.WriteLine(error);
                return false;
            }
        }

        public void PrintValues(List<int> list)
        {
            Console.WriteLine($"{Constants.ConsoleText.PrintNumers} {string.Join(", ", list)}");
        }
    }
}
