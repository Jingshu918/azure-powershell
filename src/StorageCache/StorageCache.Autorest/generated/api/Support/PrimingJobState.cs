// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support
{

    /// <summary>The state of the priming operation.</summary>
    public partial struct PrimingJobState :
        System.IEquatable<PrimingJobState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.PrimingJobState Complete = @"Complete";

        public static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.PrimingJobState Paused = @"Paused";

        public static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.PrimingJobState Queued = @"Queued";

        public static Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.PrimingJobState Running = @"Running";

        /// <summary>the value for an instance of the <see cref="PrimingJobState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to PrimingJobState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PrimingJobState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new PrimingJobState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type PrimingJobState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.PrimingJobState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type PrimingJobState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is PrimingJobState && Equals((PrimingJobState)obj);
        }

        /// <summary>Returns hashCode for enum PrimingJobState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="PrimingJobState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private PrimingJobState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for PrimingJobState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to PrimingJobState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="PrimingJobState" />.</param>

        public static implicit operator PrimingJobState(string value)
        {
            return new PrimingJobState(value);
        }

        /// <summary>Implicit operator to convert PrimingJobState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="PrimingJobState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.PrimingJobState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum PrimingJobState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.PrimingJobState e1, Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.PrimingJobState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum PrimingJobState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.PrimingJobState e1, Microsoft.Azure.PowerShell.Cmdlets.StorageCache.Support.PrimingJobState e2)
        {
            return e2.Equals(e1);
        }
    }
}