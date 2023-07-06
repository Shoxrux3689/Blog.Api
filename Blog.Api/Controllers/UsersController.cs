using Blog.Api.Managers.Interfaces;
using Blog.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(CreateUserModel createUser)
        {
            await _userManager.Register(createUser);
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserModel loginUser)
        {
            var token = await _userManager.Login(loginUser);
            return Ok(token);
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            return Ok(await _userManager.GetUserWithPosts());
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> GetUserByUsername(string username)
        {
            return Ok(await _userManager.GetUserByUsername(username));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProfile(UpdateUser updateUser)
        {
            await _userManager.Update(updateUser);
            return Ok();
        }
    }
}
