using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strada.Domain.Models
{
    /// <summary>
    /// Wrapper for action execution. 
    /// </summary>
    /// <typeparam name="T">Type of data to return</typeparam>
    public class Result<T>
    {
        /// <summary>
        /// Error info
        /// </summary>
        public ErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Code result of request
        /// </summary>
        public ProcessResult ProcessResult { get; set; }

        /// <summary>
        /// Result data of operation execution
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Create successful result
        /// </summary>
        /// <param name="data">Data that will be returned.</param>
        /// <returns></returns>
        public static Result<T> Success(T data)
        {
            return new Result<T>
            {
                Data = data,
                ProcessResult = ProcessResult.Ok
            };
        }

        /// <summary>
        /// Create unsuccessful result
        /// </summary>
        /// <param name="error">error message</param>
        /// <param name="processResult">code result</param>
        /// <returns></returns>
        public static Result<T> Fail(string error, ProcessResult processResult)
        {
            return new Result<T>()
            {
                ProcessResult = processResult,
                ErrorDetails = new ErrorDetails
                {
                    ErrorMessage = error
                }
            };
        }

        /// <summary>
        /// Create unsuccessful result
        /// </summary>
        /// <param name="errorDetails">error info</param>
        /// <param name="processResult">code result</param>
        /// <returns></returns>
        public static Result<T> Fail(ErrorDetails errorDetails, ProcessResult processResult)
        {
            return new Result<T>()
            {
                ProcessResult = processResult,
                ErrorDetails = errorDetails
            };
        }
    }
}
