using System;

namespace LeagueManager.Financial.Models
{
    public class Payment
    {
        public DateTime PaidOn { get; set; }
        public Payer PaidBy { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardExpiration { get; set; }
        public string CheckNumber { get; set; }
        public string Notes { get; set; }
    }
}
