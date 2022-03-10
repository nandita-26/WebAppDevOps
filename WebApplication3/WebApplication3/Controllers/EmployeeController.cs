using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class EmployeeController : ApiController
    {
        public static string i;
        public static string j;
        // GET: Employee
        public IEnumerable<string> Get()
        {
            i = "Employee1";
            j = "Employee2";

            return new string[] { i, j };
        }

        // GET api/values/5
      
    }
}