using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GSlate.CodingChallenge.FrontEnd.WebPage.Models;
using GSlate.CodingChallenge.BusinessLogic.Interfaces;

namespace GSlate.CodingChallenge.FrontEnd.WebPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserBusinessLogic _userBussinesLogic;
        private readonly IUserProjectBusinessLogic _userProjectBussinesLogic;

        public HomeController(ILogger<HomeController> logger, IUserBusinessLogic userBusinessLogic)
        {
            _logger = logger;
            _userBussinesLogic = userBusinessLogic;
        }

        public IActionResult Index()
        {

            ViewBag.Users = _userBussinesLogic.GetUsers();
            return View();
        }

        [HttpPost]
        public JsonResult RequestProjects(string userId)
        {
            //var jResult = new Json(OkResult);
            try
            {
                
            }
            catch
            {
               
            }
            return Json(new { success = true, data = "data"});

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
