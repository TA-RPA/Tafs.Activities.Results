//
//  GenericError.cs
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
    /// Represents a simple generic human-readable error message.
    /// </summary>
    [Obsolete("Prefer using a more specific error type.")]
    public sealed class GenericError : ResultError
    {
        /// <inheritdoc cref="ResultError(string)"/>
        public GenericError(string message)
            : base(message)
        {
        }
    }
}
