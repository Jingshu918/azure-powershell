// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine network interface IP configuration properties.
    /// </summary>
    public partial class VirtualMachineNetworkInterfaceIPConfigurationProperties
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineNetworkInterfaceIPConfigurationProperties class.
        /// </summary>
        public VirtualMachineNetworkInterfaceIPConfigurationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineNetworkInterfaceIPConfigurationProperties class.
        /// </summary>

        /// <param name="subnet">Specifies the identifier of the subnet.
        /// </param>

        /// <param name="primary">Specifies the primary network interface in case the virtual machine has
        /// more than 1 network interface.
        /// </param>

        /// <param name="publicIPAddressConfiguration">The publicIPAddressConfiguration.
        /// </param>

        /// <param name="privateIPAddressVersion">Available from Api-Version 2017-03-30 onwards, it represents whether the
        /// specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. 
        /// Possible values are: &#39;IPv4&#39; and &#39;IPv6&#39;.
        /// Possible values include: &#39;IPv4&#39;, &#39;IPv6&#39;</param>

        /// <param name="applicationSecurityGroups">Specifies an array of references to application security group.
        /// </param>

        /// <param name="applicationGatewayBackendAddressPools">Specifies an array of references to backend address pools of application
        /// gateways. A virtual machine can reference backend address pools of multiple
        /// application gateways. Multiple virtual machines cannot use the same
        /// application gateway.
        /// </param>

        /// <param name="loadBalancerBackendAddressPools">Specifies an array of references to backend address pools of load
        /// balancers. A virtual machine can reference backend address pools of one
        /// public and one internal load balancer. [Multiple virtual machines cannot
        /// use the same basic sku load balancer].
        /// </param>
        public VirtualMachineNetworkInterfaceIPConfigurationProperties(SubResource subnet = default(SubResource), bool? primary = default(bool?), VirtualMachinePublicIPAddressConfiguration publicIPAddressConfiguration = default(VirtualMachinePublicIPAddressConfiguration), string privateIPAddressVersion = default(string), System.Collections.Generic.IList<SubResource> applicationSecurityGroups = default(System.Collections.Generic.IList<SubResource>), System.Collections.Generic.IList<SubResource> applicationGatewayBackendAddressPools = default(System.Collections.Generic.IList<SubResource>), System.Collections.Generic.IList<SubResource> loadBalancerBackendAddressPools = default(System.Collections.Generic.IList<SubResource>))

        {
            this.Subnet = subnet;
            this.Primary = primary;
            this.PublicIPAddressConfiguration = publicIPAddressConfiguration;
            this.PrivateIPAddressVersion = privateIPAddressVersion;
            this.ApplicationSecurityGroups = applicationSecurityGroups;
            this.ApplicationGatewayBackendAddressPools = applicationGatewayBackendAddressPools;
            this.LoadBalancerBackendAddressPools = loadBalancerBackendAddressPools;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets specifies the identifier of the subnet.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subnet")]
        public SubResource Subnet {get; set; }

        /// <summary>
        /// Gets or sets specifies the primary network interface in case the virtual
        /// machine has more than 1 network interface.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "primary")]
        public bool? Primary {get; set; }

        /// <summary>
        /// Gets or sets the publicIPAddressConfiguration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicIPAddressConfiguration")]
        public VirtualMachinePublicIPAddressConfiguration PublicIPAddressConfiguration {get; set; }

        /// <summary>
        /// Gets or sets available from Api-Version 2017-03-30 onwards, it represents
        /// whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as
        /// IPv4.  Possible values are: &#39;IPv4&#39; and &#39;IPv6&#39;. Possible values include: &#39;IPv4&#39;, &#39;IPv6&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "privateIPAddressVersion")]
        public string PrivateIPAddressVersion {get; set; }

        /// <summary>
        /// Gets or sets specifies an array of references to application security
        /// group.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "applicationSecurityGroups")]
        public System.Collections.Generic.IList<SubResource> ApplicationSecurityGroups {get; set; }

        /// <summary>
        /// Gets or sets specifies an array of references to backend address pools of
        /// application gateways. A virtual machine can reference backend address pools
        /// of multiple application gateways. Multiple virtual machines cannot use the
        /// same application gateway.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "applicationGatewayBackendAddressPools")]
        public System.Collections.Generic.IList<SubResource> ApplicationGatewayBackendAddressPools {get; set; }

        /// <summary>
        /// Gets or sets specifies an array of references to backend address pools of
        /// load balancers. A virtual machine can reference backend address pools of
        /// one public and one internal load balancer. [Multiple virtual machines
        /// cannot use the same basic sku load balancer].
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "loadBalancerBackendAddressPools")]
        public System.Collections.Generic.IList<SubResource> LoadBalancerBackendAddressPools {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {

            if (this.PublicIPAddressConfiguration != null)
            {
                this.PublicIPAddressConfiguration.Validate();
            }




        }
    }
}