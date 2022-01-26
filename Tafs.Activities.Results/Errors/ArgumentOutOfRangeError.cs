//
//  ArgumentOutOfRangeError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using Tafs.Activities.Results.Errors.Bases;

namespace Tafs.Activities.Results.Errors
{
    /// <summary>
    /// Represents an error arising from an argument being outside of the expected range.
    /// </summary>
    public sealed class ArgumentOutOfRangeError : ArgumentError
    {
        /// <inheritdoc cref="ArgumentError(string, string)"/>
        public ArgumentOutOfRangeError(string name, string message = "Value was outside of the expected range.")
            : base(name, message)
        {
        }
    }
}
