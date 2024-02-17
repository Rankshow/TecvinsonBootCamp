namespace TecvinsonBootCamp.Core.Entities
{
    public class Common
    {
        public int Id { get; set; } 
        public string CreatedBy { get; set; } = string.Empty;
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
