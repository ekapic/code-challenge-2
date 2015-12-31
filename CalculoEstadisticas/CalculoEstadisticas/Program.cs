namespace CalculoEstadisticas
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string value;
            int output;
            var list = new List<int>();

            Console.WriteLine("**** CALCULO DE ESTADISTICAS ****");
            Console.WriteLine();
            Console.WriteLine();

            do
            {
                Console.Write("Escribe un numbero: ");
                value = Console.ReadLine();
                if (Int32.TryParse(value, out output) && output >= 0)
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
            }
            while (value != "done");

            if (list.Count > 0)
            {
                Console.WriteLine();
                Console.Write("Números: ");
                foreach (var number in list)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("El numero promedio es: " + Promedio(list).ToString());
                Console.WriteLine("El numero mínimo es: " + list.Min().ToString());
                Console.WriteLine("El numero máximo es: " + list.Max().ToString());
                Console.WriteLine("La desviación estándar es: " + Desviacion(list).ToString());
            }
            else
            {
                Console.WriteLine("No has introducido nungún número");
            }
        }

        private static double Desviacion(List<int> list)
        {
            //calcular la media. Usamos linQ que esta de moda.
            double media = list.Average();

            //a cada numero le restamos la media y el resultado lo elevamos al cuadrado.
            //usamos la libreria Math para realizar el cuadrado de los numeros.
            //usamos linQ para obtener la suma de todas las operaciones anteriores.
            double suma = list.Sum(number => Math.Pow(number - media, 2));

            //dividimos la suma anterior entre el numero de numeros y hacemos la raiz cuadrada.
            //usamos la liberia Math de nuevo para hacer la raiz cuadrada.
            return Math.Sqrt((suma) / (list.Count()));
        }

        private static decimal Promedio(List<int> list)
        {
            //suma de todos los valores / número de valores
            return (list.Sum() / list.Count);
        }
    }
}

//Restricciones

//Utilizar sólo bucles y colecciones matriciales (arrays, listas) para recoger los números y hacer los cálculos matemáticos
//Impedir que el usuario entre valores no numéricos para los parámetros
//Convertir de manera explícita los valores numéricos de salida a strings
//Vigilar de no introducir el "done" como uno de los elementos de la matriz de entrada
//Vigilar de que el programa resultante esté debidamente encapsulado en clases y métodos públicos y privados

//Para nota

//Leer los números de un fichero de texto en vez de pedirlos en el bucle
//Preguntar al usuario si se usará un fichero o la introducción manual de datos