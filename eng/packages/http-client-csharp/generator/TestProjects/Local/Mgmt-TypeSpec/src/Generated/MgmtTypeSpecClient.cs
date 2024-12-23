// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace MgmtTypeSpec
{
    /// <summary></summary>
    public partial class MgmtTypeSpecClient
    {
        private readonly Uri _endpoint;
        /// <summary> A credential used to authenticate to the service. </summary>
        private readonly TokenCredential _tokenCredential;
        private static readonly string[] AuthorizationScopes = new string[] { "user_impersonation" };
        private Operations _cachedOperations;
        private PrivateLinks _cachedPrivateLinks;
        private Foos _cachedFoos;

        /// <summary> Initializes a new instance of MgmtTypeSpecClient for mocking. </summary>
        protected MgmtTypeSpecClient()
        {
        }

        /// <summary> Initializes a new instance of MgmtTypeSpecClient. </summary>
        /// <param name="tokenCredential"> A credential used to authenticate to the service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tokenCredential"/> is null. </exception>
        public MgmtTypeSpecClient(TokenCredential tokenCredential) : this(new Uri("https://management.azure.com"), tokenCredential, new MgmtTypeSpecClientOptions())
        {
        }

        /// <summary> Initializes a new instance of MgmtTypeSpecClient. </summary>
        /// <param name="endpoint"> Service endpoint. </param>
        /// <param name="tokenCredential"> A credential used to authenticate to the service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="tokenCredential"/> is null. </exception>
        public MgmtTypeSpecClient(Uri endpoint, TokenCredential tokenCredential, MgmtTypeSpecClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(tokenCredential, nameof(tokenCredential));

            options ??= new MgmtTypeSpecClientOptions();

            _endpoint = endpoint;
            _tokenCredential = tokenCredential;
            Pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) });
        }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public HttpPipeline Pipeline { get; }

        /// <summary> Initializes a new instance of Operations. </summary>
        public virtual Operations GetOperationsClient()
        {
            return Volatile.Read(ref _cachedOperations) ?? Interlocked.CompareExchange(ref _cachedOperations, new Operations(Pipeline, _tokenCredential, _endpoint), null) ?? _cachedOperations;
        }

        /// <summary> Initializes a new instance of PrivateLinks. </summary>
        public virtual PrivateLinks GetPrivateLinksClient()
        {
            return Volatile.Read(ref _cachedPrivateLinks) ?? Interlocked.CompareExchange(ref _cachedPrivateLinks, new PrivateLinks(Pipeline, _tokenCredential, _endpoint), null) ?? _cachedPrivateLinks;
        }

        /// <summary> Initializes a new instance of Foos. </summary>
        public virtual Foos GetFoosClient()
        {
            return Volatile.Read(ref _cachedFoos) ?? Interlocked.CompareExchange(ref _cachedFoos, new Foos(Pipeline, _tokenCredential, _endpoint), null) ?? _cachedFoos;
        }
    }
}
