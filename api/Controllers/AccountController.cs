using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using api.Dtos.Account;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;

[Route("api/account")]
[ApiController]
public class AccountController(
    UserManager<AppUser> userManager,
    ITokenService tokenService,
    SignInManager<AppUser> signInManager
) : ControllerBase
{
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

            var createdUser = await userManager.CreateAsync(appUser, registerDto.Password);

            if (!createdUser.Succeeded) return StatusCode(500, createdUser.Errors);

            var roleResult = await userManager.AddToRoleAsync(appUser, "User");

            return !roleResult.Succeeded
                ? StatusCode(500, roleResult.Errors)
                : Ok(
                    new NewUserDto
                    {
                        Username = appUser.UserName ?? "No name",
                        Email = appUser.Email ?? "No email",
                        Token = tokenService.CreateToken(appUser) ?? ""
                    });
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var user = await userManager.Users.FirstOrDefaultAsync(u => u.UserName == loginDto.Username);

        if (user == null) return Unauthorized();

        var result = await signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

        if (
            !result.Succeeded
            || user.UserName == null
            || user.Email == null
        ) return Unauthorized("Username or password is incorrect");

        return Ok(
            new NewUserDto
            {
                Username = user.UserName,
                Email = user.Email,
                Token = tokenService.CreateToken(user) ?? ""
            }
        );
    }
}