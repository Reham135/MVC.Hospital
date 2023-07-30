
using Microsoft.EntityFrameworkCore;

namespace Hospital.DAL
{
    public class PatientsRepo:GenericRepo<Patient>,IPatientsRepo  
    {
        private readonly HospitalContext _context;

        public PatientsRepo(HospitalContext context):base(context) 
        {
            _context = context;
        }

       

        public Patient? GetByIdWithDoctorIssues(Guid id)

        {
            return _context.Set<Patient>()
                .Include(p => p.Doctor)
                .Include(p => p.Issues)
                .FirstOrDefault(p => p.Id == id);
        }
    }
}
