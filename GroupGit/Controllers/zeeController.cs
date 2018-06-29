using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupGit.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroupGit.Controllers
{
    public class zeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IndexModel indexModel)
        {
            return RedirectToAction("Index");
        }
    }
}