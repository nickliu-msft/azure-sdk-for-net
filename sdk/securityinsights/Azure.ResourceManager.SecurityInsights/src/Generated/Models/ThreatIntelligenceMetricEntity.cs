// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes threat intelligence metric entity. </summary>
    public partial class ThreatIntelligenceMetricEntity
    {
        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceMetricEntity"/>. </summary>
        internal ThreatIntelligenceMetricEntity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceMetricEntity"/>. </summary>
        /// <param name="metricName"> Metric name. </param>
        /// <param name="metricValue"> Metric value. </param>
        internal ThreatIntelligenceMetricEntity(string metricName, int? metricValue)
        {
            MetricName = metricName;
            MetricValue = metricValue;
        }

        /// <summary> Metric name. </summary>
        public string MetricName { get; }
        /// <summary> Metric value. </summary>
        public int? MetricValue { get; }
    }
}
