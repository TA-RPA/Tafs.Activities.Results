//
//  NotSupportedError.cs
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
    /// Represents an error raised when an attempt to perform an unsupported action is made.
    /// </summary>
    /// <remarks>Used in place of <see cref="NotSupportedException"/>.</remarks>
    public sealed class NotSupportedError : ResultError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotSupportedError"/> class.
        /// </summary>
        /// <inheritdoc cref="ResultError(string)"/>
        public NotSupportedError(string message = "The requested action is not supported.")
            : base(message)
        {
        }
    }
}
