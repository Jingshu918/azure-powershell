// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Extensions;

    /// <summary>Mongo source and target database and collection details.</summary>
    public partial class MongoMigrationCollection :
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollection,
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal
    {

        /// <summary>Internal Acessors for MigrationProgressDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetails Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal.MigrationProgressDetail { get => (this._migrationProgressDetail = this._migrationProgressDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.MongoMigrationProgressDetails()); set { {_migrationProgressDetail = value;} } }

        /// <summary>Internal Acessors for MigrationProgressDetailDurationInSecond</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal.MigrationProgressDetailDurationInSecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).DurationInSecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).DurationInSecond = value; }

        /// <summary>Internal Acessors for MigrationProgressDetailMigrationError</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal.MigrationProgressDetailMigrationError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).MigrationError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).MigrationError = value; }

        /// <summary>Internal Acessors for MigrationProgressDetailMigrationStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.MongoMigrationStatus? Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal.MigrationProgressDetailMigrationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).MigrationStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).MigrationStatus = value; }

        /// <summary>Internal Acessors for MigrationProgressDetailProcessedDocumentCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal.MigrationProgressDetailProcessedDocumentCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).ProcessedDocumentCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).ProcessedDocumentCount = value; }

        /// <summary>Internal Acessors for MigrationProgressDetailSourceDocumentCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationCollectionInternal.MigrationProgressDetailSourceDocumentCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).SourceDocumentCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).SourceDocumentCount = value; }

        /// <summary>Backing field for <see cref="MigrationProgressDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetails _migrationProgressDetail;

        /// <summary>Detailed migration status. Not included by default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetails MigrationProgressDetail { get => (this._migrationProgressDetail = this._migrationProgressDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.MongoMigrationProgressDetails()); }

        /// <summary>Migration duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public int? MigrationProgressDetailDurationInSecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).DurationInSecond; }

        /// <summary>Migration Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public string MigrationProgressDetailMigrationError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).MigrationError; }

        /// <summary>Migration Status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.MongoMigrationStatus? MigrationProgressDetailMigrationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).MigrationStatus; }

        /// <summary>Processed Document Count</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public long? MigrationProgressDetailProcessedDocumentCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).ProcessedDocumentCount; }

        /// <summary>Source Document Count</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Inlined)]
        public long? MigrationProgressDetailSourceDocumentCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetailsInternal)MigrationProgressDetail).SourceDocumentCount; }

        /// <summary>Backing field for <see cref="SourceCollection" /> property.</summary>
        private string _sourceCollection;

        /// <summary>Source collection name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public string SourceCollection { get => this._sourceCollection; set => this._sourceCollection = value; }

        /// <summary>Backing field for <see cref="SourceDatabase" /> property.</summary>
        private string _sourceDatabase;

        /// <summary>Source database name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public string SourceDatabase { get => this._sourceDatabase; set => this._sourceDatabase = value; }

        /// <summary>Backing field for <see cref="TargetCollection" /> property.</summary>
        private string _targetCollection;

        /// <summary>Target collection name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public string TargetCollection { get => this._targetCollection; set => this._targetCollection = value; }

        /// <summary>Backing field for <see cref="TargetDatabase" /> property.</summary>
        private string _targetDatabase;

        /// <summary>Target database name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.PropertyOrigin.Owned)]
        public string TargetDatabase { get => this._targetDatabase; set => this._targetDatabase = value; }

        /// <summary>Creates an new <see cref="MongoMigrationCollection" /> instance.</summary>
        public MongoMigrationCollection()
        {

        }
    }
    /// Mongo source and target database and collection details.
    public partial interface IMongoMigrationCollection :
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.IJsonSerializable
    {
        /// <summary>Migration duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Migration duration",
        SerializedName = @"durationInSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? MigrationProgressDetailDurationInSecond { get;  }
        /// <summary>Migration Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Migration Error",
        SerializedName = @"migrationError",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationProgressDetailMigrationError { get;  }
        /// <summary>Migration Status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Migration Status",
        SerializedName = @"migrationStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.MongoMigrationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.MongoMigrationStatus? MigrationProgressDetailMigrationStatus { get;  }
        /// <summary>Processed Document Count</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Processed Document Count",
        SerializedName = @"processedDocumentCount",
        PossibleTypes = new [] { typeof(long) })]
        long? MigrationProgressDetailProcessedDocumentCount { get;  }
        /// <summary>Source Document Count</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Source Document Count",
        SerializedName = @"sourceDocumentCount",
        PossibleTypes = new [] { typeof(long) })]
        long? MigrationProgressDetailSourceDocumentCount { get;  }
        /// <summary>Source collection name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source collection name.",
        SerializedName = @"sourceCollection",
        PossibleTypes = new [] { typeof(string) })]
        string SourceCollection { get; set; }
        /// <summary>Source database name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source database name.",
        SerializedName = @"sourceDatabase",
        PossibleTypes = new [] { typeof(string) })]
        string SourceDatabase { get; set; }
        /// <summary>Target collection name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target collection name.",
        SerializedName = @"targetCollection",
        PossibleTypes = new [] { typeof(string) })]
        string TargetCollection { get; set; }
        /// <summary>Target database name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target database name.",
        SerializedName = @"targetDatabase",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDatabase { get; set; }

    }
    /// Mongo source and target database and collection details.
    internal partial interface IMongoMigrationCollectionInternal

    {
        /// <summary>Detailed migration status. Not included by default.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.IMongoMigrationProgressDetails MigrationProgressDetail { get; set; }
        /// <summary>Migration duration</summary>
        int? MigrationProgressDetailDurationInSecond { get; set; }
        /// <summary>Migration Error</summary>
        string MigrationProgressDetailMigrationError { get; set; }
        /// <summary>Migration Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Support.MongoMigrationStatus? MigrationProgressDetailMigrationStatus { get; set; }
        /// <summary>Processed Document Count</summary>
        long? MigrationProgressDetailProcessedDocumentCount { get; set; }
        /// <summary>Source Document Count</summary>
        long? MigrationProgressDetailSourceDocumentCount { get; set; }
        /// <summary>Source collection name.</summary>
        string SourceCollection { get; set; }
        /// <summary>Source database name.</summary>
        string SourceDatabase { get; set; }
        /// <summary>Target collection name.</summary>
        string TargetCollection { get; set; }
        /// <summary>Target database name.</summary>
        string TargetDatabase { get; set; }

    }
}