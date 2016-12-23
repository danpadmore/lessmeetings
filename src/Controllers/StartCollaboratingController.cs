using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LessMeetings.Models.StartCollaborating;

namespace LessMeetings.Controllers
{
    public class StartCollaboratingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(StartCollaboratingRequest request)
        {
            return RedirectToAction(nameof(ConfirmCollaborationController.Index), "ConfirmCollaboration");
        }
    }
}
