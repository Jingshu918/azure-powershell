// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// The object that describes the operation.
    /// </summary>
    /// <remarks>
    /// The object that describes the operation.
    /// </remarks>
    public partial class OperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>
        public OperationDisplay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationDisplay class.
        /// </summary>

        /// <param name="provider">Friendly name of the resource provider.
        /// </param>

        /// <param name="operation">For example: read, write, delete, or listKeys/action
        /// </param>

        /// <param name="resource">The resource type on which the operation is performed.
        /// </param>

        /// <param name="description">The friendly name of the operation
        /// </param>
        public OperationDisplay(string provider = default(string), string operation = default(string), string resource = default(string), string description = default(string))

        {
            this.Provider = provider;
            this.Operation = operation;
            this.Resource = resource;
            this.Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets friendly name of the resource provider.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provider")]
        public string Provider {get; set; }

        /// <summary>
        /// Gets or sets for example: read, write, delete, or listKeys/action
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operation")]
        public string Operation {get; set; }

        /// <summary>
        /// Gets or sets the resource type on which the operation is performed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resource")]
        public string Resource {get; set; }

        /// <summary>
        /// Gets or sets the friendly name of the operation
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }
    }
}