//
//  ArgumentInvalidError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using System;
using Tafs.Activities.Results.Errors.Bases;

namespace Tafs.Activities.Results.Errors
{
    /// <summary>
    /// Represents an error arising from an argument being invalid.
    /// </summary>
    /// <remarks>Used in place of <see cref="ArgumentException"/>.</remarks>
    public sealed class ArgumentInvalidError : ArgumentError
    {
        /// <inheritdoc cref="ArgumentError(string, string)"/>
        public ArgumentInvalidError(string argument, string message)
            : base(argument, message)
        {
        }
    }
}
