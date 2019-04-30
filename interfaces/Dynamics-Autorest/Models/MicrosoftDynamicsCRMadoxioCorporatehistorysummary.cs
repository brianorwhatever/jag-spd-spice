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
    /// adoxio_corporatehistorysummary
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioCorporatehistorysummary
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioCorporatehistorysummary class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioCorporatehistorysummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioCorporatehistorysummary class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioCorporatehistorysummary(string adoxioBcregistriesnumber = default(string), string _owninguserValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string adoxioCorporatehistorysummaryid = default(string), string _createdonbehalfbyValue = default(string), string _adoxioApplicationidValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owningteamValue = default(string), string _createdbyValue = default(string), string adoxioLcrbbusinessjobnumber = default(string), string _adoxioApplicantidValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statuscode = default(int?), int? adoxioSecuritystatus = default(int?), string adoxioEstablishmentparcelid = default(string), string adoxioName = default(string), string _modifiedbyValue = default(string), long? versionnumber = default(long?), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioCompletedon = default(System.DateTimeOffset?), int? statecode = default(int?), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioCorporatehistorysummarySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioCorporatehistorysummaryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioCorporatehistorysummaryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioCorporatehistorysummaryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioCorporatehistorysummaryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMaccount adoxioApplicantId = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMadoxioApplication adoxioApplicationId = default(MicrosoftDynamicsCRMadoxioApplication))
        {
            AdoxioBcregistriesnumber = adoxioBcregistriesnumber;
            this._owninguserValue = _owninguserValue;
            Overriddencreatedon = overriddencreatedon;
            AdoxioCorporatehistorysummaryid = adoxioCorporatehistorysummaryid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._adoxioApplicationidValue = _adoxioApplicationidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owningteamValue = _owningteamValue;
            this._createdbyValue = _createdbyValue;
            AdoxioLcrbbusinessjobnumber = adoxioLcrbbusinessjobnumber;
            this._adoxioApplicantidValue = _adoxioApplicantidValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Modifiedon = modifiedon;
            Statuscode = statuscode;
            AdoxioSecuritystatus = adoxioSecuritystatus;
            AdoxioEstablishmentparcelid = adoxioEstablishmentparcelid;
            AdoxioName = adoxioName;
            this._modifiedbyValue = _modifiedbyValue;
            Versionnumber = versionnumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdon = createdon;
            AdoxioCompletedon = adoxioCompletedon;
            Statecode = statecode;
            Importsequencenumber = importsequencenumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioCorporatehistorysummarySyncErrors = adoxioCorporatehistorysummarySyncErrors;
            AdoxioCorporatehistorysummaryDuplicateMatchingRecord = adoxioCorporatehistorysummaryDuplicateMatchingRecord;
            AdoxioCorporatehistorysummaryDuplicateBaseRecord = adoxioCorporatehistorysummaryDuplicateBaseRecord;
            AdoxioCorporatehistorysummaryAsyncOperations = adoxioCorporatehistorysummaryAsyncOperations;
            AdoxioCorporatehistorysummaryBulkDeleteFailures = adoxioCorporatehistorysummaryBulkDeleteFailures;
            AdoxioApplicantId = adoxioApplicantId;
            AdoxioApplicationId = adoxioApplicationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_bcregistriesnumber")]
        public string AdoxioBcregistriesnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_corporatehistorysummaryid")]
        public string AdoxioCorporatehistorysummaryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicationid_value")]
        public string _adoxioApplicationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lcrbbusinessjobnumber")]
        public string AdoxioLcrbbusinessjobnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicantid_value")]
        public string _adoxioApplicantidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_securitystatus")]
        public int? AdoxioSecuritystatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishmentparcelid")]
        public string AdoxioEstablishmentparcelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_completedon")]
        public System.DateTimeOffset? AdoxioCompletedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_corporatehistorysummary_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioCorporatehistorysummarySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_corporatehistorysummary_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioCorporatehistorysummaryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_corporatehistorysummary_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioCorporatehistorysummaryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_corporatehistorysummary_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioCorporatehistorysummaryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_corporatehistorysummary_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioCorporatehistorysummaryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ApplicantId")]
        public MicrosoftDynamicsCRMaccount AdoxioApplicantId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ApplicationId")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioApplicationId { get; set; }

    }
}
