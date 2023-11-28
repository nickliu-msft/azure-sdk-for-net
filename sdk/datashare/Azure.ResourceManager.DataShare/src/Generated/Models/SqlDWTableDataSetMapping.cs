// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A SQL DW Table data set mapping. </summary>
    public partial class SqlDWTableDataSetMapping : ShareDataSetMappingData
    {
        /// <summary> Initializes a new instance of <see cref="SqlDWTableDataSetMapping"/>. </summary>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="dataWarehouseName"> DataWarehouse name of the source data set. </param>
        /// <param name="schemaName"> Schema of the table. Default value is dbo. </param>
        /// <param name="sqlServerResourceId"> Resource id of SQL server. </param>
        /// <param name="tableName"> SQL DW table name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataWarehouseName"/>, <paramref name="schemaName"/>, <paramref name="sqlServerResourceId"/> or <paramref name="tableName"/> is null. </exception>
        public SqlDWTableDataSetMapping(Guid dataSetId, string dataWarehouseName, string schemaName, ResourceIdentifier sqlServerResourceId, string tableName)
        {
            Argument.AssertNotNull(dataWarehouseName, nameof(dataWarehouseName));
            Argument.AssertNotNull(schemaName, nameof(schemaName));
            Argument.AssertNotNull(sqlServerResourceId, nameof(sqlServerResourceId));
            Argument.AssertNotNull(tableName, nameof(tableName));

            DataSetId = dataSetId;
            DataWarehouseName = dataWarehouseName;
            SchemaName = schemaName;
            SqlServerResourceId = sqlServerResourceId;
            TableName = tableName;
            Kind = DataSetMappingKind.SqlDWTable;
        }

        /// <summary> Initializes a new instance of <see cref="SqlDWTableDataSetMapping"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set mapping. </param>
        /// <param name="dataSetId"> The id of the source data set. </param>
        /// <param name="dataSetMappingStatus"> Gets the status of the data set mapping. </param>
        /// <param name="dataWarehouseName"> DataWarehouse name of the source data set. </param>
        /// <param name="provisioningState"> Provisioning state of the data set mapping. </param>
        /// <param name="schemaName"> Schema of the table. Default value is dbo. </param>
        /// <param name="sqlServerResourceId"> Resource id of SQL server. </param>
        /// <param name="tableName"> SQL DW table name. </param>
        internal SqlDWTableDataSetMapping(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetMappingKind kind, Guid dataSetId, DataSetMappingStatus? dataSetMappingStatus, string dataWarehouseName, DataShareProvisioningState? provisioningState, string schemaName, ResourceIdentifier sqlServerResourceId, string tableName) : base(id, name, resourceType, systemData, kind)
        {
            DataSetId = dataSetId;
            DataSetMappingStatus = dataSetMappingStatus;
            DataWarehouseName = dataWarehouseName;
            ProvisioningState = provisioningState;
            SchemaName = schemaName;
            SqlServerResourceId = sqlServerResourceId;
            TableName = tableName;
            Kind = kind;
        }

        /// <summary> The id of the source data set. </summary>
        public Guid DataSetId { get; set; }
        /// <summary> Gets the status of the data set mapping. </summary>
        public DataSetMappingStatus? DataSetMappingStatus { get; }
        /// <summary> DataWarehouse name of the source data set. </summary>
        public string DataWarehouseName { get; set; }
        /// <summary> Provisioning state of the data set mapping. </summary>
        public DataShareProvisioningState? ProvisioningState { get; }
        /// <summary> Schema of the table. Default value is dbo. </summary>
        public string SchemaName { get; set; }
        /// <summary> Resource id of SQL server. </summary>
        public ResourceIdentifier SqlServerResourceId { get; set; }
        /// <summary> SQL DW table name. </summary>
        public string TableName { get; set; }
    }
}
