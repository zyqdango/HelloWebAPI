using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloWebAPI.Models;

namespace HelloWebAPI
{
    public class DepartmentRepository
    {
        public IEnumerable<Department> GetAllDepartments()
        {
            return new List<Department>
            {
                new Department{Id = 1, Name = "aaa", Budget = 20000},
                new Department{Id = 2, Name = "bbb", Budget = 50000},
                new Department{Id = 3, Name = "ccc", Budget = 60000},
                new Department{Id = 4, Name = "ddd", Budget = 10000}
            };
        }
    }
}