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
    /// annualfiscalcalendar
    /// </summary>
    public partial class MicrosoftDynamicsCRMannualfiscalcalendar
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMannualfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMannualfiscalcalendar()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMannualfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMannualfiscalcalendar(string userfiscalcalendarid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? fiscalperiodtype = default(int?), System.DateTimeOffset? effectiveon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _businessunitidValue = default(string), object exchangerate = default(object), string _salespersonidValue = default(string), string _createdonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), string _modifiedbyValue = default(string), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), object annualBase = default(object), object annual = default(object), int? timezoneruleversionnumber = default(int?), string _createdbyValue = default(string), IList<MicrosoftDynamicsCRMbulkdeletefailure> annualFiscalCalendarBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMasyncoperation> annualFiscalCalendarAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser salespersonid = default(MicrosoftDynamicsCRMsystemuser))
        {
            Userfiscalcalendarid = userfiscalcalendarid;
            Modifiedon = modifiedon;
            Fiscalperiodtype = fiscalperiodtype;
            Effectiveon = effectiveon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._businessunitidValue = _businessunitidValue;
            Exchangerate = exchangerate;
            this._salespersonidValue = _salespersonidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedbyValue = _modifiedbyValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Createdon = createdon;
            AnnualBase = annualBase;
            Annual = annual;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdbyValue = _createdbyValue;
            AnnualFiscalCalendarBulkDeleteFailures = annualFiscalCalendarBulkDeleteFailures;
            AnnualFiscalCalendarAsyncOperations = annualFiscalCalendarAsyncOperations;
            Transactioncurrencyid = transactioncurrencyid;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Salespersonid = salespersonid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userfiscalcalendarid")]
        public string Userfiscalcalendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fiscalperiodtype")]
        public int? Fiscalperiodtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveon")]
        public System.DateTimeOffset? Effectiveon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salespersonid_value")]
        public string _salespersonidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "annual_base")]
        public object AnnualBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "annual")]
        public object Annual { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AnnualFiscalCalendar_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AnnualFiscalCalendarBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AnnualFiscalCalendar_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AnnualFiscalCalendarAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salespersonid")]
        public MicrosoftDynamicsCRMsystemuser Salespersonid { get; set; }

    }
}
