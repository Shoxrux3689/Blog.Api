using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class PostsController : ControllerBase
{
    public PostsController() 
    {

    }

    [HttpGet]
    public async Task<IActionResult> GetPosts()
    {
        return Ok();
    }

    [HttpGet("{postId}")]
    public async Task<IActionResult> GetPost(long postId)
    {
        return Ok();
    }

    public async Task<IActionResult> AddPost()
    {
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update(long postId)
    {
        return Ok();
    }
}
