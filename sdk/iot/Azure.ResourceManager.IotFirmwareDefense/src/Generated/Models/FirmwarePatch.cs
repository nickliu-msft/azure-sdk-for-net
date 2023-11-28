// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Firmware definition. </summary>
    public partial class FirmwarePatch
    {
        /// <summary> Initializes a new instance of <see cref="FirmwarePatch"/>. </summary>
        public FirmwarePatch()
        {
            StatusMessages = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> File name for a firmware that user uploaded. </summary>
        public string FileName { get; set; }
        /// <summary> Firmware vendor. </summary>
        public string Vendor { get; set; }
        /// <summary> Firmware model. </summary>
        public string Model { get; set; }
        /// <summary> Firmware version. </summary>
        public string Version { get; set; }
        /// <summary> User-specified description of the firmware. </summary>
        public string Description { get; set; }
        /// <summary> File size of the uploaded firmware image. </summary>
        public long? FileSize { get; set; }
        /// <summary> The status of firmware scan. </summary>
        public Status? Status { get; set; }
        /// <summary>
        /// A list of errors or other messages generated during firmware analysis
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> StatusMessages { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
