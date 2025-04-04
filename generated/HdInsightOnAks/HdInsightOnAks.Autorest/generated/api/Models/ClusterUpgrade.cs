// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Extensions;

    /// <summary>Cluster Upgrade.</summary>
    public partial class ClusterUpgrade :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgrade,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradeInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradeProperties Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradeInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterUpgradeProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradeProperties _property;

        /// <summary>Properties of upgrading cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterUpgradeProperties()); set => this._property = value; }

        /// <summary>Type of upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inlined)]
        public string UpgradeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradePropertiesInternal)Property).UpgradeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradePropertiesInternal)Property).UpgradeType = value ; }

        /// <summary>Creates an new <see cref="ClusterUpgrade" /> instance.</summary>
        public ClusterUpgrade()
        {

        }
    }
    /// Cluster Upgrade.
    public partial interface IClusterUpgrade :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IJsonSerializable
    {
        /// <summary>Type of upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of upgrade.",
        SerializedName = @"upgradeType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PSArgumentCompleterAttribute("AKSPatchUpgrade", "HotfixUpgrade", "PatchVersionUpgrade")]
        string UpgradeType { get; set; }

    }
    /// Cluster Upgrade.
    internal partial interface IClusterUpgradeInternal

    {
        /// <summary>Properties of upgrading cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradeProperties Property { get; set; }
        /// <summary>Type of upgrade.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PSArgumentCompleterAttribute("AKSPatchUpgrade", "HotfixUpgrade", "PatchVersionUpgrade")]
        string UpgradeType { get; set; }

    }
}