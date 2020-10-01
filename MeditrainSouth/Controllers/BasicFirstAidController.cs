using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeditrainSouth.Controllers
{
    public class BasicFirstAidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
