// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>ExtendedLocation details data.</summary>
    [System.ComponentModel.TypeConverter(typeof(A2AFabricSpecificLocationDetailsTypeConverter))]
    public partial class A2AFabricSpecificLocationDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.A2AFabricSpecificLocationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal A2AFabricSpecificLocationDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InitialPrimaryExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IExtendedLocation) content.GetValueForProperty("InitialPrimaryExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("InitialRecoveryExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IExtendedLocation) content.GetValueForProperty("InitialRecoveryExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("PrimaryExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IExtendedLocation) content.GetValueForProperty("PrimaryExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IExtendedLocation) content.GetValueForProperty("RecoveryExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("InitialPrimaryZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryZone = (string) content.GetValueForProperty("InitialPrimaryZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryZone, global::System.Convert.ToString);
            }
            if (content.Contains("InitialRecoveryZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryZone = (string) content.GetValueForProperty("InitialRecoveryZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryZone, global::System.Convert.ToString);
            }
            if (content.Contains("InitialPrimaryFabricLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryFabricLocation = (string) content.GetValueForProperty("InitialPrimaryFabricLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryFabricLocation, global::System.Convert.ToString);
            }
            if (content.Contains("InitialRecoveryFabricLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryFabricLocation = (string) content.GetValueForProperty("InitialRecoveryFabricLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryFabricLocation, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryZone = (string) content.GetValueForProperty("PrimaryZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryZone, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryZone = (string) content.GetValueForProperty("RecoveryZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryZone, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryFabricLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryFabricLocation = (string) content.GetValueForProperty("PrimaryFabricLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryFabricLocation, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryFabricLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryFabricLocation = (string) content.GetValueForProperty("RecoveryFabricLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryFabricLocation, global::System.Convert.ToString);
            }
            if (content.Contains("InitialPrimaryExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryExtendedLocationName = (string) content.GetValueForProperty("InitialPrimaryExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("InitialPrimaryExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryExtendedLocationType = (string) content.GetValueForProperty("InitialPrimaryExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("InitialRecoveryExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryExtendedLocationName = (string) content.GetValueForProperty("InitialRecoveryExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("InitialRecoveryExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryExtendedLocationType = (string) content.GetValueForProperty("InitialRecoveryExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryExtendedLocationName = (string) content.GetValueForProperty("PrimaryExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryExtendedLocationType = (string) content.GetValueForProperty("PrimaryExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryExtendedLocationName = (string) content.GetValueForProperty("RecoveryExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryExtendedLocationType = (string) content.GetValueForProperty("RecoveryExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryExtendedLocationType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.A2AFabricSpecificLocationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal A2AFabricSpecificLocationDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InitialPrimaryExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IExtendedLocation) content.GetValueForProperty("InitialPrimaryExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("InitialRecoveryExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IExtendedLocation) content.GetValueForProperty("InitialRecoveryExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("PrimaryExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IExtendedLocation) content.GetValueForProperty("PrimaryExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IExtendedLocation) content.GetValueForProperty("RecoveryExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("InitialPrimaryZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryZone = (string) content.GetValueForProperty("InitialPrimaryZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryZone, global::System.Convert.ToString);
            }
            if (content.Contains("InitialRecoveryZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryZone = (string) content.GetValueForProperty("InitialRecoveryZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryZone, global::System.Convert.ToString);
            }
            if (content.Contains("InitialPrimaryFabricLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryFabricLocation = (string) content.GetValueForProperty("InitialPrimaryFabricLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryFabricLocation, global::System.Convert.ToString);
            }
            if (content.Contains("InitialRecoveryFabricLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryFabricLocation = (string) content.GetValueForProperty("InitialRecoveryFabricLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryFabricLocation, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryZone = (string) content.GetValueForProperty("PrimaryZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryZone, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryZone = (string) content.GetValueForProperty("RecoveryZone",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryZone, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryFabricLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryFabricLocation = (string) content.GetValueForProperty("PrimaryFabricLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryFabricLocation, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryFabricLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryFabricLocation = (string) content.GetValueForProperty("RecoveryFabricLocation",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryFabricLocation, global::System.Convert.ToString);
            }
            if (content.Contains("InitialPrimaryExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryExtendedLocationName = (string) content.GetValueForProperty("InitialPrimaryExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("InitialPrimaryExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryExtendedLocationType = (string) content.GetValueForProperty("InitialPrimaryExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialPrimaryExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("InitialRecoveryExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryExtendedLocationName = (string) content.GetValueForProperty("InitialRecoveryExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("InitialRecoveryExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryExtendedLocationType = (string) content.GetValueForProperty("InitialRecoveryExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).InitialRecoveryExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryExtendedLocationName = (string) content.GetValueForProperty("PrimaryExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("PrimaryExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryExtendedLocationType = (string) content.GetValueForProperty("PrimaryExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).PrimaryExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryExtendedLocationName = (string) content.GetValueForProperty("RecoveryExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryExtendedLocationType = (string) content.GetValueForProperty("RecoveryExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetailsInternal)this).RecoveryExtendedLocationType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.A2AFabricSpecificLocationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new A2AFabricSpecificLocationDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.A2AFabricSpecificLocationDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new A2AFabricSpecificLocationDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="A2AFabricSpecificLocationDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="A2AFabricSpecificLocationDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IA2AFabricSpecificLocationDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// ExtendedLocation details data.
    [System.ComponentModel.TypeConverter(typeof(A2AFabricSpecificLocationDetailsTypeConverter))]
    public partial interface IA2AFabricSpecificLocationDetails

    {

    }
}