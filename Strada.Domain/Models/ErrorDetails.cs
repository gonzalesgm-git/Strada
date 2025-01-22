using Newtonsoft.Json;

namespace Strada.Domain.Models
{
    public class ErrorDetails
    {
        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public virtual string ErrorMessage { get; set; }
    }
}
