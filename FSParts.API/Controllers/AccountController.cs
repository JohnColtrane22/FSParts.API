using FSParts.API.DataModels;
using FSParts.API.DTOs;
using FSParts.API.Entities;
using FSParts.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FSParts.API.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly TokenService tokenService;

        public AccountController(UserManager<User> userManager, TokenService tokenService)
        {
            this.userManager = userManager;
            this.tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await userManager.FindByNameAsync(loginDto.username);
            if (user == null || !await userManager.CheckPasswordAsync(user, loginDto.password))
                return Unauthorized();
            else
            {
                return Ok(user);
            }
            //    if (user == null || !await userManager.CheckPasswordAsync(user, login.password))
            //    {
            //        return Unauthorized();
            //    }
            //    return new UserModel
            //    {
            //        Email = user.Email,
            //        Token = await tokenService.GenerateToken(user)
            //    };
            //}
            //[HttpPost("register")]
            //public async Task<ActionResult>Register(Register register)
            //{
            //    var user = new User { UserName = register.UserName, Email = register.Email };
            //    var result = await userManager.CreateAsync(user, register.Password);

            //    if (!result.Succeeded)
            //    {
            //        foreach (var error in result.Errors)
            //        {
            //            ModelState.AddModelError(error.Code, error.Description);
            //        }
            //        return ValidationProblem();
            //    }
            //    await userManager.AddToRoleAsync(user, "Member");
            //    return StatusCode(201);
        }
        [Authorize]
        [HttpGet("currentUser")]
        public async Task<ActionResult<UserModel>> GetCurrentUser()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            return new UserModel
            {
                Email = user.Email,
                Token = await tokenService.GenerateToken(user)
            };
        }
    }
}
