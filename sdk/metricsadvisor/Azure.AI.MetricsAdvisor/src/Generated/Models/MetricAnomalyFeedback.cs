// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor
{
    /// <summary> The AnomalyFeedback. </summary>
    public partial class MetricAnomalyFeedback : MetricFeedback
    {
        /// <summary> Initializes a new instance of <see cref="MetricAnomalyFeedback"/>. </summary>
        /// <param name="feedbackKind"> feedback type. </param>
        /// <param name="id"> feedback unique id. </param>
        /// <param name="createdOn"> feedback created time. </param>
        /// <param name="userPrincipal"> user who gives this feedback. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimensionFilter"></param>
        /// <param name="startsOn"> the start timestamp of feedback time range. </param>
        /// <param name="endsOn"> the end timestamp of feedback time range, when equals to startTime means only one timestamp. </param>
        /// <param name="valueInternal"></param>
        /// <param name="detectionConfigurationId"> the corresponding anomaly detection configuration of this feedback. </param>
        /// <param name="detectionConfigurationSnapshot"></param>
        internal MetricAnomalyFeedback(MetricFeedbackKind feedbackKind, string id, DateTimeOffset? createdOn, string userPrincipal, string metricId, FeedbackFilter dimensionFilter, DateTimeOffset startsOn, DateTimeOffset endsOn, AnomalyFeedbackValue valueInternal, string detectionConfigurationId, AnomalyDetectionConfiguration detectionConfigurationSnapshot) : base(feedbackKind, id, createdOn, userPrincipal, metricId, dimensionFilter)
        {
            StartsOn = startsOn;
            EndsOn = endsOn;
            ValueInternal = valueInternal;
            DetectionConfigurationId = detectionConfigurationId;
            DetectionConfigurationSnapshot = detectionConfigurationSnapshot;
            FeedbackKind = feedbackKind;
        }
    }
}
