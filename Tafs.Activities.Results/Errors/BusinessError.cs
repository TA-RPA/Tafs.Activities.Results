//
//  BusinessError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

namespace Tafs.Activities.Results.Errors
{
    /// <summary>
    /// Represents a generic error arising from a problem with data or the environment.
    /// </summary>
    public sealed class BusinessError : ResultError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessError"/> class.
        /// </summary>
        /// <inheritdoc cref="ResultError(string)"/>
        public BusinessError(string message)
            : base(message)
        {
        }
    }
}
