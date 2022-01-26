//
//  ArgumentError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using System;

namespace Tafs.Activities.Results.Errors.Bases
{
    /// <summary>
    /// Represents an error arising from an argument.
    /// </summary>
    /// <remarks>
    /// Used in place of <see cref="ArgumentException"/>.
    /// </remarks>
    public abstract class ArgumentError : ResultError
    {
        /// <summary>
        /// Gets the name of the argument that caused the error.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentError"/> class.
        /// </summary>
        /// <param name="name">The name of the argument that caused the error.</param>
        /// <param name="message">A description of why the argument is invalid.</param>
        public ArgumentError(string name, string message)
            : base($"Error in argument {name}: {message}")
        {
            Name = name;
        }
    }
}
