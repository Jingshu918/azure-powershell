// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class RecurrenceSchedule :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceSchedule,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleInternal
    {

        /// <summary>Backing field for <see cref="AdditionalProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleAdditionalProperties _additionalProperty;

        /// <summary>Dictionary of <any></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleAdditionalProperties AdditionalProperty { get => (this._additionalProperty = this._additionalProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.RecurrenceScheduleAdditionalProperties()); set => this._additionalProperty = value; }

        /// <summary>Backing field for <see cref="Hour" /> property.</summary>
        private System.Collections.Generic.List<int> _hour;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<int> Hour { get => this._hour; set => this._hour = value; }

        /// <summary>Backing field for <see cref="Minute" /> property.</summary>
        private System.Collections.Generic.List<int> _minute;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<int> Minute { get => this._minute; set => this._minute = value; }

        /// <summary>Backing field for <see cref="MonthDay" /> property.</summary>
        private System.Collections.Generic.List<int> _monthDay;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<int> MonthDay { get => this._monthDay; set => this._monthDay = value; }

        /// <summary>Backing field for <see cref="MonthlyOccurrence" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence> _monthlyOccurrence;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence> MonthlyOccurrence { get => this._monthlyOccurrence; set => this._monthlyOccurrence = value; }

        /// <summary>Backing field for <see cref="WeekDay" /> property.</summary>
        private System.Collections.Generic.List<string> _weekDay;

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> WeekDay { get => this._weekDay; set => this._weekDay = value; }

        /// <summary>Creates an new <see cref="RecurrenceSchedule" /> instance.</summary>
        public RecurrenceSchedule()
        {

        }
    }
    public partial interface IRecurrenceSchedule :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable
    {
        /// <summary>Dictionary of <any></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Dictionary of <any>",
        SerializedName = @"additionalProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleAdditionalProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleAdditionalProperties AdditionalProperty { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"hours",
        PossibleTypes = new [] { typeof(int) })]
        System.Collections.Generic.List<int> Hour { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"minutes",
        PossibleTypes = new [] { typeof(int) })]
        System.Collections.Generic.List<int> Minute { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"monthDays",
        PossibleTypes = new [] { typeof(int) })]
        System.Collections.Generic.List<int> MonthDay { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"monthlyOccurrences",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence> MonthlyOccurrence { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"weekDays",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> WeekDay { get; set; }

    }
    internal partial interface IRecurrenceScheduleInternal

    {
        /// <summary>Dictionary of <any></summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleAdditionalProperties AdditionalProperty { get; set; }

        System.Collections.Generic.List<int> Hour { get; set; }

        System.Collections.Generic.List<int> Minute { get; set; }

        System.Collections.Generic.List<int> MonthDay { get; set; }

        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence> MonthlyOccurrence { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> WeekDay { get; set; }

    }
}