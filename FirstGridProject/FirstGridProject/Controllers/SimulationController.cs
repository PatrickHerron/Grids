using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstGridProject.Controllers
{
    public class SimulationController : Controller
    {
        public IActionResult SimulationView()
        {
            return View();
        }
    }
}