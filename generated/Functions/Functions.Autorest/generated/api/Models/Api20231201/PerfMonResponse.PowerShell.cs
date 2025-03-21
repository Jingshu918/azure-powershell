// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>Performance monitor API response.</summary>
    [System.ComponentModel.TypeConverter(typeof(PerfMonResponseTypeConverter))]
    public partial class PerfMonResponse
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.PerfMonResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PerfMonResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.PerfMonResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PerfMonResponse(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PerfMonResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PerfMonResponse" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.PerfMonResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PerfMonResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Data"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).Data = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonSet) content.GetValueForProperty("Data",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).Data, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.PerfMonSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("DataName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataName = (string) content.GetValueForProperty("DataName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataName, global::System.Convert.ToString);
            }
            if (content.Contains("DataStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataStartTime = (global::System.DateTime?) content.GetValueForProperty("DataStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DataEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataEndTime = (global::System.DateTime?) content.GetValueForProperty("DataEndTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DataTimeGrain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataTimeGrain = (string) content.GetValueForProperty("DataTimeGrain",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataTimeGrain, global::System.Convert.ToString);
            }
            if (content.Contains("DataValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataValue = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonSample[]) content.GetValueForProperty("DataValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataValue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonSample>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.PerfMonSampleTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.PerfMonResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PerfMonResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Data"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).Data = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonSet) content.GetValueForProperty("Data",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).Data, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.PerfMonSetTypeConverter.ConvertFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("DataName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataName = (string) content.GetValueForProperty("DataName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataName, global::System.Convert.ToString);
            }
            if (content.Contains("DataStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataStartTime = (global::System.DateTime?) content.GetValueForProperty("DataStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DataEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataEndTime = (global::System.DateTime?) content.GetValueForProperty("DataEndTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DataTimeGrain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataTimeGrain = (string) content.GetValueForProperty("DataTimeGrain",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataTimeGrain, global::System.Convert.ToString);
            }
            if (content.Contains("DataValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataValue = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonSample[]) content.GetValueForProperty("DataValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonResponseInternal)this).DataValue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IPerfMonSample>(__y, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.PerfMonSampleTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Performance monitor API response.
    [System.ComponentModel.TypeConverter(typeof(PerfMonResponseTypeConverter))]
    public partial interface IPerfMonResponse

    {

    }
}