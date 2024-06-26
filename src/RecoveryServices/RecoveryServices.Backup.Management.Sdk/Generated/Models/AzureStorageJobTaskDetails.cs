// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Azure storage workload specific job task details.
    /// </summary>
    public partial class AzureStorageJobTaskDetails
    {
        /// <summary>
        /// Initializes a new instance of the AzureStorageJobTaskDetails class.
        /// </summary>
        public AzureStorageJobTaskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureStorageJobTaskDetails class.
        /// </summary>

        /// <param name="taskId">The task display name.
        /// </param>

        /// <param name="status">The status.
        /// </param>
        public AzureStorageJobTaskDetails(string taskId = default(string), string status = default(string))

        {
            this.TaskId = taskId;
            this.Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the task display name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskId")]
        public string TaskId {get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; set; }
    }
}