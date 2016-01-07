namespace CalculoEstadisticas.Utils
{
    using System.Collections.Generic;
    using System.Linq;

    public static class ListExtension
    {
        #region Public Methods

        public static double CalculateAverage(this List<int> list)
        {
            var sum = 0;
            list.ForEach(x => sum += x);
            return (double)sum / list.Count();
        }

        public static int CalculateMin(this List<int> list)
        {
            var min = int.MaxValue;
            list.ForEach(x => min = x < min ? x : min);
            return min;
        }

        public static int CalculateMax(this List<int> list)
        {
            var max = int.MinValue;
            list.ForEach(x => max = x > max ? x : max);
            return max;
        }

        public static double CalculateStandardDeviation(this List<int> list)
        {
            var avgList = CalculateAvgAndValueDiffAndPow(list);
            var avgFromDiff = CalculateAvgForDiffList(avgList);
            return CalculateSquare(avgFromDiff);
        }

        #endregion Public Methods

        #region Private Methods

        private static List<double> CalculateAvgAndValueDiffAndPow(List<int> list)
        {
            var avg = list.CalculateAverage();
            var avgList = new List<double>();
            list.ForEach(x => avgList.Add((avg - x) * (avg - x)));
            return avgList;
        }

        private static double CalculateAvgForDiffList(List<double> list)
        {
            var sum = 0.0;
            list.ForEach(x => sum += x);
            return (double)sum / list.Count();
        }

        private static double CalculateSquare(double value)
        {
            if (value == 0) { return 0.0; }
            double t;
            double squareRoot = value / 2;
            do
            {
                t = squareRoot;
                squareRoot = ((t + (value / t)) / 2);
            } while ((t - squareRoot) != 0);

            return squareRoot;
        }

        #endregion Private Methods
    }
}
