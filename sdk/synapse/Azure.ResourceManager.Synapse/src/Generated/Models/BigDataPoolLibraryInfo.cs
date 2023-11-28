// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Library/package information of a Big Data pool powered by Apache Spark. </summary>
    public partial class BigDataPoolLibraryInfo
    {
        /// <summary> Initializes a new instance of <see cref="BigDataPoolLibraryInfo"/>. </summary>
        public BigDataPoolLibraryInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BigDataPoolLibraryInfo"/>. </summary>
        /// <param name="name"> Name of the library. </param>
        /// <param name="path"> Storage blob path of library. </param>
        /// <param name="containerName"> Storage blob container name. </param>
        /// <param name="uploadedOn"> The last update time of the library. </param>
        /// <param name="libraryInfoType"> Type of the library. </param>
        /// <param name="provisioningStatus"> Provisioning status of the library/package. </param>
        /// <param name="creatorId"> Creator Id of the library/package. </param>
        internal BigDataPoolLibraryInfo(string name, string path, string containerName, DateTimeOffset? uploadedOn, string libraryInfoType, string provisioningStatus, string creatorId)
        {
            Name = name;
            Path = path;
            ContainerName = containerName;
            UploadedOn = uploadedOn;
            LibraryInfoType = libraryInfoType;
            ProvisioningStatus = provisioningStatus;
            CreatorId = creatorId;
        }

        /// <summary> Name of the library. </summary>
        public string Name { get; set; }
        /// <summary> Storage blob path of library. </summary>
        public string Path { get; set; }
        /// <summary> Storage blob container name. </summary>
        public string ContainerName { get; set; }
        /// <summary> The last update time of the library. </summary>
        public DateTimeOffset? UploadedOn { get; set; }
        /// <summary> Type of the library. </summary>
        public string LibraryInfoType { get; set; }
        /// <summary> Provisioning status of the library/package. </summary>
        public string ProvisioningStatus { get; }
        /// <summary> Creator Id of the library/package. </summary>
        public string CreatorId { get; }
    }
}
