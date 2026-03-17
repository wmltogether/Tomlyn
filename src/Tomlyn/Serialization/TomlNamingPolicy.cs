// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace Tomlyn.Serialization
{
    /// <summary>
    /// TomlNamingPolicy
    /// </summary>
    public abstract partial class TomlNamingPolicy
    {
        /// <summary>
        /// Returns the naming policy for camel-casing.
        /// </summary>
        public static TomlNamingPolicy CamelCase { get; } = new TomlCamelCaseNamingPolicy();

        /// <summary>
        /// Returns the naming policy for lower snake-casing.
        /// </summary>
        public static TomlNamingPolicy SnakeCaseLower { get; } = new TomlSnakeCaseLowerNamingPolicy();

        /// <summary>
        /// Returns the naming policy for upper snake-casing.
        /// </summary>
        public static TomlNamingPolicy SnakeCaseUpper { get; } = new TomlSnakeCaseUpperNamingPolicy();

        /// <summary>
        /// Returns the naming policy for lower kebab-casing.
        /// </summary>
        public static TomlNamingPolicy KebabCaseLower { get; } = new TomlKebabCaseLowerNamingPolicy();

        /// <summary>
        /// Returns the naming policy for upper kebab-casing.
        /// </summary>
        public static TomlNamingPolicy KebabCaseUpper { get; } = new TomlKebabCaseUpperNamingPolicy();

        /// <summary>
        /// When overridden in a derived class, converts the specified name according to the policy.
        /// </summary>
        /// <param name="name">The name to convert.</param>
        /// <returns>The converted name.</returns>
        public abstract string ConvertName(string name);
    }
}