// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing the ContainerAppRevision data model.
    /// Container App Revision.
    /// </summary>
    public partial class ContainerAppRevisionData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ContainerAppRevisionData"/>. </summary>
        public ContainerAppRevisionData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppRevisionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn">
        /// Timestamp describing when the revision was created
        /// by controller
        /// </param>
        /// <param name="lastActiveOn"> Timestamp describing when the revision was last active. Only meaningful when revision is inactive. </param>
        /// <param name="fqdn"> Fully qualified domain name of the revision. </param>
        /// <param name="template">
        /// Container App Revision Template with all possible settings and the
        /// defaults if user did not provide them. The defaults are populated
        /// as they were at the creation time
        /// </param>
        /// <param name="isActive"> Boolean describing if the Revision is Active. </param>
        /// <param name="replicas"> Number of pods currently running for this revision. </param>
        /// <param name="trafficWeight"> Traffic weight assigned to this revision. </param>
        /// <param name="provisioningError"> Optional Field - Platform Error Message. </param>
        /// <param name="healthState"> Current health State of the revision. </param>
        /// <param name="provisioningState"> Current provisioning State of the revision. </param>
        /// <param name="runningState"> Current running state of the revision. </param>
        internal ContainerAppRevisionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? createdOn, DateTimeOffset? lastActiveOn, string fqdn, ContainerAppTemplate template, bool? isActive, int? replicas, int? trafficWeight, string provisioningError, ContainerAppRevisionHealthState? healthState, ContainerAppRevisionProvisioningState? provisioningState, RevisionRunningState? runningState) : base(id, name, resourceType, systemData)
        {
            CreatedOn = createdOn;
            LastActiveOn = lastActiveOn;
            Fqdn = fqdn;
            Template = template;
            IsActive = isActive;
            Replicas = replicas;
            TrafficWeight = trafficWeight;
            ProvisioningError = provisioningError;
            HealthState = healthState;
            ProvisioningState = provisioningState;
            RunningState = runningState;
        }

        /// <summary>
        /// Timestamp describing when the revision was created
        /// by controller
        /// </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Timestamp describing when the revision was last active. Only meaningful when revision is inactive. </summary>
        public DateTimeOffset? LastActiveOn { get; }
        /// <summary> Fully qualified domain name of the revision. </summary>
        public string Fqdn { get; }
        /// <summary>
        /// Container App Revision Template with all possible settings and the
        /// defaults if user did not provide them. The defaults are populated
        /// as they were at the creation time
        /// </summary>
        public ContainerAppTemplate Template { get; }
        /// <summary> Boolean describing if the Revision is Active. </summary>
        public bool? IsActive { get; }
        /// <summary> Number of pods currently running for this revision. </summary>
        public int? Replicas { get; }
        /// <summary> Traffic weight assigned to this revision. </summary>
        public int? TrafficWeight { get; }
        /// <summary> Optional Field - Platform Error Message. </summary>
        public string ProvisioningError { get; }
        /// <summary> Current health State of the revision. </summary>
        public ContainerAppRevisionHealthState? HealthState { get; }
        /// <summary> Current provisioning State of the revision. </summary>
        public ContainerAppRevisionProvisioningState? ProvisioningState { get; }
        /// <summary> Current running state of the revision. </summary>
        public RevisionRunningState? RunningState { get; }
    }
}
