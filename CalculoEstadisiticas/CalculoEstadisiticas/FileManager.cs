

namespace CalculoEstadisiticas
{
    using System.Collections.Generic;
    using System.IO;

    public class FileManager
    {
        public string TextReader()
        {
            string line;
            StreamReader file = new System.IO.StreamReader(@"c:\test.txt");
            while((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
            }

            file.Close();

            return line;
        }

    }
}
