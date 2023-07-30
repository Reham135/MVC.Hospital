using Hospital.DAL;

namespace Hospital.BL
{
    public class PatientReadVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;
        public ICollection<Issue> Issues { get; set; } = new List<Issue>();
    }
}
