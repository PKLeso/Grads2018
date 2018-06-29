using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GroupGit.Models
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {


            return Content("Hello from zees controler, this application will boom!!!");

        }
    }
}