// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary>
    /// Base type for functions that can modify document scores during ranking.
    /// Please note <see cref="ScoringFunction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DistanceScoringFunction"/>, <see cref="FreshnessScoringFunction"/>, <see cref="MagnitudeScoringFunction"/> and <see cref="TagScoringFunction"/>.
    /// </summary>
    public partial class ScoringFunction
    {
        /// <summary> Initializes a new instance of <see cref="ScoringFunction"/>. </summary>
        /// <param name="type"> Indicates the type of function to use. Valid values include magnitude, freshness, distance, and tag. The function type must be lower case. </param>
        /// <param name="fieldName"> The name of the field used as input to the scoring function. </param>
        /// <param name="boost"> A multiplier for the raw score. Must be a positive number not equal to 1.0. </param>
        /// <param name="interpolation"> A value indicating how boosting will be interpolated across document scores; defaults to "Linear". </param>
        internal ScoringFunction(string type, string fieldName, double boost, ScoringFunctionInterpolation? interpolation)
        {
            Type = type;
            FieldName = fieldName;
            Boost = boost;
            Interpolation = interpolation;
        }

        /// <summary> Indicates the type of function to use. Valid values include magnitude, freshness, distance, and tag. The function type must be lower case. </summary>
        internal string Type { get; set; }
        /// <summary> The name of the field used as input to the scoring function. </summary>
        public string FieldName { get; set; }
        /// <summary> A multiplier for the raw score. Must be a positive number not equal to 1.0. </summary>
        public double Boost { get; set; }
        /// <summary> A value indicating how boosting will be interpolated across document scores; defaults to "Linear". </summary>
        public ScoringFunctionInterpolation? Interpolation { get; set; }
    }
}
