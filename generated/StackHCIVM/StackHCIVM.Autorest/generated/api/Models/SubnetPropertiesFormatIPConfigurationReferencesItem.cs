// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Extensions;

    /// <summary>
    /// IPConfigurationReference - Describes a IPConfiguration under the virtual network
    /// </summary>
    public partial class SubnetPropertiesFormatIPConfigurationReferencesItem :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatIPConfigurationReferencesItem,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatIPConfigurationReferencesItemInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>IPConfigurationID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>
        /// Creates an new <see cref="SubnetPropertiesFormatIPConfigurationReferencesItem" /> instance.
        /// </summary>
        public SubnetPropertiesFormatIPConfigurationReferencesItem()
        {

        }
    }
    /// IPConfigurationReference - Describes a IPConfiguration under the virtual network
    public partial interface ISubnetPropertiesFormatIPConfigurationReferencesItem :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.IJsonSerializable
    {
        /// <summary>IPConfigurationID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IPConfigurationID",
        SerializedName = @"ID",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// IPConfigurationReference - Describes a IPConfiguration under the virtual network
    internal partial interface ISubnetPropertiesFormatIPConfigurationReferencesItemInternal

    {
        /// <summary>IPConfigurationID</summary>
        string Id { get; set; }

    }
}