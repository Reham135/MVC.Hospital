
namespace Hospital.DAL
{
    public class IssuePatient
    {
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }
        public Guid IssueId { get; set; }

        public Issue? Issue { get; set; }
    }
}
