// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace Tomlyn.Serialization
{
    /// <summary>
    /// TomlKnownNamingPolicy
    /// </summary>
    public enum TomlKnownNamingPolicy
    {
        /// <summary>
        /// Unspecified
        /// </summary>
        Unspecified,
        /// <summary>
        /// CamelCase
        /// </summary>
        CamelCase,
        /// <summary>
        /// SnakeCaseLower
        /// </summary>
        SnakeCaseLower,
        /// <summary>
        /// SnakeCaseUpper
        /// </summary>
        SnakeCaseUpper,
        /// <summary>
        /// KebabCaseLower
        /// </summary>
        KebabCaseLower,
        /// <summary>
        /// KebabCaseUpper
        /// </summary>
        KebabCaseUpper
    }
}