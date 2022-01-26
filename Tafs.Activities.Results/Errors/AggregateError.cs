//
//  AggregateError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using System.Collections.Generic;

namespace Tafs.Activities.Results.Errors
{
    /// <summary>
    /// Represents a set of errors produced by an operation.
    /// </summary>
    public sealed class AggregateError : ResultError
    {
        /// <summary>
        /// Gets a read-only collection of errors which caused the current error.
        /// </summary>
        public IReadOnlyCollection<IResult> Errors { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateError"/> class.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="errors">The errors.</param>
        public AggregateError(IReadOnlyCollection<IResult> errors, string message = "One or more errors occurred.")
            : base(message)
        {
            Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateError"/> class.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="errors">The errors.</param>
        public AggregateError(string message, params IResult[] errors)
            : this(errors, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateError"/> class.
        /// </summary>
        /// <param name="errors">The errors.</param>
        public AggregateError(params IResult[] errors)
            : this((IReadOnlyCollection<IResult>)errors)
        {
        }
    }
}
