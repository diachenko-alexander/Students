using BLL.Interfaces;
using System.Web.Mvc;

namespace PLWebApiMVC.Controllers
{
    public class StudentsController : Controller
    {
        private IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            var allStudents = _studentService.GetAll();
            return View(allStudents);
        }

        [HttpGet]
        public ActionResult GetById(int id)
        {
            var student = _studentService.Get(id);
            return View(student);
        }

       
        public ActionResult Delete (int id)
        {
            _studentService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}