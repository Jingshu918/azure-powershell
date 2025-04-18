// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Extensions;

    /// <summary>
    /// Contains clientId or objectId (use only one, not both) of a user-assigned managed identity that has access to storage
    /// blob used in Run Command. Use an empty RunCommandManagedIdentity object in case of system-assigned identity. Make sure
    /// the Azure storage blob exists in case of scriptUri, and managed identity has been given access to blob's container with
    /// 'Storage Blob Data Reader' role assignment with scriptUri blob and 'Storage Blob Data Contributor' for Append blobs(outputBlobUri,
    /// errorBlobUri). In case of user assigned identity, make sure you add it under VM's identity. For more info on managed identity
    /// and Run Command, refer https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged.
    /// </summary>
    public partial class RunCommandManagedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IRunCommandManagedIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IRunCommandManagedIdentityInternal
    {

        /// <summary>Backing field for <see cref="ClientId" /> property.</summary>
        private string _clientId;

        /// <summary>
        /// Client Id (GUID value) of the user-assigned managed identity. ObjectId should not be used if this is provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Owned)]
        public string ClientId { get => this._clientId; set => this._clientId = value; }

        /// <summary>Backing field for <see cref="ObjectId" /> property.</summary>
        private string _objectId;

        /// <summary>
        /// Object Id (GUID value) of the user-assigned managed identity. ClientId should not be used if this is provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.PropertyOrigin.Owned)]
        public string ObjectId { get => this._objectId; set => this._objectId = value; }

        /// <summary>Creates an new <see cref="RunCommandManagedIdentity" /> instance.</summary>
        public RunCommandManagedIdentity()
        {

        }
    }
    /// Contains clientId or objectId (use only one, not both) of a user-assigned managed identity that has access to storage
    /// blob used in Run Command. Use an empty RunCommandManagedIdentity object in case of system-assigned identity. Make sure
    /// the Azure storage blob exists in case of scriptUri, and managed identity has been given access to blob's container with
    /// 'Storage Blob Data Reader' role assignment with scriptUri blob and 'Storage Blob Data Contributor' for Append blobs(outputBlobUri,
    /// errorBlobUri). In case of user assigned identity, make sure you add it under VM's identity. For more info on managed identity
    /// and Run Command, refer https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged.
    public partial interface IRunCommandManagedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Client Id (GUID value) of the user-assigned managed identity. ObjectId should not be used if this is provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Client Id (GUID value) of the user-assigned managed identity. ObjectId should not be used if this is provided.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientId { get; set; }
        /// <summary>
        /// Object Id (GUID value) of the user-assigned managed identity. ClientId should not be used if this is provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Object Id (GUID value) of the user-assigned managed identity. ClientId should not be used if this is provided.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectId { get; set; }

    }
    /// Contains clientId or objectId (use only one, not both) of a user-assigned managed identity that has access to storage
    /// blob used in Run Command. Use an empty RunCommandManagedIdentity object in case of system-assigned identity. Make sure
    /// the Azure storage blob exists in case of scriptUri, and managed identity has been given access to blob's container with
    /// 'Storage Blob Data Reader' role assignment with scriptUri blob and 'Storage Blob Data Contributor' for Append blobs(outputBlobUri,
    /// errorBlobUri). In case of user assigned identity, make sure you add it under VM's identity. For more info on managed identity
    /// and Run Command, refer https://aka.ms/ManagedIdentity and https://aka.ms/RunCommandManaged.
    internal partial interface IRunCommandManagedIdentityInternal

    {
        /// <summary>
        /// Client Id (GUID value) of the user-assigned managed identity. ObjectId should not be used if this is provided.
        /// </summary>
        string ClientId { get; set; }
        /// <summary>
        /// Object Id (GUID value) of the user-assigned managed identity. ClientId should not be used if this is provided.
        /// </summary>
        string ObjectId { get; set; }

    }
}