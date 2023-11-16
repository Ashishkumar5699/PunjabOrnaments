using APIServices.Data;
using APIServices.DTOs;
using APIServices.Entities;
using APIServices.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace APIServices.Controllers
{
    [AllowAnonymous]
    public class AccountController : BaseApiController
    {
        public AccountController(DataContext context, ITokenService tokenService) : base(context, tokenService)
        {
        }
        #region APIs
        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            try
            {
                if (await UserExist(registerDto.UserName)) return BadRequest("Username is taken");
                using var hmac = new HMACSHA512();

                var user = new AppUser
                {
                    UserName = registerDto.UserName.ToLower(),
                    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                    PasswordSalt = hmac.Key
                };
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return new UserDto
                {
                    UserName = registerDto.UserName,
                    Token = _tokenService.CreateToken(user)
                };


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == loginDto.Username);

            if (user == null) return Unauthorized("invalid username");
            using var hmac = new HMACSHA512(user.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i]) return Unauthorized("invalid Password");
            }

            return new UserDto
            {
                UserName = loginDto.Username,
                Token = _tokenService.CreateToken(user),
                LoginTime = DateTime.Now,
                Device = "Mobile"
            };
        }

        #endregion

        #region Methods
        private async Task<bool> UserExist(string username)
        {
            try
            {
                var result = await _context.Users.AnyAsync(x => x.UserName == username.ToLower());
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion
    }
}
