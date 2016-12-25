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
    public class CollaborationStatusController : Controller
    {
        private readonly ILogger _logger;

        public CollaborationStatusController(ILogger<StartCollaboratingController> logger)
        {
            if(logger == null) throw new ArgumentNullException(nameof(logger));
            
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = JsonConvert.DeserializeObject<CollaborationStatusViewModel>(TempData["model"].ToString());

            _logger.LogInformation("Redirected to CollaborationStatusController");
            _logger.LogInformation(TempData["model"].ToString());

            return View(model);
        }
    }
}
