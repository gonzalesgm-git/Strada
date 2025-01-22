namespace Strada.Domain.Models
{
    public class ValidationError
    {
        /// <summary>
        /// Create new instance of class.
        /// </summary>
        /// <param name="field">Invalid field name</param>
        /// <param name="message">Error message</param>
        public ValidationError(string field, string message)
        {
            Field = !string.IsNullOrEmpty(field) ? field.ToLower()[0] + field.Substring(1) : string.Empty;
            Message = message;
        }

        /// <summary>
        /// Error message
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Invalid field name
        /// </summary>
        public string Field { get; }
    }
}
