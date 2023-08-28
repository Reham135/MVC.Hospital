using Hospital.DAL;
namespace Hospital.BL
{
    public class PatientDetailsVM
    {
        
        public string Name { get; set; } = string.Empty;
        public Doctor Doctor { get; set; } = null!;
        public IEnumerable<IssueChildVM> Issues { get; set; }
    }
}





public class IssueChildVM
{
    public string Name { get; set; } = string.Empty;
    public int NumberOfIssues { get; set; }
}



