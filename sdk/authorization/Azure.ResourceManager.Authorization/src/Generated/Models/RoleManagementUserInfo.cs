// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The detail of a user. </summary>
    public partial class RoleManagementUserInfo
    {
        /// <summary> Initializes a new instance of <see cref="RoleManagementUserInfo"/>. </summary>
        public RoleManagementUserInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RoleManagementUserInfo"/>. </summary>
        /// <param name="userType"> The type of user. </param>
        /// <param name="isBackup"> The value indicating whether the user is a backup fallback approver. </param>
        /// <param name="id"> The object id of the user. </param>
        /// <param name="description"> The description of the user. </param>
        internal RoleManagementUserInfo(RoleManagementUserType? userType, bool? isBackup, string id, string description)
        {
            UserType = userType;
            IsBackup = isBackup;
            Id = id;
            Description = description;
        }

        /// <summary> The type of user. </summary>
        public RoleManagementUserType? UserType { get; set; }
        /// <summary> The value indicating whether the user is a backup fallback approver. </summary>
        public bool? IsBackup { get; set; }
        /// <summary> The object id of the user. </summary>
        public string Id { get; set; }
        /// <summary> The description of the user. </summary>
        public string Description { get; set; }
    }
}
