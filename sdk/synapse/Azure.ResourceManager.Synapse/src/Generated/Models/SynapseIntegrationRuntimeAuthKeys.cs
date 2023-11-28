// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The integration runtime authentication keys. </summary>
    public partial class SynapseIntegrationRuntimeAuthKeys
    {
        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeAuthKeys"/>. </summary>
        internal SynapseIntegrationRuntimeAuthKeys()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeAuthKeys"/>. </summary>
        /// <param name="authKey1"> The primary integration runtime authentication key. </param>
        /// <param name="authKey2"> The secondary integration runtime authentication key. </param>
        internal SynapseIntegrationRuntimeAuthKeys(string authKey1, string authKey2)
        {
            AuthKey1 = authKey1;
            AuthKey2 = authKey2;
        }

        /// <summary> The primary integration runtime authentication key. </summary>
        public string AuthKey1 { get; }
        /// <summary> The secondary integration runtime authentication key. </summary>
        public string AuthKey2 { get; }
    }
}
