// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A WebLinkedService that uses client certificate based authentication to communicate with an HTTP endpoint. This scheme follows mutual authentication; the server must also provide valid credentials to the client. </summary>
    public partial class WebClientCertificateAuthentication : WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of <see cref="WebClientCertificateAuthentication"/>. </summary>
        /// <param name="url"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="pfx">
        /// Base64-encoded contents of a PFX file.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="password">
        /// Password for the PFX file.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/>, <paramref name="pfx"/> or <paramref name="password"/> is null. </exception>
        public WebClientCertificateAuthentication(object url, SecretBase pfx, SecretBase password) : base(url)
        {
            Argument.AssertNotNull(url, nameof(url));
            Argument.AssertNotNull(pfx, nameof(pfx));
            Argument.AssertNotNull(password, nameof(password));

            Pfx = pfx;
            Password = password;
            AuthenticationType = WebAuthenticationType.ClientCertificate;
        }

        /// <summary> Initializes a new instance of <see cref="WebClientCertificateAuthentication"/>. </summary>
        /// <param name="url"> The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        /// <param name="pfx">
        /// Base64-encoded contents of a PFX file.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="password">
        /// Password for the PFX file.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        internal WebClientCertificateAuthentication(object url, WebAuthenticationType authenticationType, SecretBase pfx, SecretBase password) : base(url, authenticationType)
        {
            Pfx = pfx;
            Password = password;
            AuthenticationType = authenticationType;
        }

        /// <summary>
        /// Base64-encoded contents of a PFX file.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Pfx { get; set; }
        /// <summary>
        /// Password for the PFX file.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
    }
}
