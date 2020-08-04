using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsAndModelBinding.Models;

namespace ModelsAndModelBinding.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet] //When user navs to URL
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost] //Call method AFTER user submits form data.

        public IActionResult Add(IFormCollection form)
        {
            Student stu = new Student();
            //populates each property
            stu.FullName = form["full_name"];
            stu.DateOfBirth = Convert.ToDateTime(form["dob"]);
            stu.PhoneNumber = form["phone_number"];
            stu.EmailAddress = form["email"];
            return View();
        }
    }
}
