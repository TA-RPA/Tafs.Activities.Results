//
//  ExceptionErrorTests.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using System;
using Tafs.Activities.Results.Errors;
using Xunit;

namespace Tafs.Activities.Results.Tests
{
    /// <summary>
    /// Tests the <see cref="ExceptionError"/> type.
    /// </summary>
    public class ExceptionErrorTests
    {
        /// <summary>
        /// Tests whether the <see cref="ExceptionError.Exception"/> property returns the correct object.
        /// </summary>
        [Fact]
        public void ExceptionReturnsCorrectObject()
        {
            var exception = new Exception();
            var error = new ExceptionError(exception);

            Assert.Equal(exception, error.Exception);
        }

        /// <summary>
        /// Tests whether the <see cref="ResultError.Message"/> is simply forwarded from the exception by default.
        /// </summary>
        [Fact]
        public void ExceptionErrorForwardsExceptionMessageByDefault()
        {
            var exception = new Exception("Wooga");
            var error = new ExceptionError(exception);

            Assert.Equal(exception.Message, error.Message);
        }

        /// <summary>
        /// Tests whether the <see cref="ResultError.Message"/> is simply forwarded from the exception by default.
        /// </summary>
        [Fact]
        public void ExceptionErrorUsesProvidedMessageIfAvailable()
        {
            var exception = new Exception("Wooga");
            var error = new ExceptionError(exception, "Booga");

            Assert.NotEqual(exception.Message, error.Message);
        }
    }
}
