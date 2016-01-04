

namespace CalculoEstadisiticas
{
    using System;

    static class InputValidator
    {
        static public bool IsDecimal(string readLine)
        {
            float number;
            bool isDecimal = float.TryParse(readLine, out number);
            return isDecimal;
        }

        static public bool IsInteger(string readLine)
        {
            int number;
            bool isInteger = int.TryParse(readLine, out number);
            return isInteger;
        }
        
    }
}
