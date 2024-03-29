﻿using BLL.Interfaces;
using PLWebApiMVC.Contracts.V1;
using System.Web.Http;

namespace PLWebApiMVC.Controllers
{
    public class StudentController : ApiController
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET api/values
        [Route(ApiRoutes.Students.GetAll)]
        public IHttpActionResult GetAll()
        {
            return Ok(_studentService.GetAll());
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
