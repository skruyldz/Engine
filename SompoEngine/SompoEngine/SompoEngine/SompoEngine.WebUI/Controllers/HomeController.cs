using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SompoEngine.BusinessLogic.Abstract;
using SompoEngine.Models;

namespace SompoEngine.WebUI.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IRequestResponseService _serviceCall;
        public HomeController(IRequestResponseService serviceCall)
        {
            _serviceCall = serviceCall;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ServiceCall()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> Send(ServiceCall request)
        {
            request.Results = (await _serviceCall.SendServiceCall(request)).Data;
            return Json(await RenderViewAsync("_showResponse",request)); 
        }
    }
}
