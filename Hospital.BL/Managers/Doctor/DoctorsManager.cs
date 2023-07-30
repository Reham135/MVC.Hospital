using Hospital.BL.ViewModels;
using Hospital.DAL;

namespace Hospital.BL
{
    public class DoctorsManager : IDoctorsManager    
    {
        private readonly IUnitOfWork _unitOfWork;

        public DoctorsManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        #region Get Operations Implementation
        public IEnumerable<DoctorReadVM> GetAllAsVM()
        {
            IEnumerable<Doctor> doctorsfromDb = _unitOfWork.DoctorsRepo.GetAll();
            IEnumerable<DoctorReadVM> doctorsVM = doctorsfromDb
                .Select(d => new DoctorReadVM
                {
                    Id = d.Id,
                    Name = d.Name,
                    Specialization = d.Specialization,
                    Salary = d.Salary,
                    PerformanceRate = d.PerformanceRate,

                });
            return doctorsVM;
        }

        public DoctorReadVM? GetByIdASVM(Guid id)
        {
            Doctor? doctorfromdb = _unitOfWork.DoctorsRepo.GetById(id);
            if (doctorfromdb == null)
            {
                return null;
            }
            return new DoctorReadVM
            {
                Id = doctorfromdb.Id,
                Name = doctorfromdb.Name,
                Specialization = doctorfromdb.Specialization,
                Salary = doctorfromdb.Salary,
                PerformanceRate = doctorfromdb.PerformanceRate,
            };
        }
        public DoctorDetailsVM? GetDetails(Guid id)
        {
            Doctor? doctorFromdb = _unitOfWork.DoctorsRepo.GetByIdWithPatientsIssues(id);
            if (doctorFromdb == null) { return null; }
            return new DoctorDetailsVM
            {
                Name = doctorFromdb.Name,
                Specialization = doctorFromdb.Specialization,
                PerformanceRate = doctorFromdb.PerformanceRate,
                Patients = doctorFromdb.Patients
                .Select(p => new PatientChildVM
                {
                    Name = p.Name,
                    NumberOfIssues = p.Issues.Count
                }).ToList()
            };
        }

        #endregion


        #region CRUD OPERATIONS

        //Add
        public void AddUsingVM(DoctorAddVM doctorVM)          
        {
            var doctor = new Doctor
            {
                Id=Guid.NewGuid(),
                Name = doctorVM.Name,
                Specialization = doctorVM.Specialization,
                Salary = doctorVM.Salary,
                PerformanceRate = doctorVM.PerformanceRate

            };
            _unitOfWork.DoctorsRepo.Add(doctor);
            _unitOfWork.SaveChanges();
        }


        /*******************************************************/


        //edit (open edit form data with data)
        public DoctorEditVM? GetByIdASEditVM(Guid id)
        {
            Doctor? doctorfromdb = _unitOfWork.DoctorsRepo.GetById(id);
            if (doctorfromdb == null)
            {
                return null;
            }
            return new DoctorEditVM
            {
                Id = doctorfromdb.Id,
                Name = doctorfromdb.Name,
                Specialization = doctorfromdb.Specialization,
                Salary= doctorfromdb.Salary,
                
            };
        }
        //edit(replace old data with new data)
        public void EditUsingVM(DoctorEditVM doctorVM)
        {
            Doctor? doctor = _unitOfWork.DoctorsRepo.GetById(doctorVM.Id);
            if (doctor == null) { return; }
            doctor.Name = doctorVM.Name;
            doctor.Specialization = doctorVM.Specialization;
            doctor.Salary = doctorVM.Salary;
            //_doctorRepo.Update(doctor);// this line is useless with tracking enable
            _unitOfWork.SaveChanges();
        }

        /**********************************************************/

        //Delete
        public void Delete(Guid id)
        {
            Doctor? doctordb= _unitOfWork.DoctorsRepo.GetById(id);
            if (doctordb == null) { return; }
            _unitOfWork.DoctorsRepo.Delete(doctordb);
            _unitOfWork.SaveChanges();

        }
        #endregion
    }
}

