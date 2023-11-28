// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates connection to SQL Server and also validates source server requirements. </summary>
    public partial class ConnectToSourceSqlServerTaskInput
    {
        /// <summary> Initializes a new instance of <see cref="ConnectToSourceSqlServerTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Connection information for Source SQL Server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/> is null. </exception>
        public ConnectToSourceSqlServerTaskInput(SqlConnectionInfo sourceConnectionInfo)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));

            SourceConnectionInfo = sourceConnectionInfo;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToSourceSqlServerTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Connection information for Source SQL Server. </param>
        /// <param name="checkPermissionsGroup"> Permission group for validations. </param>
        /// <param name="collectDatabases"> Flag for whether to collect databases from source server. </param>
        /// <param name="collectLogins"> Flag for whether to collect logins from source server. </param>
        /// <param name="collectAgentJobs"> Flag for whether to collect agent jobs from source server. </param>
        /// <param name="collectTdeCertificateInfo"> Flag for whether to collect TDE Certificate names from source server. </param>
        /// <param name="validateSsisCatalogOnly"> Flag for whether to validate SSIS catalog is reachable on the source server. </param>
        /// <param name="encryptedKeyForSecureFields"> encrypted key for secure fields. </param>
        internal ConnectToSourceSqlServerTaskInput(SqlConnectionInfo sourceConnectionInfo, ServerLevelPermissionsGroup? checkPermissionsGroup, bool? collectDatabases, bool? collectLogins, bool? collectAgentJobs, bool? collectTdeCertificateInfo, bool? validateSsisCatalogOnly, string encryptedKeyForSecureFields)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            CheckPermissionsGroup = checkPermissionsGroup;
            CollectDatabases = collectDatabases;
            CollectLogins = collectLogins;
            CollectAgentJobs = collectAgentJobs;
            CollectTdeCertificateInfo = collectTdeCertificateInfo;
            ValidateSsisCatalogOnly = validateSsisCatalogOnly;
            EncryptedKeyForSecureFields = encryptedKeyForSecureFields;
        }

        /// <summary> Connection information for Source SQL Server. </summary>
        public SqlConnectionInfo SourceConnectionInfo { get; set; }
        /// <summary> Permission group for validations. </summary>
        public ServerLevelPermissionsGroup? CheckPermissionsGroup { get; set; }
        /// <summary> Flag for whether to collect databases from source server. </summary>
        public bool? CollectDatabases { get; set; }
        /// <summary> Flag for whether to collect logins from source server. </summary>
        public bool? CollectLogins { get; set; }
        /// <summary> Flag for whether to collect agent jobs from source server. </summary>
        public bool? CollectAgentJobs { get; set; }
        /// <summary> Flag for whether to collect TDE Certificate names from source server. </summary>
        public bool? CollectTdeCertificateInfo { get; set; }
        /// <summary> Flag for whether to validate SSIS catalog is reachable on the source server. </summary>
        public bool? ValidateSsisCatalogOnly { get; set; }
        /// <summary> encrypted key for secure fields. </summary>
        public string EncryptedKeyForSecureFields { get; set; }
    }
}
