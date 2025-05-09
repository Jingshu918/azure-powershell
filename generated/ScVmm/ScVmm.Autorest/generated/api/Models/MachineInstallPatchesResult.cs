// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Extensions;

    /// <summary>The result summary of an installation operation.</summary>
    public partial class MachineInstallPatchesResult :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResult,
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal
    {

        /// <summary>Backing field for <see cref="ErrorDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGenerated _errorDetail;

        /// <summary>
        /// The errors that were encountered during execution of the operation. The details array contains the list of them.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGenerated ErrorDetail { get => (this._errorDetail = this._errorDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ErrorDetailAutoGenerated()); }

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorAdditionalInfo> ErrorDetailAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGenerated> ErrorDetailDetails { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).Detail; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).Message; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Inlined)]
        public string ErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).Target; }

        /// <summary>Backing field for <see cref="ExcludedPatchCount" /> property.</summary>
        private int? _excludedPatchCount;

        /// <summary>
        /// The number of patches that were not installed due to the user blocking their installation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public int? ExcludedPatchCount { get => this._excludedPatchCount; }

        /// <summary>Backing field for <see cref="FailedPatchCount" /> property.</summary>
        private int? _failedPatchCount;

        /// <summary>
        /// The number of patches that could not be installed due to some issue. See errors for details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public int? FailedPatchCount { get => this._failedPatchCount; }

        /// <summary>Backing field for <see cref="InstallationActivityId" /> property.</summary>
        private string _installationActivityId;

        /// <summary>The activity ID of the operation that produced this result.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string InstallationActivityId { get => this._installationActivityId; }

        /// <summary>Backing field for <see cref="InstalledPatchCount" /> property.</summary>
        private int? _installedPatchCount;

        /// <summary>The number of patches successfully installed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public int? InstalledPatchCount { get => this._installedPatchCount; }

        /// <summary>Backing field for <see cref="LastModifiedDateTime" /> property.</summary>
        private global::System.DateTime? _lastModifiedDateTime;

        /// <summary>The UTC timestamp when the operation finished.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public global::System.DateTime? LastModifiedDateTime { get => this._lastModifiedDateTime; }

        /// <summary>Backing field for <see cref="MaintenanceWindowExceeded" /> property.</summary>
        private bool? _maintenanceWindowExceeded;

        /// <summary>
        /// Whether the operation ran out of time before it completed all its intended actions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public bool? MaintenanceWindowExceeded { get => this._maintenanceWindowExceeded; }

        /// <summary>Internal Acessors for ErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.ErrorDetail { get => (this._errorDetail = this._errorDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ErrorDetailAutoGenerated()); set { {_errorDetail = value;} } }

        /// <summary>Internal Acessors for ErrorDetailAdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.ErrorDetailAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).AdditionalInfo = value; }

        /// <summary>Internal Acessors for ErrorDetailCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).Code = value; }

        /// <summary>Internal Acessors for ErrorDetailDetails</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGenerated> Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.ErrorDetailDetails { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).Detail = value; }

        /// <summary>Internal Acessors for ErrorDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).Message = value; }

        /// <summary>Internal Acessors for ErrorDetailTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.ErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGeneratedInternal)ErrorDetail).Target = value; }

        /// <summary>Internal Acessors for ExcludedPatchCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.ExcludedPatchCount { get => this._excludedPatchCount; set { {_excludedPatchCount = value;} } }

        /// <summary>Internal Acessors for FailedPatchCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.FailedPatchCount { get => this._failedPatchCount; set { {_failedPatchCount = value;} } }

        /// <summary>Internal Acessors for InstallationActivityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.InstallationActivityId { get => this._installationActivityId; set { {_installationActivityId = value;} } }

        /// <summary>Internal Acessors for InstalledPatchCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.InstalledPatchCount { get => this._installedPatchCount; set { {_installedPatchCount = value;} } }

        /// <summary>Internal Acessors for LastModifiedDateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.LastModifiedDateTime { get => this._lastModifiedDateTime; set { {_lastModifiedDateTime = value;} } }

        /// <summary>Internal Acessors for MaintenanceWindowExceeded</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.MaintenanceWindowExceeded { get => this._maintenanceWindowExceeded; set { {_maintenanceWindowExceeded = value;} } }

        /// <summary>Internal Acessors for NotSelectedPatchCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.NotSelectedPatchCount { get => this._notSelectedPatchCount; set { {_notSelectedPatchCount = value;} } }

        /// <summary>Internal Acessors for OSType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.OSType { get => this._oSType; set { {_oSType = value;} } }

        /// <summary>Internal Acessors for PatchServiceUsed</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.PatchServiceUsed { get => this._patchServiceUsed; set { {_patchServiceUsed = value;} } }

        /// <summary>Internal Acessors for PendingPatchCount</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.PendingPatchCount { get => this._pendingPatchCount; set { {_pendingPatchCount = value;} } }

        /// <summary>Internal Acessors for RebootStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.RebootStatus { get => this._rebootStatus; set { {_rebootStatus = value;} } }

        /// <summary>Internal Acessors for StartDateTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.StartDateTime { get => this._startDateTime; set { {_startDateTime = value;} } }

        /// <summary>Internal Acessors for StartedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.StartedBy { get => this._startedBy; set { {_startedBy = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineInstallPatchesResultInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="NotSelectedPatchCount" /> property.</summary>
        private int? _notSelectedPatchCount;

        /// <summary>
        /// The number of patches that were detected as available for install, but did not meet the operation's criteria.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public int? NotSelectedPatchCount { get => this._notSelectedPatchCount; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>The operating system type of the machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; }

        /// <summary>Backing field for <see cref="PatchServiceUsed" /> property.</summary>
        private string _patchServiceUsed;

        /// <summary>Specifies the patch service used for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string PatchServiceUsed { get => this._patchServiceUsed; }

        /// <summary>Backing field for <see cref="PendingPatchCount" /> property.</summary>
        private int? _pendingPatchCount;

        /// <summary>
        /// The number of patches that were identified as meeting the installation criteria, but were not able to be installed. Typically
        /// this happens when maintenanceWindowExceeded == true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public int? PendingPatchCount { get => this._pendingPatchCount; }

        /// <summary>Backing field for <see cref="RebootStatus" /> property.</summary>
        private string _rebootStatus;

        /// <summary>The reboot state of the VM following completion of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string RebootStatus { get => this._rebootStatus; }

        /// <summary>Backing field for <see cref="StartDateTime" /> property.</summary>
        private global::System.DateTime? _startDateTime;

        /// <summary>The UTC timestamp when the operation began.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public global::System.DateTime? StartDateTime { get => this._startDateTime; }

        /// <summary>Backing field for <see cref="StartedBy" /> property.</summary>
        private string _startedBy;

        /// <summary>Indicates if operation was triggered by user or by platform.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string StartedBy { get => this._startedBy; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>
        /// The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that
        /// point it will become "Failed", "Succeeded", "Unknown" or "CompletedWithWarnings."
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Origin(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Creates an new <see cref="MachineInstallPatchesResult" /> instance.</summary>
        public MachineInstallPatchesResult()
        {

        }
    }
    /// The result summary of an installation operation.
    public partial interface IMachineInstallPatchesResult :
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorAdditionalInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorAdditionalInfo> ErrorDetailAdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailCode { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGenerated) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGenerated> ErrorDetailDetails { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailMessage { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailTarget { get;  }
        /// <summary>
        /// The number of patches that were not installed due to the user blocking their installation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The number of patches that were not installed due to the user blocking their installation.",
        SerializedName = @"excludedPatchCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ExcludedPatchCount { get;  }
        /// <summary>
        /// The number of patches that could not be installed due to some issue. See errors for details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The number of patches that could not be installed due to some issue. See errors for details.",
        SerializedName = @"failedPatchCount",
        PossibleTypes = new [] { typeof(int) })]
        int? FailedPatchCount { get;  }
        /// <summary>The activity ID of the operation that produced this result.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The activity ID of the operation that produced this result.",
        SerializedName = @"installationActivityId",
        PossibleTypes = new [] { typeof(string) })]
        string InstallationActivityId { get;  }
        /// <summary>The number of patches successfully installed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The number of patches successfully installed.",
        SerializedName = @"installedPatchCount",
        PossibleTypes = new [] { typeof(int) })]
        int? InstalledPatchCount { get;  }
        /// <summary>The UTC timestamp when the operation finished.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The UTC timestamp when the operation finished.",
        SerializedName = @"lastModifiedDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModifiedDateTime { get;  }
        /// <summary>
        /// Whether the operation ran out of time before it completed all its intended actions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Whether the operation ran out of time before it completed all its intended actions.",
        SerializedName = @"maintenanceWindowExceeded",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MaintenanceWindowExceeded { get;  }
        /// <summary>
        /// The number of patches that were detected as available for install, but did not meet the operation's criteria.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The number of patches that were detected as available for install, but did not meet the operation's criteria.",
        SerializedName = @"notSelectedPatchCount",
        PossibleTypes = new [] { typeof(int) })]
        int? NotSelectedPatchCount { get;  }
        /// <summary>The operating system type of the machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The operating system type of the machine.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Windows", "Linux", "Other")]
        string OSType { get;  }
        /// <summary>Specifies the patch service used for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies the patch service used for the operation.",
        SerializedName = @"patchServiceUsed",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Unknown", "WU", "WU_WSUS", "YUM", "APT", "Zypper")]
        string PatchServiceUsed { get;  }
        /// <summary>
        /// The number of patches that were identified as meeting the installation criteria, but were not able to be installed. Typically
        /// this happens when maintenanceWindowExceeded == true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The number of patches that were identified as meeting the installation criteria, but were not able to be installed. Typically this happens when maintenanceWindowExceeded == true.",
        SerializedName = @"pendingPatchCount",
        PossibleTypes = new [] { typeof(int) })]
        int? PendingPatchCount { get;  }
        /// <summary>The reboot state of the VM following completion of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The reboot state of the VM following completion of the operation.",
        SerializedName = @"rebootStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Unknown", "NotNeeded", "Required", "Started", "Failed", "Completed")]
        string RebootStatus { get;  }
        /// <summary>The UTC timestamp when the operation began.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The UTC timestamp when the operation began.",
        SerializedName = @"startDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartDateTime { get;  }
        /// <summary>Indicates if operation was triggered by user or by platform.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Indicates if operation was triggered by user or by platform.",
        SerializedName = @"startedBy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("User", "Platform")]
        string StartedBy { get;  }
        /// <summary>
        /// The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that
        /// point it will become "Failed", "Succeeded", "Unknown" or "CompletedWithWarnings."
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The overall success or failure status of the operation. It remains ""InProgress"" until the operation completes. At that point it will become ""Failed"", ""Succeeded"", ""Unknown"" or ""CompletedWithWarnings.""",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Unknown", "InProgress", "Failed", "Succeeded", "CompletedWithWarnings")]
        string Status { get;  }

    }
    /// The result summary of an installation operation.
    internal partial interface IMachineInstallPatchesResultInternal

    {
        /// <summary>
        /// The errors that were encountered during execution of the operation. The details array contains the list of them.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGenerated ErrorDetail { get; set; }
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorAdditionalInfo> ErrorDetailAdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string ErrorDetailCode { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGenerated> ErrorDetailDetails { get; set; }
        /// <summary>The error message.</summary>
        string ErrorDetailMessage { get; set; }
        /// <summary>The error target.</summary>
        string ErrorDetailTarget { get; set; }
        /// <summary>
        /// The number of patches that were not installed due to the user blocking their installation.
        /// </summary>
        int? ExcludedPatchCount { get; set; }
        /// <summary>
        /// The number of patches that could not be installed due to some issue. See errors for details.
        /// </summary>
        int? FailedPatchCount { get; set; }
        /// <summary>The activity ID of the operation that produced this result.</summary>
        string InstallationActivityId { get; set; }
        /// <summary>The number of patches successfully installed.</summary>
        int? InstalledPatchCount { get; set; }
        /// <summary>The UTC timestamp when the operation finished.</summary>
        global::System.DateTime? LastModifiedDateTime { get; set; }
        /// <summary>
        /// Whether the operation ran out of time before it completed all its intended actions.
        /// </summary>
        bool? MaintenanceWindowExceeded { get; set; }
        /// <summary>
        /// The number of patches that were detected as available for install, but did not meet the operation's criteria.
        /// </summary>
        int? NotSelectedPatchCount { get; set; }
        /// <summary>The operating system type of the machine.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Windows", "Linux", "Other")]
        string OSType { get; set; }
        /// <summary>Specifies the patch service used for the operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Unknown", "WU", "WU_WSUS", "YUM", "APT", "Zypper")]
        string PatchServiceUsed { get; set; }
        /// <summary>
        /// The number of patches that were identified as meeting the installation criteria, but were not able to be installed. Typically
        /// this happens when maintenanceWindowExceeded == true.
        /// </summary>
        int? PendingPatchCount { get; set; }
        /// <summary>The reboot state of the VM following completion of the operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Unknown", "NotNeeded", "Required", "Started", "Failed", "Completed")]
        string RebootStatus { get; set; }
        /// <summary>The UTC timestamp when the operation began.</summary>
        global::System.DateTime? StartDateTime { get; set; }
        /// <summary>Indicates if operation was triggered by user or by platform.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("User", "Platform")]
        string StartedBy { get; set; }
        /// <summary>
        /// The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that
        /// point it will become "Failed", "Succeeded", "Unknown" or "CompletedWithWarnings."
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ScVmm.PSArgumentCompleterAttribute("Unknown", "InProgress", "Failed", "Succeeded", "CompletedWithWarnings")]
        string Status { get; set; }

    }
}