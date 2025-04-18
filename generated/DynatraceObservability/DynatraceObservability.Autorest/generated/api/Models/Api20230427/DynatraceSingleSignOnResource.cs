// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Extensions;

    /// <summary>Single sign-on configurations for a given monitor resource.</summary>
    public partial class DynatraceSingleSignOnResource :
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnResource,
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.Resource();

        /// <summary>array of Aad(azure active directory) domains</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.DoNotFormat]
        public string[] AadDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnPropertiesInternal)Property).AadDomain; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnPropertiesInternal)Property).AadDomain = value ?? null /* arrayOf */; }

        /// <summary>Version of the Dynatrace agent installed on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.DoNotFormat]
        public string EnterpriseAppId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnPropertiesInternal)Property).EnterpriseAppId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnPropertiesInternal)Property).EnterpriseAppId = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal)__resource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnProperties Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.DynatraceSingleSignOnProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnResourceInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.SystemData()); set { {_systemData = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.DynatraceSingleSignOnProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.FormatTable(Index = 2)]
        public Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.FormatTable(Index = 1)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>State of Single Sign On</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.FormatTable(Index = 3)]
        public Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SingleSignOnStates? SingleSignOnState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnPropertiesInternal)Property).SingleSignOnState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnPropertiesInternal)Property).SingleSignOnState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SingleSignOnStates)""); }

        /// <summary>The login URL specific to this Dynatrace Environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.FormatTable(Index = 4)]
        public string SingleSignOnUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnPropertiesInternal)Property).SingleSignOnUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnPropertiesInternal)Property).SingleSignOnUrl = value ?? null; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemData _systemData;

        /// <summary>System metadata for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemDataInternal)SystemData).CreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemDataInternal)SystemData).LastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="DynatraceSingleSignOnResource" /> instance.</summary>
        public DynatraceSingleSignOnResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Single sign-on configurations for a given monitor resource.
    public partial interface IDynatraceSingleSignOnResource :
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResource
    {
        /// <summary>array of Aad(azure active directory) domains</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"array of Aad(azure active directory) domains",
        SerializedName = @"aadDomains",
        PossibleTypes = new [] { typeof(string) })]
        string[] AadDomain { get; set; }
        /// <summary>Version of the Dynatrace agent installed on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the Dynatrace agent installed on the VM.",
        SerializedName = @"enterpriseAppId",
        PossibleTypes = new [] { typeof(string) })]
        string EnterpriseAppId { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>State of Single Sign On</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of Single Sign On",
        SerializedName = @"singleSignOnState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SingleSignOnStates) })]
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SingleSignOnStates? SingleSignOnState { get; set; }
        /// <summary>The login URL specific to this Dynatrace Environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The login URL specific to this Dynatrace Environment",
        SerializedName = @"singleSignOnUrl",
        PossibleTypes = new [] { typeof(string) })]
        string SingleSignOnUrl { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
    /// Single sign-on configurations for a given monitor resource.
    internal partial interface IDynatraceSingleSignOnResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.IResourceInternal
    {
        /// <summary>array of Aad(azure active directory) domains</summary>
        string[] AadDomain { get; set; }
        /// <summary>Version of the Dynatrace agent installed on the VM.</summary>
        string EnterpriseAppId { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IDynatraceSingleSignOnProperties Property { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>State of Single Sign On</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SingleSignOnStates? SingleSignOnState { get; set; }
        /// <summary>The login URL specific to this Dynatrace Environment</summary>
        string SingleSignOnUrl { get; set; }
        /// <summary>System metadata for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.CreatedByType? SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.CreatedByType? SystemDataLastModifiedByType { get; set; }

    }
}