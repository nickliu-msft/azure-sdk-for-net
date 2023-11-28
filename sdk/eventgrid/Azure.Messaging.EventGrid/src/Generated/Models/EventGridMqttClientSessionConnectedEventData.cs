// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Event data for Microsoft.EventGrid.MQTTClientSessionConnected event. </summary>
    public partial class EventGridMqttClientSessionConnectedEventData : EventGridMqttClientEventData
    {
        /// <summary> Initializes a new instance of <see cref="EventGridMqttClientSessionConnectedEventData"/>. </summary>
        internal EventGridMqttClientSessionConnectedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventGridMqttClientSessionConnectedEventData"/>. </summary>
        /// <param name="clientAuthenticationName"> Unique identifier for the MQTT client that the client presents to the service for authentication. This case-sensitive string can be up to 128 characters long, and supports UTF-8 characters. </param>
        /// <param name="clientName"> Name of the client resource in the Event Grid namespace. </param>
        /// <param name="namespaceName"> Name of the Event Grid namespace where the MQTT client was created or updated. </param>
        /// <param name="clientSessionName"> Unique identifier for the MQTT client's session. This case-sensitive string can be up to 128 characters long, and supports UTF-8 characters. </param>
        /// <param name="sequenceNumber"> A number that helps indicate order of MQTT client session connected or disconnected events. Latest event will have a sequence number that is higher than the previous event. </param>
        internal EventGridMqttClientSessionConnectedEventData(string clientAuthenticationName, string clientName, string namespaceName, string clientSessionName, long? sequenceNumber) : base(clientAuthenticationName, clientName, namespaceName)
        {
            ClientSessionName = clientSessionName;
            SequenceNumber = sequenceNumber;
        }

        /// <summary> Unique identifier for the MQTT client's session. This case-sensitive string can be up to 128 characters long, and supports UTF-8 characters. </summary>
        public string ClientSessionName { get; }
        /// <summary> A number that helps indicate order of MQTT client session connected or disconnected events. Latest event will have a sequence number that is higher than the previous event. </summary>
        public long? SequenceNumber { get; }
    }
}
