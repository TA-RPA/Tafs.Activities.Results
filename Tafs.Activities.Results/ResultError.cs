//
//  ResultError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

namespace Tafs.Activities.Results
{
    /// <inheritdoc />
    public abstract class ResultError : IResultError
    {
        /// <inheritdoc />
        public string Message { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultError"/> class.
        /// </summary>
        /// <param name="message">A message which describes the error.</param>
        public ResultError(string message)
        {
            Message = message;
        }
    }
}
