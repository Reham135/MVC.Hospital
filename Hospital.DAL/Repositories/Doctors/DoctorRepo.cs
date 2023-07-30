using Microsoft.EntityFrameworkCore;

namespace Hospital.DAL;
public class DoctorRepo : GenericRepo<Doctor>, IDoctorRepo
{
    HospitalContext _context;
    public DoctorRepo(HospitalContext context) : base(context)
    {
        _context = context;
    }

    public Doctor? GetByIdWithPatientsIssues(Guid id)
    
        {
            return _context.Set<Doctor>()
                .Include(d => d.Patients)
                .ThenInclude(p => p.Issues)
                .FirstOrDefault(d => d.Id == id);
        }
    

    public IEnumerable<Doctor> GetByPeroformance(int rate)
    {
        return _context.Set<Doctor>().Where(d => d.PerformanceRate > rate);
    }
}
        

 