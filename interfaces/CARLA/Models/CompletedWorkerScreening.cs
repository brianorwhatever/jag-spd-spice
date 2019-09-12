// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CompletedWorkerScreening
    {
        /// <summary>
        /// Initializes a new instance of the CompletedWorkerScreening class.
        /// </summary>
        public CompletedWorkerScreening()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CompletedWorkerScreening class.
        /// </summary>
        /// <param name="result">Possible values include: 'Cleared',
        /// 'NotCleared', 'FitAndProper', 'NotFitAndProper',
        /// 'Withdrawn'</param>
        public CompletedWorkerScreening(string recordIdentifier = default(string), SpiceApplicationStatus? result = default(SpiceApplicationStatus?), Worker worker = default(Worker))
        {
            RecordIdentifier = recordIdentifier;
            Result = result;
            Worker = worker;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recordIdentifier")]
        public string RecordIdentifier { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Cleared', 'NotCleared',
        /// 'FitAndProper', 'NotFitAndProper', 'Withdrawn'
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public SpiceApplicationStatus? Result { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "worker")]
        public Worker Worker { get; set; }

    }
}
