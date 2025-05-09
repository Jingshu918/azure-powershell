// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System.Linq;

    /// <summary>
    /// Properties to EncryptionScope
    /// </summary>
    public partial class EncryptionScopeProperties : Encryption
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionScopeProperties class.
        /// </summary>
        public EncryptionScopeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionScopeProperties class.
        /// </summary>

        /// <param name="keyVaultProperties">Properties of KeyVault
        /// </param>

        /// <param name="keySource">Enumerates the possible value of keySource for Encryption
        /// Possible values include: &#39;Microsoft.CognitiveServices&#39;,
        /// &#39;Microsoft.KeyVault&#39;</param>

        /// <param name="provisioningState">Gets the status of the resource at the time the operation was called.
        /// Possible values include: &#39;Accepted&#39;, &#39;Creating&#39;, &#39;Deleting&#39;, &#39;Moving&#39;,
        /// &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;</param>

        /// <param name="state">The encryptionScope state.
        /// Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;</param>
        public EncryptionScopeProperties(KeyVaultProperties keyVaultProperties = default(KeyVaultProperties), string keySource = default(string), string provisioningState = default(string), string state = default(string))

        : base(keyVaultProperties, keySource)
        {
            this.ProvisioningState = provisioningState;
            this.State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets gets the status of the resource at the time the operation was called. Possible values include: &#39;Accepted&#39;, &#39;Creating&#39;, &#39;Deleting&#39;, &#39;Moving&#39;, &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets the encryptionScope state. Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public string State {get; set; }
    }
}