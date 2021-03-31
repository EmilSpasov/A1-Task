using System.ComponentModel.DataAnnotations;

namespace A1Db.Data.Models
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }

        public double MonthlyFee { get; set; }

        public int NewContractsForMonth { get; set; }

        public int SameContractsForMonth { get; set; }

        public int CancelledContractsForMonth { get; set; }
    }
}
