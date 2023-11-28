// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that gets the list of tables for a provided list of PostgreSQL databases. </summary>
    public partial class GetUserTablesPostgreSqlTaskInput
    {
        /// <summary> Initializes a new instance of <see cref="GetUserTablesPostgreSqlTaskInput"/>. </summary>
        /// <param name="connectionInfo"> Information for connecting to PostgreSQL source. </param>
        /// <param name="selectedDatabases"> List of PostgreSQL databases for which to collect tables. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionInfo"/> or <paramref name="selectedDatabases"/> is null. </exception>
        public GetUserTablesPostgreSqlTaskInput(PostgreSqlConnectionInfo connectionInfo, IEnumerable<string> selectedDatabases)
        {
            Argument.AssertNotNull(connectionInfo, nameof(connectionInfo));
            Argument.AssertNotNull(selectedDatabases, nameof(selectedDatabases));

            ConnectionInfo = connectionInfo;
            SelectedDatabases = selectedDatabases.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GetUserTablesPostgreSqlTaskInput"/>. </summary>
        /// <param name="connectionInfo"> Information for connecting to PostgreSQL source. </param>
        /// <param name="selectedDatabases"> List of PostgreSQL databases for which to collect tables. </param>
        internal GetUserTablesPostgreSqlTaskInput(PostgreSqlConnectionInfo connectionInfo, IList<string> selectedDatabases)
        {
            ConnectionInfo = connectionInfo;
            SelectedDatabases = selectedDatabases;
        }

        /// <summary> Information for connecting to PostgreSQL source. </summary>
        public PostgreSqlConnectionInfo ConnectionInfo { get; set; }
        /// <summary> List of PostgreSQL databases for which to collect tables. </summary>
        public IList<string> SelectedDatabases { get; }
    }
}
