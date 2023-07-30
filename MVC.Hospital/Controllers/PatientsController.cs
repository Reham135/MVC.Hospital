using Hospital.BL;
using Hospital.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Hospital.MVC.Controllers
{
    public class PatientsController : Controller
    {
        IPatientManager _patientManager;
        private readonly IUnitOfWork _unitOfWork;

        public PatientsController(IPatientManager patientManager, IUnitOfWork unitOfWork)
        {
            _patientManager = patientManager;
            _unitOfWork = unitOfWork;
        }
       
        public void viewdataDoctor()
        {
            ViewData[Constants.Doctors] = _unitOfWork.DoctorsRepo.GetAll().Select(d => new SelectListItem(d.Name, d.Id.ToString())).ToList();

        }
        public void viewBagIssue()
        {
            ViewBag.Issues = _unitOfWork.IssuesRepo.GetAll().Select(d => new SelectListItem(d.Name, d.Id.ToString())).ToList();

        }


        #region Get All Patients
        [HttpGet]

        public IActionResult Index()
        {
            IEnumerable<PatientReadVM> patients = _patientManager.GetAllAsVM();
            return View(patients);
        }
        #endregion


        #region Get Patient Details

        [HttpGet]
        public IActionResult Details(Guid id)
        {

            PatientDetailsVM? patientVM = _patientManager.GetDetails(id);
            if (patientVM == null) { return RedirectToAction(nameof(Index)); }
            return View(patientVM);

        }
        #endregion


        #region Add

        [HttpGet]
        public IActionResult AddPatient()
        {
            viewdataDoctor();
            viewBagIssue();

            return View();
        }

        [HttpPost]
        public IActionResult AddPatient(PatientAddVM patientAddVM)
        {
            _patientManager.AddUsingVM(patientAddVM);
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _patientManager.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}