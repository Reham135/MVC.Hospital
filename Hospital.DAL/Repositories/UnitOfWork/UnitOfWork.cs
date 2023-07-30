
namespace Hospital.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HospitalContext _context;

        public IDoctorRepo DoctorsRepo  {get;}

        public IPatientsRepo PatientsRepo { get; }
        public IIssuesRepo IssuesRepo { get; }
        public UnitOfWork(HospitalContext context, IDoctorRepo doctorRepo, IPatientsRepo patientRepo,IIssuesRepo issueRepo)
        {
            _context = context;
            DoctorsRepo = doctorRepo;
            PatientsRepo=patientRepo;
            IssuesRepo=issueRepo;

        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
