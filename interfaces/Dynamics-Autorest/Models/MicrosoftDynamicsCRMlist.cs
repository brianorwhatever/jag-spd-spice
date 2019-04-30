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
    /// list
    /// </summary>
    public partial class MicrosoftDynamicsCRMlist
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMlist class.
        /// </summary>
        public MicrosoftDynamicsCRMlist()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMlist class.
        /// </summary>
        public MicrosoftDynamicsCRMlist(bool? type = default(bool?), string _owningbusinessunitValue = default(string), int? membertype = default(int?), string listname = default(string), int? createdfromcode = default(int?), string processid = default(string), string traversedpath = default(string), string query = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string _modifiedonbehalfbyValue = default(string), string _owninguserValue = default(string), string _modifiedbyValue = default(string), int? statuscode = default(int?), int? statecode = default(int?), string _createdbyValue = default(string), string _owneridValue = default(string), object exchangerate = default(object), bool? lockstatus = default(bool?), System.DateTimeOffset? lastusedon = default(System.DateTimeOffset?), string stageid = default(string), bool? donotsendonoptout = default(bool?), string _owningteamValue = default(string), object cost = default(object), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string listid = default(string), object costBase = default(object), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), int? membercount = default(int?), int? importsequencenumber = default(int?), string description = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string purpose = default(string), string _transactioncurrencyidValue = default(string), string source = default(string), bool? ignoreinactivelistmembers = default(bool?), long? versionnumber = default(long?), IList<MicrosoftDynamicsCRMcampaign> campaignlistAssociation = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMlead> listleadAssociation = default(IList<MicrosoftDynamicsCRMlead>), IList<MicrosoftDynamicsCRMcontact> listcontactAssociation = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMaccount> listaccountAssociation = default(IList<MicrosoftDynamicsCRMaccount>), IList<MicrosoftDynamicsCRMcampaignactivity> campaignactivitylistAssociation = default(IList<MicrosoftDynamicsCRMcampaignactivity>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMannotation> listAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMconnection> listConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkoperation> listBulkOperations = default(IList<MicrosoftDynamicsCRMbulkoperation>), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMduplicaterecord> listDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsyncerror> listSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMconnection> listConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMasyncoperation> listAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMduplicaterecord> listDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMbulkdeletefailure> listBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Type = type;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Membertype = membertype;
            Listname = listname;
            Createdfromcode = createdfromcode;
            Processid = processid;
            Traversedpath = traversedpath;
            Query = query;
            Createdon = createdon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owninguserValue = _owninguserValue;
            this._modifiedbyValue = _modifiedbyValue;
            Statuscode = statuscode;
            Statecode = statecode;
            this._createdbyValue = _createdbyValue;
            this._owneridValue = _owneridValue;
            Exchangerate = exchangerate;
            Lockstatus = lockstatus;
            Lastusedon = lastusedon;
            Stageid = stageid;
            Donotsendonoptout = donotsendonoptout;
            this._owningteamValue = _owningteamValue;
            Cost = cost;
            Modifiedon = modifiedon;
            Listid = listid;
            CostBase = costBase;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Membercount = membercount;
            Importsequencenumber = importsequencenumber;
            Description = description;
            Overriddencreatedon = overriddencreatedon;
            Purpose = purpose;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Source = source;
            Ignoreinactivelistmembers = ignoreinactivelistmembers;
            Versionnumber = versionnumber;
            CampaignlistAssociation = campaignlistAssociation;
            ListleadAssociation = listleadAssociation;
            ListcontactAssociation = listcontactAssociation;
            ListaccountAssociation = listaccountAssociation;
            CampaignactivitylistAssociation = campaignactivitylistAssociation;
            StageidProcessstage = stageidProcessstage;
            ListAnnotation = listAnnotation;
            Ownerid = ownerid;
            Createdonbehalfby = createdonbehalfby;
            Owningteam = owningteam;
            ListConnections2 = listConnections2;
            Owninguser = owninguser;
            ListBulkOperations = listBulkOperations;
            Owningbusinessunit = owningbusinessunit;
            Modifiedonbehalfby = modifiedonbehalfby;
            ListDuplicateBaseRecord = listDuplicateBaseRecord;
            Transactioncurrencyid = transactioncurrencyid;
            ListSyncErrors = listSyncErrors;
            Modifiedby = modifiedby;
            ListConnections1 = listConnections1;
            ListAsyncOperations = listAsyncOperations;
            ListDuplicateMatchingRecord = listDuplicateMatchingRecord;
            ListBulkDeleteFailures = listBulkDeleteFailures;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public bool? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "membertype")]
        public int? Membertype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listname")]
        public string Listname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdfromcode")]
        public int? Createdfromcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lockstatus")]
        public bool? Lockstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastusedon")]
        public System.DateTimeOffset? Lastusedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "donotsendonoptout")]
        public bool? Donotsendonoptout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cost")]
        public object Cost { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listid")]
        public string Listid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cost_base")]
        public object CostBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "membercount")]
        public int? Membercount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ignoreinactivelistmembers")]
        public bool? Ignoreinactivelistmembers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignlist_association")]
        public IList<MicrosoftDynamicsCRMcampaign> CampaignlistAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listlead_association")]
        public IList<MicrosoftDynamicsCRMlead> ListleadAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listcontact_association")]
        public IList<MicrosoftDynamicsCRMcontact> ListcontactAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listaccount_association")]
        public IList<MicrosoftDynamicsCRMaccount> ListaccountAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignactivitylist_association")]
        public IList<MicrosoftDynamicsCRMcampaignactivity> CampaignactivitylistAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> ListAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "list_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> ListConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_BulkOperations")]
        public IList<MicrosoftDynamicsCRMbulkoperation> ListBulkOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ListDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> ListSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "list_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> ListConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> ListAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> ListDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "List_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> ListBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
