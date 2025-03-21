﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Management.Automation;
using Microsoft.Azure.Commands.CosmosDB.Models;
using Microsoft.Azure.Commands.CosmosDB.Helpers;
using System;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.CosmosDB
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "CosmosDBSqlVectorEmbeddingPolicy", SupportsShouldProcess = true), OutputType(typeof(PSSqlVectorEmbeddingPolicy))]
    public class NewAzCosmosDBSqlVectorEmbeddingPolicy : AzureCosmosDBCmdletBase
    {
        [Parameter(Mandatory = true, HelpMessage = Constants.VectorEmbeddingPolicyVectorEmbeddingHelpMessage)]
        [ValidateNotNullOrEmpty]
        public PSVectorEmbedding[] VectorEmbedding { get; set; }

        public override void ExecuteCmdlet()
        {
            PSSqlVectorEmbeddingPolicy sqlVectorEmbeddingPolicy = new PSSqlVectorEmbeddingPolicy();

            if (VectorEmbedding != null && VectorEmbedding.Length > 0)
            {
                sqlVectorEmbeddingPolicy.VectorEmbeddings = new List<PSVectorEmbedding>(VectorEmbedding);
            }
           
            WriteObject(sqlVectorEmbeddingPolicy);
            return;
        }
    }
}