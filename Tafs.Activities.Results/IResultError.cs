//
//  IResultError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

namespace Tafs.Activities.Results
{
    /// <summary>
    /// Represents an error returned by a result.
    /// </summary>
    public interface IResultError
    {
        /// <summary>
        /// Gets the human-readable error message.
        /// </summary>
        string Message { get; }
    }
}
