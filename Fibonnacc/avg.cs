using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnacc
{
    public class avg
    {
        public double CalculateAverage(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return (double)sum / array.Length;
        }
    }

}
