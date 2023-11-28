// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ExtendedLocation represents the Azure custom location where the resource will be created. </summary>
    public partial class ExtendedLocation
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedLocation"/>. </summary>
        /// <param name="name"> The resource ID of the extended location on which the resource will be created. </param>
        /// <param name="extendedLocationType"> The extended location type, for example, CustomLocation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="extendedLocationType"/> is null. </exception>
        public ExtendedLocation(string name, string extendedLocationType)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(extendedLocationType, nameof(extendedLocationType));

            Name = name;
            ExtendedLocationType = extendedLocationType;
        }

        /// <summary> The resource ID of the extended location on which the resource will be created. </summary>
        public string Name { get; set; }
        /// <summary> The extended location type, for example, CustomLocation. </summary>
        public string ExtendedLocationType { get; set; }
    }
}
