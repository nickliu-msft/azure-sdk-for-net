// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The SIMs to upload. The SIM credentials must be encrypted. </summary>
    public partial class EncryptedSimUploadList
    {
        /// <summary> Initializes a new instance of <see cref="EncryptedSimUploadList"/>. </summary>
        /// <param name="version"> The upload file format version. </param>
        /// <param name="azureKeyIdentifier"> An identifier for the Azure SIM onboarding public key used for encrypted upload. </param>
        /// <param name="vendorKeyFingerprint"> The fingerprint of the SIM vendor public key. The private counterpart is used for signing the encrypted transport key. </param>
        /// <param name="encryptedTransportKey"> The transport key used for encrypting SIM credentials, encrypted using the SIM onboarding public key. </param>
        /// <param name="signedTransportKey"> The encrypted transport key, signed using the SIM vendor private key. </param>
        /// <param name="sims"> A list of SIMs to upload, with encrypted properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vendorKeyFingerprint"/>, <paramref name="encryptedTransportKey"/>, <paramref name="signedTransportKey"/> or <paramref name="sims"/> is null. </exception>
        public EncryptedSimUploadList(int version, int azureKeyIdentifier, string vendorKeyFingerprint, string encryptedTransportKey, string signedTransportKey, IEnumerable<SimNameAndEncryptedProperties> sims)
        {
            Argument.AssertNotNull(vendorKeyFingerprint, nameof(vendorKeyFingerprint));
            Argument.AssertNotNull(encryptedTransportKey, nameof(encryptedTransportKey));
            Argument.AssertNotNull(signedTransportKey, nameof(signedTransportKey));
            Argument.AssertNotNull(sims, nameof(sims));

            Version = version;
            AzureKeyIdentifier = azureKeyIdentifier;
            VendorKeyFingerprint = vendorKeyFingerprint;
            EncryptedTransportKey = encryptedTransportKey;
            SignedTransportKey = signedTransportKey;
            Sims = sims.ToList();
        }

        /// <summary> The upload file format version. </summary>
        public int Version { get; }
        /// <summary> An identifier for the Azure SIM onboarding public key used for encrypted upload. </summary>
        public int AzureKeyIdentifier { get; }
        /// <summary> The fingerprint of the SIM vendor public key. The private counterpart is used for signing the encrypted transport key. </summary>
        public string VendorKeyFingerprint { get; }
        /// <summary> The transport key used for encrypting SIM credentials, encrypted using the SIM onboarding public key. </summary>
        public string EncryptedTransportKey { get; }
        /// <summary> The encrypted transport key, signed using the SIM vendor private key. </summary>
        public string SignedTransportKey { get; }
        /// <summary> A list of SIMs to upload, with encrypted properties. </summary>
        public IList<SimNameAndEncryptedProperties> Sims { get; }
    }
}
