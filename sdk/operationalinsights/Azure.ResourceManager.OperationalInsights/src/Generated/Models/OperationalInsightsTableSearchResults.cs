// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Parameters of the search job that initiated this table. </summary>
    public partial class OperationalInsightsTableSearchResults
    {
        /// <summary> Initializes a new instance of <see cref="OperationalInsightsTableSearchResults"/>. </summary>
        public OperationalInsightsTableSearchResults()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsTableSearchResults"/>. </summary>
        /// <param name="query"> Search job query. </param>
        /// <param name="description"> Search job Description. </param>
        /// <param name="limit"> Limit the search job to return up to specified number of rows. </param>
        /// <param name="startSearchOn"> The timestamp to start the search from (UTC). </param>
        /// <param name="endSearchOn"> The timestamp to end the search by (UTC). </param>
        /// <param name="sourceTable"> The table used in the search job. </param>
        /// <param name="azureAsyncOperationId"> Search results table async operation id. </param>
        internal OperationalInsightsTableSearchResults(string query, string description, int? limit, DateTimeOffset? startSearchOn, DateTimeOffset? endSearchOn, string sourceTable, Guid? azureAsyncOperationId)
        {
            Query = query;
            Description = description;
            Limit = limit;
            StartSearchOn = startSearchOn;
            EndSearchOn = endSearchOn;
            SourceTable = sourceTable;
            AzureAsyncOperationId = azureAsyncOperationId;
        }

        /// <summary> Search job query. </summary>
        public string Query { get; set; }
        /// <summary> Search job Description. </summary>
        public string Description { get; set; }
        /// <summary> Limit the search job to return up to specified number of rows. </summary>
        public int? Limit { get; set; }
        /// <summary> The timestamp to start the search from (UTC). </summary>
        public DateTimeOffset? StartSearchOn { get; set; }
        /// <summary> The timestamp to end the search by (UTC). </summary>
        public DateTimeOffset? EndSearchOn { get; set; }
        /// <summary> The table used in the search job. </summary>
        public string SourceTable { get; }
        /// <summary> Search results table async operation id. </summary>
        public Guid? AzureAsyncOperationId { get; }
    }
}
