//Restricciones

//Utilizar sólo bucles y colecciones matriciales (arrays, listas) para recoger los números y hacer los cálculos matemáticos
//Impedir que el usuario entre valores no numéricos para los parámetros
//Convertir de manera explícita los valores numéricos de salida a strings
//Vigilar de no introducir el "done" como uno de los elementos de la matriz de entrada
//Vigilar de que el programa resultante esté debidamente encapsulado en clases y métodos públicos y privados

//Para nota

//Leer los números de un fichero de texto en vez de pedirlos en el bucle
//Preguntar al usuario si se usará un fichero o la introducción manual de datos

namespace CalculoEstadisticas
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    internal class Program
    {
        private static readonly Validator Validator = new Validator();
        private static readonly CalculadoraEstadisticasService EstadisticasService = new CalculadoraEstadisticasService();

        private static void Main(string[] args)
        {
            var list = new List<int>();
            var salir = false;

            Console.WriteLine("**** CALCULO DE ESTADISTICAS ****");
            Console.WriteLine();
            Console.WriteLine();

            do
            {
                Console.WriteLine("¿Usara un fichero o introducira los datos manualmente?");
                Console.WriteLine("1 - Fichero");
                Console.WriteLine("2 - Manualmente. Introduzca 'done' para finalizar");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        GetDataFromFile(list);
                        salir = true;
                        break;
                    case "2":
                        GetInputData(list);
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                }
            } while (salir == false);

            GetResults(list);
        }

        private static void GetDataFromFile(List<int> list)
        {
            var streamReader = new StreamReader(new FileStream("numbers.txt", FileMode.Open));
            var line = streamReader.ReadLine();

            if (line != null)
            {
                var values = line.Split(';');
                var number = 0;
                list.AddRange(from value in values where Validator.IsValidNumber(value, out number) && number >= 0 select number);
            }
        }

        private static void GetResults(List<int> list)
        {
            if (list.Count > 0)
            {
                PrintNumbers(list);
                PrintStadisticResults(list);
            }
            else
            {
                Console.WriteLine("No has introducido nungún número, no hay estadisticas");
            }
        }

        private static void PrintStadisticResults(List<int> list)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("El numero promedio es: " + EstadisticasService.Promedio(list).ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine("El numero mínimo es: " + list.Min());
            Console.WriteLine("El numero máximo es: " + list.Max());
            Console.WriteLine("La desviación estándar es: " + EstadisticasService.Desviacion(list).ToString("0.00", CultureInfo.InvariantCulture));
        }

        private static void PrintNumbers(IEnumerable<int> list)
        {
            Console.WriteLine();
            Console.Write("Números: ");
            foreach (var number in list)
            {
                Console.Write(number + " ");
            }
        }

        private static void GetInputData(ICollection<int> list)
        {
            string value;
            do
            {
                Console.Write("Escribe un numbero: ");
                value = Console.ReadLine();
                int output;
                if (Validator.IsValidNumber(value, out output) && output >= 0)
                {
                    list.Add(output);
                }
                else
                {
                    if (value != "done")
                    {
                        Console.WriteLine("No es un número valido");
                    }
                }
            } while (value != "done");
        }
    }
}