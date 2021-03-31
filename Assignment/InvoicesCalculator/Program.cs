using System;

namespace InvoicesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Calculator();

            Console.WriteLine(invoice.Calculate(9.99m, 2, 0, 15, 6, 32, 0, 0, 0, 0, 1.99m, 1.50m));
        }
    }
}
