
using Microsoft.EntityFrameworkCore;

namespace Hospital.DAL
{
    public interface IPatientsRepo:IGenericRepo<Patient>
    {

        //Specific Methods
         Patient? GetByIdWithDoctorIssues(Guid id);
         Patient? GetByIdWithIssues(Guid id);
        
            
    }
}
