using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;


namespace FirstGridProject.Controllers
{
    public class SimulationController : Controller
    {
        public IActionResult SimulationView()
        {
            return View();
        }

        public JsonResult RunSimulation()
        {
            var value = GetRunTime();
            return Json(value); 
        }

        public double GetRunTime()
        {
            return 2.345;
        }
    }
}