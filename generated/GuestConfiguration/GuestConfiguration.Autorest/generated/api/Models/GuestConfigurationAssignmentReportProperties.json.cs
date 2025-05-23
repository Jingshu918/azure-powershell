// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Extensions;

    /// <summary>
    /// Report for the guest configuration assignment. Report contains information such as compliance status, reason, and more.
    /// </summary>
    public partial class GuestConfigurationAssignmentReportProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IGuestConfigurationAssignmentReportProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IGuestConfigurationAssignmentReportProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.IGuestConfigurationAssignmentReportProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject json ? new GuestConfigurationAssignmentReportProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject into a new instance of <see cref="GuestConfigurationAssignmentReportProperties"
        /// />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal GuestConfigurationAssignmentReportProperties(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_assignment = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject>("assignment"), out var __jsonAssignment) ? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.AssignmentInfo.FromJson(__jsonAssignment) : _assignment;}
            {_vM = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject>("vm"), out var __jsonVM) ? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.VMInfo.FromJson(__jsonVM) : _vM;}
            {_detail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject>("details"), out var __jsonDetails) ? Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Models.AssignmentReportDetails.FromJson(__jsonDetails) : _detail;}
            {_complianceStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("complianceStatus"), out var __jsonComplianceStatus) ? (string)__jsonComplianceStatus : (string)_complianceStatus;}
            {_reportId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("reportId"), out var __jsonReportId) ? (string)__jsonReportId : (string)_reportId;}
            {_startTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("startTime"), out var __jsonStartTime) ? global::System.DateTime.TryParse((string)__jsonStartTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartTimeValue) ? __jsonStartTimeValue : _startTime : _startTime;}
            {_endTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("endTime"), out var __jsonEndTime) ? global::System.DateTime.TryParse((string)__jsonEndTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonEndTimeValue) ? __jsonEndTimeValue : _endTime : _endTime;}
            {_vmssResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString>("vmssResourceId"), out var __jsonVmssResourceId) ? (string)__jsonVmssResourceId : (string)_vmssResourceId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="GuestConfigurationAssignmentReportProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="GuestConfigurationAssignmentReportProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._assignment ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) this._assignment.ToJson(null,serializationMode) : null, "assignment" ,container.Add );
            AddIf( null != this._vM ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) this._vM.ToJson(null,serializationMode) : null, "vm" ,container.Add );
            AddIf( null != this._detail ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) this._detail.ToJson(null,serializationMode) : null, "details" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._complianceStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._complianceStatus.ToString()) : null, "complianceStatus" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._reportId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._reportId.ToString()) : null, "reportId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._startTime ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._startTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "startTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._endTime ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._endTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "endTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._vmssResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.GuestConfiguration.Runtime.Json.JsonString(this._vmssResourceId.ToString()) : null, "vmssResourceId" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}