// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Support topic information. </summary>
    public partial class ContainerAppDiagnosticSupportTopic
    {
        /// <summary> Initializes a new instance of <see cref="ContainerAppDiagnosticSupportTopic"/>. </summary>
        public ContainerAppDiagnosticSupportTopic()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppDiagnosticSupportTopic"/>. </summary>
        /// <param name="id"> Unique topic identifier. </param>
        /// <param name="pesId"> PES identifier. </param>
        internal ContainerAppDiagnosticSupportTopic(string id, string pesId)
        {
            Id = id;
            PesId = pesId;
        }

        /// <summary> Unique topic identifier. </summary>
        public string Id { get; }
        /// <summary> PES identifier. </summary>
        public string PesId { get; }
    }
}
