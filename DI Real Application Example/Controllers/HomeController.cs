using DI_Real_Application_Example.Models;
using DI_Real_Application_Example.StudentServices;
using DI_Real_Application_Example.With_Out_DI_Example_Student;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DI_Real_Application_Example.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IStudents _studentsService;

        public HomeController(IStudents studentsService)
        {
            _studentsService = studentsService;
        }

        public async Task<IActionResult> Index()
        {
            //Tightly Coupled
            SciStu stu = new  SciStu();
            ViewBag.Students = stu.GetStudentsAsync().Result;
            return View();
        }
        public async Task<IActionResult> DiIndex()
        {
            //Loose Coupling
            var students = await _studentsService.GetStudentsAsync();
            ViewBag.Students = students;
            return View();
        }

    }
}
