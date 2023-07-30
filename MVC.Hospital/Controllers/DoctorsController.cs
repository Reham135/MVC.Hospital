using Hospital.BL;
using Hospital.BL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.MVC.Controllers
{
    public class DoctorsController : Controller     
    {
        IDoctorsManager _doctorsManager;    

        public DoctorsController(IDoctorsManager doctorsManager)  
        {
            _doctorsManager = doctorsManager;   
        }


        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<DoctorReadVM> doctors = _doctorsManager.GetAllAsVM();
            return View(doctors);
        }



        #region Add

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(DoctorAddVM doctorAddVM)
        {if (!ModelState.IsValid) {return View();}
            _doctorsManager.AddUsingVM(doctorAddVM);
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Edit
        //Edit
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            DoctorEditVM? model = _doctorsManager.GetByIdASEditVM(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(DoctorEditVM doctorVM)
        { if (!ModelState.IsValid) {return View();}
            _doctorsManager.EditUsingVM(doctorVM);
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _doctorsManager.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        #endregion


        #region Get Details
        [HttpGet]
        public IActionResult Details(Guid id)
        {

            DoctorDetailsVM? doctorVM = _doctorsManager.GetDetails(id);
            if (doctorVM == null) { return RedirectToAction(nameof(Index)); }
            return View(doctorVM);

        }
        #endregion
    }
}
