using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сreate an anonymous method that accepts three integer arguments and returns their average arithmetic value
            Func<int, int, int, double> average = delegate (int a, int b, int c)
            {
                return (double)(a + b + c) / 3;
            };

            // Call the method
            double result = average(100, 68, 14);

            Console.WriteLine($"Середнє арифметичне значення: {result}");
        }
    }
}
