// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The tag resource. </summary>
    public partial class ConsumptionTag
    {
        /// <summary> Initializes a new instance of <see cref="ConsumptionTag"/>. </summary>
        public ConsumptionTag()
        {
            Value = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ConsumptionTag"/>. </summary>
        /// <param name="key"> Tag key. </param>
        /// <param name="value"> Tag values. </param>
        internal ConsumptionTag(string key, IList<string> value)
        {
            Key = key;
            Value = value;
        }

        /// <summary> Tag key. </summary>
        public string Key { get; set; }
        /// <summary> Tag values. </summary>
        public IList<string> Value { get; }
    }
}
