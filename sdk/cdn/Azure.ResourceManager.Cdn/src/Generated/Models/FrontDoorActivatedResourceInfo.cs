// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Reference to another resource along with its state. </summary>
    public partial class FrontDoorActivatedResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="FrontDoorActivatedResourceInfo"/>. </summary>
        public FrontDoorActivatedResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorActivatedResourceInfo"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="isActive"> Whether the resource is active or inactive. </param>
        internal FrontDoorActivatedResourceInfo(ResourceIdentifier id, bool? isActive)
        {
            Id = id;
            IsActive = isActive;
        }

        /// <summary> Resource ID. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Whether the resource is active or inactive. </summary>
        public bool? IsActive { get; }
    }
}
