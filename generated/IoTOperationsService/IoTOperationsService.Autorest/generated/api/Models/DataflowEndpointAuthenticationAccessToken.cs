// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Extensions;

    /// <summary>DataflowEndpoint Authentication Access Token properties</summary>
    public partial class DataflowEndpointAuthenticationAccessToken :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationAccessToken,
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowEndpointAuthenticationAccessTokenInternal
    {

        /// <summary>Backing field for <see cref="SecretRef" /> property.</summary>
        private string _secretRef;

        /// <summary>Token secret name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public string SecretRef { get => this._secretRef; set => this._secretRef = value; }

        /// <summary>
        /// Creates an new <see cref="DataflowEndpointAuthenticationAccessToken" /> instance.
        /// </summary>
        public DataflowEndpointAuthenticationAccessToken()
        {

        }
    }
    /// DataflowEndpoint Authentication Access Token properties
    public partial interface IDataflowEndpointAuthenticationAccessToken :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IJsonSerializable
    {
        /// <summary>Token secret name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Token secret name.",
        SerializedName = @"secretRef",
        PossibleTypes = new [] { typeof(string) })]
        string SecretRef { get; set; }

    }
    /// DataflowEndpoint Authentication Access Token properties
    internal partial interface IDataflowEndpointAuthenticationAccessTokenInternal

    {
        /// <summary>Token secret name.</summary>
        string SecretRef { get; set; }

    }
}