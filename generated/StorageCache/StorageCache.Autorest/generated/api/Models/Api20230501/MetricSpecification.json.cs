// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Extensions;

    /// <summary>Details about operation related to metrics.</summary>
    public partial class MetricSpecification
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IMetricSpecification.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IMetricSpecification.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IMetricSpecification FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonObject json ? new MetricSpecification(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonObject into a new instance of <see cref="MetricSpecification" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MetricSpecification(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)DisplayName;}
            {_displayDescription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString>("displayDescription"), out var __jsonDisplayDescription) ? (string)__jsonDisplayDescription : (string)DisplayDescription;}
            {_unit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString>("unit"), out var __jsonUnit) ? (string)__jsonUnit : (string)Unit;}
            {_aggregationType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString>("aggregationType"), out var __jsonAggregationType) ? (string)__jsonAggregationType : (string)AggregationType;}
            {_supportedAggregationType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonArray>("supportedAggregationTypes"), out var __jsonSupportedAggregationTypes) ? If( __jsonSupportedAggregationTypes as Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.MetricAggregationType[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.MetricAggregationType) (__u is Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString __t ? (Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.MetricAggregationType)(__t.ToString()) : ((Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.MetricAggregationType)""))) ))() : null : SupportedAggregationType;}
            {_metricClass = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString>("metricClass"), out var __jsonMetricClass) ? (string)__jsonMetricClass : (string)MetricClass;}
            {_dimension = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonArray>("dimensions"), out var __jsonDimensions) ? If( __jsonDimensions as Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IMetricDimension[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.IMetricDimension) (Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Models.Api20230501.MetricDimension.FromJson(__p) )) ))() : null : Dimension;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MetricSpecification" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MetricSpecification" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            AddIf( null != (((object)this._displayDescription)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString(this._displayDescription.ToString()) : null, "displayDescription" ,container.Add );
            AddIf( null != (((object)this._unit)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString(this._unit.ToString()) : null, "unit" ,container.Add );
            AddIf( null != (((object)this._aggregationType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString(this._aggregationType.ToString()) : null, "aggregationType" ,container.Add );
            if (null != this._supportedAggregationType)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.XNodeArray();
                foreach( var __x in this._supportedAggregationType )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("supportedAggregationTypes",__w);
            }
            AddIf( null != (((object)this._metricClass)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.JsonString(this._metricClass.ToString()) : null, "metricClass" ,container.Add );
            if (null != this._dimension)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Runtime.Json.XNodeArray();
                foreach( var __s in this._dimension )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("dimensions",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}