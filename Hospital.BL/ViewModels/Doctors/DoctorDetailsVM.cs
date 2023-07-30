

namespace Hospital.BL
{
    public class DoctorDetailsVM
    {
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public int PerformanceRate { get; set; }
        public List<PatientChildVM>Patients { get; set; } = new();
    }
    


    public class PatientChildVM
    {
        public string Name { get; set; } = string.Empty;
        public int NumberOfIssues { get; set; }
    }
}
