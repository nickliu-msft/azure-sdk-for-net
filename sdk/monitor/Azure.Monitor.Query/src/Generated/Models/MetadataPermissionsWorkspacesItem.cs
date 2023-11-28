// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The MetadataPermissionsWorkspacesItem. </summary>
    internal partial class MetadataPermissionsWorkspacesItem
    {
        /// <summary> Initializes a new instance of <see cref="MetadataPermissionsWorkspacesItem"/>. </summary>
        /// <param name="resourceId"> The resource ID on the permission indication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        internal MetadataPermissionsWorkspacesItem(string resourceId)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            ResourceId = resourceId;
            DenyTables = new ChangeTrackingList<string>();
        }

        /// <summary> The resource ID on the permission indication. </summary>
        public string ResourceId { get; }
        /// <summary> The list of tables that were denied access for the resource ID. </summary>
        public IReadOnlyList<string> DenyTables { get; }
    }
}
