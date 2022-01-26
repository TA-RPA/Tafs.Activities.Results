//
//  NotFoundError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

namespace Tafs.Activities.Results.Errors
{
    /// <summary>
    /// Represents a failure to find something that was searched for.
    /// </summary>
    public sealed class NotFoundError : ResultError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundError"/> class.
        /// </summary>
        /// <inheritdoc cref="ResultError(string)"/>
        public NotFoundError(string message = "The searched-for entity was not found.")
            : base(message)
        {
        }
    }
}
