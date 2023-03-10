//
//  VerificationPortalStatus.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tafs.Activities.Results.Errors
{
    /// <summary>
    /// Represents a final status as reported to the Verification Portal endpoint.
    /// </summary>
    public enum VerificationPortalStatus
    {
        /// <summary>
        /// The record was verified successfully.
        /// </summary>
        Verified,

        /// <summary>
        /// The record was not found or the client did not match.
        /// </summary>
        RejectedFraud,

        /// <summary>
        /// The invoice was found but the amount did not match.
        /// </summary>
        RejectedPaymentIssue,

        /// <summary>
        /// A bot exception occurred.
        /// </summary>
        Exception
    }
}
