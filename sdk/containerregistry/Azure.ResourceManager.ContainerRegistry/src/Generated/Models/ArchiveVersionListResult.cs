// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The result of a request to list export pipelines for a container registry. </summary>
    internal partial class ArchiveVersionListResult
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

        /// <summary> Initializes a new instance of <see cref="ArchiveVersionListResult"/>. </summary>
        internal ArchiveVersionListResult()
        {
            Value = new ChangeTrackingList<ContainerRegistryArchiveVersionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ArchiveVersionListResult"/>. </summary>
        /// <param name="value"> The list of export pipelines. Since this list may be incomplete, the nextLink field should be used to request the next list of export pipelines. </param>
        /// <param name="nextLink"> The URI that can be used to request the next list of pipeline runs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArchiveVersionListResult(IReadOnlyList<ContainerRegistryArchiveVersionData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of export pipelines. Since this list may be incomplete, the nextLink field should be used to request the next list of export pipelines. </summary>
        public IReadOnlyList<ContainerRegistryArchiveVersionData> Value { get; }
        /// <summary> The URI that can be used to request the next list of pipeline runs. </summary>
        public string NextLink { get; }
    }
}
