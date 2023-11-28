// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan HVR Azure failback input. </summary>
    public partial class RecoveryPlanHyperVReplicaAzureFailbackContent : RecoveryPlanProviderSpecificFailoverContent
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPlanHyperVReplicaAzureFailbackContent"/>. </summary>
        /// <param name="dataSyncOption"> The data sync option. </param>
        /// <param name="recoveryVmCreationOption"> The ALR option. </param>
        public RecoveryPlanHyperVReplicaAzureFailbackContent(SiteRecoveryDataSyncStatus dataSyncOption, AlternateLocationRecoveryOption recoveryVmCreationOption)
        {
            DataSyncOption = dataSyncOption;
            RecoveryVmCreationOption = recoveryVmCreationOption;
            InstanceType = "HyperVReplicaAzureFailback";
        }

        /// <summary> The data sync option. </summary>
        public SiteRecoveryDataSyncStatus DataSyncOption { get; }
        /// <summary> The ALR option. </summary>
        public AlternateLocationRecoveryOption RecoveryVmCreationOption { get; }
    }
}
