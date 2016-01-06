namespace CalculoEstadisticas
{
    using Utils;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GetDataFromConsole
    {
        private List<int> _list;

        public void GetValues(List<int> list)
        {
            _list = list;
            InputValues();
            PrintValues();
        }

        #region Private Methods

        private void InputValues()
        {
            Console.WriteLine(Constants.ConsoleText.Separator);
            Console.WriteLine(Constants.ConsoleText.StartProgram);
            Console.WriteLine(Constants.ConsoleText.FinalizeProgram);
            Console.WriteLine(Constants.ConsoleText.Separator);
            String value;
            do
            {
                Console.Write($"{Constants.ConsoleText.IntroduceData} ");
                value = Console.ReadLine();
                CheckValues(value);
            } while (!value.ToUpper().Equals(Constants.Done));
        }

        private void CheckValues(string value)
        {
            if (value.ToUpper().Equals(Constants.Done)) { return; }

            if (value.IsIntegerAndGreaterThanZero())
            {
                this._list.Add(int.Parse(value));
            }
            else
            {
                Console.WriteLine(Constants.Errors.ErrorIntroduceData);
            }
        }

        private void PrintValues()
        {
            Console.Write(Constants.ConsoleText.PrintNumers);
            Console.WriteLine(string.Join(",", this._list));
        }

        #endregion Private Methods
    }
}