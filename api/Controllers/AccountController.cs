using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using api.Dtos.Account;
using api.Interfaces;
using api.Models;

namespace api.Controllers;

[Route("api/account")]
[ApiController]
public class AccountController : ControllerBase
{
    private readonly UserManager<AppUser> _userManager;
    
    private readonly ITokenService _tokenService;
    
    public AccountController(UserManager<AppUser> userManager, ITokenService tokenService)
    {
        _userManager = userManager;
        _tokenService = tokenService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
    {
        try
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var appUser = new AppUser
            {
                UserName = registerDto.Username,
                Email = registerDto.Email,
            };
            
            var createdUser = await _userManager.CreateAsync(appUser, registerDto.Password);

            if (!createdUser.Succeeded) return StatusCode(500, createdUser.Errors);

            var roleResult = await _userManager.AddToRoleAsync(appUser, "User");

            return !roleResult.Succeeded ? StatusCode(500, roleResult.Errors) : Ok(
                new NewUserDto
                {
                    Username = appUser.UserName ?? "No name",
                    Email = appUser.Email ?? "No email",
                    Token = _tokenService.CreateToken(appUser) ?? ""
                });
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
