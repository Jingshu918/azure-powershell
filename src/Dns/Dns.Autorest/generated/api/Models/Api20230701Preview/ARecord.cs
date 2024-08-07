// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Extensions;

    /// <summary>An A record.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.Dns.DoNotFormat]
    public partial class ARecord :
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IARecord,
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Models.Api20230701Preview.IARecordInternal
    {

        /// <summary>Backing field for <see cref="Ipv4Address" /> property.</summary>
        private string _ipv4Address;

        /// <summary>The IPv4 address of this A record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dns.PropertyOrigin.Owned)]
        public string Ipv4Address { get => this._ipv4Address; set => this._ipv4Address = value; }

        /// <summary>Creates an new <see cref="ARecord" /> instance.</summary>
        public ARecord()
        {

        }
    }
    /// An A record.
    public partial interface IARecord :
        Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.IJsonSerializable
    {
        /// <summary>The IPv4 address of this A record.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dns.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IPv4 address of this A record.",
        SerializedName = @"ipv4Address",
        PossibleTypes = new [] { typeof(string) })]
        string Ipv4Address { get; set; }

    }
    /// An A record.
    internal partial interface IARecordInternal

    {
        /// <summary>The IPv4 address of this A record.</summary>
        string Ipv4Address { get; set; }

    }
}