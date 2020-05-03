using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PLWebApiMVC.Controllers
{
    public class ValuesController : ApiController
    {
        private IStudentService _studentService;

        public ValuesController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET api/values
        [Route("api/Values/Get")]
        public IHttpActionResult Get()
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
