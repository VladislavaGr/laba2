using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double result = calc.Add(5, 3);
            Console.WriteLine("Add Result: " + result);
            result = calc.Mul(5, 3);
            Console.WriteLine("Mul Result: " + result);
        }
    }
}
