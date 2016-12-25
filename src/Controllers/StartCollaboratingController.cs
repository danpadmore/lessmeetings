using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LessMeetings.Models.StartCollaborating;
using LessMeetings.Models.CollaborationStatus;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace LessMeetings.Controllers
{
    public class StartCollaboratingController : Controller
    {
        private readonly ILogger _logger;

        public StartCollaboratingController(ILogger<StartCollaboratingController> logger)
        {
            if(logger == null) throw new ArgumentNullException(nameof(logger));
            
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(StartCollaboratingRequest request)
        {
            if(!ModelState.IsValid)
                return View(request);

            _logger.LogInformation("Received StartCollaboratingRequest");
            _logger.LogInformation(request.Title);

            var model = new CollaborationStatusViewModel();
            TempData["model"] = JsonConvert.SerializeObject(model);
            _logger.LogInformation(JsonConvert.SerializeObject(model));

            return RedirectToAction(nameof(CollaborationStatusController.Index), "CollaborationStatus");
        }
    }
}
