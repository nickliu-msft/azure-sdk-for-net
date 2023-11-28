// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DefenderEasm.Models
{
    /// <summary> Label patch properties. </summary>
    public partial class EasmLabelPatch : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="EasmLabelPatch"/>. </summary>
        public EasmLabelPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EasmLabelPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Resource provisioning state. </param>
        /// <param name="displayName"> Label display name. </param>
        /// <param name="color"> Label color. </param>
        internal EasmLabelPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EasmResourceProvisioningState? provisioningState, string displayName, string color) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            DisplayName = displayName;
            Color = color;
        }

        /// <summary> Resource provisioning state. </summary>
        public EasmResourceProvisioningState? ProvisioningState { get; }
        /// <summary> Label display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Label color. </summary>
        public string Color { get; set; }
    }
}
