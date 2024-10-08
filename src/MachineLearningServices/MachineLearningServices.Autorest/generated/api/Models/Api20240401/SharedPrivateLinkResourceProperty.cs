// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Properties of a shared private link resource.</summary>
    public partial class SharedPrivateLinkResourceProperty :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISharedPrivateLinkResourceProperty,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISharedPrivateLinkResourcePropertyInternal
    {

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>The private link resource group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>Backing field for <see cref="PrivateLinkResourceId" /> property.</summary>
        private string _privateLinkResourceId;

        /// <summary>The resource id that private link links to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string PrivateLinkResourceId { get => this._privateLinkResourceId; set => this._privateLinkResourceId = value; }

        /// <summary>Backing field for <see cref="RequestMessage" /> property.</summary>
        private string _requestMessage;

        /// <summary>Request message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string RequestMessage { get => this._requestMessage; set => this._requestMessage = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.PrivateEndpointServiceConnectionStatus? _status;

        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.PrivateEndpointServiceConnectionStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="SharedPrivateLinkResourceProperty" /> instance.</summary>
        public SharedPrivateLinkResourceProperty()
        {

        }
    }
    /// Properties of a shared private link resource.
    public partial interface ISharedPrivateLinkResourceProperty :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>The private link resource group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The private link resource group id.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get; set; }
        /// <summary>The resource id that private link links to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id that private link links to.",
        SerializedName = @"privateLinkResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkResourceId { get; set; }
        /// <summary>Request message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Request message.",
        SerializedName = @"requestMessage",
        PossibleTypes = new [] { typeof(string) })]
        string RequestMessage { get; set; }
        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.PrivateEndpointServiceConnectionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.PrivateEndpointServiceConnectionStatus? Status { get; set; }

    }
    /// Properties of a shared private link resource.
    internal partial interface ISharedPrivateLinkResourcePropertyInternal

    {
        /// <summary>The private link resource group id.</summary>
        string GroupId { get; set; }
        /// <summary>The resource id that private link links to.</summary>
        string PrivateLinkResourceId { get; set; }
        /// <summary>Request message.</summary>
        string RequestMessage { get; set; }
        /// <summary>
        /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.PrivateEndpointServiceConnectionStatus? Status { get; set; }

    }
}