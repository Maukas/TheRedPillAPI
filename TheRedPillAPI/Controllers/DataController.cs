using DataModels.DataModels;
using Microsoft.AspNetCore.Mvc;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheRedPillAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        public DataController (IDataService dataservice )
        {
            _dataservice = dataservice;
        }

        private IDataService _dataservice;

        [HttpPost("anonymousdata")]
        public IActionResult PostAnonymousData(AnonymousSessionDataModel sessiondata)
        {
            _dataservice.AddAnonymousSessionData(sessiondata);
            return Ok();
        }
    }

}
