// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary>
    /// A class representing the HealthcareApisIotFhirDestination data model.
    /// IoT Connector FHIR destination definition.
    /// </summary>
    public partial class HealthcareApisIotFhirDestinationData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="HealthcareApisIotFhirDestinationData"/>. </summary>
        /// <param name="resourceIdentityResolutionType"> Determines how resource identity is resolved on the destination. </param>
        /// <param name="fhirServiceResourceId"> Fully qualified resource id of the FHIR service to connect to. </param>
        /// <param name="fhirMapping"> FHIR Mappings. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fhirServiceResourceId"/> or <paramref name="fhirMapping"/> is null. </exception>
        public HealthcareApisIotFhirDestinationData(HealthcareApisIotIdentityResolutionType resourceIdentityResolutionType, ResourceIdentifier fhirServiceResourceId, HealthcareApisIotMappingProperties fhirMapping)
        {
            Argument.AssertNotNull(fhirServiceResourceId, nameof(fhirServiceResourceId));
            Argument.AssertNotNull(fhirMapping, nameof(fhirMapping));

            ResourceIdentityResolutionType = resourceIdentityResolutionType;
            FhirServiceResourceId = fhirServiceResourceId;
            FhirMapping = fhirMapping;
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareApisIotFhirDestinationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="resourceIdentityResolutionType"> Determines how resource identity is resolved on the destination. </param>
        /// <param name="fhirServiceResourceId"> Fully qualified resource id of the FHIR service to connect to. </param>
        /// <param name="fhirMapping"> FHIR Mappings. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        internal HealthcareApisIotFhirDestinationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, HealthcareApisProvisioningState? provisioningState, HealthcareApisIotIdentityResolutionType resourceIdentityResolutionType, ResourceIdentifier fhirServiceResourceId, HealthcareApisIotMappingProperties fhirMapping, AzureLocation? location, ETag? etag) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            ResourceIdentityResolutionType = resourceIdentityResolutionType;
            FhirServiceResourceId = fhirServiceResourceId;
            FhirMapping = fhirMapping;
            Location = location;
            ETag = etag;
        }

        /// <summary> The provisioning state. </summary>
        public HealthcareApisProvisioningState? ProvisioningState { get; }
        /// <summary> Determines how resource identity is resolved on the destination. </summary>
        public HealthcareApisIotIdentityResolutionType ResourceIdentityResolutionType { get; set; }
        /// <summary> Fully qualified resource id of the FHIR service to connect to. </summary>
        public ResourceIdentifier FhirServiceResourceId { get; set; }
        /// <summary> FHIR Mappings. </summary>
        internal HealthcareApisIotMappingProperties FhirMapping { get; set; }
        /// <summary>
        /// The mapping.
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
        public BinaryData FhirMappingContent
        {
            get => FhirMapping is null ? default : FhirMapping.Content;
            set
            {
                if (FhirMapping is null)
                    FhirMapping = new HealthcareApisIotMappingProperties();
                FhirMapping.Content = value;
            }
        }

        /// <summary> The resource location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> An etag associated with the resource, used for optimistic concurrency when editing it. </summary>
        public ETag? ETag { get; set; }
    }
}
