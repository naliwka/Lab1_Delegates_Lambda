using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array with three delegates that return a random value of type int
            Random random = new Random();

            Func<int>[] methods = {
                () => random.Next(100),
                () => random.Next(100),
                () => random.Next(100)
            };

            // Create an anonymous method that accepts an array of delegates and returns the average arithmetic value
            Func<Func<int>[], double> average = delegate (Func<int>[] delegates)
            {
                int sum = 0;
                foreach (var method in delegates)
                {
                    sum += method();
                }
                return (double)sum / delegates.Length;
            };

            // Call an anonymous method with an array of delegates
            double result = average(methods);
            Console.WriteLine($"Average arithmetic value: {result}");
        }
    }
}
