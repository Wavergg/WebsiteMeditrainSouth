using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeditrainSouth.Controllers
{
    public class WorksafeGuidanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
