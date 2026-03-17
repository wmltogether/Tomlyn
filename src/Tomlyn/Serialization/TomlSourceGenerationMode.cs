// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System;

namespace Tomlyn.Serialization
{
    /// <summary>
    /// TomlSourceGenerationMode
    /// </summary>
    [Flags]
    public enum TomlSourceGenerationMode
    {
        /// <summary>
        /// Default
        /// </summary>
        Default,
        /// <summary>
        /// Metadata
        /// </summary>
        Metadata,
        /// <summary>
        /// Serialization
        /// </summary>
        Serialization,
    }
}