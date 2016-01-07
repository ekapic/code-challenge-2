using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    public class StatisticsCalculator
    {
        public StatisticsResult CalculateStatistics(IEnumerable<int> values)
        {
            if (IsArgumentEmpty(values))
            {
                throw new ArgumentNullException("La colección tiene que contener al menos un número.");
            }

            var result = ProcessCollectionStatistics(values);

            return result;
        }

        private StatisticsResult ProcessCollectionStatistics(IEnumerable<int> values)
        {
            var result = this.FindMinMaxAverage(values);

            result.StandardDeviation = this.FindStandardDeviation(values, result.Average);

            return result;
        }

        private decimal FindStandardDeviation(IEnumerable<int> values, decimal average)
        {
            // calcular la diferencia de la media para cada valor, elevarla al cuadrado, 
            // hacer una media de las diferencias al cuadrado y sacar la raíz cuadrada de la media. 
            double runningTotal = 0;
            int count = 0;

            foreach (var value in values)
            {
                var diffFromAverage = (double) (value - average);
                var diffSquared = Math.Pow(diffFromAverage, 2);
                runningTotal += diffSquared;
                count++;
            }

            double mean = runningTotal / count;
            var stdDev = Math.Sqrt(mean);
            return Math.Round((decimal)stdDev, 2);
        }

        private StatisticsResult FindMinMaxAverage(IEnumerable<int> values)
        {
            var minValue = values.First();
            var maxValue = values.First();
            int runningTotal = 0;
            int count = 0;


            foreach (var value in values)
            {
                if (value < minValue)
                {
                    minValue = value;
                }

                if (value > maxValue)
                {
                    maxValue = value;
                }

                runningTotal += value;
                count++;
            }

            var avg = Math.Round( (decimal) (runningTotal / count), 2);

            return new StatisticsResult()
            {
                Min = minValue,
                Max = maxValue,
                Average = avg
            };
        }


        private static bool IsArgumentEmpty(IEnumerable<int> values)
        {
            var isNull = values == null;
            var isEmpty = values.Count() == 0;
            return  (isNull || isEmpty);
        }
    }
}
