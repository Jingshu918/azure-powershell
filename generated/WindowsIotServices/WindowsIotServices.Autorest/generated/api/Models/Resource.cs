// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Runtime.Extensions;

    /// <summary>The core properties of ARM resources</summary>
    public partial class Resource :
        Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Models.IResource,
        Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Models.IResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Fully qualified resource Id for the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Models.IResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Models.IResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Models.IResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="Resource" /> instance.</summary>
        public Resource()
        {

        }
    }
    /// The core properties of ARM resources
    public partial interface IResource :
        Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Runtime.IJsonSerializable
    {
        /// <summary>Fully qualified resource Id for the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Fully qualified resource Id for the resource",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the resource",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WindowsIotServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of the resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The core properties of ARM resources
    internal partial interface IResourceInternal

    {
        /// <summary>Fully qualified resource Id for the resource</summary>
        string Id { get; set; }
        /// <summary>The name of the resource</summary>
        string Name { get; set; }
        /// <summary>The type of the resource.</summary>
        string Type { get; set; }

    }
}