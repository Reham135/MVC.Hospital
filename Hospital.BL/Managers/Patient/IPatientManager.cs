
namespace Hospital.BL
{
    public interface IPatientManager
    {
        IEnumerable<PatientReadVM> GetAllAsVM();
        //PatientReadVM? GetByIdASVM(Guid id);
        PatientDetailsVM? GetDetails(Guid id);

        //PatientEditVM? GetByIdASEditVM(Guid id);
        //void EditUsingVM(PatientEditVM patientVM);
        void AddUsingVM(PatientAddVM patientVM);
        void Delete(Guid id);
    }
}
