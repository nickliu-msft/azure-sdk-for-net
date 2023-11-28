// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> StorageApplianceEnableRemoteVendorManagementParameters represents the body of the request to enable remote vendor management of a storage appliance. </summary>
    public partial class StorageApplianceEnableRemoteVendorManagementContent
    {
        /// <summary> Initializes a new instance of <see cref="StorageApplianceEnableRemoteVendorManagementContent"/>. </summary>
        public StorageApplianceEnableRemoteVendorManagementContent()
        {
            SupportEndpoints = new ChangeTrackingList<string>();
        }

        /// <summary> Field Deprecated. This field is not used and will be rejected if provided. The list of IPv4 subnets (in CIDR format), IPv6 subnets (in CIDR format), or hostnames that the storage appliance needs accessible in order to turn on the remote vendor management. </summary>
        public IList<string> SupportEndpoints { get; }
    }
}
