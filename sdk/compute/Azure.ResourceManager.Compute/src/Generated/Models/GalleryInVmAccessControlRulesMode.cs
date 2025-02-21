// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This property allows you to specify whether the access control rules are in Audit mode, in Enforce mode or Disabled. Possible values are: 'Audit', 'Enforce' or 'Disabled'. </summary>
    public readonly partial struct GalleryInVmAccessControlRulesMode : IEquatable<GalleryInVmAccessControlRulesMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GalleryInVmAccessControlRulesMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GalleryInVmAccessControlRulesMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AuditValue = "Audit";
        private const string EnforceValue = "Enforce";
        private const string DisabledValue = "Disabled";

        /// <summary> Audit. </summary>
        public static GalleryInVmAccessControlRulesMode Audit { get; } = new GalleryInVmAccessControlRulesMode(AuditValue);
        /// <summary> Enforce. </summary>
        public static GalleryInVmAccessControlRulesMode Enforce { get; } = new GalleryInVmAccessControlRulesMode(EnforceValue);
        /// <summary> Disabled. </summary>
        public static GalleryInVmAccessControlRulesMode Disabled { get; } = new GalleryInVmAccessControlRulesMode(DisabledValue);
        /// <summary> Determines if two <see cref="GalleryInVmAccessControlRulesMode"/> values are the same. </summary>
        public static bool operator ==(GalleryInVmAccessControlRulesMode left, GalleryInVmAccessControlRulesMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GalleryInVmAccessControlRulesMode"/> values are not the same. </summary>
        public static bool operator !=(GalleryInVmAccessControlRulesMode left, GalleryInVmAccessControlRulesMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="GalleryInVmAccessControlRulesMode"/>. </summary>
        public static implicit operator GalleryInVmAccessControlRulesMode(string value) => new GalleryInVmAccessControlRulesMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GalleryInVmAccessControlRulesMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GalleryInVmAccessControlRulesMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
