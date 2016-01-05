using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculoEstadisticas
{
    public class CalculadoraEstadisticasService
    {
        public double Desviacion(List<int> list)
        {
            //calcular la media. Usamos linQ que esta de moda.
            var media = list.Average();

            //a cada numero le restamos la media y el resultado lo elevamos al cuadrado.
            //usamos la libreria Math para realizar el cuadrado de los numeros.
            //usamos linQ para obtener la suma de todas las operaciones anteriores.
            var suma = list.Sum(number => Math.Pow(number - media, 2));

            //dividimos la suma anterior entre el numero de numeros y hacemos la raiz cuadrada.
            //usamos la liberia Math de nuevo para hacer la raiz cuadrada.
            return Math.Sqrt((suma) / (list.Count()));
        }

        public decimal Promedio(List<int> list)
        {
            //suma de todos los valores / número de valores
            return (list.Sum() / list.Count);
        }
    }
}