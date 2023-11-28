// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The SparkServicePlugin. </summary>
    public partial class SparkServicePlugin
    {
        /// <summary> Initializes a new instance of <see cref="SparkServicePlugin"/>. </summary>
        internal SparkServicePlugin()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SparkServicePlugin"/>. </summary>
        /// <param name="preparationStartedAt"></param>
        /// <param name="resourceAcquisitionStartedAt"></param>
        /// <param name="submissionStartedAt"></param>
        /// <param name="monitoringStartedAt"></param>
        /// <param name="cleanupStartedAt"></param>
        /// <param name="currentState"></param>
        internal SparkServicePlugin(DateTimeOffset? preparationStartedAt, DateTimeOffset? resourceAcquisitionStartedAt, DateTimeOffset? submissionStartedAt, DateTimeOffset? monitoringStartedAt, DateTimeOffset? cleanupStartedAt, PluginCurrentState? currentState)
        {
            PreparationStartedAt = preparationStartedAt;
            ResourceAcquisitionStartedAt = resourceAcquisitionStartedAt;
            SubmissionStartedAt = submissionStartedAt;
            MonitoringStartedAt = monitoringStartedAt;
            CleanupStartedAt = cleanupStartedAt;
            CurrentState = currentState;
        }

        /// <summary> Gets the preparation started at. </summary>
        public DateTimeOffset? PreparationStartedAt { get; }
        /// <summary> Gets the resource acquisition started at. </summary>
        public DateTimeOffset? ResourceAcquisitionStartedAt { get; }
        /// <summary> Gets the submission started at. </summary>
        public DateTimeOffset? SubmissionStartedAt { get; }
        /// <summary> Gets the monitoring started at. </summary>
        public DateTimeOffset? MonitoringStartedAt { get; }
        /// <summary> Gets the cleanup started at. </summary>
        public DateTimeOffset? CleanupStartedAt { get; }
        /// <summary> Gets the current state. </summary>
        public PluginCurrentState? CurrentState { get; }
    }
}
