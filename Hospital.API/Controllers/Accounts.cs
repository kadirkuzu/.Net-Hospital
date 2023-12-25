using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Hospital.Models;
using Hospital.Models.Hospital.RequestDto.Account;
using Hospital.Models.Common;
using System.Security.Claims;

namespace Hospital.API.Controllers
{
    [Route("api/account/{accountType}")]
    [ApiController]
    public class Accounts : ControllerBase
    {
        private readonly UserManager<Admin> _userManager;
        private readonly SignInManager<Admin> _signInManager;

        public Accounts(UserManager<Admin> userManager, SignInManager<Admin> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register(AccountType accountType, [FromBody] RegisterRequestDto model)
        {
            var user = new Admin { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                var roleResult = await _userManager.AddToRoleAsync(user, accountType.ToString());

                if (roleResult.Succeeded)
                {
                    return Ok(new { Message = "Registration successful", Email = model.Email, Role = accountType.ToString() });
                }
                else
                {
                    return BadRequest(new { Message = "Role assignment failed", Errors = roleResult.Errors });
                }
            }
            else
            {
                return BadRequest(new { Message = "Registration failed", Errors = result.Errors });
            }

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(AccountType accountType, [FromBody] LoginRequestDto model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: false, lockoutOnFailure: false);

            if (result.Succeeded){
                return Ok(new { Message = "Login successful", Email = model.Email });
            }
            else {
                return BadRequest(new { Message = "Login failed", Errors = "Invalid login attempt" });
            }

        }

        [HttpGet("loggedId")]
        public ValueDto? GetLoggedId(AccountType accountType)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId != null)
            {
                return new ValueDto(userId) ;
            }
            else
            {
                return null;
            }
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout(AccountType accountType)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if(userId == null)
            {
                return NotFound();
            }
            await _signInManager.SignOutAsync();
            return Ok(new { Message = "Logout successful" });
        }
    }
}