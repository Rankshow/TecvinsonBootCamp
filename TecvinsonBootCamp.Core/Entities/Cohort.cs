namespace TecvinsonBootCamp.Core.Entities
{
    public class Cohort : Common
    {
        public string Name { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public DateTime StartDate {  get; set; } 
        public DateTime EndDate { get; set; }  
        public string Status { get; set; } = string.Empty;
    }
}
  