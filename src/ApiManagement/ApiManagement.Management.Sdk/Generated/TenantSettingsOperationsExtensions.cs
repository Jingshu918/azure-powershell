// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for TenantSettingsOperations
    /// </summary>
    public static partial class TenantSettingsOperationsExtensions
    {
        /// <summary>
        /// Public settings.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<TenantSettingsContract> ListByService(this ITenantSettingsOperations operations, string resourceGroupName, string serviceName, Microsoft.Rest.Azure.OData.ODataQuery<TenantSettingsContract> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<TenantSettingsContract>))
        {
                return ((ITenantSettingsOperations)operations).ListByServiceAsync(resourceGroupName, serviceName, odataQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Public settings.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<TenantSettingsContract>> ListByServiceAsync(this ITenantSettingsOperations operations, string resourceGroupName, string serviceName, Microsoft.Rest.Azure.OData.ODataQuery<TenantSettingsContract> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<TenantSettingsContract>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get tenant settings.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        public static TenantSettingsContract Get(this ITenantSettingsOperations operations, string resourceGroupName, string serviceName)
        {
                return ((ITenantSettingsOperations)operations).GetAsync(resourceGroupName, serviceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get tenant settings.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<TenantSettingsContract> GetAsync(this ITenantSettingsOperations operations, string resourceGroupName, string serviceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Public settings.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<TenantSettingsContract> ListByServiceNext(this ITenantSettingsOperations operations, string nextPageLink)
        {
                return ((ITenantSettingsOperations)operations).ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Public settings.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<TenantSettingsContract>> ListByServiceNextAsync(this ITenantSettingsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
