// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.RouterJobClassificationFailed event. </summary>
    public partial class AcsRouterJobClassificationFailedEventData : AcsRouterJobEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsRouterJobClassificationFailedEventData"/>. </summary>
        internal AcsRouterJobClassificationFailedEventData()
        {
            ErrorsInternal = new ChangeTrackingList<AcsRouterCommunicationError>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterJobClassificationFailedEventData"/>. </summary>
        /// <param name="jobId"> Router Event Job ID. </param>
        /// <param name="channelReference"> Router Event Channel Reference. </param>
        /// <param name="channelId"> Router Event Channel ID. </param>
        /// <param name="queueId"> Router Job events Queue Id. </param>
        /// <param name="labels"> Router Job events Labels. </param>
        /// <param name="tags"> Router Jobs events Tags. </param>
        /// <param name="classificationPolicyId"> Router Job Classification Policy Id. </param>
        /// <param name="errorsInternal"> Router Job Classification Failed Errors. </param>
        internal AcsRouterJobClassificationFailedEventData(string jobId, string channelReference, string channelId, string queueId, IReadOnlyDictionary<string, string> labels, IReadOnlyDictionary<string, string> tags, string classificationPolicyId, IReadOnlyList<AcsRouterCommunicationError> errorsInternal) : base(jobId, channelReference, channelId, queueId, labels, tags)
        {
            ClassificationPolicyId = classificationPolicyId;
            ErrorsInternal = errorsInternal;
        }

        /// <summary> Router Job Classification Policy Id. </summary>
        public string ClassificationPolicyId { get; }
    }
}
