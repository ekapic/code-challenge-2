namespace CalculoEstadisticas
{
    using Utils;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GetDataFromConsole
    {
        private List<int> _list;
        private Helpers _helper = new Helpers();

        public void GetValues(List<int> list)
        {
            _list = list;
            InputValues();
            this._helper.PrintValues(this._list);
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
                this._helper.CheckValues(value, this._list, Constants.Errors.ErrorIntroduceData);

            } while (!value.ToUpper().Equals(Constants.Done));
        }

        #endregion Private Methods
    }
}