// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Information of the private link resource. </summary>
    public partial class ServiceBusPrivateLinkResource : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ServiceBusPrivateLinkResource"/>. </summary>
        internal ServiceBusPrivateLinkResource()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBusPrivateLinkResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"></param>
        /// <param name="requiredMembers"> Required Members. </param>
        /// <param name="requiredZoneNames"> Required Zone Names. </param>
        internal ServiceBusPrivateLinkResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames) : base(id, name, resourceType, systemData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> Gets the group id. </summary>
        public string GroupId { get; }
        /// <summary> Required Members. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> Required Zone Names. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
    }
}
