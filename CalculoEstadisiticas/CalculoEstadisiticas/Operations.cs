using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoEstadisiticas
{
    public static class Operations
    {
        public static float GetMedia(IEnumerable<int> numList)
        {
           int suma = 0;
           foreach(int number in numList)
           {
               suma += number;
           }
           return suma / numList.Count();
        }

        //public static float GetMaxMin(IEnumerable<int> numList)
        //{
        //    int[] vector1 = numList.ToArray();
        //    int[] vector2 = numList.ToArray();

        //    int min = vector1[0];
        //    int max = vector2[0];
        //}
    }
}
