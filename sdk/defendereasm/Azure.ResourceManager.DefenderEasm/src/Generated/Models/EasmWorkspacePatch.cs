// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DefenderEasm.Models
{
    /// <summary> Workspace patch properties. </summary>
    public partial class EasmWorkspacePatch
    {
        /// <summary> Initializes a new instance of <see cref="EasmWorkspacePatch"/>. </summary>
        public EasmWorkspacePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
    }
}
