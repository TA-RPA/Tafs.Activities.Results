﻿//
//  SalesforceError.cs
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
using UiPath.Salesforce.Activities.Models;

namespace Tafs.Activities.Results.Errors
{
    /// <summary>
    /// Represents an error which occurred due to an error in the Salesforce API.
    /// </summary>
    public sealed class SalesforceError : ResultError
    {
        /// <summary>
        /// Gets the underlying <see cref="SalesforceStatus"/> object.
        /// </summary>
        public SalesforceStatus Status { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesforceError"/> class.
        /// </summary>
        /// <param name="status">The <see cref="SalesforceStatus"/> that caused this error.</param>
        public SalesforceError(SalesforceStatus status)
            : base($"A Salesforce API error occurred: {status.Message}")
        {
            if (status.Success)
            {
                throw new ArgumentException("Successful statuses cannot result in an error.", nameof(status));
            }

            Status = status;
        }
    }
}