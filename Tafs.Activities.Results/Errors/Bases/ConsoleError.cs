//
//  ConsoleError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

namespace Tafs.Activities.Results.Errors.Bases
{
    /// <summary>
    /// Represents an error arising from a console.
    /// </summary>
    public abstract class ConsoleError : ResultError
    {
        /// <summary>
        /// Gets the name of the type of console in which the error occurred.
        /// </summary>
        public string ConsoleName { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleError"/> class.
        /// </summary>
        /// <param name="consoleName">The name of the type of console in which the error occurred, e.g. "batch" or "AS400".</param>
        /// <param name="message">The error message.</param>
        public ConsoleError(string consoleName, string message)
            : base($"Error in {consoleName}: {message}")
        {
            ConsoleName = consoleName;
        }
    }
}
