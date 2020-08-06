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
            //Validation code - need serverside validation for all data.
            Student stu = new Student();
            //populates each property
            stu.FullName = form["full_name"];
            stu.DateOfBirth = Convert.ToDateTime(form["dob"]);
            stu.PhoneNumber = form["phone_number"];
            stu.EmailAddress = form["email"];

            //add to database.
            ViewData["Added"] = stu.FullName + "Was added to the Database!";

            return View();
        }

        [HttpGet]
        public IActionResult AddWithBinding()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddWithBinding(Student s)
        {
            if(ModelState.IsValid)//true if all validation in model passes
            {
                ViewData["Message"] = $"{s.FullName} was added";
            }

            return View();
        }
    }
}
