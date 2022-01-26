//
//  Result.cs
//
//  Author:
//       TAFS RPA Developers
//
//  Copyright (c) 2021 TAFS, LLC.. All rights reserved.
//

using System;
using Tafs.Activities.Results.Errors;

#pragma warning disable SA1402

namespace Tafs.Activities.Results
{
    /// <inheritdoc />
    public readonly struct Result : IResult
    {
        /// <inheritdoc />
        public bool IsSuccess => Error is null;

        /// <inheritdoc />
        public IResult Inner { get; }

        /// <inheritdoc />
        public IResultError Error { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Result"/> struct.
        /// </summary>
        /// <param name="error">The error, if any.</param>
        /// <param name="inner">The inner result, if any.</param>
        private Result(IResultError error, IResult inner)
        {
            Error = error;
            Inner = inner;
        }

        /// <summary>
        /// Creates a new successful result.
        /// </summary>
        /// <returns>The successful result.</returns>
        public static Result FromSuccess()
            => new Result(default, default);

        /// <summary>
        /// Creates a new failed result.
        /// </summary>
        /// <typeparam name="TError">The error type.</typeparam>
        /// <param name="error">The error.</param>
        /// <returns>The failed result.</returns>
        public static Result FromError<TError>(TError error) where TError : IResultError
            => new Result(error, default);

        /// <summary>
        /// Creates a new failed result.
        /// </summary>
        /// <typeparam name="TError">The error type.</typeparam>
        /// <param name="error">The error.</param>
        /// <param name="inner">The inner error that caused this error, if any.</param>
        /// <returns>The failed result.</returns>
        public static Result FromError<TError>(TError error, IResult inner) where TError : IResultError
            => new Result(error, inner);

        /// <summary>
        /// Creates a new failed result from another result.
        /// </summary>
        /// <typeparam name="TEntity">The entity type of the base result.</typeparam>
        /// <param name="result">The error.</param>
        /// <returns>The failed result.</returns>
        public static Result FromError<TEntity>(Result<TEntity> result)
            => new Result(result.Error, result);

        /// <summary>
        /// Creates a new failed result from another result.
        /// </summary>
        /// <param name="result">The error.</param>
        /// <returns>The failed result.</returns>
        public static Result FromError(Result result)
            => new Result(result.Error, result);

        /// <summary>
        /// Creates a new failed result from an exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns>The failed result.</returns>
        public static Result FromException(Exception exception)
            => new Result(new ExceptionError(exception), default);

        /// <summary>
        /// Converts an error into a failed result.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <returns>The failed result.</returns>
        public static implicit operator Result(ResultError error)
            => new Result(error, default);

        /// <summary>
        /// Converts an exception into a failed result.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns>The failed result.</returns>
        public static implicit operator Result(Exception exception)
            => new Result(new ExceptionError(exception), default);
    }

    /// <inheritdoc />
    public readonly struct Result<TEntity> : IResult
    {
        /// <summary>
        /// Gets the entity returned by the result.
        /// </summary>
        public TEntity Entity { get; }

        /// <inheritdoc />
        public bool IsSuccess => Error is null;

        /// <inheritdoc />
        public IResult Inner { get; }

        /// <inheritdoc />
        public IResultError Error { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Result{TEntity}"/> struct.
        /// </summary>
        /// <param name="entity">The entity, if any.</param>
        /// <param name="error">The error, if any.</param>
        /// <param name="inner">The inner result, if any.</param>
        private Result(TEntity entity, IResultError error, IResult inner)
        {
            Error = error ?? inner?.Error;
            Inner = inner;
            Entity = entity;
        }

        /// <summary>
        /// Determines whether the result contains a defined value; that is, it has a value and the value is not null.
        /// </summary>
        /// <returns><c>True</c> if the result contains a defined value; otherwise, <c>False</c>.</returns>
        public bool IsDefined()
            => IsSuccess && Entity != null;

        /// <summary>
        /// Determines whether the result contains a defined value; that is, it has a value and the value is not null.
        /// </summary>
        /// <param name="entity">The entity, if it is defined.</param>
        /// <returns><c>true</c> if the result contains a defined value; otherwise, <c>false</c>.</returns>
        public bool IsDefined(out TEntity entity)
        {
            entity = default;

            if (!IsSuccess)
            {
                return false;
            }

            if (Entity == null)
            {
                return false;
            }

            entity = Entity;
            return true;
        }

        /// <summary>
        /// Creates a new successful result.
        /// </summary>
        /// <param name="entity">The returned entity.</param>
        /// <returns>The successful result.</returns>
        public static Result<TEntity> FromSuccess(TEntity entity)
            => new Result<TEntity>(entity, default, default);

        /// <summary>
        /// Creates a new failed result.
        /// </summary>
        /// <typeparam name="TError">The error type.</typeparam>
        /// <param name="error">The error.</param>
        /// <returns>The failed result.</returns>
        public static Result<TEntity> FromError<TError>(TError error) where TError : IResultError
            => new Result<TEntity>(default, error, default);

        /// <summary>
        /// Creates a new failed result.
        /// </summary>
        /// <typeparam name="TError">The error type.</typeparam>
        /// <param name="error">The error.</param>
        /// <param name="inner">The inner error that caused this error, if any.</param>
        /// <returns>The failed result.</returns>
        public static Result<TEntity> FromError<TError>(TError error, IResult inner) where TError : IResultError
            => new Result<TEntity>(default, error, inner);

        /// <summary>
        /// Creates a new failed result from another result.
        /// </summary>
        /// <typeparam name="TOtherEntity">The entity type of the base result.</typeparam>
        /// <param name="result">The error.</param>
        /// <returns>The failed result.</returns>
        public static Result<TEntity> FromError<TOtherEntity>(Result<TOtherEntity> result)
            => new Result<TEntity>(default, result.Error, result);

        /// <summary>
        /// Creates a new failed result from another result.
        /// </summary>
        /// <param name="result">The error.</param>
        /// <returns>The failed result.</returns>
        public static Result<TEntity> FromError(Result result)
            => new Result<TEntity>(default, result.Error, result);

        /// <summary>
        /// Creates a new failed result from an exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns>The failed result.</returns>
        public static Result<TEntity> FromException(Exception exception)
            => new Result<TEntity>(default, new ExceptionError(exception), default);

        /// <summary>
        /// Converts an entity into a successful result.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>The successful result.</returns>
        public static implicit operator Result<TEntity>(TEntity entity)
        {
            return new Result<TEntity>(entity, default, default);
        }

        /// <summary>
        /// Converts an error into a failed result.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <returns>The failed result.</returns>
        public static implicit operator Result<TEntity>(ResultError error)
        {
            return new Result<TEntity>(default, error, default);
        }

        /// <summary>
        /// Converts an exception into a failed result.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns>The failed result.</returns>
        public static implicit operator Result<TEntity>(Exception exception)
        {
            return new Result<TEntity>(default, new ExceptionError(exception), default);
        }
    }
}
