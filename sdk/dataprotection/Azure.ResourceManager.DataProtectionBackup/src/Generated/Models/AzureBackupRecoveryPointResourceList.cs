// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Azure backup recoveryPoint resource list. </summary>
    internal partial class AzureBackupRecoveryPointResourceList
    {
        /// <summary> Initializes a new instance of <see cref="AzureBackupRecoveryPointResourceList"/>. </summary>
        internal AzureBackupRecoveryPointResourceList()
        {
            Value = new ChangeTrackingList<DataProtectionBackupRecoveryPointData>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureBackupRecoveryPointResourceList"/>. </summary>
        /// <param name="value"> List of resources. </param>
        /// <param name="nextLink"> The uri to fetch the next page of resources. Call ListNext() fetches next page of resources. </param>
        internal AzureBackupRecoveryPointResourceList(IReadOnlyList<DataProtectionBackupRecoveryPointData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of resources. </summary>
        public IReadOnlyList<DataProtectionBackupRecoveryPointData> Value { get; }
        /// <summary> The uri to fetch the next page of resources. Call ListNext() fetches next page of resources. </summary>
        public string NextLink { get; }
    }
}
