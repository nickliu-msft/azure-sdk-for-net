// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Definition of ARM tracked top level resource properties for update operation. </summary>
    public partial class MonitorWorkspaceResourcePatch
    {
        /// <summary> Initializes a new instance of <see cref="MonitorWorkspaceResourcePatch"/>. </summary>
        public MonitorWorkspaceResourcePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
