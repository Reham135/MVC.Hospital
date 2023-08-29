

namespace Hospital.BL;

public class PatientEditVM
{
    public Guid ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid DoctorId { get; set; }
    public List<Guid> IssuesId { get; set; } = new();
}
