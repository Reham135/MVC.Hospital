

namespace Hospital.DAL
{
    public interface IUnitOfWork
    {
        public IDoctorRepo DoctorsRepo { get;  }
        public IPatientsRepo PatientsRepo { get;  }

        public IIssuesRepo IssuesRepo { get;  }

        int SaveChanges();
    }
}
