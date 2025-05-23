// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Information about a hop between the source and the destination.
    /// </summary>
    public partial class ConnectivityHop
    {
        /// <summary>
        /// Initializes a new instance of the ConnectivityHop class.
        /// </summary>
        public ConnectivityHop()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectivityHop class.
        /// </summary>

        /// <param name="type">The type of the hop.
        /// </param>

        /// <param name="id">The ID of the hop.
        /// </param>

        /// <param name="address">The IP address of the hop.
        /// </param>

        /// <param name="resourceId">The ID of the resource corresponding to this hop.
        /// </param>

        /// <param name="nextHopIds">List of next hop identifiers.
        /// </param>

        /// <param name="issues">List of issues.
        /// </param>
        public ConnectivityHop(string type = default(string), string id = default(string), string address = default(string), string resourceId = default(string), System.Collections.Generic.IList<string> nextHopIds = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<ConnectivityIssue> issues = default(System.Collections.Generic.IList<ConnectivityIssue>))

        {
            this.Type = type;
            this.Id = id;
            this.Address = address;
            this.ResourceId = resourceId;
            this.NextHopIds = nextHopIds;
            this.Issues = issues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the type of the hop.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; private set; }

        /// <summary>
        /// Gets the ID of the hop.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; private set; }

        /// <summary>
        /// Gets the IP address of the hop.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "address")]
        public string Address {get; private set; }

        /// <summary>
        /// Gets the ID of the resource corresponding to this hop.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceId")]
        public string ResourceId {get; private set; }

        /// <summary>
        /// Gets list of next hop identifiers.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextHopIds")]
        public System.Collections.Generic.IList<string> NextHopIds {get; private set; }

        /// <summary>
        /// Gets list of issues.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "issues")]
        public System.Collections.Generic.IList<ConnectivityIssue> Issues {get; private set; }
    }
}