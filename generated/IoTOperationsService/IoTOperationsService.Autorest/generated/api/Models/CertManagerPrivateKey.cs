// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Extensions;

    /// <summary>Cert Manager private key properties</summary>
    public partial class CertManagerPrivateKey :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerPrivateKey,
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.ICertManagerPrivateKeyInternal
    {

        /// <summary>Backing field for <see cref="Algorithm" /> property.</summary>
        private string _algorithm;

        /// <summary>algorithm for private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public string Algorithm { get => this._algorithm; set => this._algorithm = value; }

        /// <summary>Backing field for <see cref="RotationPolicy" /> property.</summary>
        private string _rotationPolicy;

        /// <summary>cert-manager private key rotationPolicy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public string RotationPolicy { get => this._rotationPolicy; set => this._rotationPolicy = value; }

        /// <summary>Creates an new <see cref="CertManagerPrivateKey" /> instance.</summary>
        public CertManagerPrivateKey()
        {

        }
    }
    /// Cert Manager private key properties
    public partial interface ICertManagerPrivateKey :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IJsonSerializable
    {
        /// <summary>algorithm for private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"algorithm for private key.",
        SerializedName = @"algorithm",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Ec256", "Ec384", "Ec521", "Ed25519", "Rsa2048", "Rsa4096", "Rsa8192")]
        string Algorithm { get; set; }
        /// <summary>cert-manager private key rotationPolicy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"cert-manager private key rotationPolicy.",
        SerializedName = @"rotationPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Always", "Never")]
        string RotationPolicy { get; set; }

    }
    /// Cert Manager private key properties
    internal partial interface ICertManagerPrivateKeyInternal

    {
        /// <summary>algorithm for private key.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Ec256", "Ec384", "Ec521", "Ed25519", "Rsa2048", "Rsa4096", "Rsa8192")]
        string Algorithm { get; set; }
        /// <summary>cert-manager private key rotationPolicy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PSArgumentCompleterAttribute("Always", "Never")]
        string RotationPolicy { get; set; }

    }
}