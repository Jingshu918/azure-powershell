// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    /// <summary>Reservation utilization</summary>
    public partial class ReservationsPropertiesUtilization :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsPropertiesUtilization,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsPropertiesUtilizationInternal
    {

        /// <summary>Backing field for <see cref="Aggregate" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationUtilizationAggregates> _aggregate;

        /// <summary>The array of aggregates of a reservation's utilization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationUtilizationAggregates> Aggregate { get => this._aggregate; set => this._aggregate = value; }

        /// <summary>Internal Acessors for Trend</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationsPropertiesUtilizationInternal.Trend { get => this._trend; set { {_trend = value;} } }

        /// <summary>Backing field for <see cref="Trend" /> property.</summary>
        private string _trend;

        /// <summary>last 7 day utilization trend for a reservation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string Trend { get => this._trend; }

        /// <summary>Creates an new <see cref="ReservationsPropertiesUtilization" /> instance.</summary>
        public ReservationsPropertiesUtilization()
        {

        }
    }
    /// Reservation utilization
    public partial interface IReservationsPropertiesUtilization :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>The array of aggregates of a reservation's utilization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The array of aggregates of a reservation's utilization",
        SerializedName = @"aggregates",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationUtilizationAggregates) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationUtilizationAggregates> Aggregate { get; set; }
        /// <summary>last 7 day utilization trend for a reservation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"last 7 day utilization trend for a reservation",
        SerializedName = @"trend",
        PossibleTypes = new [] { typeof(string) })]
        string Trend { get;  }

    }
    /// Reservation utilization
    internal partial interface IReservationsPropertiesUtilizationInternal

    {
        /// <summary>The array of aggregates of a reservation's utilization</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.IReservationUtilizationAggregates> Aggregate { get; set; }
        /// <summary>last 7 day utilization trend for a reservation</summary>
        string Trend { get; set; }

    }
}