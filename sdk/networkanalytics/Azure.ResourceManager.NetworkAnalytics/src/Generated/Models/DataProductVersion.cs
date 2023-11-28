// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> Data Product Version. </summary>
    public partial class DataProductVersion
    {
        /// <summary> Initializes a new instance of <see cref="DataProductVersion"/>. </summary>
        /// <param name="version"> Version of data product. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public DataProductVersion(string version)
        {
            Argument.AssertNotNull(version, nameof(version));

            Version = version;
        }

        /// <summary> Version of data product. </summary>
        public string Version { get; set; }
    }
}
