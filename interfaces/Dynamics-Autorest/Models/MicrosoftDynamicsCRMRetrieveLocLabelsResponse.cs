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
    /// RetrieveLocLabelsResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveLocLabelsResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveLocLabelsResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveLocLabelsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveLocLabelsResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveLocLabelsResponse(MicrosoftDynamicsCRMLabel label = default(MicrosoftDynamicsCRMLabel))
        {
            Label = label;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Label")]
        public MicrosoftDynamicsCRMLabel Label { get; set; }

    }
}
