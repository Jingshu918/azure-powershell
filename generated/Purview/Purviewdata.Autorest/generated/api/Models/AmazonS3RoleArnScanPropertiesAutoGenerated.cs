// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class AmazonS3RoleArnScanPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesAutoGeneratedInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanProperties __amazonS3RoleArnScanProperties = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.AmazonS3RoleArnScanProperties();

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesCollection Collection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).Collection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).Collection = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).CollectionLastModifiedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CollectionReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).CollectionReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).CollectionReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CollectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).CollectionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).CollectionType = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesConnectedVia ConnectedVia { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).ConnectedVia; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).ConnectedVia = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ConnectedViaReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).ConnectedViaReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).ConnectedViaReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).CreatedAt; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesCredential Credential { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal)__amazonS3RoleArnScanProperties).Credential; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal)__amazonS3RoleArnScanProperties).Credential = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CredentialReferenceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal)__amazonS3RoleArnScanProperties).CredentialReferenceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal)__amazonS3RoleArnScanProperties).CredentialReferenceName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string CredentialType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal)__amazonS3RoleArnScanProperties).CredentialType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal)__amazonS3RoleArnScanProperties).CredentialType = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public bool? IsMauiScan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal)__amazonS3RoleArnScanProperties).IsMauiScan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal)__amazonS3RoleArnScanProperties).IsMauiScan = value ?? default(bool); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).LastModifiedAt; }

        /// <summary>Internal Acessors for Credential</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesCredential Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal.Credential { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal)__amazonS3RoleArnScanProperties).Credential; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal)__amazonS3RoleArnScanProperties).Credential = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Collection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesCollection Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal.Collection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).Collection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).Collection = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CollectionLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal.CollectionLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).CollectionLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).CollectionLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for ConnectedVia</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesConnectedVia Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal.ConnectedVia { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).ConnectedVia; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).ConnectedVia = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal.LastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).LastModifiedAt = value ?? default(global::System.DateTime); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string RoleArn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal)__amazonS3RoleArnScanProperties).RoleArn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal)__amazonS3RoleArnScanProperties).RoleArn = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ScanRulesetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).ScanRulesetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).ScanRulesetName = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string ScanRulesetType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).ScanRulesetType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).ScanRulesetType = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public int? Worker { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).Worker; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanPropertiesInternal)__amazonS3RoleArnScanProperties).Worker = value ?? default(int); }

        /// <summary>
        /// Creates an new <see cref="AmazonS3RoleArnScanPropertiesAutoGenerated" /> instance.
        /// </summary>
        public AmazonS3RoleArnScanPropertiesAutoGenerated()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__amazonS3RoleArnScanProperties), __amazonS3RoleArnScanProperties);
            await eventListener.AssertObjectIsValid(nameof(__amazonS3RoleArnScanProperties), __amazonS3RoleArnScanProperties);
        }
    }
    public partial interface IAmazonS3RoleArnScanPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanProperties
    {

    }
    internal partial interface IAmazonS3RoleArnScanPropertiesAutoGeneratedInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IAmazonS3RoleArnScanPropertiesInternal
    {

    }
}