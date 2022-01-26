//
//  IResult.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

namespace Tafs.Activities.Results
{
    /// <summary>
    /// Represents the public API of an interface.
    /// </summary>
    public interface IResult
    {
        /// <summary>
        /// Gets a value indicating whether the result was successful.
        /// </summary>
        bool IsSuccess { get; }

        /// <summary>
        /// Gets the error, if any.
        /// </summary>
        IResultError Error { get; }

        /// <summary>
        /// Gets the inner result, if any.
        /// </summary>
        IResult Inner { get; }
    }
}
