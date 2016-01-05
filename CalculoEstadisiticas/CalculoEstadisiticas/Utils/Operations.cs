namespace CalculoEstadisiticas
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Operations
    {
        public static float GetAverage(IEnumerable<float> numList)
        {
           int suma = 0;
           foreach(int number in numList)
           {
               suma += number;
           }
           return suma / numList.Count();
        }
      
        public static double GetStandardDeviation(IEnumerable<float> numList, float averageResult)
        {
            List<float> resultList = new List<float>();
            float poweredAvg;
            foreach (float num in numList)
            {
                resultList.Add(GetPow((num - averageResult), 2));
            }
            poweredAvg = GetAverage(resultList);
            return GetSquareRoot(poweredAvg);
        }

        public static float GetMinValue(IEnumerable<float> numList)
        {
            return GetValues(numList, (a, b) => a < b);
        }

        public static float GetMaxValue(IEnumerable<float> numList)
        {
            return GetValues(numList, (a, b) => a > b);
        }

        private static float GetValues(IEnumerable<float> numList, Func<float, float, bool> compareNumbers)
        {
            float currentNumber = numList.ElementAt(0);

            foreach (int number in numList)
            {
                if (compareNumbers(number, currentNumber))
                {
                    currentNumber = number;
                }
            }
            return currentNumber;
        }

        private static float GetSquareRoot(float num)
        {
            float x = num, x1;
            do
            {
                x1 = x;
                x = (((x * x) + num) / (2 * x));

            } while (x != x1);
            return x;
        }

        private static float GetPow(float numbase, int exponent)
        {
            float result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result = result * numbase;
            }
            return result;
        }
    }
}
