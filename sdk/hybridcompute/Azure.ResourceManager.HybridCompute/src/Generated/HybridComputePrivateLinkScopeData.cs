// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing the HybridComputePrivateLinkScope data model.
    /// An Azure Arc PrivateLinkScope definition.
    /// </summary>
    public partial class HybridComputePrivateLinkScopeData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="HybridComputePrivateLinkScopeData"/>. </summary>
        /// <param name="location"> The location. </param>
        public HybridComputePrivateLinkScopeData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputePrivateLinkScopeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Properties that define a Azure Arc PrivateLinkScope resource. </param>
        internal HybridComputePrivateLinkScopeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, HybridComputePrivateLinkScopeProperties properties) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
        }

        /// <summary> Properties that define a Azure Arc PrivateLinkScope resource. </summary>
        public HybridComputePrivateLinkScopeProperties Properties { get; set; }
    }
}
