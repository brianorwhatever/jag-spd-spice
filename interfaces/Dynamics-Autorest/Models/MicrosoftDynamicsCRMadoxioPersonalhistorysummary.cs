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
    /// adoxio_personalhistorysummary
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioPersonalhistorysummary
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPersonalhistorysummary class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPersonalhistorysummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioPersonalhistorysummary class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioPersonalhistorysummary(string _adoxioContactidValue = default(string), int? statecode = default(int?), string _adoxioWorkeridValue = default(string), string adoxioBirthlastname = default(string), string _owningbusinessunitValue = default(string), string adoxioEmail = default(string), string adoxioBirthmiddlename = default(string), string adoxioName = default(string), string adoxioPhonenumber = default(string), string adoxioFirstname = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioEstablishmentname = default(string), System.DateTimeOffset? adoxioCompletedon = default(System.DateTimeOffset?), string adoxioResidenceaddresscity = default(string), string adoxioDriverslicencenumber = default(string), string _modifiedbyValue = default(string), int? utcconversiontimezonecode = default(int?), string adoxioMiddlename = default(string), string _createdbyValue = default(string), string _owningteamValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string adoxioLastname = default(string), int? adoxioGender = default(int?), string adoxioAssociatejobnumber = default(string), string _createdonbehalfbyValue = default(string), int? statuscode = default(int?), string adoxioResidenceaddressprovincecountry = default(string), System.DateTimeOffset? adoxioExpirydate = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? adoxioBirthdate = default(System.DateTimeOffset?), bool? adoxioSameasapplyingperson = default(bool?), string adoxioFullname = default(string), int? adoxioLegalentityname = default(int?), string adoxioResidenceaddresspostalcode = default(string), string adoxioBirthfirstname = default(string), int? timezoneruleversionnumber = default(int?), int? adoxioSecuritystatus = default(int?), string adoxioResidenceaddressstreet = default(string), string _adoxioLegalentityidValue = default(string), long? versionnumber = default(long?), string adoxioWorkerjobnumber = default(string), string _adoxioApplicationidValue = default(string), int? adoxioComplete = default(int?), int? importsequencenumber = default(int?), string _owninguserValue = default(string), string adoxioPersonalhistorysummaryid = default(string), string adoxioLicenceorjobnumber = default(string), string adoxioOtherlastnames = default(string), string adoxioEstablishmentparcelid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioPersonalhistorysummarySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioPersonalhistorysummaryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioPersonalhistorysummaryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> adoxioPersonalhistorysummarySharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioPersonalhistorysummaryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioPersonalhistorysummaryBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioApplication adoxioApplicationid = default(MicrosoftDynamicsCRMadoxioApplication), IList<MicrosoftDynamicsCRMadoxioLegalentity> adoxioAdoxioPersonalhistorysummaryAdoxioLegalentityCorrespondingPersonalHistorySummary = default(IList<MicrosoftDynamicsCRMadoxioLegalentity>), MicrosoftDynamicsCRMcontact adoxioContactid = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMadoxioLegalentity adoxioLegalEntityId = default(MicrosoftDynamicsCRMadoxioLegalentity), MicrosoftDynamicsCRMadoxioWorker adoxioWorkerId = default(MicrosoftDynamicsCRMadoxioWorker))
        {
            this._adoxioContactidValue = _adoxioContactidValue;
            Statecode = statecode;
            this._adoxioWorkeridValue = _adoxioWorkeridValue;
            AdoxioBirthlastname = adoxioBirthlastname;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioEmail = adoxioEmail;
            AdoxioBirthmiddlename = adoxioBirthmiddlename;
            AdoxioName = adoxioName;
            AdoxioPhonenumber = adoxioPhonenumber;
            AdoxioFirstname = adoxioFirstname;
            Modifiedon = modifiedon;
            AdoxioEstablishmentname = adoxioEstablishmentname;
            AdoxioCompletedon = adoxioCompletedon;
            AdoxioResidenceaddresscity = adoxioResidenceaddresscity;
            AdoxioDriverslicencenumber = adoxioDriverslicencenumber;
            this._modifiedbyValue = _modifiedbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioMiddlename = adoxioMiddlename;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            AdoxioLastname = adoxioLastname;
            AdoxioGender = adoxioGender;
            AdoxioAssociatejobnumber = adoxioAssociatejobnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statuscode = statuscode;
            AdoxioResidenceaddressprovincecountry = adoxioResidenceaddressprovincecountry;
            AdoxioExpirydate = adoxioExpirydate;
            Createdon = createdon;
            AdoxioBirthdate = adoxioBirthdate;
            AdoxioSameasapplyingperson = adoxioSameasapplyingperson;
            AdoxioFullname = adoxioFullname;
            AdoxioLegalentityname = adoxioLegalentityname;
            AdoxioResidenceaddresspostalcode = adoxioResidenceaddresspostalcode;
            AdoxioBirthfirstname = adoxioBirthfirstname;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioSecuritystatus = adoxioSecuritystatus;
            AdoxioResidenceaddressstreet = adoxioResidenceaddressstreet;
            this._adoxioLegalentityidValue = _adoxioLegalentityidValue;
            Versionnumber = versionnumber;
            AdoxioWorkerjobnumber = adoxioWorkerjobnumber;
            this._adoxioApplicationidValue = _adoxioApplicationidValue;
            AdoxioComplete = adoxioComplete;
            Importsequencenumber = importsequencenumber;
            this._owninguserValue = _owninguserValue;
            AdoxioPersonalhistorysummaryid = adoxioPersonalhistorysummaryid;
            AdoxioLicenceorjobnumber = adoxioLicenceorjobnumber;
            AdoxioOtherlastnames = adoxioOtherlastnames;
            AdoxioEstablishmentparcelid = adoxioEstablishmentparcelid;
            Overriddencreatedon = overriddencreatedon;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioPersonalhistorysummarySyncErrors = adoxioPersonalhistorysummarySyncErrors;
            AdoxioPersonalhistorysummaryDuplicateMatchingRecord = adoxioPersonalhistorysummaryDuplicateMatchingRecord;
            AdoxioPersonalhistorysummaryDuplicateBaseRecord = adoxioPersonalhistorysummaryDuplicateBaseRecord;
            AdoxioPersonalhistorysummarySharePointDocumentLocations = adoxioPersonalhistorysummarySharePointDocumentLocations;
            AdoxioPersonalhistorysummaryAsyncOperations = adoxioPersonalhistorysummaryAsyncOperations;
            AdoxioPersonalhistorysummaryBulkDeleteFailures = adoxioPersonalhistorysummaryBulkDeleteFailures;
            AdoxioApplicationid = adoxioApplicationid;
            AdoxioAdoxioPersonalhistorysummaryAdoxioLegalentityCorrespondingPersonalHistorySummary = adoxioAdoxioPersonalhistorysummaryAdoxioLegalentityCorrespondingPersonalHistorySummary;
            AdoxioContactid = adoxioContactid;
            AdoxioLegalEntityId = adoxioLegalEntityId;
            AdoxioWorkerId = adoxioWorkerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contactid_value")]
        public string _adoxioContactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_workerid_value")]
        public string _adoxioWorkeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_birthlastname")]
        public string AdoxioBirthlastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_email")]
        public string AdoxioEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_birthmiddlename")]
        public string AdoxioBirthmiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phonenumber")]
        public string AdoxioPhonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_firstname")]
        public string AdoxioFirstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishmentname")]
        public string AdoxioEstablishmentname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_completedon")]
        public System.DateTimeOffset? AdoxioCompletedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_residenceaddresscity")]
        public string AdoxioResidenceaddresscity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_driverslicencenumber")]
        public string AdoxioDriverslicencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_middlename")]
        public string AdoxioMiddlename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_lastname")]
        public string AdoxioLastname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_gender")]
        public int? AdoxioGender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_associatejobnumber")]
        public string AdoxioAssociatejobnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_residenceaddressprovincecountry")]
        public string AdoxioResidenceaddressprovincecountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_expirydate")]
        public System.DateTimeOffset? AdoxioExpirydate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_birthdate")]
        public System.DateTimeOffset? AdoxioBirthdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sameasapplyingperson")]
        public bool? AdoxioSameasapplyingperson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fullname")]
        public string AdoxioFullname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_legalentityname")]
        public int? AdoxioLegalentityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_residenceaddresspostalcode")]
        public string AdoxioResidenceaddresspostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_birthfirstname")]
        public string AdoxioBirthfirstname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_securitystatus")]
        public int? AdoxioSecuritystatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_residenceaddressstreet")]
        public string AdoxioResidenceaddressstreet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_legalentityid_value")]
        public string _adoxioLegalentityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_workerjobnumber")]
        public string AdoxioWorkerjobnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicationid_value")]
        public string _adoxioApplicationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complete")]
        public int? AdoxioComplete { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummaryid")]
        public string AdoxioPersonalhistorysummaryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenceorjobnumber")]
        public string AdoxioLicenceorjobnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_otherlastnames")]
        public string AdoxioOtherlastnames { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishmentparcelid")]
        public string AdoxioEstablishmentparcelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_personalhistorysummary_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioPersonalhistorysummarySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummary_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioPersonalhistorysummaryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummary_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioPersonalhistorysummaryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummary_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> AdoxioPersonalhistorysummarySharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummary_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioPersonalhistorysummaryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_personalhistorysummary_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioPersonalhistorysummaryBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_applicationid")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioApplicationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_personalhistorysummary_adoxio_legalentity_CorrespondingPersonalHistorySummary")]
        public IList<MicrosoftDynamicsCRMadoxioLegalentity> AdoxioAdoxioPersonalhistorysummaryAdoxioLegalentityCorrespondingPersonalHistorySummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contactid")]
        public MicrosoftDynamicsCRMcontact AdoxioContactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LegalEntityId")]
        public MicrosoftDynamicsCRMadoxioLegalentity AdoxioLegalEntityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_WorkerId")]
        public MicrosoftDynamicsCRMadoxioWorker AdoxioWorkerId { get; set; }

    }
}
