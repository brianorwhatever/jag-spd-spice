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
    /// connectionroleassociation
    /// </summary>
    public partial class MicrosoftDynamicsCRMconnectionroleassociation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMconnectionroleassociation class.
        /// </summary>
        public MicrosoftDynamicsCRMconnectionroleassociation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMconnectionroleassociation class.
        /// </summary>
        public MicrosoftDynamicsCRMconnectionroleassociation(string associatedconnectionroleid = default(string), string connectionroleassociationid = default(string), string connectionroleid = default(string), long? versionnumber = default(long?))
        {
            Associatedconnectionroleid = associatedconnectionroleid;
            Connectionroleassociationid = connectionroleassociationid;
            Connectionroleid = connectionroleid;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "associatedconnectionroleid")]
        public string Associatedconnectionroleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionroleassociationid")]
        public string Connectionroleassociationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionroleid")]
        public string Connectionroleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

    }
}
