// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Virtual Network rule. </summary>
    public partial class ElasticSanVirtualNetworkRule
    {
        /// <summary> Initializes a new instance of <see cref="ElasticSanVirtualNetworkRule"/>. </summary>
        /// <param name="virtualNetworkResourceId"> Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkResourceId"/> is null. </exception>
        public ElasticSanVirtualNetworkRule(ResourceIdentifier virtualNetworkResourceId)
        {
            Argument.AssertNotNull(virtualNetworkResourceId, nameof(virtualNetworkResourceId));

            VirtualNetworkResourceId = virtualNetworkResourceId;
        }

        /// <summary> Initializes a new instance of <see cref="ElasticSanVirtualNetworkRule"/>. </summary>
        /// <param name="virtualNetworkResourceId"> Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}. </param>
        /// <param name="action"> The action of virtual network rule. </param>
        internal ElasticSanVirtualNetworkRule(ResourceIdentifier virtualNetworkResourceId, ElasticSanVirtualNetworkRuleAction? action)
        {
            VirtualNetworkResourceId = virtualNetworkResourceId;
            Action = action;
        }

        /// <summary> Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}. </summary>
        public ResourceIdentifier VirtualNetworkResourceId { get; set; }
        /// <summary> The action of virtual network rule. </summary>
        public ElasticSanVirtualNetworkRuleAction? Action { get; set; }
    }
}
