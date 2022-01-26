//
//  HttpError.cs
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
    /// Represents an error resulting from a web operation.
    /// </summary>
    public sealed class HttpError : ResultError
    {
        /// <summary>
        /// Gets the HTTP Status Code.
        /// </summary>
        public int StatusCode { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpError"/> class.
        /// </summary>
        /// <param name="statusCode">The <see href="http://www.iana.org/assignments/http-status-codes/http-status-codes.xhtml">HTTP Status Code</see> associated with this error.</param>
        /// <param name="message">A message which describes the error.</param>
        public HttpError(int statusCode, string message)
            : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
