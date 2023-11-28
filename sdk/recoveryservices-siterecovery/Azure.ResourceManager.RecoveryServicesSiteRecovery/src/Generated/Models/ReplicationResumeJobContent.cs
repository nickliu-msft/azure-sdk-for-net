// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Resume job params. </summary>
    public partial class ReplicationResumeJobContent
    {
        /// <summary> Initializes a new instance of <see cref="ReplicationResumeJobContent"/>. </summary>
        public ReplicationResumeJobContent()
        {
        }

        /// <summary> Resume job properties. </summary>
        internal ReplicationResumeJobProperties Properties { get; set; }
        /// <summary> Resume job comments. </summary>
        public string ReplicationResumeJobComments
        {
            get => Properties is null ? default : Properties.Comments;
            set
            {
                if (Properties is null)
                    Properties = new ReplicationResumeJobProperties();
                Properties.Comments = value;
            }
        }
    }
}
