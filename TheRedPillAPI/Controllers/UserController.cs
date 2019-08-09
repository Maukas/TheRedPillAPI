using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels.DataModels;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.IServices;

namespace TheRedPillAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public UserController(IUserService userservice)
        {
            _userService = userservice;
        }
        private IUserService _userService;

        [HttpGet("one")]
        public IActionResult GetOne()
        {
            return Ok(_userService.GetOne());
        }
   
        [HttpPost("create")]
        public IActionResult CreateOne([FromBody]UserModel userModel)
        {
            if (userModel == null)
            {
                throw new ArgumentNullException("userModel");
            }
            _userService.CreateOne(userModel.GAccountMail);
            return Ok();
        }
    }
}
