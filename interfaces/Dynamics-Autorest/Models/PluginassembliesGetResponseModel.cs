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
    /// Collection of pluginassemblies
    /// </summary>
    public partial class PluginassembliesGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the PluginassembliesGetResponseModel
        /// class.
        /// </summary>
        public PluginassembliesGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PluginassembliesGetResponseModel
        /// class.
        /// </summary>
        public PluginassembliesGetResponseModel(IList<MicrosoftDynamicsCRMpluginassembly> value = default(IList<MicrosoftDynamicsCRMpluginassembly>))
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
        public IList<MicrosoftDynamicsCRMpluginassembly> Value { get; set; }

    }
}
