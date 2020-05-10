using System;

namespace LeagueManager.Financial.Models
{
    public class Payment
    {
        public DateTime PaidOn { get; set; }
        public Payer PaidBy { get; set; } = null!;
        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string CreditCardNumber { get; set; } = string.Empty;
        public string CreditCardExpiration { get; set; } = string.Empty;
        public string CheckNumber { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
