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
        public ActionResult Index()
        {
            ViewBag.Student = _studentService.Get(3);
            return View();
        }
    }
}