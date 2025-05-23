// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Properties which are specific to datasource/datasourceSets</summary>
    public partial class BaseResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IBaseResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IBaseResourcePropertiesInternal
    {

        /// <summary>Internal Acessors for ObjectType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202501.IBaseResourcePropertiesInternal.ObjectType { get => this._objectType; set { {_objectType = value;} } }

        /// <summary>Backing field for <see cref="ObjectType" /> property.</summary>
        private string _objectType= @"DefaultResourceProperties";

        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string ObjectType { get => this._objectType; }

        /// <summary>Creates an new <see cref="BaseResourceProperties" /> instance.</summary>
        public BaseResourceProperties()
        {

        }
    }
    /// Properties which are specific to datasource/datasourceSets
    public partial interface IBaseResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>Type of the specific object - used for deserializing</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"Type of the specific object - used for deserializing",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectType { get;  }

    }
    /// Properties which are specific to datasource/datasourceSets
    internal partial interface IBaseResourcePropertiesInternal

    {
        /// <summary>Type of the specific object - used for deserializing</summary>
        string ObjectType { get; set; }

    }
}