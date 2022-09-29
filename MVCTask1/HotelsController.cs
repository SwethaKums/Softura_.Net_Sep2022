using Microsoft.AspNetCore.Mvc;
using SampleApp.Models;

namespace SampleApp.Controllers
{
    public class HotelsController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return ("List of Hotels");
        }
        public IActionResult AnandhaBavan()
        {
            return View();
        }

        public IActionResult CopperKitchen( int dishid ,string dishname)
        {
            ViewData["dishid"]="The dishid is " + dishid;
            ViewData["dishname"]="The dish name is "+ dishname;
            return View();
        }
        public IActionResult Palmshore()
        {
            Palm palm = new Palm() { Dishid=1, DishName="FriedRice", Dishrate=200 };
            return View("Restaurant",palm);
        } 
    }
}
