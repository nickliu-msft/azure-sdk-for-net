// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> A map of collections subscriptions details. </summary>
    public partial class CollectionsToSubscriptionsMappingResult
    {
        /// <summary> Initializes a new instance of <see cref="CollectionsToSubscriptionsMappingResult"/>. </summary>
        internal CollectionsToSubscriptionsMappingResult()
        {
            Details = new ChangeTrackingDictionary<string, CollectionsSubscriptionsMappingDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="CollectionsToSubscriptionsMappingResult"/>. </summary>
        /// <param name="details"> The map of collections subscriptions. </param>
        internal CollectionsToSubscriptionsMappingResult(IReadOnlyDictionary<string, CollectionsSubscriptionsMappingDetails> details)
        {
            Details = details;
        }

        /// <summary> The map of collections subscriptions. </summary>
        public IReadOnlyDictionary<string, CollectionsSubscriptionsMappingDetails> Details { get; }
    }
}
