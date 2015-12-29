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

        public static string GetMaxMin(IEnumerable<float> numList)
        {
            float max = numList.ElementAt(0);
            float min = numList.ElementAt(0);
            string result = String.Empty;

            foreach(int number in numList)
            {
                if(number > max)
                {
                    max = number;
                }
                else if(number < min)
                {
                    min = number;
                }
            }
            result = string.Format("El valor mínimo es: {0} y el máximo es: {1}", min,max);
            return result; 
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
