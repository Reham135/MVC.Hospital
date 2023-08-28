
using Hospital.DAL;
namespace Hospital.BL
{
    public class PatientAddVM
    {
        public string Name { get; set; } = string.Empty;
        public Guid DoctorId { get; set; }
        public List<Guid> IssuesId { get; set; } = new();



    }
}