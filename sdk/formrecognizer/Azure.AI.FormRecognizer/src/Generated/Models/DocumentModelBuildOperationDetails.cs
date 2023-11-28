// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Get Operation response object. </summary>
    public partial class DocumentModelBuildOperationDetails : OperationDetails
    {
        /// <summary> Initializes a new instance of <see cref="DocumentModelBuildOperationDetails"/>. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="createdOn"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> or <paramref name="resourceLocation"/> is null. </exception>
        internal DocumentModelBuildOperationDetails(string operationId, DocumentOperationStatus status, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, Uri resourceLocation) : base(operationId, status, createdOn, lastUpdatedOn, resourceLocation)
        {
            Argument.AssertNotNull(operationId, nameof(operationId));
            Argument.AssertNotNull(resourceLocation, nameof(resourceLocation));

            Kind = DocumentOperationKind.DocumentModelBuild;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentModelBuildOperationDetails"/>. </summary>
        /// <param name="operationId"> Operation ID. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentCompleted"> Operation progress (0-100). </param>
        /// <param name="createdOn"> Date and time (UTC) when the operation was created. </param>
        /// <param name="lastUpdatedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="kind"> Type of operation. </param>
        /// <param name="resourceLocation"> URL of the resource targeted by this operation. </param>
        /// <param name="serviceVersion"> API version used to create this operation. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document model. </param>
        /// <param name="jsonError"> Encountered error. </param>
        /// <param name="result"> Operation result upon success. </param>
        internal DocumentModelBuildOperationDetails(string operationId, DocumentOperationStatus status, int? percentCompleted, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, DocumentOperationKind kind, Uri resourceLocation, string serviceVersion, IReadOnlyDictionary<string, string> tags, JsonElement jsonError, DocumentModelDetails result) : base(operationId, status, percentCompleted, createdOn, lastUpdatedOn, kind, resourceLocation, serviceVersion, tags, jsonError)
        {
            Result = result;
            Kind = kind;
        }

        /// <summary> Operation result upon success. </summary>
        public DocumentModelDetails Result { get; }
    }
}
