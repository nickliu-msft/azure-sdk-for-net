// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Certificate create or update details. </summary>
    public partial class ApiManagementCertificateCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="ApiManagementCertificateCreateOrUpdateContent"/>. </summary>
        public ApiManagementCertificateCreateOrUpdateContent()
        {
        }

        /// <summary> Base 64 encoded certificate using the application/x-pkcs12 representation. </summary>
        public string Data { get; set; }
        /// <summary> Password for the Certificate. </summary>
        public string Password { get; set; }
        /// <summary> KeyVault location details of the certificate. </summary>
        public KeyVaultContractCreateProperties KeyVaultDetails { get; set; }
    }
}
