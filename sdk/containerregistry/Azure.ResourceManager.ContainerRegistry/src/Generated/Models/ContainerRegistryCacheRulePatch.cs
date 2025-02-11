// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The parameters for updating a cache rule. </summary>
    public partial class ContainerRegistryCacheRulePatch
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryCacheRulePatch"/>. </summary>
        public ContainerRegistryCacheRulePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryCacheRulePatch"/>. </summary>
        /// <param name="credentialSetResourceId"> The ARM resource ID of the credential store which is associated with the Cache rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryCacheRulePatch(ResourceIdentifier credentialSetResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CredentialSetResourceId = credentialSetResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ARM resource ID of the credential store which is associated with the Cache rule. </summary>
        [WirePath("properties.credentialSetResourceId")]
        public ResourceIdentifier CredentialSetResourceId { get; set; }
    }
}
