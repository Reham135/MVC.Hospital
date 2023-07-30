
namespace Hospital.BL.ViewModels
{
    public class DoctorReadVM       
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public int PerformanceRate { get; set; }

    }
}











