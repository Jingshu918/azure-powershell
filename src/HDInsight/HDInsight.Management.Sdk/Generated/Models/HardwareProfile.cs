// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using System.Linq;

    /// <summary>
    /// The hardware profile.
    /// </summary>
    public partial class HardwareProfile
    {
        /// <summary>
        /// Initializes a new instance of the HardwareProfile class.
        /// </summary>
        public HardwareProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HardwareProfile class.
        /// </summary>

        /// <param name="vmSize">The size of the VM
        /// </param>
        public HardwareProfile(string vmSize = default(string))

        {
            this.VMSize = vmSize;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the size of the VM
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmSize")]
        public string VMSize {get; set; }
    }
}