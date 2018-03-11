// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.ClientDictionaries.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ErrorModel
    {
        /// <summary>
        /// Initializes a new instance of the ErrorModel class.
        /// </summary>
        public ErrorModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorModel class.
        /// </summary>
        /// <param name="type">Possible values include: 'NotFound',
        /// 'Validation'</param>
        public ErrorModel(ErrorType type, string message = default(string))
        {
            Message = message;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NotFound', 'Validation'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public ErrorType Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
