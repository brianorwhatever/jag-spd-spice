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
    /// servicecontractcontacts
    /// </summary>
    public partial class MicrosoftDynamicsCRMservicecontractcontacts
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMservicecontractcontacts class.
        /// </summary>
        public MicrosoftDynamicsCRMservicecontractcontacts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMservicecontractcontacts class.
        /// </summary>
        public MicrosoftDynamicsCRMservicecontractcontacts(int? servicelevel = default(int?), string contactid = default(string), string servicecontractcontactid = default(string), long? versionnumber = default(long?), string contractid = default(string))
        {
            Servicelevel = servicelevel;
            Contactid = contactid;
            Servicecontractcontactid = servicecontractcontactid;
            Versionnumber = versionnumber;
            Contractid = contractid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicelevel")]
        public int? Servicelevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactid")]
        public string Contactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicecontractcontactid")]
        public string Servicecontractcontactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contractid")]
        public string Contractid { get; set; }

    }
}
