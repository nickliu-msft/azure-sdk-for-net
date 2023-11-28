// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kusto;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Class representing an iot hub data connection. </summary>
    public partial class KustoIotHubDataConnection : KustoDataConnectionData
    {
        /// <summary> Initializes a new instance of <see cref="KustoIotHubDataConnection"/>. </summary>
        public KustoIotHubDataConnection()
        {
            EventSystemProperties = new ChangeTrackingList<string>();
            Kind = DataConnectionKind.IotHub;
        }

        /// <summary> Initializes a new instance of <see cref="KustoIotHubDataConnection"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="kind"> Kind of the endpoint for the data connection. </param>
        /// <param name="iotHubResourceId"> The resource ID of the Iot hub to be used to create a data connection. </param>
        /// <param name="consumerGroup"> The iot hub consumer group. </param>
        /// <param name="tableName"> The table where the data should be ingested. Optionally the table information can be added to each message. </param>
        /// <param name="mappingRuleName"> The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message. </param>
        /// <param name="dataFormat"> The data format of the message. Optionally the data format can be added to each message. </param>
        /// <param name="eventSystemProperties"> System properties of the iot hub. </param>
        /// <param name="sharedAccessPolicyName"> The name of the share access policy. </param>
        /// <param name="databaseRouting"> Indication for database routing information from the data connection, by default only database routing information is allowed. </param>
        /// <param name="retrievalStartOn"> When defined, the data connection retrieves existing Event hub events created since the Retrieval start date. It can only retrieve events retained by the Event hub, based on its retention period. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        internal KustoIotHubDataConnection(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, DataConnectionKind kind, ResourceIdentifier iotHubResourceId, string consumerGroup, string tableName, string mappingRuleName, KustoIotHubDataFormat? dataFormat, IList<string> eventSystemProperties, string sharedAccessPolicyName, KustoDatabaseRouting? databaseRouting, DateTimeOffset? retrievalStartOn, KustoProvisioningState? provisioningState) : base(id, name, resourceType, systemData, location, kind)
        {
            IotHubResourceId = iotHubResourceId;
            ConsumerGroup = consumerGroup;
            TableName = tableName;
            MappingRuleName = mappingRuleName;
            DataFormat = dataFormat;
            EventSystemProperties = eventSystemProperties;
            SharedAccessPolicyName = sharedAccessPolicyName;
            DatabaseRouting = databaseRouting;
            RetrievalStartOn = retrievalStartOn;
            ProvisioningState = provisioningState;
            Kind = kind;
        }

        /// <summary> The resource ID of the Iot hub to be used to create a data connection. </summary>
        public ResourceIdentifier IotHubResourceId { get; set; }
        /// <summary> The iot hub consumer group. </summary>
        public string ConsumerGroup { get; set; }
        /// <summary> The table where the data should be ingested. Optionally the table information can be added to each message. </summary>
        public string TableName { get; set; }
        /// <summary> The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message. </summary>
        public string MappingRuleName { get; set; }
        /// <summary> The data format of the message. Optionally the data format can be added to each message. </summary>
        public KustoIotHubDataFormat? DataFormat { get; set; }
        /// <summary> System properties of the iot hub. </summary>
        public IList<string> EventSystemProperties { get; }
        /// <summary> The name of the share access policy. </summary>
        public string SharedAccessPolicyName { get; set; }
        /// <summary> Indication for database routing information from the data connection, by default only database routing information is allowed. </summary>
        public KustoDatabaseRouting? DatabaseRouting { get; set; }
        /// <summary> When defined, the data connection retrieves existing Event hub events created since the Retrieval start date. It can only retrieve events retained by the Event hub, based on its retention period. </summary>
        public DateTimeOffset? RetrievalStartOn { get; set; }
        /// <summary> The provisioned state of the resource. </summary>
        public KustoProvisioningState? ProvisioningState { get; }
    }
}
