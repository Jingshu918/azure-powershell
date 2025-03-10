// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.SignalR.Models
{
    using System.Linq;

    /// <summary>
    /// Managed identity settings for upstream.
    /// </summary>
    public partial class ManagedIdentitySettings
    {
        /// <summary>
        /// Initializes a new instance of the ManagedIdentitySettings class.
        /// </summary>
        public ManagedIdentitySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedIdentitySettings class.
        /// </summary>

        /// <param name="resource">The Resource indicating the App ID URI of the target resource.
        /// It also appears in the aud (audience) claim of the issued token.
        /// </param>
        public ManagedIdentitySettings(string resource = default(string))

        {
            this.Resource = resource;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the Resource indicating the App ID URI of the target resource.
        /// It also appears in the aud (audience) claim of the issued token.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resource")]
        public string Resource {get; set; }
    }
}