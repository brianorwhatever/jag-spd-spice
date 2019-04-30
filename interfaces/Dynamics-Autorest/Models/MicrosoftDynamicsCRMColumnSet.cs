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
    /// ColumnSet
    /// </summary>
    public partial class MicrosoftDynamicsCRMColumnSet
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMColumnSet
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMColumnSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMColumnSet
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMColumnSet(bool? allColumns = default(bool?), IList<string> columns = default(IList<string>))
        {
            AllColumns = allColumns;
            Columns = columns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllColumns")]
        public bool? AllColumns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Columns")]
        public IList<string> Columns { get; set; }

    }
}
