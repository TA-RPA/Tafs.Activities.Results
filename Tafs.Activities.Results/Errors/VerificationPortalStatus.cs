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
    public sealed class VerificationPortalStatus
    {
        /// <summary>
        /// The record was verified successfully.
        /// </summary>
        public static readonly VerificationPortalStatus Verified = new VerificationPortalStatus(nameof(Verified));

        /// <summary>
        /// The record was not found or the client did not match.
        /// </summary>
        public static readonly VerificationPortalStatus RejectedFraud = new VerificationPortalStatus("Rejected - Fraud");

        /// <summary>
        /// The invoice was found but the amount did not match.
        /// </summary>
        public static readonly VerificationPortalStatus RejectedPaymentIssue = new VerificationPortalStatus("Rejected - Payment Issue");

        /// <summary>
        /// A bot exception occurred.
        /// </summary>
        public static readonly VerificationPortalStatus BotException = new VerificationPortalStatus("Bot Exception");

        /// <summary>
        /// A business exception occurred.
        /// </summary>
        public static readonly VerificationPortalStatus BusinessException = new VerificationPortalStatus("Business Exception");

        /// <summary>
        /// Gets the internal message used for writing to the endpoint.
        /// </summary>
        public string Message { get; }

        private VerificationPortalStatus(string message)
        {
            Message = message;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return Message;
        }
    }
}
