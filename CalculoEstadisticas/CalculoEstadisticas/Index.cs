namespace CalculoEstadisticas
{
    using System;
    using System.Collections.Generic;

    class Index
    {
        private static List<int> _list = new List<int>();
        private static GetDataFromConsole _getDataFromConsole = new GetDataFromConsole();
        private static StatisticsCalculator _statisticsCalculator = new StatisticsCalculator();

        public static void Main(string[] args)
        {
            _getDataFromConsole.GetValues(_list);
            _statisticsCalculator.Calculate(_list);
            Console.ReadKey();
        }
    }
}
