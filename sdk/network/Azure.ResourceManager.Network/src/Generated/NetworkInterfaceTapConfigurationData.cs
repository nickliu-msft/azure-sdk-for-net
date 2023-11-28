// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the NetworkInterfaceTapConfiguration data model.
    /// Tap configuration in a Network Interface.
    /// </summary>
    public partial class NetworkInterfaceTapConfigurationData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceTapConfigurationData"/>. </summary>
        public NetworkInterfaceTapConfigurationData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceTapConfigurationData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualNetworkTap"> The reference to the Virtual Network Tap resource. </param>
        /// <param name="provisioningState"> The provisioning state of the network interface tap configuration resource. </param>
        internal NetworkInterfaceTapConfigurationData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, VirtualNetworkTapData virtualNetworkTap, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            VirtualNetworkTap = virtualNetworkTap;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The reference to the Virtual Network Tap resource. </summary>
        public VirtualNetworkTapData VirtualNetworkTap { get; set; }
        /// <summary> The provisioning state of the network interface tap configuration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
