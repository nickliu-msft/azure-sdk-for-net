// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for Salesforce V2. </summary>
    public partial class SalesforceV2LinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="SalesforceV2LinkedService"/>. </summary>
        public SalesforceV2LinkedService()
        {
            Type = "SalesforceV2";
        }

        /// <summary> Initializes a new instance of <see cref="SalesforceV2LinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="environmentUrl"> The URL of Salesforce instance. For example, 'https://[domain].my.salesforce.com'. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> The authentication type to be used to connect to the Salesforce. Currently, we only support OAuth2ClientCredentials, it is also the default value. </param>
        /// <param name="clientId"> The client Id for OAuth 2.0 Client Credentials Flow authentication of the Salesforce instance. Type: string (or Expression with resultType string). </param>
        /// <param name="clientSecret">
        /// The client secret for OAuth 2.0 Client Credentials Flow authentication of the Salesforce instance.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="apiVersion"> The Salesforce API version used in ADF. The version must be larger than or equal to 47.0 which is required by Salesforce BULK API 2.0. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal SalesforceV2LinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object environmentUrl, object authenticationType, object clientId, SecretBase clientSecret, object apiVersion, string encryptedCredential) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            EnvironmentUrl = environmentUrl;
            AuthenticationType = authenticationType;
            ClientId = clientId;
            ClientSecret = clientSecret;
            ApiVersion = apiVersion;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "SalesforceV2";
        }

        /// <summary> The URL of Salesforce instance. For example, 'https://[domain].my.salesforce.com'. Type: string (or Expression with resultType string). </summary>
        public object EnvironmentUrl { get; set; }
        /// <summary> The authentication type to be used to connect to the Salesforce. Currently, we only support OAuth2ClientCredentials, it is also the default value. </summary>
        public object AuthenticationType { get; set; }
        /// <summary> The client Id for OAuth 2.0 Client Credentials Flow authentication of the Salesforce instance. Type: string (or Expression with resultType string). </summary>
        public object ClientId { get; set; }
        /// <summary>
        /// The client secret for OAuth 2.0 Client Credentials Flow authentication of the Salesforce instance.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase ClientSecret { get; set; }
        /// <summary> The Salesforce API version used in ADF. The version must be larger than or equal to 47.0 which is required by Salesforce BULK API 2.0. Type: string (or Expression with resultType string). </summary>
        public object ApiVersion { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
