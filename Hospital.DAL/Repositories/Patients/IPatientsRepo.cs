
namespace Hospital.DAL
{
    public interface IPatientsRepo:IGenericRepo<Patient>
    {

        //Specific Methods
        public Patient? GetByIdWithDoctorIssues(Guid id);
    }
}
