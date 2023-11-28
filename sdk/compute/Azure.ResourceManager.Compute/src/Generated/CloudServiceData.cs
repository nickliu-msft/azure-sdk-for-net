// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the CloudService data model.
    /// Describes the cloud service.
    /// </summary>
    public partial class CloudServiceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="CloudServiceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public CloudServiceData(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CloudServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="zones"> List of logical availability zone of the resource. List should contain only 1 zone where cloud service should be provisioned. This field is optional. </param>
        /// <param name="packageUri">
        /// Specifies a URL that refers to the location of the service package in the Blob service. The service package URL can be Shared Access Signature (SAS) URI from any storage account.
        /// This is a write-only property and is not returned in GET calls.
        /// </param>
        /// <param name="configuration"> Specifies the XML service configuration (.cscfg) for the cloud service. </param>
        /// <param name="configurationUri">
        /// Specifies a URL that refers to the location of the service configuration in the Blob service. The service package URL  can be Shared Access Signature (SAS) URI from any storage account.
        /// This is a write-only property and is not returned in GET calls.
        /// </param>
        /// <param name="startCloudService">
        /// (Optional) Indicates whether to start the cloud service immediately after it is created. The default value is `true`.
        /// If false, the service model is still deployed, but the code is not run immediately. Instead, the service is PoweredOff until you call Start, at which time the service will be started. A deployed service still incurs charges, even if it is poweredoff.
        /// </param>
        /// <param name="allowModelOverride">
        /// (Optional) Indicates whether the role sku properties (roleProfile.roles.sku) specified in the model/template should override the role instance count and vm size specified in the .cscfg and .csdef respectively.
        /// The default value is `false`.
        /// </param>
        /// <param name="upgradeMode">
        /// Update mode for the cloud service. Role instances are allocated to update domains when the service is deployed. Updates can be initiated manually in each update domain or initiated automatically in all update domains.
        /// Possible Values are &lt;br /&gt;&lt;br /&gt;**Auto**&lt;br /&gt;&lt;br /&gt;**Manual** &lt;br /&gt;&lt;br /&gt;**Simultaneous**&lt;br /&gt;&lt;br /&gt;
        /// If not specified, the default value is Auto. If set to Manual, PUT UpdateDomain must be called to apply the update. If set to Auto, the update is automatically applied to each update domain in sequence.
        /// </param>
        /// <param name="roleProfile"> Describes the role profile for the cloud service. </param>
        /// <param name="osProfile"> Describes the OS profile for the cloud service. </param>
        /// <param name="networkProfile"> Network Profile for the cloud service. </param>
        /// <param name="extensionProfile"> Describes a cloud service extension profile. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="uniqueId"> The unique identifier for the cloud service. </param>
        internal CloudServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IList<string> zones, Uri packageUri, string configuration, Uri configurationUri, bool? startCloudService, bool? allowModelOverride, CloudServiceUpgradeMode? upgradeMode, CloudServiceRoleProfile roleProfile, CloudServiceOSProfile osProfile, CloudServiceNetworkProfile networkProfile, CloudServiceExtensionProfile extensionProfile, string provisioningState, string uniqueId) : base(id, name, resourceType, systemData, tags, location)
        {
            Zones = zones;
            PackageUri = packageUri;
            Configuration = configuration;
            ConfigurationUri = configurationUri;
            StartCloudService = startCloudService;
            AllowModelOverride = allowModelOverride;
            UpgradeMode = upgradeMode;
            RoleProfile = roleProfile;
            OSProfile = osProfile;
            NetworkProfile = networkProfile;
            ExtensionProfile = extensionProfile;
            ProvisioningState = provisioningState;
            UniqueId = uniqueId;
        }

        /// <summary> List of logical availability zone of the resource. List should contain only 1 zone where cloud service should be provisioned. This field is optional. </summary>
        public IList<string> Zones { get; }
        /// <summary>
        /// Specifies a URL that refers to the location of the service package in the Blob service. The service package URL can be Shared Access Signature (SAS) URI from any storage account.
        /// This is a write-only property and is not returned in GET calls.
        /// </summary>
        public Uri PackageUri { get; set; }
        /// <summary> Specifies the XML service configuration (.cscfg) for the cloud service. </summary>
        public string Configuration { get; set; }
        /// <summary>
        /// Specifies a URL that refers to the location of the service configuration in the Blob service. The service package URL  can be Shared Access Signature (SAS) URI from any storage account.
        /// This is a write-only property and is not returned in GET calls.
        /// </summary>
        public Uri ConfigurationUri { get; set; }
        /// <summary>
        /// (Optional) Indicates whether to start the cloud service immediately after it is created. The default value is `true`.
        /// If false, the service model is still deployed, but the code is not run immediately. Instead, the service is PoweredOff until you call Start, at which time the service will be started. A deployed service still incurs charges, even if it is poweredoff.
        /// </summary>
        public bool? StartCloudService { get; set; }
        /// <summary>
        /// (Optional) Indicates whether the role sku properties (roleProfile.roles.sku) specified in the model/template should override the role instance count and vm size specified in the .cscfg and .csdef respectively.
        /// The default value is `false`.
        /// </summary>
        public bool? AllowModelOverride { get; set; }
        /// <summary>
        /// Update mode for the cloud service. Role instances are allocated to update domains when the service is deployed. Updates can be initiated manually in each update domain or initiated automatically in all update domains.
        /// Possible Values are &lt;br /&gt;&lt;br /&gt;**Auto**&lt;br /&gt;&lt;br /&gt;**Manual** &lt;br /&gt;&lt;br /&gt;**Simultaneous**&lt;br /&gt;&lt;br /&gt;
        /// If not specified, the default value is Auto. If set to Manual, PUT UpdateDomain must be called to apply the update. If set to Auto, the update is automatically applied to each update domain in sequence.
        /// </summary>
        public CloudServiceUpgradeMode? UpgradeMode { get; set; }
        /// <summary> Describes the role profile for the cloud service. </summary>
        internal CloudServiceRoleProfile RoleProfile { get; set; }
        /// <summary> List of roles for the cloud service. </summary>
        public IList<CloudServiceRoleProfileProperties> Roles
        {
            get
            {
                if (RoleProfile is null)
                    RoleProfile = new CloudServiceRoleProfile();
                return RoleProfile.Roles;
            }
        }

        /// <summary> Describes the OS profile for the cloud service. </summary>
        internal CloudServiceOSProfile OSProfile { get; set; }
        /// <summary> Specifies set of certificates that should be installed onto the role instances. </summary>
        public IList<CloudServiceVaultSecretGroup> OSSecrets
        {
            get
            {
                if (OSProfile is null)
                    OSProfile = new CloudServiceOSProfile();
                return OSProfile.Secrets;
            }
        }

        /// <summary> Network Profile for the cloud service. </summary>
        public CloudServiceNetworkProfile NetworkProfile { get; set; }
        /// <summary> Describes a cloud service extension profile. </summary>
        internal CloudServiceExtensionProfile ExtensionProfile { get; set; }
        /// <summary> List of extensions for the cloud service. </summary>
        public IList<CloudServiceExtension> Extensions
        {
            get
            {
                if (ExtensionProfile is null)
                    ExtensionProfile = new CloudServiceExtensionProfile();
                return ExtensionProfile.Extensions;
            }
        }

        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique identifier for the cloud service. </summary>
        public string UniqueId { get; }
    }
}
