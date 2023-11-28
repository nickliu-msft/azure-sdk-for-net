// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB SQL container resource object. </summary>
    public partial class RestorableSqlContainerPropertiesResourceContainer : CosmosDBSqlContainerResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="RestorableSqlContainerPropertiesResourceContainer"/>. </summary>
        /// <param name="containerName"> Name of the Cosmos DB SQL container. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public RestorableSqlContainerPropertiesResourceContainer(string containerName) : base(containerName)
        {
            Argument.AssertNotNull(containerName, nameof(containerName));
        }

        /// <summary> Initializes a new instance of <see cref="RestorableSqlContainerPropertiesResourceContainer"/>. </summary>
        /// <param name="containerName"> Name of the Cosmos DB SQL container. </param>
        /// <param name="indexingPolicy"> The configuration of the indexing policy. By default, the indexing is automatic for all document paths within the container. </param>
        /// <param name="partitionKey"> The configuration of the partition key to be used for partitioning data into multiple partitions. </param>
        /// <param name="defaultTtl"> Default time to live. </param>
        /// <param name="uniqueKeyPolicy"> The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service. </param>
        /// <param name="conflictResolutionPolicy"> The conflict resolution policy for the container. </param>
        /// <param name="clientEncryptionPolicy"> The client encryption policy for the container. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="createMode"> Enum to indicate the mode of resource creation. </param>
        /// <param name="materializedViewDefinition"> The configuration for defining Materialized Views. This must be specified only for creating a Materialized View container. </param>
        /// <param name="self"> A system generated property that specifies the addressable path of the container resource. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal RestorableSqlContainerPropertiesResourceContainer(string containerName, CosmosDBIndexingPolicy indexingPolicy, CosmosDBContainerPartitionKey partitionKey, int? defaultTtl, CosmosDBUniqueKeyPolicy uniqueKeyPolicy, ConflictResolutionPolicy conflictResolutionPolicy, CosmosDBClientEncryptionPolicy clientEncryptionPolicy, long? analyticalStorageTtl, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode, MaterializedViewDefinition materializedViewDefinition, string self, string rid, float? timestamp, ETag? etag) : base(containerName, indexingPolicy, partitionKey, defaultTtl, uniqueKeyPolicy, conflictResolutionPolicy, clientEncryptionPolicy, analyticalStorageTtl, restoreParameters, createMode, materializedViewDefinition)
        {
            Self = self;
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> A system generated property that specifies the addressable path of the container resource. </summary>
        public string Self { get; }
        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public ETag? ETag { get; }
    }
}
