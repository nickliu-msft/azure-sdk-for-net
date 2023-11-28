// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Request to perform a single operation on a batch of time series types. Exactly one of "get", "put" or "delete" must be set. </summary>
    internal partial class TypesBatchRequest
    {
        /// <summary> Initializes a new instance of <see cref="TypesBatchRequest"/>. </summary>
        public TypesBatchRequest()
        {
            Put = new ChangeTrackingList<TimeSeriesType>();
        }

        /// <summary> Definition of what time series types to return. </summary>
        public TypesRequestBatchGetOrDelete Get { get; set; }
        /// <summary> Definition of what time series types to update or create. </summary>
        public IList<TimeSeriesType> Put { get; }
        /// <summary> Definition of what time series types to delete. </summary>
        public TypesRequestBatchGetOrDelete Delete { get; set; }
    }
}
