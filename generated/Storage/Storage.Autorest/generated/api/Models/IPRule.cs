// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Storage.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Extensions;

    /// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
    public partial class IPRule :
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IIPRule,
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IIPRuleInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private string _action;

        /// <summary>The action of IP ACL rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string Action { get => this._action; set => this._action = value; }

        /// <summary>Backing field for <see cref="IPAddressOrRange" /> property.</summary>
        private string _iPAddressOrRange;

        /// <summary>Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Origin(Microsoft.Azure.PowerShell.Cmdlets.Storage.PropertyOrigin.Owned)]
        public string IPAddressOrRange { get => this._iPAddressOrRange; set => this._iPAddressOrRange = value; }

        /// <summary>Creates an new <see cref="IPRule" /> instance.</summary>
        public IPRule()
        {

        }
    }
    /// IP rule with specific IP or IP range in CIDR format.
    public partial interface IIPRule :
        Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.IJsonSerializable
    {
        /// <summary>The action of IP ACL rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The action of IP ACL rule.",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Storage.PSArgumentCompleterAttribute("Allow")]
        string Action { get; set; }
        /// <summary>Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Storage.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddressOrRange { get; set; }

    }
    /// IP rule with specific IP or IP range in CIDR format.
    internal partial interface IIPRuleInternal

    {
        /// <summary>The action of IP ACL rule.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Storage.PSArgumentCompleterAttribute("Allow")]
        string Action { get; set; }
        /// <summary>Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.</summary>
        string IPAddressOrRange { get; set; }

    }
}