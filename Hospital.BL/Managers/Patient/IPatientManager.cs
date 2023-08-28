
namespace Hospital.BL
{
    public interface IPatientManager
    {
        IEnumerable<PatientReadVM> GetAllAsVM();
        PatientDetailsVM? GetDetails(Guid id);

        void AddUsingVM(PatientAddVM patientVM);
        void Delete(Guid id);
        PatientEditVM? GetPatientByIdASEditVM(Guid id);
        void EditUsingVM(PatientEditVM patientVM);
    }
}
