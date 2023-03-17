using Fibonnacc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonnacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("Derinliğini giriniz: ");
            int length = Convert.ToInt32(Console.ReadLine());

            FibonacciCalculator fbc = new FibonacciCalculator();
            avg average = new avg();

            int[] fSeries = fbc.CalculateFibonacciSeries(length);

            foreach (var item in fSeries)
            {
                Console.Write(item + " ");
            }

            double averageResult = average.CalculateAverage(fSeries);

            Console.WriteLine(" \n\n\n Fibonacci serisinin ortalaması: " + averageResult);
            

        }
    }
}
