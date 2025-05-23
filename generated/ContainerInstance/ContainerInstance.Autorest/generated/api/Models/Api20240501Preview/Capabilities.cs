// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Extensions;

    /// <summary>The regional capabilities.</summary>
    public partial class Capabilities :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilities,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesInternal
    {

        /// <summary>Backing field for <see cref="Capability" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGenerated _capability;

        /// <summary>The supported capabilities.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGenerated Capability { get => (this._capability = this._capability ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.CapabilitiesAutoGenerated()); }

        /// <summary>The maximum allowed CPU request in cores.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public float? CapabilityMaxCpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal)Capability).MaxCpu; }

        /// <summary>The maximum allowed GPU count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public float? CapabilityMaxGpuCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal)Capability).MaxGpuCount; }

        /// <summary>The maximum allowed memory request in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Inlined)]
        public float? CapabilityMaxMemoryInGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal)Capability).MaxMemoryInGb; }

        /// <summary>Backing field for <see cref="Gpu" /> property.</summary>
        private string _gpu;

        /// <summary>The GPU sku that this capability describes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string Gpu { get => this._gpu; }

        /// <summary>Backing field for <see cref="IPAddressType" /> property.</summary>
        private string _iPAddressType;

        /// <summary>The ip address type that this capability describes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string IPAddressType { get => this._iPAddressType; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string Location { get => this._location; }

        /// <summary>Internal Acessors for Capability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesInternal.Capability { get => (this._capability = this._capability ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.CapabilitiesAutoGenerated()); set { {_capability = value;} } }

        /// <summary>Internal Acessors for CapabilityMaxCpu</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesInternal.CapabilityMaxCpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal)Capability).MaxCpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal)Capability).MaxCpu = value; }

        /// <summary>Internal Acessors for CapabilityMaxGpuCount</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesInternal.CapabilityMaxGpuCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal)Capability).MaxGpuCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal)Capability).MaxGpuCount = value; }

        /// <summary>Internal Acessors for CapabilityMaxMemoryInGb</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesInternal.CapabilityMaxMemoryInGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal)Capability).MaxMemoryInGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGeneratedInternal)Capability).MaxMemoryInGb = value; }

        /// <summary>Internal Acessors for Gpu</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesInternal.Gpu { get => this._gpu; set { {_gpu = value;} } }

        /// <summary>Internal Acessors for IPAddressType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesInternal.IPAddressType { get => this._iPAddressType; set { {_iPAddressType = value;} } }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesInternal.Location { get => this._location; set { {_location = value;} } }

        /// <summary>Internal Acessors for OSType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesInternal.OSType { get => this._oSType; set { {_oSType = value;} } }

        /// <summary>Internal Acessors for ResourceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesInternal.ResourceType { get => this._resourceType; set { {_resourceType = value;} } }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>The OS type that this capability describes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>The resource type that this capability describes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; }

        /// <summary>Creates an new <see cref="Capabilities" /> instance.</summary>
        public Capabilities()
        {

        }
    }
    /// The regional capabilities.
    public partial interface ICapabilities :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.IJsonSerializable
    {
        /// <summary>The maximum allowed CPU request in cores.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The maximum allowed CPU request in cores.",
        SerializedName = @"maxCpu",
        PossibleTypes = new [] { typeof(float) })]
        float? CapabilityMaxCpu { get;  }
        /// <summary>The maximum allowed GPU count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The maximum allowed GPU count.",
        SerializedName = @"maxGpuCount",
        PossibleTypes = new [] { typeof(float) })]
        float? CapabilityMaxGpuCount { get;  }
        /// <summary>The maximum allowed memory request in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The maximum allowed memory request in GB.",
        SerializedName = @"maxMemoryInGB",
        PossibleTypes = new [] { typeof(float) })]
        float? CapabilityMaxMemoryInGb { get;  }
        /// <summary>The GPU sku that this capability describes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The GPU sku that this capability describes.",
        SerializedName = @"gpu",
        PossibleTypes = new [] { typeof(string) })]
        string Gpu { get;  }
        /// <summary>The ip address type that this capability describes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ip address type that this capability describes.",
        SerializedName = @"ipAddressType",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddressType { get;  }
        /// <summary>The resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource location.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get;  }
        /// <summary>The OS type that this capability describes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The OS type that this capability describes.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get;  }
        /// <summary>The resource type that this capability describes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource type that this capability describes.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get;  }

    }
    /// The regional capabilities.
    internal partial interface ICapabilitiesInternal

    {
        /// <summary>The supported capabilities.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerInstance.Models.Api20240501Preview.ICapabilitiesAutoGenerated Capability { get; set; }
        /// <summary>The maximum allowed CPU request in cores.</summary>
        float? CapabilityMaxCpu { get; set; }
        /// <summary>The maximum allowed GPU count.</summary>
        float? CapabilityMaxGpuCount { get; set; }
        /// <summary>The maximum allowed memory request in GB.</summary>
        float? CapabilityMaxMemoryInGb { get; set; }
        /// <summary>The GPU sku that this capability describes.</summary>
        string Gpu { get; set; }
        /// <summary>The ip address type that this capability describes.</summary>
        string IPAddressType { get; set; }
        /// <summary>The resource location.</summary>
        string Location { get; set; }
        /// <summary>The OS type that this capability describes.</summary>
        string OSType { get; set; }
        /// <summary>The resource type that this capability describes.</summary>
        string ResourceType { get; set; }

    }
}