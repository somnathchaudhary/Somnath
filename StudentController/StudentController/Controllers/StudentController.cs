using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentController.Models;

namespace StudentController.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Student()
        {
            List<Student> stdlist = new List<Student>();
            Student user = new Student();
            user.Id = 01; user.Name = "Som"; user.fee = 1000;
            return View(user);
            
        }
    }
}