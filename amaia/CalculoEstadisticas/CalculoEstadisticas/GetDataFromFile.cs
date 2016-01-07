namespace CalculoEstadisticas
{
    using Utils;
    using System;
    using System.IO;
    using System.Collections.Generic;

    public class GetDataFromFile
    {
        private List<int> _list;
        private bool isValid = true;
        private Helpers _helper = new Helpers();

        public void ReadValues(List<int> list)
        {
            this._list = list;
            Console.WriteLine(Constants.FileText.PathFileText);
            OpenAndReadFile();
            this._helper.PrintValues(this._list);
        }

        private void OpenAndReadFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(new FileStream(Constants.FileText.PathFile, FileMode.Open)))
                {
                    var line = string.Empty;

                    while (sr.Peek() != -1)
                    {
                        line = sr.ReadLine();
                        isValid = this._helper.CheckValues(line, this._list, $"{line} {Constants.Errors.ErrorFileData}");

                        if (!isValid)
                        {
                            this._list.Clear();
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(Constants.Errors.FileNotFound);
                Console.WriteLine(e.Message);
            }
        }
    }
}
