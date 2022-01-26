//
//  ArgumentNullError.cs
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
    /// Represents an error arising from an argument being null.
    /// </summary>
    public sealed class ArgumentNullError : ArgumentError
    {
        /// <inheritdoc cref="ArgumentError(string, string)"/>
        public ArgumentNullError(string name, string message = "Value may not be null.")
            : base(name, message)
        {
        }
    }
}
