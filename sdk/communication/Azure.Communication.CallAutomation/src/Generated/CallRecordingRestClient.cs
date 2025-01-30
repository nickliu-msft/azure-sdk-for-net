// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.CallAutomation
{
    internal partial class CallRecordingRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of CallRecordingRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public CallRecordingRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2024-09-01-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateStartRecordingRequest(StartCallRecordingRequestInternal startCallRecording)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/recordings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(startCallRecording);
            request.Content = content;
            return message;
        }

        /// <summary> Start recording the call. </summary>
        /// <param name="startCallRecording"> The request body of start call recording request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startCallRecording"/> is null. </exception>
        public async Task<Response<RecordingStateResult>> StartRecordingAsync(StartCallRecordingRequestInternal startCallRecording, CancellationToken cancellationToken = default)
        {
            if (startCallRecording == null)
            {
                throw new ArgumentNullException(nameof(startCallRecording));
            }

            using var message = CreateStartRecordingRequest(startCallRecording);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    {
                        RecordingStateResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RecordingStateResult.DeserializeRecordingStateResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Start recording the call. </summary>
        /// <param name="startCallRecording"> The request body of start call recording request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startCallRecording"/> is null. </exception>
        public Response<RecordingStateResult> StartRecording(StartCallRecordingRequestInternal startCallRecording, CancellationToken cancellationToken = default)
        {
            if (startCallRecording == null)
            {
                throw new ArgumentNullException(nameof(startCallRecording));
            }

            using var message = CreateStartRecordingRequest(startCallRecording);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    {
                        RecordingStateResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RecordingStateResult.DeserializeRecordingStateResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRecordingPropertiesRequest(string recordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/recordings/", false);
            uri.AppendPath(recordingId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get call recording properties. </summary>
        /// <param name="recordingId"> The recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recordingId"/> is null. </exception>
        public async Task<Response<RecordingStateResult>> GetRecordingPropertiesAsync(string recordingId, CancellationToken cancellationToken = default)
        {
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateGetRecordingPropertiesRequest(recordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RecordingStateResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RecordingStateResult.DeserializeRecordingStateResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get call recording properties. </summary>
        /// <param name="recordingId"> The recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recordingId"/> is null. </exception>
        public Response<RecordingStateResult> GetRecordingProperties(string recordingId, CancellationToken cancellationToken = default)
        {
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateGetRecordingPropertiesRequest(recordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RecordingStateResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RecordingStateResult.DeserializeRecordingStateResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateStopRecordingRequest(string recordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/recordings/", false);
            uri.AppendPath(recordingId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Stop recording the call. </summary>
        /// <param name="recordingId"> The recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recordingId"/> is null. </exception>
        public async Task<Response> StopRecordingAsync(string recordingId, CancellationToken cancellationToken = default)
        {
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateStopRecordingRequest(recordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Stop recording the call. </summary>
        /// <param name="recordingId"> The recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recordingId"/> is null. </exception>
        public Response StopRecording(string recordingId, CancellationToken cancellationToken = default)
        {
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateStopRecordingRequest(recordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePauseRecordingRequest(string recordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/recordings/", false);
            uri.AppendPath(recordingId, true);
            uri.AppendPath(":pause", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Pause recording the call. </summary>
        /// <param name="recordingId"> The recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recordingId"/> is null. </exception>
        public async Task<Response> PauseRecordingAsync(string recordingId, CancellationToken cancellationToken = default)
        {
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreatePauseRecordingRequest(recordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Pause recording the call. </summary>
        /// <param name="recordingId"> The recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recordingId"/> is null. </exception>
        public Response PauseRecording(string recordingId, CancellationToken cancellationToken = default)
        {
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreatePauseRecordingRequest(recordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateResumeRecordingRequest(string recordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/recordings/", false);
            uri.AppendPath(recordingId, true);
            uri.AppendPath(":resume", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Resume recording the call. </summary>
        /// <param name="recordingId"> The recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recordingId"/> is null. </exception>
        public async Task<Response> ResumeRecordingAsync(string recordingId, CancellationToken cancellationToken = default)
        {
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateResumeRecordingRequest(recordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Resume recording the call. </summary>
        /// <param name="recordingId"> The recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recordingId"/> is null. </exception>
        public Response ResumeRecording(string recordingId, CancellationToken cancellationToken = default)
        {
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateResumeRecordingRequest(recordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRecordingResultRequest(string recordingId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/calling/recordings/", false);
            uri.AppendPath(recordingId, true);
            uri.AppendPath("/result", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get recording result. This includes the download URLs for the recording chunks. </summary>
        /// <param name="recordingId"> The recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recordingId"/> is null. </exception>
        public async Task<Response<RecordingResult>> GetRecordingResultAsync(string recordingId, CancellationToken cancellationToken = default)
        {
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateGetRecordingResultRequest(recordingId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RecordingResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RecordingResult.DeserializeRecordingResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get recording result. This includes the download URLs for the recording chunks. </summary>
        /// <param name="recordingId"> The recording id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recordingId"/> is null. </exception>
        public Response<RecordingResult> GetRecordingResult(string recordingId, CancellationToken cancellationToken = default)
        {
            if (recordingId == null)
            {
                throw new ArgumentNullException(nameof(recordingId));
            }

            using var message = CreateGetRecordingResultRequest(recordingId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RecordingResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RecordingResult.DeserializeRecordingResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
