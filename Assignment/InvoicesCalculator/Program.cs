using System;

namespace InvoicesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Calculator();

            var input = new CalculatorInputModel
            {
                MonthlyFee = 9.99,
                NumOfSentSms = 2,
                NumOfSentMms = 0,
                NotIncludedMinutesToA1 = 15,
                NotIncludedMinutesToTelenor = 6,
                NotIncludedMinutesToVivacom = 32,
                RoumingMinutes = 0,
                NotIncludedUsedMbInCountry = 0,
                NotIncludedUsedMbInEu = 0,
                IncludedUsedMbOutOfEu = 0,
                OtherTaxes = 1.99,
                Discount = 1.50,
            };

            Console.WriteLine(invoice.Calculate(input));
        }
    }
}
