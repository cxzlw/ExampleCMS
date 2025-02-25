﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CMS.Controllers
{
    public class RecordController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TimeTable()
        {
            return View();
        }

        public IActionResult Assessments()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TestForm(Models.TestResult sm)
        {
            ViewBag.subject = sm.subject;
            ViewBag.grade = sm.grade;

            return View("Assessments");
        }
    }
}

