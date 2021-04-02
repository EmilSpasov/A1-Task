using System;

namespace InvoicesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Calculator();

            Console.WriteLine(invoice.Calculate(9.99, 2, 0, 15, 6, 32, 0, 0, 0, 0, 1.99, 1.50));
        }
    }
}
