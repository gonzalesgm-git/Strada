namespace Strada.Domain.Models
{
    public class ValidationResultModel
    {
        /// <summary>
        /// Create new instance of class.
        /// </summary>
        public ValidationResultModel()
        {
        }

        /// <summary>
        /// Create new instance of class.
        /// </summary>
        /// <param name="validationErrors">Enumerable of validation errors.</param>
        public ValidationResultModel(IEnumerable<ValidationError> validationErrors)
        {
            ErrorMessage = "Validation Failed";
            Errors = validationErrors
                .GroupBy(x => x.Field)
                .ToDictionary(
                    error => error.Key,
                    error => error.Select(x => x.Message).ToList());
        }

        /// <summary>
        /// Error message
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Re-grouped errors.
        /// </summary>
        public Dictionary<string, List<string>> Errors { get; set; }
    }
}
