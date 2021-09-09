using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab9_2MVCForm.Controllers
{
    public class CreateProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateProfile()
        {
            return View();
        }

        public IActionResult MyPage(string firstName, string lastName)
        {
            ViewData["FirstName"] = firstName;
            ViewData["LastName"] = lastName;

            return View();
        }
    }
}
