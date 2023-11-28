// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Quantum.Models
{
    /// <summary> Detailed pricing information for an sku. </summary>
    public partial class PricingDetail
    {
        /// <summary> Initializes a new instance of <see cref="PricingDetail"/>. </summary>
        internal PricingDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PricingDetail"/>. </summary>
        /// <param name="id"> Unique id for this pricing information. </param>
        /// <param name="value"> The unit cost of this sku. </param>
        internal PricingDetail(string id, string value)
        {
            Id = id;
            Value = value;
        }

        /// <summary> Unique id for this pricing information. </summary>
        public string Id { get; }
        /// <summary> The unit cost of this sku. </summary>
        public string Value { get; }
    }
}
