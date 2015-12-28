

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
                Console.WriteLine("Introduce un numero decimal");
                readLine = Console.ReadLine();
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
                Console.WriteLine("Introduce un numero entero");
                readLine = Console.ReadLine();
                isInteger = int.TryParse(readLine, out number);
            }
            return number;
        }
    }
}
