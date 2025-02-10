// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ServiceNetworking.Models;

namespace Azure.ResourceManager.ServiceNetworking
{
    /// <summary>
    /// A class representing the TrafficController data model.
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    /// </summary>
    public partial class TrafficControllerData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TrafficControllerData"/>. </summary>
        /// <param name="location"> The location. </param>
        public TrafficControllerData(AzureLocation location) : base(location)
        {
            ConfigurationEndpoints = new ChangeTrackingList<string>();
            Frontends = new ChangeTrackingList<SubResource>();
            Associations = new ChangeTrackingList<SubResource>();
            SecurityPolicies = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="TrafficControllerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="configurationEndpoints"> Configuration Endpoints. </param>
        /// <param name="frontends"> Frontends References List. </param>
        /// <param name="associations"> Associations References List. </param>
        /// <param name="securityPolicies"> Security Policies References List. </param>
        /// <param name="securityPolicyConfigurations"> Security Policy Configuration. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrafficControllerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IReadOnlyList<string> configurationEndpoints, IReadOnlyList<SubResource> frontends, IReadOnlyList<SubResource> associations, IReadOnlyList<SubResource> securityPolicies, SecurityPolicyConfigurations securityPolicyConfigurations, ProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ConfigurationEndpoints = configurationEndpoints;
            Frontends = frontends;
            Associations = associations;
            SecurityPolicies = securityPolicies;
            SecurityPolicyConfigurations = securityPolicyConfigurations;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TrafficControllerData"/> for deserialization. </summary>
        internal TrafficControllerData()
        {
        }

        /// <summary> Configuration Endpoints. </summary>
        public IReadOnlyList<string> ConfigurationEndpoints { get; }
        /// <summary> Frontends References List. </summary>
        public IReadOnlyList<SubResource> Frontends { get; }
        /// <summary> Associations References List. </summary>
        public IReadOnlyList<SubResource> Associations { get; }
        /// <summary> Security Policies References List. </summary>
        public IReadOnlyList<SubResource> SecurityPolicies { get; }
        /// <summary> Security Policy Configuration. </summary>
        internal SecurityPolicyConfigurations SecurityPolicyConfigurations { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier WafSecurityPolicyId
        {
            get => SecurityPolicyConfigurations is null ? default : SecurityPolicyConfigurations.WafSecurityPolicyId;
            set
            {
                if (SecurityPolicyConfigurations is null)
                    SecurityPolicyConfigurations = new SecurityPolicyConfigurations();
                SecurityPolicyConfigurations.WafSecurityPolicyId = value;
            }
        }

        /// <summary> The status of the last operation. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
