//
//  AS400Error.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using Tafs.Activities.Results.Errors.Bases;

namespace Tafs.Activities.Results.Errors
{
    /// <summary>
    /// Represents an error arising from the AS400 terminal emulator.
    /// </summary>
    public sealed class AS400Error : ConsoleError
    {
        /// <inheritdoc cref="ConsoleError(string, string)"/>
        public AS400Error(string message)
            : base("AS400 Terminal Emulator", message)
        {
        }
    }
}
