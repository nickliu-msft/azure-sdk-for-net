// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> billing information. </summary>
    public partial class ReservationRefundBillingInformation
    {
        /// <summary> Initializes a new instance of <see cref="ReservationRefundBillingInformation"/>. </summary>
        internal ReservationRefundBillingInformation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReservationRefundBillingInformation"/>. </summary>
        /// <param name="billingPlan"> Represent the billing plans. </param>
        /// <param name="completedTransactions"> The number of completed transactions in this reservation's payment. </param>
        /// <param name="totalTransactions"> The number of total transactions in this reservation's payment. </param>
        /// <param name="billingCurrencyTotalPaidAmount"> Pricing information containing the amount and the currency code. </param>
        /// <param name="billingCurrencyProratedAmount"> Pricing information containing the amount and the currency code. </param>
        /// <param name="billingCurrencyRemainingCommitmentAmount"> Pricing information containing the amount and the currency code. </param>
        internal ReservationRefundBillingInformation(ReservationBillingPlan? billingPlan, int? completedTransactions, int? totalTransactions, PurchasePrice billingCurrencyTotalPaidAmount, PurchasePrice billingCurrencyProratedAmount, PurchasePrice billingCurrencyRemainingCommitmentAmount)
        {
            BillingPlan = billingPlan;
            CompletedTransactions = completedTransactions;
            TotalTransactions = totalTransactions;
            BillingCurrencyTotalPaidAmount = billingCurrencyTotalPaidAmount;
            BillingCurrencyProratedAmount = billingCurrencyProratedAmount;
            BillingCurrencyRemainingCommitmentAmount = billingCurrencyRemainingCommitmentAmount;
        }

        /// <summary> Represent the billing plans. </summary>
        public ReservationBillingPlan? BillingPlan { get; }
        /// <summary> The number of completed transactions in this reservation's payment. </summary>
        public int? CompletedTransactions { get; }
        /// <summary> The number of total transactions in this reservation's payment. </summary>
        public int? TotalTransactions { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice BillingCurrencyTotalPaidAmount { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice BillingCurrencyProratedAmount { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice BillingCurrencyRemainingCommitmentAmount { get; }
    }
}
