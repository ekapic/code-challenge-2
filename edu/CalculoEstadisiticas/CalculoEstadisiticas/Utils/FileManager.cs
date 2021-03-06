﻿

namespace CalculoEstadisiticas
{
    using System.Collections.Generic;
    using System.IO;
    using System;

    public class FileManager
    {
        public string TextReader(string fileroute)
        {
            string line = string.Empty;
            string sequence = string.Empty;
            try
            {
                StreamReader file = new System.IO.StreamReader(fileroute);
                while((line = file.ReadLine()) != null)
                {
                    sequence += line;
                }
                file.Close();
                return sequence;
            }
            catch(Exception ex)
            {
                Console.WriteLine(string.Format("Error al leer en fichero: {0}", ex.Message));
                return string.Empty;
            }
        }

        public void TextWriter(string text, string fileroute)
        {
            try
            {
                if(!string.IsNullOrEmpty(text))
                {

                    StreamWriter sw = new StreamWriter(Constants.textfileRoute);
                    sw.WriteLine(text);
                    sw.Close();
                }
                else
                {
                    throw new System.ArgumentException();
                }               
            }
            catch(Exception ex)
            {
                Console.WriteLine(string.Format("Error al escribir en fichero: {0}",ex.Message));
            }
        }

    }
}
