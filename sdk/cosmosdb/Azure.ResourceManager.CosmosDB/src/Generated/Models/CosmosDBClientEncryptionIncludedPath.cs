// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> . </summary>
    public partial class CosmosDBClientEncryptionIncludedPath
    {
        /// <summary> Initializes a new instance of <see cref="CosmosDBClientEncryptionIncludedPath"/>. </summary>
        /// <param name="path"> Path that needs to be encrypted. </param>
        /// <param name="clientEncryptionKeyId"> The identifier of the Client Encryption Key to be used to encrypt the path. </param>
        /// <param name="encryptionType"> The type of encryption to be performed. Eg - Deterministic, Randomized. </param>
        /// <param name="encryptionAlgorithm"> The encryption algorithm which will be used. Eg - AEAD_AES_256_CBC_HMAC_SHA256. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/>, <paramref name="clientEncryptionKeyId"/>, <paramref name="encryptionType"/> or <paramref name="encryptionAlgorithm"/> is null. </exception>
        public CosmosDBClientEncryptionIncludedPath(string path, string clientEncryptionKeyId, string encryptionType, string encryptionAlgorithm)
        {
            Argument.AssertNotNull(path, nameof(path));
            Argument.AssertNotNull(clientEncryptionKeyId, nameof(clientEncryptionKeyId));
            Argument.AssertNotNull(encryptionType, nameof(encryptionType));
            Argument.AssertNotNull(encryptionAlgorithm, nameof(encryptionAlgorithm));

            Path = path;
            ClientEncryptionKeyId = clientEncryptionKeyId;
            EncryptionType = encryptionType;
            EncryptionAlgorithm = encryptionAlgorithm;
        }

        /// <summary> Path that needs to be encrypted. </summary>
        public string Path { get; set; }
        /// <summary> The identifier of the Client Encryption Key to be used to encrypt the path. </summary>
        public string ClientEncryptionKeyId { get; set; }
        /// <summary> The type of encryption to be performed. Eg - Deterministic, Randomized. </summary>
        public string EncryptionType { get; set; }
        /// <summary> The encryption algorithm which will be used. Eg - AEAD_AES_256_CBC_HMAC_SHA256. </summary>
        public string EncryptionAlgorithm { get; set; }
    }
}
