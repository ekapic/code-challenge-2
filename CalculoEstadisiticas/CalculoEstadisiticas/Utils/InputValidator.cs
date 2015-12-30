

namespace CalculoEstadisiticas
{
    using System;

    static class InputValidator
    {
        static public float GetDecimal(string readLine)
        {
            float number;
            bool isDecimal = float.TryParse(readLine,out number);
            while (!isDecimal || number < 0)
            {
                readLine = AskNumber();
                isDecimal = float.TryParse(readLine, out number);
            }
            return number;
        }

        static public int GetInteger(string readLine)
        {
            int number;
            bool isInteger = int.TryParse(readLine,out number);
            while (!isInteger || number < 0)
            {
                readLine = AskNumber();
                isInteger = int.TryParse(readLine, out number);
            }
            return number;
        }
        
        static private string AskNumber()
        {
            string readLine = string.Empty;
            Console.WriteLine("Introduce un numero valido");
            readLine = Console.ReadLine();
            return readLine;
        }

    }
}
