using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SompoEngine.BusinessLogic.Abstract;

namespace SompoEngine.WebUI.Controllers
{
    public class HistoryController : BaseController
    {
        private readonly IRequestResponseService _serviceCall;
        public HistoryController(IRequestResponseService serviceCall)
        {
            _serviceCall = serviceCall;
        }
        public async Task<IActionResult> Index()
        { 
            return View((await _serviceCall.GetAllServiceCall()).Data);
        }
        public async Task<JsonResult> GetRequest(string dataId)
        {
            return Json(await _serviceCall.GetRequestJson(Convert.ToInt32(dataId)));
        }
        public async Task<JsonResult> GetResponse(string dataId)
        {
            return Json(await _serviceCall.GetResponseJson(Convert.ToInt32(dataId)));
        }
    }
}
