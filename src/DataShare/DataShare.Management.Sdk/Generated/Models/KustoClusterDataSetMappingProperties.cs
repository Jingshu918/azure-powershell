// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataShare.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of the Kusto cluster data set mapping
    /// </summary>
    public partial class KustoClusterDataSetMappingProperties
    {
        /// <summary>
        /// Initializes a new instance of the KustoClusterDataSetMappingProperties class.
        /// </summary>
        public KustoClusterDataSetMappingProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KustoClusterDataSetMappingProperties class.
        /// </summary>

        /// <param name="dataSetId">The id of the source data set.
        /// </param>

        /// <param name="dataSetMappingStatus">Gets the status of the data set mapping.
        /// Possible values include: &#39;Ok&#39;, &#39;Broken&#39;</param>

        /// <param name="kustoClusterResourceId">Resource id of the sink kusto cluster.
        /// </param>

        /// <param name="location">Location of the sink kusto cluster.
        /// </param>

        /// <param name="provisioningState">Provisioning state of the data set mapping.
        /// Possible values include: &#39;Succeeded&#39;, &#39;Creating&#39;, &#39;Deleting&#39;, &#39;Moving&#39;,
        /// &#39;Failed&#39;</param>
        public KustoClusterDataSetMappingProperties(string dataSetId, string kustoClusterResourceId, string dataSetMappingStatus = default(string), string location = default(string), string provisioningState = default(string))

        {
            this.DataSetId = dataSetId;
            this.DataSetMappingStatus = dataSetMappingStatus;
            this.KustoClusterResourceId = kustoClusterResourceId;
            this.Location = location;
            this.ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the id of the source data set.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataSetId")]
        public string DataSetId {get; set; }

        /// <summary>
        /// Gets gets the status of the data set mapping. Possible values include: &#39;Ok&#39;, &#39;Broken&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataSetMappingStatus")]
        public string DataSetMappingStatus {get; private set; }

        /// <summary>
        /// Gets or sets resource id of the sink kusto cluster.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kustoClusterResourceId")]
        public string KustoClusterResourceId {get; set; }

        /// <summary>
        /// Gets location of the sink kusto cluster.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location {get; private set; }

        /// <summary>
        /// Gets provisioning state of the data set mapping. Possible values include: &#39;Succeeded&#39;, &#39;Creating&#39;, &#39;Deleting&#39;, &#39;Moving&#39;, &#39;Failed&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.DataSetId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DataSetId");
            }
            if (this.KustoClusterResourceId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "KustoClusterResourceId");
            }





        }
    }
}