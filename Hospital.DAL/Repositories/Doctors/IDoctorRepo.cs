
namespace Hospital.DAL
{
    public interface IDoctorRepo:IGenericRepo<Doctor> 
    {
        IEnumerable<Doctor> GetByPeroformance(int rate);
        Doctor? GetByIdWithPatientsIssues(Guid id);


    }
}


