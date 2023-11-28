// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Billing.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing the BillingPaymentMethodLink data model.
    /// A payment method link.
    /// </summary>
    public partial class BillingPaymentMethodLinkData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="BillingPaymentMethodLinkData"/>. </summary>
        public BillingPaymentMethodLinkData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BillingPaymentMethodLinkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="paymentMethod"> Projection of a payment method. </param>
        internal BillingPaymentMethodLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PaymentMethodProjectionProperties paymentMethod) : base(id, name, resourceType, systemData)
        {
            PaymentMethod = paymentMethod;
        }

        /// <summary> Projection of a payment method. </summary>
        public PaymentMethodProjectionProperties PaymentMethod { get; set; }
    }
}
