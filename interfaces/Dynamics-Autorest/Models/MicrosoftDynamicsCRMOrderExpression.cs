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
    /// OrderExpression
    /// </summary>
    public partial class MicrosoftDynamicsCRMOrderExpression
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMOrderExpression class.
        /// </summary>
        public MicrosoftDynamicsCRMOrderExpression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMOrderExpression class.
        /// </summary>
        /// <param name="orderType">Possible values include: 'Ascending',
        /// 'Descending'</param>
        public MicrosoftDynamicsCRMOrderExpression(string attributeName = default(string), string orderType = default(string))
        {
            AttributeName = attributeName;
            OrderType = orderType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttributeName")]
        public string AttributeName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Ascending', 'Descending'
        /// </summary>
        [JsonProperty(PropertyName = "OrderType")]
        public string OrderType { get; set; }

    }
}
