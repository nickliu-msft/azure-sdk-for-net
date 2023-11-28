// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> Project onboarding info. </summary>
    public partial class AzureDevOpsProjectMetadata
    {
        /// <summary> Initializes a new instance of <see cref="AzureDevOpsProjectMetadata"/>. </summary>
        public AzureDevOpsProjectMetadata()
        {
            Repos = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsProjectMetadata"/>. </summary>
        /// <param name="name"> Gets or sets name of the AzureDevOps Project. </param>
        /// <param name="autoDiscovery"></param>
        /// <param name="repos"> Gets or sets repositories. </param>
        internal AzureDevOpsProjectMetadata(string name, AutoDiscovery? autoDiscovery, IList<string> repos)
        {
            Name = name;
            AutoDiscovery = autoDiscovery;
            Repos = repos;
        }

        /// <summary> Gets or sets name of the AzureDevOps Project. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the auto discovery. </summary>
        public AutoDiscovery? AutoDiscovery { get; set; }
        /// <summary> Gets or sets repositories. </summary>
        public IList<string> Repos { get; }
    }
}
