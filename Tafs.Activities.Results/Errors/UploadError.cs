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
        /// Gets the number of documents that were properly uploaded.
        /// </summary>
        public int DocumentsUploaded { get; }

        /// <summary>
        /// Gets the number of documents that should have been uploaded.
        /// </summary>
        public int ExpectedDocumentsCount { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadError"/> class.
        /// </summary>
        /// <param name="documentsUploaded">The number of documents that were properly uploaded.</param>
        /// <param name="message">Error Message.</param>
        /// <param name="expectedDocumentsCount">The number of documents that should have been uploaded.</param>
        public UploadError(int documentsUploaded, string message, int expectedDocumentsCount = 0)
            : base(message)
        {
            DocumentsUploaded = documentsUploaded;
            ExpectedDocumentsCount = expectedDocumentsCount;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Uploaded {DocumentsUploaded}{(ExpectedDocumentsCount > 0 ? $"/{ExpectedDocumentsCount}" : string.Empty)} documents: {Message}";
        }
    }
}
