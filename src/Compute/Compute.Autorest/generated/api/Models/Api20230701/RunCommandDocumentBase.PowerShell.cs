// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701
{
    using Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.PowerShell;

    /// <summary>Describes the properties of a Run Command metadata.</summary>
    [System.ComponentModel.TypeConverter(typeof(RunCommandDocumentBaseTypeConverter))]
    public partial class RunCommandDocumentBase
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.RunCommandDocumentBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBase" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBase DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RunCommandDocumentBase(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.RunCommandDocumentBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBase" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBase DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RunCommandDocumentBase(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RunCommandDocumentBase" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="RunCommandDocumentBase" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBase FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.RunCommandDocumentBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RunCommandDocumentBase(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Schema"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Schema = (string) content.GetValueForProperty("Schema",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Schema, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).OSType = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).OSType, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes.CreateFrom);
            }
            if (content.Contains("Label"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Label = (string) content.GetValueForProperty("Label",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Label, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Description, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.RunCommandDocumentBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RunCommandDocumentBase(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Schema"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Schema = (string) content.GetValueForProperty("Schema",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Schema, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).OSType = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).OSType, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes.CreateFrom);
            }
            if (content.Contains("Label"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Label = (string) content.GetValueForProperty("Label",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Label, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandDocumentBaseInternal)this).Description, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes the properties of a Run Command metadata.
    [System.ComponentModel.TypeConverter(typeof(RunCommandDocumentBaseTypeConverter))]
    public partial interface IRunCommandDocumentBase

    {

    }
}