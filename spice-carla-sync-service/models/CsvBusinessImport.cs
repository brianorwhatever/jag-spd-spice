namespace SpiceCarlaSync.models
{
    public class CsvBusinessImport
    {
        public string LcrbBusinessJobId { get; set; }
        public string Result { get; set; }
        
        public static string? TranslateStatus(string result)
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
