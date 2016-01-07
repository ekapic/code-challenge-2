namespace CalculoEstadisticas
{
    using System;
    using System.Collections.Generic;
    using Utils;

    public class StatisticsCalculator
    {
        private List<int> _list;

        public void Calculate(List<int> list)
        {
            this._list = list;
            if (ArrayHasNotValues())
            {
                Console.WriteLine(Constants.StatisticsText.NotValuesInArray);
                return;
            }

            Console.WriteLine(Constants.StatisticsText.Separator);
            this.Average();
            this.Min();
            this.Max();
            this.StandardDeviation();
        }

        #region Private Methods
        private bool ArrayHasNotValues()
        {
            return this._list.Count == 0;
        }

        private void Average()
        {
            var avg = this._list.CalculateAverage();
            Console.WriteLine(string.Format($"{Constants.StatisticsText.Average} {avg}"));
        }

        private void Min()
        {
            var min = this._list.CalculateMin();
            Console.WriteLine(string.Format($"{Constants.StatisticsText.Min} {min}"));
        }

        private void Max()
        {
            var max = this._list.CalculateMax();
            Console.WriteLine(string.Format($"{Constants.StatisticsText.Max} {max}"));
        }

        private void StandardDeviation()
        {
            var sd = this._list.CalculateStandardDeviation();
            Console.WriteLine(string.Format($"{Constants.StatisticsText.StandardDeviation} {sd}"));
        }
       
        #endregion Private Methods
    }
}
