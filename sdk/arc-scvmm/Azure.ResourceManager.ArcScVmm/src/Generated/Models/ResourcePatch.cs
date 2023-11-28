// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Object containing tags updates for patch operations. </summary>
    public partial class ResourcePatch
    {
        /// <summary> Initializes a new instance of <see cref="ResourcePatch"/>. </summary>
        public ResourcePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
