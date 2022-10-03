using EmployeeApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult GetAllInfo()
        {
            List<EmployeeDetails> listemp = EmployeeDetails.GetEmployeeDetails();
            return View(listemp);

        }
        public IActionResult GetInfo()
        {
            EmployeeDetails emp = new EmployeeDetails() { EmpId=5, EmpFirstName="sobana", EmpLastName="Babu", EmpGender="female" };
           

            return View(emp);


        }

        public IActionResult Insert()
        {

            return View();
        }

    }

}