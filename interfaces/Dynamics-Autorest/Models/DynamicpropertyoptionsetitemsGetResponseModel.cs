// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Collection of dynamicpropertyoptionsetitems
    /// </summary>
    public partial class DynamicpropertyoptionsetitemsGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DynamicpropertyoptionsetitemsGetResponseModel class.
        /// </summary>
        public DynamicpropertyoptionsetitemsGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DynamicpropertyoptionsetitemsGetResponseModel class.
        /// </summary>
        public DynamicpropertyoptionsetitemsGetResponseModel(IList<MicrosoftDynamicsCRMdynamicpropertyoptionsetitem> value = default(IList<MicrosoftDynamicsCRMdynamicpropertyoptionsetitem>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMdynamicpropertyoptionsetitem> Value { get; set; }

    }
}
