using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    public class FileNumberSource: INumberSource
    {
        public IEnumerable<int> GetNumbers()
        {
            var result = new List<int>();
            bool isFinished = false;

            do
            {
                var filename = GetFilenameFromUser();
                if (IsValidFilename(filename))
                {
                    var lines = File.ReadAllLines(filename);
                    ParseFileLines(result, lines);
                    isFinished = true;
                }
                else
                {
                    ShowErrorMessage();
                }
            } while (!isFinished);

            return result;
        }

        private void ShowErrorMessage()
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: El fichero introducido no existe.");
            Console.ForegroundColor = oldColor;
        }

        private bool IsValidFilename(string filename)
        {
            return File.Exists(filename);
        }

        private void ParseFileLines(List<int> result, string[] lines)
        {
            foreach (string line in lines)
            {
                if (!String.IsNullOrWhiteSpace(line))
                {
                    if (IsValidNumber(line))
                    {
                        result.Add(int.Parse(line));
                    }
                }
            }
        }

        private bool IsValidNumber(string input)
        {
            int temporaryNumber;
            var isNumber = int.TryParse(input, out temporaryNumber);
            var isAcceptableRange = temporaryNumber >= 0;
            return isNumber && isAcceptableRange;
        }

        private string GetFilenameFromUser()
        {
            Console.Write("Introduzca el nombre del fichero a abrir: ");
            var filename = Console.ReadLine();
            return filename;
        }
    }
}
