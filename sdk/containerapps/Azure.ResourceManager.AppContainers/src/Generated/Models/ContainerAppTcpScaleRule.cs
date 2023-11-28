// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App container Tcp scaling rule. </summary>
    public partial class ContainerAppTcpScaleRule
    {
        /// <summary> Initializes a new instance of <see cref="ContainerAppTcpScaleRule"/>. </summary>
        public ContainerAppTcpScaleRule()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
            Auth = new ChangeTrackingList<ContainerAppScaleRuleAuth>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppTcpScaleRule"/>. </summary>
        /// <param name="metadata"> Metadata properties to describe tcp scale rule. </param>
        /// <param name="auth"> Authentication secrets for the tcp scale rule. </param>
        internal ContainerAppTcpScaleRule(IDictionary<string, string> metadata, IList<ContainerAppScaleRuleAuth> auth)
        {
            Metadata = metadata;
            Auth = auth;
        }

        /// <summary> Metadata properties to describe tcp scale rule. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> Authentication secrets for the tcp scale rule. </summary>
        public IList<ContainerAppScaleRuleAuth> Auth { get; }
    }
}
