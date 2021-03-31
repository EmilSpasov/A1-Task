namespace InvoicesCalculator
{
    public class Calculator
    {
        public decimal Calculate(decimal monthlyFee,
            int numOfSentSms,
            int numOfSentMms,
            int notIncludedMinutesToA1,
            int notIncludedMinutesToTelenor,
            int notIncludedMinutesToVivacom,
            int roumingMinutes,
            decimal notIncludedUsedMbInCountry,
            decimal notIncludedUsedMbInEu,
            decimal includedUsedMbOutOfEu,
            decimal otherTaxes,
            decimal discount)
        {
            var result = monthlyFee;

            //Add Sms Price
            result += CalculateSmsPrice(numOfSentSms) * numOfSentSms;

            //Add Mms Price
            result += CalculateMmsPrice(numOfSentMms) * numOfSentMms;

            result += notIncludedMinutesToA1 * 0.03m;

            result += notIncludedMinutesToTelenor * 0.09m;

            result += notIncludedMinutesToVivacom * 0.09m;

            result += roumingMinutes * 0.15m;

            result += notIncludedUsedMbInCountry * 0.02m;

            result += notIncludedUsedMbInEu * 0.05m;

            result += includedUsedMbOutOfEu * 0.20m;

            result += otherTaxes;

            result -= discount;

            return result;
        }

        private decimal CalculateMmsPrice(int numOfSentMms)
        {
            if (numOfSentMms < 50)
            {
                return 0.25m;
            }
            else if (numOfSentMms <= 100)
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
            else if (numOfSentSms <= 100)
            {
                return 0.16m;
            }

            return 0.11m;
        }
    }
}
