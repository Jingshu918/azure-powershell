// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// The response for a QueryInboundNatRulePortMapping API.
    /// </summary>
    public partial class BackendAddressInboundNatRulePortMappings
    {
        /// <summary>
        /// Initializes a new instance of the BackendAddressInboundNatRulePortMappings class.
        /// </summary>
        public BackendAddressInboundNatRulePortMappings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackendAddressInboundNatRulePortMappings class.
        /// </summary>

        /// <param name="inboundNatRulePortMappings">Collection of inbound NAT rule port mappings.
        /// </param>
        public BackendAddressInboundNatRulePortMappings(System.Collections.Generic.IList<InboundNatRulePortMapping> inboundNatRulePortMappings = default(System.Collections.Generic.IList<InboundNatRulePortMapping>))

        {
            this.InboundNatRulePortMappings = inboundNatRulePortMappings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets collection of inbound NAT rule port mappings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "inboundNatRulePortMappings")]
        public System.Collections.Generic.IList<InboundNatRulePortMapping> InboundNatRulePortMappings {get; set; }
    }
}