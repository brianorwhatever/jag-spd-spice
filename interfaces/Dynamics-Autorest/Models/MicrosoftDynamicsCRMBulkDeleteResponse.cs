// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// BulkDeleteResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMBulkDeleteResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBulkDeleteResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMBulkDeleteResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMBulkDeleteResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMBulkDeleteResponse(string jobId = default(string))
        {
            JobId = jobId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "JobId")]
        public string JobId { get; set; }

    }
}
