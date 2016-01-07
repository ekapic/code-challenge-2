using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsCalculatorApp
{
    public static class InputValidator
    {
        public static bool Validate(InputTypes type, string value)
        {
            int number;
            bool result = false;

            switch (type)
            {
                case InputTypes.Number:
                    result = (int.TryParse(value, out number) && number > 0)  ? true : false;
                    break;               
            }

            return result;
        }
    }

    public enum InputTypes
    {
        Number     
    }
}

