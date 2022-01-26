//
//  OrchestratorStoppedError.cs
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
    /// Represents an error which occurs when Orchestrator has requested a stop.
    /// </summary>
    [Obsolete("A requested stop should not cause an error state.")]
    public sealed class OrchestratorStoppedError : ResultError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorStoppedError"/> class.
        /// </summary>
        public OrchestratorStoppedError()
            : base("Orchestrator requested STOP.")
        {
        }
    }
}
