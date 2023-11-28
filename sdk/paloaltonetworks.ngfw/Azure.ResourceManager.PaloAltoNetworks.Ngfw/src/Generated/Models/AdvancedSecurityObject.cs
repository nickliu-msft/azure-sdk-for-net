// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> List of custom and predefined url category. </summary>
    public partial class AdvancedSecurityObject
    {
        /// <summary> Initializes a new instance of <see cref="AdvancedSecurityObject"/>. </summary>
        /// <param name="entry"> URL entry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entry"/> is null. </exception>
        internal AdvancedSecurityObject(IEnumerable<NameDescriptionObject> entry)
        {
            Argument.AssertNotNull(entry, nameof(entry));

            Entry = entry.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AdvancedSecurityObject"/>. </summary>
        /// <param name="advSecurityObjectModelType"> type of object. </param>
        /// <param name="entry"> URL entry. </param>
        internal AdvancedSecurityObject(string advSecurityObjectModelType, IReadOnlyList<NameDescriptionObject> entry)
        {
            AdvSecurityObjectModelType = advSecurityObjectModelType;
            Entry = entry;
        }

        /// <summary> type of object. </summary>
        public string AdvSecurityObjectModelType { get; }
        /// <summary> URL entry. </summary>
        public IReadOnlyList<NameDescriptionObject> Entry { get; }
    }
}
