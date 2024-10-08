// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// VMwareV2 fabric specific details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("VMwareV2")]
    public partial class VMwareV2FabricSpecificDetails : FabricSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the VMwareV2FabricSpecificDetails class.
        /// </summary>
        public VMwareV2FabricSpecificDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMwareV2FabricSpecificDetails class.
        /// </summary>

        /// <param name="vmwareSiteId">The ARM Id of the VMware site.
        /// </param>

        /// <param name="physicalSiteId">The ARM Id of the physical site.
        /// </param>

        /// <param name="migrationSolutionId">The Migration solution ARM Id.
        /// </param>

        /// <param name="serviceEndpoint">The service endpoint.
        /// </param>

        /// <param name="serviceResourceId">The service resource Id.
        /// </param>

        /// <param name="serviceContainerId">The service container Id.
        /// </param>

        /// <param name="processServers">The list of process servers.
        /// </param>
        public VMwareV2FabricSpecificDetails(string vmwareSiteId = default(string), string physicalSiteId = default(string), string migrationSolutionId = default(string), string serviceEndpoint = default(string), string serviceResourceId = default(string), string serviceContainerId = default(string), System.Collections.Generic.IList<ProcessServerDetails> processServers = default(System.Collections.Generic.IList<ProcessServerDetails>))

        {
            this.VmwareSiteId = vmwareSiteId;
            this.PhysicalSiteId = physicalSiteId;
            this.MigrationSolutionId = migrationSolutionId;
            this.ServiceEndpoint = serviceEndpoint;
            this.ServiceResourceId = serviceResourceId;
            this.ServiceContainerId = serviceContainerId;
            this.ProcessServers = processServers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the ARM Id of the VMware site.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmwareSiteId")]
        public string VmwareSiteId {get; private set; }

        /// <summary>
        /// Gets the ARM Id of the physical site.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "physicalSiteId")]
        public string PhysicalSiteId {get; private set; }

        /// <summary>
        /// Gets the Migration solution ARM Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "migrationSolutionId")]
        public string MigrationSolutionId {get; private set; }

        /// <summary>
        /// Gets the service endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serviceEndpoint")]
        public string ServiceEndpoint {get; private set; }

        /// <summary>
        /// Gets the service resource Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serviceResourceId")]
        public string ServiceResourceId {get; private set; }

        /// <summary>
        /// Gets the service container Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serviceContainerId")]
        public string ServiceContainerId {get; private set; }

        /// <summary>
        /// Gets the list of process servers.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "processServers")]
        public System.Collections.Generic.IList<ProcessServerDetails> ProcessServers {get; private set; }
    }
}