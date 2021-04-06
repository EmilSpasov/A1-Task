namespace InvoicesCalculator
{
    public class CalculatorInputModel
    {
        public double MonthlyFee { get; set; }

        public int NumOfSentSms { get; set; }

        public int NumOfSentMms { get; set; }

        public int NotIncludedMinutesToA1 { get; set; }

        public int NotIncludedMinutesToTelenor { get; set; }

        public int NotIncludedMinutesToVivacom { get; set; }

        public int RoumingMinutes { get; set; }

        public double NotIncludedUsedMbInCountry { get; set; }

        public double NotIncludedUsedMbInEu { get; set; }

        public double IncludedUsedMbOutOfEu { get; set; }

        public double OtherTaxes { get; set; }

        public double Discount { get; set; }
    }
}
