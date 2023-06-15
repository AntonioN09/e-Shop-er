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

        [HttpGet("Logare")]
        public IActionResult Logare()
        {
            var viewModel = new UserAuthRequestDto();
            return View(viewModel);
        }

        [HttpGet("Inregistrare")]
        public IActionResult Inregistrare()
        {
            var viewModel = new UserAuthRequestDto();
            return View(viewModel);
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromForm] UserAuthRequestDto user)
        {
            await _userService.Create(user);
            return View("Inregistrare");
        }

        [HttpPost("LoginUser")]
        public IActionResult LoginUser([FromForm] UserAuthRequestDto user)
        {
            var response = _userService.Authenticate(user);
            if (response == null)
            {
                return BadRequest("Username or password is invalid!");
            }
            return View("Logare");
        }
    }
}
