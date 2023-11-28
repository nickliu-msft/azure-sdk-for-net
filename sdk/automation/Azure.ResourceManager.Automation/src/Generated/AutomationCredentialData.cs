// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the AutomationCredential data model.
    /// Definition of the credential.
    /// </summary>
    public partial class AutomationCredentialData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AutomationCredentialData"/>. </summary>
        public AutomationCredentialData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationCredentialData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="userName"> Gets the user name of the credential. </param>
        /// <param name="createdOn"> Gets the creation time. </param>
        /// <param name="lastModifiedOn"> Gets the last modified time. </param>
        /// <param name="description"> Gets or sets the description. </param>
        internal AutomationCredentialData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string userName, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string description) : base(id, name, resourceType, systemData)
        {
            UserName = userName;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            Description = description;
        }

        /// <summary> Gets the user name of the credential. </summary>
        public string UserName { get; }
        /// <summary> Gets the creation time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets the last modified time. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
    }
}
