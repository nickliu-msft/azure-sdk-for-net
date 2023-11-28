// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> IoT Hub Message source allows for the pipeline to consume messages from the IoT Edge Hub. Messages can be routed from other IoT modules via routes declared in the IoT Edge deployment manifest. </summary>
    public partial class IotHubMessageSource : SourceNodeBase
    {
        /// <summary> Initializes a new instance of <see cref="IotHubMessageSource"/>. </summary>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public IotHubMessageSource(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Type = "#Microsoft.VideoAnalyzer.IotHubMessageSource";
        }

        /// <summary> Initializes a new instance of <see cref="IotHubMessageSource"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="hubInputName"> Name of the IoT Edge Hub input from which messages will be consumed. </param>
        internal IotHubMessageSource(string type, string name, string hubInputName) : base(type, name)
        {
            HubInputName = hubInputName;
            Type = type ?? "#Microsoft.VideoAnalyzer.IotHubMessageSource";
        }

        /// <summary> Name of the IoT Edge Hub input from which messages will be consumed. </summary>
        public string HubInputName { get; set; }
    }
}
