namespace SpiceCarlaSync.models
{
    public class CsvWorkerImport
    {
        public string RecordIdentifier { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Result { get; set; }
        public string DateProcessed { get; set; }

        public static string TranslateStatus(string result)
        {
            switch(result)
            {
                case "PASS":
                    return SpiceApplicationStatusEnum.Cleared.ToString();
                case "FAIL":
                    return SpiceApplicationStatusEnum.NotCleared.ToString();
                case "WITHDRAWN":
                    return SpiceApplicationStatusEnum.Withdrawn.ToString();
                default:
                    return null;
            }
        }
    }
}
