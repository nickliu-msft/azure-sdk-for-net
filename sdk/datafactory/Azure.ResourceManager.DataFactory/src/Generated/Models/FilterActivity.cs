// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Filter and return results from input array based on the conditions. </summary>
    public partial class FilterActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of <see cref="FilterActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="items"> Input array on which filter should be applied. </param>
        /// <param name="condition"> Condition to be used for filtering the input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="items"/> or <paramref name="condition"/> is null. </exception>
        public FilterActivity(string name, DataFactoryExpression items, DataFactoryExpression condition) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(items, nameof(items));
            Argument.AssertNotNull(condition, nameof(condition));

            Items = items;
            Condition = condition;
            ActivityType = "Filter";
        }

        /// <summary> Initializes a new instance of <see cref="FilterActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="items"> Input array on which filter should be applied. </param>
        /// <param name="condition"> Condition to be used for filtering the input. </param>
        internal FilterActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryExpression items, DataFactoryExpression condition) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties)
        {
            Items = items;
            Condition = condition;
            ActivityType = activityType ?? "Filter";
        }

        /// <summary> Input array on which filter should be applied. </summary>
        public DataFactoryExpression Items { get; set; }
        /// <summary> Condition to be used for filtering the input. </summary>
        public DataFactoryExpression Condition { get; set; }
    }
}
