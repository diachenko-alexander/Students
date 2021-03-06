﻿using BLL.Interfaces;
using System.Web.Mvc;

namespace PLMVC.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
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