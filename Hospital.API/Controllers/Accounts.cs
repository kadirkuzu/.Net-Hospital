using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Hospital.Models;
using Hospital.Models.Hospital.RequestDto.Account;
using Hospital.Models.Common;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Cryptography;

namespace Hospital.API.Controllers
{
    [Route("api/account/{accountType}")]
    [ApiController]
    public class Accounts : ControllerBase
    {
        private readonly UserManager<HospitalUser> _userManager;
        private readonly SignInManager<HospitalUser> _signInManager;

        public Accounts(UserManager<HospitalUser> userManager, SignInManager<HospitalUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register(AccountType accountType, [FromBody] RegisterRequestDto model)
        {
            var user = new HospitalUser { UserName = model.Email, Email = model.Email };
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
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
            Jwt jwt = new();
            if (result.Succeeded){
                var token = jwt.GenerateJwtToken(model.Email);
                return Ok(token);
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
            await _signInManager.SignOutAsync();
            return Ok(new { Message = "Logout successful" });
        }
    }
    public record LoginWithToken(string Token);
    public class Jwt
    {
        private byte[] secretKey;

        public Jwt()
        {
            // Güvenli bir şekilde rastgele bir anahtar oluştur
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] key = new byte[32]; // 256 bit
                rng.GetBytes(key);
                secretKey = key;
            }
        }

        public string GenerateJwtToken(string email)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("1AB31F0D7191A87E94313FF7703E8CFC614C2214B87D6142DB3F65D60A4E8536");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name, email)
            }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);

            return jwtToken;
        }

        public ClaimsPrincipal DecodeJwtToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("1AB31F0D7191A87E94313FF7703E8CFC614C2214B87D6142DB3F65D60A4E8536")),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            };

            SecurityToken validatedToken;
            var principal = tokenHandler.ValidateToken(token, validationParameters, out validatedToken);

            return principal;
        }
    }

}
