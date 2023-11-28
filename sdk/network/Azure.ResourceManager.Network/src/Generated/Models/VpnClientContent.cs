// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Vpn Client Parameters for package generation. </summary>
    public partial class VpnClientContent
    {
        /// <summary> Initializes a new instance of <see cref="VpnClientContent"/>. </summary>
        public VpnClientContent()
        {
            ClientRootCertificates = new ChangeTrackingList<string>();
        }

        /// <summary> VPN client Processor Architecture. </summary>
        public ProcessorArchitecture? ProcessorArchitecture { get; set; }
        /// <summary> VPN client authentication method. </summary>
        public NetworkAuthenticationMethod? AuthenticationMethod { get; set; }
        /// <summary> The public certificate data for the radius server authentication certificate as a Base-64 encoded string. Required only if external radius authentication has been configured with EAPTLS authentication. </summary>
        public string RadiusServerAuthCertificate { get; set; }
        /// <summary> A list of client root certificates public certificate data encoded as Base-64 strings. Optional parameter for external radius based authentication with EAPTLS. </summary>
        public IList<string> ClientRootCertificates { get; }
    }
}
