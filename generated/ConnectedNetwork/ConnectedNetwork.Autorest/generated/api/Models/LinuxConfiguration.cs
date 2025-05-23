// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>Specifies the Linux operating system settings on the virtual machine.</summary>
    public partial class LinuxConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ILinuxConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ILinuxConfigurationInternal
    {

        /// <summary>Internal Acessors for Ssh</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshConfiguration Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ILinuxConfigurationInternal.Ssh { get => (this._ssh = this._ssh ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.SshConfiguration()); set { {_ssh = value;} } }

        /// <summary>Backing field for <see cref="Ssh" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshConfiguration _ssh;

        /// <summary>Specifies the ssh key configuration for a Linux OS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshConfiguration Ssh { get => (this._ssh = this._ssh ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.SshConfiguration()); set => this._ssh = value; }

        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshPublicKey> SshPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshConfigurationInternal)Ssh).PublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshConfigurationInternal)Ssh).PublicKey = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="LinuxConfiguration" /> instance.</summary>
        public LinuxConfiguration()
        {

        }
    }
    /// Specifies the Linux operating system settings on the virtual machine.
    public partial interface ILinuxConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IJsonSerializable
    {
        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of SSH public keys used to authenticate with linux based VMs.",
        SerializedName = @"publicKeys",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshPublicKey) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshPublicKey> SshPublicKey { get; set; }

    }
    /// Specifies the Linux operating system settings on the virtual machine.
    internal partial interface ILinuxConfigurationInternal

    {
        /// <summary>Specifies the ssh key configuration for a Linux OS.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshConfiguration Ssh { get; set; }
        /// <summary>The list of SSH public keys used to authenticate with linux based VMs.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.ISshPublicKey> SshPublicKey { get; set; }

    }
}