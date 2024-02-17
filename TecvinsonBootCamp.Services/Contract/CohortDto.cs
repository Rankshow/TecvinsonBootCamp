namespace TecvinsonBootCamp.Services.Contract
{
    public class CohortDto
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
