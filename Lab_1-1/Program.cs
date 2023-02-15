using System;

namespace Lab_1_1
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers:\na = ");
            double a  = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the arithmetic mark - ");
            char mark = Convert.ToChar(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            switch (mark)
            {
                case '+':
                    {
                        Console.WriteLine(Add(a, b));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(Sub(a, b));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(Mul(a, b));
                        break;
                    }
                case '/':
                    {
                        if 
                            (b != 0) Console.WriteLine(Div(a, b)); 
                        else 
                            Console.WriteLine("It’s impossible to divide by zero.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Entered incorrect mark.");
                        break;
                    }
            }
            double Add(double x, double y) => x + y;
            double Sub(double x, double y) => x - y;
            double Mul(double x, double y) => x * y;
            double Div(double x, double y) => x / y;
        }
    }
}
