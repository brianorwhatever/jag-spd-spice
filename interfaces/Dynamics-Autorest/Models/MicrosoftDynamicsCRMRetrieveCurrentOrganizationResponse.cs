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
    /// RetrieveCurrentOrganizationResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveCurrentOrganizationResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveCurrentOrganizationResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveCurrentOrganizationResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveCurrentOrganizationResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveCurrentOrganizationResponse(MicrosoftDynamicsCRMOrganizationDetail detail = default(MicrosoftDynamicsCRMOrganizationDetail))
        {
            Detail = detail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Detail")]
        public MicrosoftDynamicsCRMOrganizationDetail Detail { get; set; }

    }
}
