using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GroupGit.Controllers
{
    public class zeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}