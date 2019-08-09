using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace TheRedPillAPI.Controllers
{
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        public UserController(UserService userservice)
        {
            _userService = userservice;
        }
        private UserService _userService;
        [HttpGet]
        [Route("/one")]
        public IActionResult GetOne()
        {
            return Ok(_userService.GetOne());
        }
    }
}
