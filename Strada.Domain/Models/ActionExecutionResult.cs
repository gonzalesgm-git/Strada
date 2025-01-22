namespace Strada.Domain.Models
{
    /// <summary>
    /// Result of request execution, then we don't need additional information
    /// Indicate, was operation successful or not
    /// </summary>
    public class ActionExecutionResult
    {
        /// <summary>
        /// Was action executed successful
        /// </summary>
        public bool Successful { get; set; }

        /// <summary>
        /// Information message to show user after executing action.
        /// </summary>
        public string InformationMessage { get; set; }
    }
}
