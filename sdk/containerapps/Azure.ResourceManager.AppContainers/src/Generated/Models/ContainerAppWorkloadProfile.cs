// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Workload profile to scope container app execution. </summary>
    public partial class ContainerAppWorkloadProfile
    {
        /// <summary> Initializes a new instance of <see cref="ContainerAppWorkloadProfile"/>. </summary>
        /// <param name="name"> Workload profile type for the workloads to run on. </param>
        /// <param name="workloadProfileType"> Workload profile type for the workloads to run on. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="workloadProfileType"/> is null. </exception>
        public ContainerAppWorkloadProfile(string name, string workloadProfileType)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(workloadProfileType, nameof(workloadProfileType));

            Name = name;
            WorkloadProfileType = workloadProfileType;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppWorkloadProfile"/>. </summary>
        /// <param name="name"> Workload profile type for the workloads to run on. </param>
        /// <param name="workloadProfileType"> Workload profile type for the workloads to run on. </param>
        /// <param name="minimumNodeCount"> The minimum capacity. </param>
        /// <param name="maximumNodeCount"> The maximum capacity. </param>
        internal ContainerAppWorkloadProfile(string name, string workloadProfileType, int? minimumNodeCount, int? maximumNodeCount)
        {
            Name = name;
            WorkloadProfileType = workloadProfileType;
            MinimumNodeCount = minimumNodeCount;
            MaximumNodeCount = maximumNodeCount;
        }

        /// <summary> Workload profile type for the workloads to run on. </summary>
        public string Name { get; set; }
        /// <summary> Workload profile type for the workloads to run on. </summary>
        public string WorkloadProfileType { get; set; }
        /// <summary> The minimum capacity. </summary>
        public int? MinimumNodeCount { get; set; }
        /// <summary> The maximum capacity. </summary>
        public int? MaximumNodeCount { get; set; }
    }
}
