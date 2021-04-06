namespace InvoicesCalculator
{
    public class Calculator
    {
        public decimal Calculate(CalculatorInputModel input)
        {
            var result = (decimal)input.MonthlyFee;

            //Add Sms Price
            result += CalculateSmsPrice(input.NumOfSentSms) * input.NumOfSentSms;

            //Add Mms Price
            result += CalculateMmsPrice(input.NumOfSentMms) * input.NumOfSentMms;

            result += input.NotIncludedMinutesToA1 * 0.03m;

            result += input.NotIncludedMinutesToTelenor * 0.09m;

            result += input.NotIncludedMinutesToVivacom * 0.09m;

            result += input.RoumingMinutes * 0.15m;

            result += (decimal)input.NotIncludedUsedMbInCountry * 0.02m;

            result += (decimal)input.NotIncludedUsedMbInEu * 0.05m;

            result += (decimal)input.IncludedUsedMbOutOfEu * 0.20m;

            result += (decimal)input.OtherTaxes;

            result -= (decimal)input.Discount;

            return result;
        }

        private decimal CalculateMmsPrice(int numOfSentMms)
        {
            if (numOfSentMms < 50)
            {
                return 0.25m;
            }
            if (numOfSentMms <= 100)
            {
                return 0.23m;
            }

            return 0.18m;
        }

        private decimal CalculateSmsPrice(int numOfSentSms)
        {
            if (numOfSentSms < 50)
            {
                return 0.18m;
            }
            if (numOfSentSms <= 100)
            {
                return 0.16m;
            }

            return 0.11m;
        }
    }
}
