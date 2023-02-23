//
//  UploadError.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

namespace Tafs.Activities.Results.Errors
{
    /// <summary>
    /// Represents an error resulting from a partial document upload.
    /// </summary>
    public sealed class UploadError : ResultError
    {
        /// <summary>
        /// Gets a count that records the number of documents that were properly uploaded.
        /// </summary>
        public int DocumentsUploaded { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadError"/> class.
        /// </summary>
        /// <param name="documentsUploaded">A count that records the number of documents that were properly uploaded.</param>
        /// <param name="message">Error Message.</param>
        public UploadError(int documentsUploaded, string message)
            : base(message)
        {
            this.DocumentsUploaded = documentsUploaded;
        }
    }
}
