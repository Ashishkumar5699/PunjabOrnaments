using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PunjabOrnamentsAPI.Data;
using PunjabOrnamentsAPI.DTOs;
using PunjabOrnamentsAPI.Entities;
using PunjabOrnamentsAPI.Interface;
using System.Security.Cryptography;
using System.Text;

namespace PunjabOrnamentsAPI.Controllers
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
                Username = registerDto.UserName,
                Token = _tokenService.CreateToken(user)
            };
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
                Username = loginDto.Username,
                Token = _tokenService.CreateToken(user)
            };
        }

        #endregion

        #region Methods
        private async Task<bool> UserExist(string username)
        {
            return await _context.Users.AnyAsync(x => x.UserName == username.ToLower());
        }
        #endregion
    }
}
