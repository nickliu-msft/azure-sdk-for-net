// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the cache expiration action for the delivery rule. </summary>
    public partial class DeliveryRuleCacheExpirationAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="DeliveryRuleCacheExpirationAction"/>. </summary>
        /// <param name="properties"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleCacheExpirationAction(CacheExpirationActionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Name = DeliveryRuleActionType.CacheExpiration;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleCacheExpirationAction"/>. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="properties"> Defines the parameters for the action. </param>
        internal DeliveryRuleCacheExpirationAction(DeliveryRuleActionType name, CacheExpirationActionProperties properties) : base(name)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Defines the parameters for the action. </summary>
        public CacheExpirationActionProperties Properties { get; set; }
    }
}
