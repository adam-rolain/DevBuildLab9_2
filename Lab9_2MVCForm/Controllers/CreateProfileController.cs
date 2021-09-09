using Lab9_2MVCForm.Models;
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

        public IActionResult CreateProfile(Profile profile)
        {
            ViewData["NoFirstName"] = "";
            ViewData["NoLastName"] = "";
            return View(profile);
        }

        public IActionResult MyPage(Profile profile)
        {
            if (profile.FirstName == null || profile.LastName == null)
            {
                if (profile.FirstName == null)
                {
                    ViewData["NoFirstName"] = "You must input a First Name before submitting the form";
                }
                if (profile.LastName == null)
                {
                    ViewData["NoLastName"] = "You must input a Last Name before submitting the form";
                }
                return View("CreateProfile", profile);
            }
            else
            {
                return View(profile);
            }
        }
    }
}
