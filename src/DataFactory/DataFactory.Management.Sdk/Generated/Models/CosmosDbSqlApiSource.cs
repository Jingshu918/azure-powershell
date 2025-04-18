// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// A copy activity Azure CosmosDB (SQL API) Collection source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("CosmosDbSqlApiSource")]
    public partial class CosmosDbSqlApiSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the CosmosDbSqlApiSource class.
        /// </summary>
        public CosmosDbSqlApiSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CosmosDbSqlApiSource class.
        /// </summary>

        /// <param name="additionalProperties">A copy activity source.
        /// </param>

        /// <param name="sourceRetryCount">Source retry count. Type: integer (or Expression with resultType integer).
        /// </param>

        /// <param name="sourceRetryWait">Source retry wait. Type: string (or Expression with resultType string),
        /// pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </param>

        /// <param name="maxConcurrentConnections">The maximum concurrent connection count for the source data store. Type:
        /// integer (or Expression with resultType integer).
        /// </param>

        /// <param name="disableMetricsCollection">If true, disable data store metrics collection. Default is false. Type:
        /// boolean (or Expression with resultType boolean).
        /// </param>

        /// <param name="query">SQL API query. Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="pageSize">Page size of the result. Type: integer (or Expression with resultType
        /// integer).
        /// </param>

        /// <param name="preferredRegions">Preferred regions. Type: array of strings (or Expression with resultType
        /// array of strings).
        /// </param>

        /// <param name="detectDatetime">Whether detect primitive values as datetime values. Type: boolean (or
        /// Expression with resultType boolean).
        /// </param>

        /// <param name="additionalColumns">Specifies the additional columns to be added to source data. Type: array of
        /// objects(AdditionalColumns) (or Expression with resultType array of
        /// objects).
        /// </param>
        public CosmosDbSqlApiSource(System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object), object query = default(object), object pageSize = default(object), object preferredRegions = default(object), object detectDatetime = default(object), object additionalColumns = default(object))

        : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection)
        {
            this.Query = query;
            this.PageSize = pageSize;
            this.PreferredRegions = preferredRegions;
            this.DetectDatetime = detectDatetime;
            this.AdditionalColumns = additionalColumns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets sQL API query. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "query")]
        public object Query {get; set; }

        /// <summary>
        /// Gets or sets page size of the result. Type: integer (or Expression with
        /// resultType integer).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "pageSize")]
        public object PageSize {get; set; }

        /// <summary>
        /// Gets or sets preferred regions. Type: array of strings (or Expression with
        /// resultType array of strings).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "preferredRegions")]
        public object PreferredRegions {get; set; }

        /// <summary>
        /// Gets or sets whether detect primitive values as datetime values. Type:
        /// boolean (or Expression with resultType boolean).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "detectDatetime")]
        public object DetectDatetime {get; set; }

        /// <summary>
        /// Gets or sets specifies the additional columns to be added to source data.
        /// Type: array of objects(AdditionalColumns) (or Expression with resultType
        /// array of objects).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "additionalColumns")]
        public object AdditionalColumns {get; set; }
    }
}