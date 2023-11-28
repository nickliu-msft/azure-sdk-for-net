// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The swagger custom dynamic tree settings. </summary>
    public partial class SwaggerCustomDynamicTreeSettings
    {
        /// <summary> Initializes a new instance of <see cref="SwaggerCustomDynamicTreeSettings"/>. </summary>
        public SwaggerCustomDynamicTreeSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SwaggerCustomDynamicTreeSettings"/>. </summary>
        /// <param name="canSelectParentNodes"> Indicates whether parent nodes can be selected. </param>
        /// <param name="canSelectLeafNodes"> Indicates whether leaf nodes can be selected. </param>
        internal SwaggerCustomDynamicTreeSettings(bool? canSelectParentNodes, bool? canSelectLeafNodes)
        {
            CanSelectParentNodes = canSelectParentNodes;
            CanSelectLeafNodes = canSelectLeafNodes;
        }

        /// <summary> Indicates whether parent nodes can be selected. </summary>
        public bool? CanSelectParentNodes { get; set; }
        /// <summary> Indicates whether leaf nodes can be selected. </summary>
        public bool? CanSelectLeafNodes { get; set; }
    }
}
