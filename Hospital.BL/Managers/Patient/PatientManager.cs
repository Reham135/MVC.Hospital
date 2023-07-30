
using Hospital.BL.ViewModels;
using Hospital.DAL;
using System.Linq;
using System.Numerics;

namespace Hospital.BL
{
    public class PatientManager : IPatientManager
    {private readonly IUnitOfWork _unitOfWork;

        public PatientManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }




        public IEnumerable<PatientReadVM> GetAllAsVM()
        {
            IEnumerable<Patient> patientsfromDb = _unitOfWork.PatientsRepo.GetAll();
            IEnumerable<PatientReadVM> patientsVM = patientsfromDb
                .Select(p => new PatientReadVM
                {
                    Id = p.Id,
                    DoctorId = p.DoctorId,
                    Doctor = p.Doctor,
                    Name = p.Name,
                    Issues = p.Issues,

                });
            return patientsVM;
        }

      

        public PatientDetailsVM? GetDetails(Guid id)
        {
            Patient? patientFromdb = _unitOfWork.PatientsRepo.GetByIdWithDoctorIssues(id);
            if (patientFromdb == null) { return null; }
            return new PatientDetailsVM
            {
                Name = patientFromdb.Name,
                Doctor = patientFromdb.Doctor,
                Issues = patientFromdb.Issues.Select(p => new IssueChildVM
                {
                    Name = p.Name,
                    
                }).ToList()
                    

            };
        }


      



        public void AddUsingVM(PatientAddVM patientVM)
        {
            var selectedDoctor = _unitOfWork.DoctorsRepo.GetAll().FirstOrDefault(d => d.Id == patientVM.DoctorId);
            var selectedIssues = _unitOfWork.IssuesRepo.GetAll().Where(x => patientVM.IssuesId.Contains(x.Id)).ToList();

            var patient = new Patient
            {
                Id = Guid.NewGuid(),
                Name = patientVM.Name,
                DoctorId = selectedDoctor.Id,
                Issues = selectedIssues

            };
            _unitOfWork.PatientsRepo.Add(patient);
            _unitOfWork.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Patient? patientdb = _unitOfWork.PatientsRepo.GetById(id);
            _unitOfWork.PatientsRepo.Delete(patientdb);
            _unitOfWork.SaveChanges();
        }

     


    }
}
