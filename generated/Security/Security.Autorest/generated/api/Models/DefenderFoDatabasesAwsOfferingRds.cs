// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Security.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Extensions;

    /// <summary>The RDS configuration</summary>
    public partial class DefenderFoDatabasesAwsOfferingRds :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderFoDatabasesAwsOfferingRds,
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderFoDatabasesAwsOfferingRdsInternal
    {

        /// <summary>Backing field for <see cref="CloudRoleArn" /> property.</summary>
        private string _cloudRoleArn;

        /// <summary>The cloud role ARN in AWS for this feature</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string CloudRoleArn { get => this._cloudRoleArn; set => this._cloudRoleArn = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Is RDS protection enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Creates an new <see cref="DefenderFoDatabasesAwsOfferingRds" /> instance.</summary>
        public DefenderFoDatabasesAwsOfferingRds()
        {

        }
    }
    /// The RDS configuration
    public partial interface IDefenderFoDatabasesAwsOfferingRds :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.IJsonSerializable
    {
        /// <summary>The cloud role ARN in AWS for this feature</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The cloud role ARN in AWS for this feature",
        SerializedName = @"cloudRoleArn",
        PossibleTypes = new [] { typeof(string) })]
        string CloudRoleArn { get; set; }
        /// <summary>Is RDS protection enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Is RDS protection enabled",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

    }
    /// The RDS configuration
    internal partial interface IDefenderFoDatabasesAwsOfferingRdsInternal

    {
        /// <summary>The cloud role ARN in AWS for this feature</summary>
        string CloudRoleArn { get; set; }
        /// <summary>Is RDS protection enabled</summary>
        bool? Enabled { get; set; }

    }
}