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
    /// discount
    /// </summary>
    public partial class MicrosoftDynamicsCRMdiscount
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMdiscount
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMdiscount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMdiscount
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMdiscount(object amount = default(object), int? importsequencenumber = default(int?), string _modifiedbyValue = default(string), bool? isamounttype = default(bool?), string _modifiedonbehalfbyValue = default(string), string organizationid = default(string), object amountBase = default(object), object highquantity = default(object), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), object exchangerate = default(object), string discountid = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), object percentage = default(object), object lowquantity = default(object), string _discounttypeidValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), long? versionnumber = default(long?), string _transactioncurrencyidValue = default(string), IList<MicrosoftDynamicsCRMasyncoperation> discountAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsyncerror> discountSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMdiscounttype discounttypeid = default(MicrosoftDynamicsCRMdiscounttype), IList<MicrosoftDynamicsCRMbulkdeletefailure> discountBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Amount = amount;
            Importsequencenumber = importsequencenumber;
            this._modifiedbyValue = _modifiedbyValue;
            Isamounttype = isamounttype;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Organizationid = organizationid;
            AmountBase = amountBase;
            Highquantity = highquantity;
            Createdon = createdon;
            Exchangerate = exchangerate;
            Discountid = discountid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            Percentage = percentage;
            Lowquantity = lowquantity;
            this._discounttypeidValue = _discounttypeidValue;
            this._createdbyValue = _createdbyValue;
            Overriddencreatedon = overriddencreatedon;
            Versionnumber = versionnumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            DiscountAsyncOperations = discountAsyncOperations;
            Createdonbehalfby = createdonbehalfby;
            Transactioncurrencyid = transactioncurrencyid;
            DiscountSyncErrors = discountSyncErrors;
            Createdby = createdby;
            Discounttypeid = discounttypeid;
            DiscountBulkDeleteFailures = discountBulkDeleteFailures;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public object Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isamounttype")]
        public bool? Isamounttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amount_base")]
        public object AmountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "highquantity")]
        public object Highquantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountid")]
        public string Discountid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "percentage")]
        public object Percentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lowquantity")]
        public object Lowquantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_discounttypeid_value")]
        public string _discounttypeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Discount_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> DiscountAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Discount_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> DiscountSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discounttypeid")]
        public MicrosoftDynamicsCRMdiscounttype Discounttypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Discount_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> DiscountBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
