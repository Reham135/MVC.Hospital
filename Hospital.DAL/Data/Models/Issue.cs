namespace Hospital.DAL;
    public class Issue
    {
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
  public  ICollection<Patient> Patients { get; set; }= new List<Patient>();
    }

