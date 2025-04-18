// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Extensions;

    /// <summary>Defines the request body for updating SAP Central Instance.</summary>
    public partial class UpdateSapCentralInstanceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IUpdateSapCentralInstanceRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IUpdateSapCentralInstanceRequestInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IUpdateSapCentralInstanceRequestTags _tag;

        /// <summary>Gets or sets the Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IUpdateSapCentralInstanceRequestTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.UpdateSapCentralInstanceRequestTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="UpdateSapCentralInstanceRequest" /> instance.</summary>
        public UpdateSapCentralInstanceRequest()
        {

        }
    }
    /// Defines the request body for updating SAP Central Instance.
    public partial interface IUpdateSapCentralInstanceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IUpdateSapCentralInstanceRequestTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IUpdateSapCentralInstanceRequestTags Tag { get; set; }

    }
    /// Defines the request body for updating SAP Central Instance.
    internal partial interface IUpdateSapCentralInstanceRequestInternal

    {
        /// <summary>Gets or sets the Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Models.Api20240901.IUpdateSapCentralInstanceRequestTags Tag { get; set; }

    }
}