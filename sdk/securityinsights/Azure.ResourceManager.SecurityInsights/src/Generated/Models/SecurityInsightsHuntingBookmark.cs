// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a Hunting bookmark entity. </summary>
    public partial class SecurityInsightsHuntingBookmark : SecurityInsightsEntity
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsHuntingBookmark"/>. </summary>
        public SecurityInsightsHuntingBookmark()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Labels = new ChangeTrackingList<string>();
            Kind = SecurityInsightsEntityKind.Bookmark;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsHuntingBookmark"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="createdOn"> The time the bookmark was created. </param>
        /// <param name="createdBy"> Describes a user that created the bookmark. </param>
        /// <param name="displayName"> The display name of the bookmark. </param>
        /// <param name="eventOn"> The time of the event. </param>
        /// <param name="labels"> List of labels relevant to this bookmark. </param>
        /// <param name="notes"> The notes of the bookmark. </param>
        /// <param name="query"> The query of the bookmark. </param>
        /// <param name="queryResult"> The query result of the bookmark. </param>
        /// <param name="updatedOn"> The last time the bookmark was updated. </param>
        /// <param name="updatedBy"> Describes a user that updated the bookmark. </param>
        /// <param name="incidentInfo"> Describes an incident that relates to bookmark. </param>
        internal SecurityInsightsHuntingBookmark(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SecurityInsightsEntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, DateTimeOffset? createdOn, SecurityInsightsUserInfo createdBy, string displayName, DateTimeOffset? eventOn, IList<string> labels, string notes, string query, string queryResult, DateTimeOffset? updatedOn, SecurityInsightsUserInfo updatedBy, SecurityInsightsBookmarkIncidentInfo incidentInfo) : base(id, name, resourceType, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            CreatedOn = createdOn;
            CreatedBy = createdBy;
            DisplayName = displayName;
            EventOn = eventOn;
            Labels = labels;
            Notes = notes;
            Query = query;
            QueryResult = queryResult;
            UpdatedOn = updatedOn;
            UpdatedBy = updatedBy;
            IncidentInfo = incidentInfo;
            Kind = kind;
        }

        /// <summary>
        /// A bag of custom fields that should be part of the entity and will be presented to the user.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The time the bookmark was created. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> Describes a user that created the bookmark. </summary>
        public SecurityInsightsUserInfo CreatedBy { get; set; }
        /// <summary> The display name of the bookmark. </summary>
        public string DisplayName { get; set; }
        /// <summary> The time of the event. </summary>
        public DateTimeOffset? EventOn { get; set; }
        /// <summary> List of labels relevant to this bookmark. </summary>
        public IList<string> Labels { get; }
        /// <summary> The notes of the bookmark. </summary>
        public string Notes { get; set; }
        /// <summary> The query of the bookmark. </summary>
        public string Query { get; set; }
        /// <summary> The query result of the bookmark. </summary>
        public string QueryResult { get; set; }
        /// <summary> The last time the bookmark was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; set; }
        /// <summary> Describes a user that updated the bookmark. </summary>
        public SecurityInsightsUserInfo UpdatedBy { get; set; }
        /// <summary> Describes an incident that relates to bookmark. </summary>
        public SecurityInsightsBookmarkIncidentInfo IncidentInfo { get; set; }
    }
}
