// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Extensions;

    /// <summary>The type used for update operations of the TagRule.</summary>
    public partial class TagRuleUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdateInternal
    {

        /// <summary>
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty,
        /// all resources will be captured.
        /// If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are
        /// specified, the rules will only include resources with the associated tags.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IFilteringTag> LogRuleFilteringTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).LogRuleFilteringTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).LogRuleFilteringTag = value ?? null /* arrayOf */; }

        /// <summary>Flag specifying if AAD logs should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public string LogRuleSendAadLog { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).LogRuleSendAadLog; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).LogRuleSendAadLog = value ?? null; }

        /// <summary>
        /// Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public string LogRuleSendActivityLog { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).LogRuleSendActivityLog; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).LogRuleSendActivityLog = value ?? null; }

        /// <summary>Flag specifying if subscription logs should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public string LogRuleSendSubscriptionLog { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).LogRuleSendSubscriptionLog; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).LogRuleSendSubscriptionLog = value ?? null; }

        /// <summary>List of filtering tags to be used for capturing metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IFilteringTag> MetricRuleFilteringTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).MetricRuleFilteringTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).MetricRuleFilteringTag = value ?? null /* arrayOf */; }

        /// <summary>Flag specifying if metrics should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public string MetricRuleSendMetric { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).MetricRuleSendMetric; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).MetricRuleSendMetric = value ?? null; }

        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public string MetricRuleUserEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).MetricRuleUserEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).MetricRuleUserEmail = value ?? null; }

        /// <summary>Internal Acessors for LogRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ILogRules Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdateInternal.LogRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).LogRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).LogRule = value; }

        /// <summary>Internal Acessors for MetricRule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMetricRules Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdateInternal.MetricRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).MetricRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdatePropertiesInternal)Property).MetricRule = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.TagRuleUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdateProperties _property;

        /// <summary>The updatable properties of the TagRule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.TagRuleUpdateProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="TagRuleUpdate" /> instance.</summary>
        public TagRuleUpdate()
        {

        }
    }
    /// The type used for update operations of the TagRule.
    public partial interface ITagRuleUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.IJsonSerializable
    {
        /// <summary>
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty,
        /// all resources will be captured.
        /// If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are
        /// specified, the rules will only include resources with the associated tags.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty, all resources will be captured.
        If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags.",
        SerializedName = @"filteringTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IFilteringTag) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IFilteringTag> LogRuleFilteringTag { get; set; }
        /// <summary>Flag specifying if AAD logs should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag specifying if AAD logs should be sent for the Monitor resource.",
        SerializedName = @"sendAadLogs",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string LogRuleSendAadLog { get; set; }
        /// <summary>
        /// Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.",
        SerializedName = @"sendActivityLogs",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string LogRuleSendActivityLog { get; set; }
        /// <summary>Flag specifying if subscription logs should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag specifying if subscription logs should be sent for the Monitor resource.",
        SerializedName = @"sendSubscriptionLogs",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string LogRuleSendSubscriptionLog { get; set; }
        /// <summary>List of filtering tags to be used for capturing metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of filtering tags to be used for capturing metrics.",
        SerializedName = @"filteringTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IFilteringTag) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IFilteringTag> MetricRuleFilteringTag { get; set; }
        /// <summary>Flag specifying if metrics should be sent for the Monitor resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag specifying if metrics should be sent for the Monitor resource.",
        SerializedName = @"sendMetrics",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string MetricRuleSendMetric { get; set; }
        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User Email",
        SerializedName = @"userEmail",
        PossibleTypes = new [] { typeof(string) })]
        string MetricRuleUserEmail { get; set; }

    }
    /// The type used for update operations of the TagRule.
    internal partial interface ITagRuleUpdateInternal

    {
        /// <summary>Set of rules for sending logs for the Monitor resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ILogRules LogRule { get; set; }
        /// <summary>
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty,
        /// all resources will be captured.
        /// If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are
        /// specified, the rules will only include resources with the associated tags.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IFilteringTag> LogRuleFilteringTag { get; set; }
        /// <summary>Flag specifying if AAD logs should be sent for the Monitor resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string LogRuleSendAadLog { get; set; }
        /// <summary>
        /// Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string LogRuleSendActivityLog { get; set; }
        /// <summary>Flag specifying if subscription logs should be sent for the Monitor resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string LogRuleSendSubscriptionLog { get; set; }
        /// <summary>Set of rules for sending metrics for the Monitor resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMetricRules MetricRule { get; set; }
        /// <summary>List of filtering tags to be used for capturing metrics.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IFilteringTag> MetricRuleFilteringTag { get; set; }
        /// <summary>Flag specifying if metrics should be sent for the Monitor resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string MetricRuleSendMetric { get; set; }
        /// <summary>User Email</summary>
        string MetricRuleUserEmail { get; set; }
        /// <summary>The updatable properties of the TagRule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.ITagRuleUpdateProperties Property { get; set; }

    }
}