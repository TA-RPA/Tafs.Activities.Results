//
//  InvalidOperationError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using System;

namespace Tafs.Activities.Results.Errors
{
    /// <summary>
    /// Represents an error raised when an attempt to perform an invalid operation is made.
    /// </summary>
    /// <remarks>Used in place of <see cref="InvalidOperationException"/>.</remarks>
    public sealed class InvalidOperationError : ResultError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidOperationError"/> class.
        /// </summary>
        /// <inheritdoc cref="ResultError(string)"/>
        public InvalidOperationError(string message = "The requested operation is invalid.")
            : base(message)
        {
        }
    }
}
