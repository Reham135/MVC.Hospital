using Hospital.DAL;
namespace Hospital.BL
{
    public class PatientDetailsVM
    {
        
        public string Name { get; set; } = string.Empty;
        public Doctor Doctor { get; set; } = null!;
        public List<IssueChildVM> Issues { get; set; } = new ();
    }
}





public class IssueChildVM
{
    public string Name { get; set; } = string.Empty;
    public int NumberOfIssues { get; set; }
}



