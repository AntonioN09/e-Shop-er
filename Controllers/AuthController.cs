using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EShop.Models.Enums;
using System.Data;
using EShop.Data;
using EShop.Controllers;
using EShop.Models.DTOs;
using EShop.Helpers.Attributes;
using EShop.Models;
using EShop.Services.UserServices;

namespace EShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    { 
        private IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorization(Role.Admin)]
        [HttpPost("create-user")]
        public async Task<IActionResult> CreateUser(UserAuthRequestDto user)
        {
            await _userService.Create(user);
            return Ok();
        }

        [Authorization(Role.User)]
        [HttpPost("login-user")]
        public IActionResult LoginManager(UserAuthRequestDto user)
        {
            var response = _userService.Authenticate(user);
            if (response == null)
            {
                return BadRequest("Username or password is invalid!");
            }
            return Ok(response);
        }

        [HttpGet("Logare")]
        public IActionResult Logare()
        {
            return View();
        }

        [HttpGet("Inregistrare")]
        public IActionResult Inregistrare()
        {
            return View();
        }
    }
}
