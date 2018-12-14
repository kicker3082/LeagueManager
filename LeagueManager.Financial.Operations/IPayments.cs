using LeagueManager.Financial.Models;
using System;
using System.Collections.Generic;

namespace LeagueManager.Financial.Payments
{
    public interface IPayments
    {
        /// <summary>
        /// Accepts a payment and produces a receipt for the payment
        /// </summary>
        /// <param name="payment"></param>
        /// <returns>A new receipt object</returns>
        PaymentReceipt AcceptPayment(Payment payment);

        /// <summary>
        /// Accepts multiple payments in a batch and generates receipts for each payment
        /// </summary>
        /// <param name="payments">One or more payments to accept in a batch</param>
        /// <returns>One or more receipts, one for each payment</returns>
        IEnumerable<PaymentReceipt> AcceptPayments(IEnumerable<Payment> payments);

        CancelReceipt CancelPayment(Payment paymentToCancel);
    }
}
