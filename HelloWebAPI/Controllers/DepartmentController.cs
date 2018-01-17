using HelloWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebAPI.Controllers
{
    [RoutePrefix("api/department")]
    public class DepartmentController : ApiController
    {
        // GET: api/Department
        [HttpGet]
        [Route("list")]
        public IEnumerable<Department> GetAllDepartment()
        {
            return new DepartmentRepository().GetAllDepartments();
        }
        [HttpGet]
        [Route("speciallist")]
        public IEnumerable<Department> GetValue()
        {
            return new DepartmentRepository().GetAllDepartments().Where(d => d.Budget > 50000).ToList();
        }

        // GET: api/Department/5
        public HttpResponseMessage GetDepartment(int id)
        {
            var department = new DepartmentRepository().GetAllDepartments().Where(d => d.Id == id).FirstOrDefault();
            if (department != null)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, department);
                return response;
            }
            else
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.NotFound);
                return response;
            }
        }

        // POST: api/Department
        [HttpPost]
        public HttpResponseMessage SaveDepartment(Department dept)
        {
            if (string.IsNullOrEmpty(dept.Name))
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest);
                return response;
            }
            else
            {
                //save data to database
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);
                return response;
            }
        }

        // PUT: api/Department/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Department/5
        public void Delete(int id)
        {
        }
    }
}
