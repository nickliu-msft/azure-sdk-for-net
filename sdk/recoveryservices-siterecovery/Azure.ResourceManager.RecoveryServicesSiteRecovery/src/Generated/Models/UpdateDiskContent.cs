// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Disk input for update. </summary>
    public partial class UpdateDiskContent
    {
        /// <summary> Initializes a new instance of <see cref="UpdateDiskContent"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diskId"/> is null. </exception>
        public UpdateDiskContent(string diskId)
        {
            Argument.AssertNotNull(diskId, nameof(diskId));

            DiskId = diskId;
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> The target disk name. </summary>
        public string TargetDiskName { get; set; }
    }
}
