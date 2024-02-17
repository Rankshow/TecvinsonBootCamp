namespace TecvinsonBootCamp.Core.Entities
{
    public class Mentor : Common 
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty; 
        public string Phone { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string AreaOfSpecializations { get; set; } = string.Empty;
        public int CohortId { get; set; }
        public Cohort? Cohort { get; set; }
    }
}
