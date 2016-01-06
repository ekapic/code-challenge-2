using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsCalculatorApp
{
    public static class ListExtensions
    {
        public static int Minimum(this IList<int> self)
        {
            int min = self[0];
            int minIndex = 0;

            for (int i = 1; i < self.Count; ++i)
            {
                if (self[i] < min)
                {
                    min = self[i];
                    minIndex = i;
                }
            }

            return self[minIndex];
        }

        public static int Maximum(this IList<int> self)
        {
            int max = self[0];
            int maxIndex = 0;

            for (int i = 1; i < self.Count; ++i)
            {
                if (self[i] > max)
                {
                    max = self[i];
                    maxIndex = i;
                }
            }

            return self[maxIndex];
        }

        public static double ArithmeticMean(this IList<int> self)
        {            
            double aggregate = 0;
            foreach (var number in self)
            {
                aggregate += number;
            }

            return (aggregate / self.Count);
        }

        public static double StandardDeviation(this IList<int> self)
        {
            double average = self.ArithmeticMean();
            double sumOfDerivation = 0;
            double sumOfDerivationAverage = 0;

            foreach (double value in self)
            {
                double diffAvg = value - average;
                sumOfDerivation += (diffAvg) * (diffAvg);
            }

            sumOfDerivationAverage = sumOfDerivation / (self.Count -1);

            return Math.Sqrt(sumOfDerivationAverage);
        }
    }

}
