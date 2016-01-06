namespace CalculoEstadisticas
{
    using Utils;
    using System;
    using System.Collections.Generic;

    class Index
    {
        private static List<int> _list = new List<int>();
        private static GetDataFromConsole _getDataFromConsole = new GetDataFromConsole();
        private static GetDataFromFile _getDataFromFile = new GetDataFromFile();
        private static StatisticsCalculator _statisticsCalculator = new StatisticsCalculator();

        public static void Main(string[] args)
        {
            Console.WriteLine(Constants.SelectFileOrConsole.SelectFileOrConsoleText);
            var option = Console.ReadLine();
            bool isValid = false;
            while (!isValid)
            {
                switch (option)
                {
                    case Constants.SelectFileOrConsole.Console:
                        _getDataFromConsole.GetValues(_list);
                        isValid = true;
                        break;
                    case Constants.SelectFileOrConsole.File:
                        _getDataFromFile.ReadValues(_list);
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine(Constants.Errors.ErrorIntroduceData);
                        option = Console.ReadLine();
                        break;
                }
            }
            _statisticsCalculator.Calculate(_list);
            Console.ReadKey();
        }
    }
}
