using Hospital.BL.ViewModels;

namespace Hospital.BL;

public interface IDoctorsManager 
{
    IEnumerable<DoctorReadVM> GetAllAsVM();
    DoctorReadVM? GetByIdASVM(Guid id);
  
    DoctorDetailsVM? GetDetails(Guid id);

    DoctorEditVM? GetByIdASEditVM(Guid id);
    void EditUsingVM(DoctorEditVM doctorVM);
    void AddUsingVM(DoctorAddVM doctorVM);
    void Delete(Guid id);
}

