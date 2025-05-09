// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Extensions;

    /// <summary>The list of bot service connection settings response.</summary>
    public partial class ConnectionSettingResponseList :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IConnectionSettingResponseList,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IConnectionSettingResponseListInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IConnectionSetting> Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IConnectionSettingResponseListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link used to get the next page of bot service connection setting resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IConnectionSetting> _value;

        /// <summary>Gets the list of bot service connection settings and their properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IConnectionSetting> Value { get => this._value; }

        /// <summary>Creates an new <see cref="ConnectionSettingResponseList" /> instance.</summary>
        public ConnectionSettingResponseList()
        {

        }
    }
    /// The list of bot service connection settings response.
    public partial interface IConnectionSettingResponseList :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IJsonSerializable
    {
        /// <summary>The link used to get the next page of bot service connection setting resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link used to get the next page of bot service connection setting resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Gets the list of bot service connection settings and their properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets the list of bot service connection settings and their properties.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IConnectionSetting) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IConnectionSetting> Value { get;  }

    }
    /// The list of bot service connection settings response.
    internal partial interface IConnectionSettingResponseListInternal

    {
        /// <summary>The link used to get the next page of bot service connection setting resources.</summary>
        string NextLink { get; set; }
        /// <summary>Gets the list of bot service connection settings and their properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IConnectionSetting> Value { get; set; }

    }
}