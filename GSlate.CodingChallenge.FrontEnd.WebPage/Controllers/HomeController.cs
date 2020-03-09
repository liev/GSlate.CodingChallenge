using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GSlate.CodingChallenge.FrontEnd.WebPage.Models;
using GSlate.CodingChallenge.BusinessLogic.Interfaces;
using Newtonsoft.Json;
using GSlate.CodingChallenge.Common.Models.ViewModels;

namespace GSlate.CodingChallenge.FrontEnd.WebPage.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly IUserBusinessLogic _userBussinesLogic;
        private readonly IUserProjectBusinessLogic _userProjectBussinesLogic;

        public HomeController(ILogger<HomeController> logger, IUserBusinessLogic userBusinessLogic, IUserProjectBusinessLogic userProjectBusinessLogic)
        {
            _logger = logger;
            _userBussinesLogic = userBusinessLogic;
            _userProjectBussinesLogic = userProjectBusinessLogic;
        }

        public IActionResult Index()
        {

            ViewBag.Users = _userBussinesLogic.GetUsers();
            return View();
        }


        /// <summary>
        /// Get projects data for Id User
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult RequestProjects(int Id)
        {
            var data = new List<UserProjectViewModel>();
            var message = string.Empty;
            
            try
            {
                // data = JsonConvert.SerializeObject(_userProjectBussinesLogic.GetUSerProjectsByUser(Id), Formatting.None, jsonSerializerSettings);
                data = _userProjectBussinesLogic.GetUSerProjectsByUser(Id);                
                return Json(data);
            }
            catch (Exception e)
            {
                 message = e.Message;
            }
            return Json(new { success = true, data = data, message = message });

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
