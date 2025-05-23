// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Extensions;

    /// <summary>
    /// JsonArrayMapper destination field used to describe the field to which the parsed output will be written.
    /// </summary>
    public partial class JsonMapperDestinationField :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IJsonMapperDestinationField,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IJsonMapperDestinationFieldInternal
    {

        /// <summary>Backing field for <see cref="Destination" /> property.</summary>
        private string _destination;

        /// <summary>
        /// Define the destination's element. The element is the body or the attributes of the message, to which the json array mapper
        /// will write the output map.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public string Destination { get => this._destination; set => this._destination = value; }

        /// <summary>Backing field for <see cref="FieldName" /> property.</summary>
        private string _fieldName;

        /// <summary>
        /// Define a destination field name under the given element. Leaving this empty, means the root of the element. In case element=attributes
        /// and fieldName is empty, the object's attributes themselves will contain the key value output pairs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public string FieldName { get => this._fieldName; set => this._fieldName = value; }

        /// <summary>Creates an new <see cref="JsonMapperDestinationField" /> instance.</summary>
        public JsonMapperDestinationField()
        {

        }
    }
    /// JsonArrayMapper destination field used to describe the field to which the parsed output will be written.
    public partial interface IJsonMapperDestinationField :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Define the destination's element. The element is the body or the attributes of the message, to which the json array mapper
        /// will write the output map.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Define the destination's element. The element is the body or the attributes of the message, to which the json array mapper will write the output map.",
        SerializedName = @"destination",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PSArgumentCompleterAttribute("body", "attributes")]
        string Destination { get; set; }
        /// <summary>
        /// Define a destination field name under the given element. Leaving this empty, means the root of the element. In case element=attributes
        /// and fieldName is empty, the object's attributes themselves will contain the key value output pairs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Define a destination field name under the given element. Leaving this empty, means the root of the element. In case element=attributes and fieldName is empty, the object's attributes themselves will contain the key value output pairs.",
        SerializedName = @"fieldName",
        PossibleTypes = new [] { typeof(string) })]
        string FieldName { get; set; }

    }
    /// JsonArrayMapper destination field used to describe the field to which the parsed output will be written.
    internal partial interface IJsonMapperDestinationFieldInternal

    {
        /// <summary>
        /// Define the destination's element. The element is the body or the attributes of the message, to which the json array mapper
        /// will write the output map.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PSArgumentCompleterAttribute("body", "attributes")]
        string Destination { get; set; }
        /// <summary>
        /// Define a destination field name under the given element. Leaving this empty, means the root of the element. In case element=attributes
        /// and fieldName is empty, the object's attributes themselves will contain the key value output pairs.
        /// </summary>
        string FieldName { get; set; }

    }
}