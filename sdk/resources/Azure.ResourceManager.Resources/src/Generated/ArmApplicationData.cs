// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A class representing the ArmApplication data model.
    /// Information about managed application.
    /// </summary>
    public partial class ArmApplicationData : ArmApplicationResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ArmApplicationData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kind"/> is null. </exception>
        public ArmApplicationData(AzureLocation location, string kind) : base(location)
        {
            Argument.AssertNotNull(kind, nameof(kind));

            Kind = kind;
            Authorizations = new ChangeTrackingList<ArmApplicationAuthorization>();
            Artifacts = new ChangeTrackingList<ArmApplicationArtifact>();
        }

        /// <summary> Initializes a new instance of <see cref="ArmApplicationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="managedBy"> ID of the resource that manages this resource. </param>
        /// <param name="sku"> The SKU of the resource. </param>
        /// <param name="plan"> The plan information. </param>
        /// <param name="kind"> The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="managedResourceGroupId"> The managed resource group Id. </param>
        /// <param name="applicationDefinitionId"> The fully qualified path of managed application definition Id. </param>
        /// <param name="parameters"> Name and value pairs that define the managed application parameters. It can be a JObject or a well formed JSON string. </param>
        /// <param name="outputs"> Name and value pairs that define the managed application outputs. </param>
        /// <param name="provisioningState"> The managed application provisioning state. </param>
        /// <param name="billingDetails"> The managed application billing details. </param>
        /// <param name="jitAccessPolicy"> The managed application Jit access policy. </param>
        /// <param name="publisherTenantId"> The publisher tenant Id. </param>
        /// <param name="authorizations"> The  read-only authorizations property that is retrieved from the application package. </param>
        /// <param name="managementMode"> The managed application management mode. </param>
        /// <param name="customerSupport"> The read-only customer support property that is retrieved from the application package. </param>
        /// <param name="supportUris"> The read-only support URLs property that is retrieved from the application package. </param>
        /// <param name="artifacts"> The collection of managed application artifacts. </param>
        /// <param name="createdBy"> The client entity that created the JIT request. </param>
        /// <param name="updatedBy"> The client entity that last updated the JIT request. </param>
        internal ArmApplicationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string managedBy, ArmApplicationSku sku, ArmPlan plan, string kind, ArmApplicationManagedIdentity identity, ResourceIdentifier managedResourceGroupId, ResourceIdentifier applicationDefinitionId, BinaryData parameters, BinaryData outputs, ResourcesProvisioningState? provisioningState, ArmApplicationBillingDetails billingDetails, ArmApplicationJitAccessPolicy jitAccessPolicy, Guid? publisherTenantId, IReadOnlyList<ArmApplicationAuthorization> authorizations, ArmApplicationManagementMode? managementMode, ArmApplicationPackageContact customerSupport, ArmApplicationPackageSupportUris supportUris, IReadOnlyList<ArmApplicationArtifact> artifacts, ArmApplicationDetails createdBy, ArmApplicationDetails updatedBy) : base(id, name, resourceType, systemData, tags, location, managedBy, sku)
        {
            Plan = plan;
            Kind = kind;
            Identity = identity;
            ManagedResourceGroupId = managedResourceGroupId;
            ApplicationDefinitionId = applicationDefinitionId;
            Parameters = parameters;
            Outputs = outputs;
            ProvisioningState = provisioningState;
            BillingDetails = billingDetails;
            JitAccessPolicy = jitAccessPolicy;
            PublisherTenantId = publisherTenantId;
            Authorizations = authorizations;
            ManagementMode = managementMode;
            CustomerSupport = customerSupport;
            SupportUris = supportUris;
            Artifacts = artifacts;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
        }

        /// <summary> The plan information. </summary>
        public ArmPlan Plan { get; set; }
        /// <summary> The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog. </summary>
        public string Kind { get; set; }
        /// <summary> The identity of the resource. </summary>
        public ArmApplicationManagedIdentity Identity { get; set; }
        /// <summary> The managed resource group Id. </summary>
        public ResourceIdentifier ManagedResourceGroupId { get; set; }
        /// <summary> The fully qualified path of managed application definition Id. </summary>
        public ResourceIdentifier ApplicationDefinitionId { get; set; }
        /// <summary>
        /// Name and value pairs that define the managed application parameters. It can be a JObject or a well formed JSON string.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Parameters { get; set; }
        /// <summary>
        /// Name and value pairs that define the managed application outputs.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Outputs { get; }
        /// <summary> The managed application provisioning state. </summary>
        public ResourcesProvisioningState? ProvisioningState { get; }
        /// <summary> The managed application billing details. </summary>
        internal ArmApplicationBillingDetails BillingDetails { get; }
        /// <summary> The managed application resource usage Id. </summary>
        public string BillingDetailsResourceUsageId
        {
            get => BillingDetails?.ResourceUsageId;
        }

        /// <summary> The managed application Jit access policy. </summary>
        public ArmApplicationJitAccessPolicy JitAccessPolicy { get; set; }
        /// <summary> The publisher tenant Id. </summary>
        public Guid? PublisherTenantId { get; }
        /// <summary> The  read-only authorizations property that is retrieved from the application package. </summary>
        public IReadOnlyList<ArmApplicationAuthorization> Authorizations { get; }
        /// <summary> The managed application management mode. </summary>
        public ArmApplicationManagementMode? ManagementMode { get; }
        /// <summary> The read-only customer support property that is retrieved from the application package. </summary>
        public ArmApplicationPackageContact CustomerSupport { get; }
        /// <summary> The read-only support URLs property that is retrieved from the application package. </summary>
        public ArmApplicationPackageSupportUris SupportUris { get; }
        /// <summary> The collection of managed application artifacts. </summary>
        public IReadOnlyList<ArmApplicationArtifact> Artifacts { get; }
        /// <summary> The client entity that created the JIT request. </summary>
        public ArmApplicationDetails CreatedBy { get; }
        /// <summary> The client entity that last updated the JIT request. </summary>
        public ArmApplicationDetails UpdatedBy { get; }
    }
}
