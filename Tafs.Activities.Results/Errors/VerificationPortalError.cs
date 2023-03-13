//
//  VerificationPortalError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

namespace Tafs.Activities.Results.Errors
{
    /// <summary>
    /// Represents an error which occurred while verifying a batch against a debtor portal.
    /// </summary>
    public sealed class VerificationPortalError : ResultError
    {
        /// <summary>
        /// Gets the <see cref="VerificationPortalStatus"/> for this error.
        /// </summary>
        public VerificationPortalStatus VerificationStatus { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationPortalError"/> class.
        /// </summary>
        /// <param name="verificationStatus">The status to report for this error.</param>
        /// <param name="details">The reason behind the failure.</param>
        public VerificationPortalError
        (
            VerificationPortalStatus verificationStatus,
            string details
        )
            : base($"Verifying the batch failed: {details}")
        {
            VerificationStatus = verificationStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationPortalError"/> class.
        /// </summary>
        /// <remarks>
        /// Sets the verification error to '<paramref name="expected"/>' does not equal '<paramref name="actual"/>'. <paramref name="comment"/>.
        /// </remarks>
        /// <param name="verificationStatus">The status to report for this error.</param>
        /// <param name="expected">The expected value.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="comment">An additional comment appended to the end.</param>
        public VerificationPortalError
        (
            VerificationPortalStatus verificationStatus,
            string expected,
            string actual,
            string comment = ""
        )
            : this(verificationStatus, $"'{expected}' does not equal '{actual}'. {comment}".Trim())
        {
        }
    }
}
