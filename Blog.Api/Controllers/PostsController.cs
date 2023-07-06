using Blog.Api.Managers.Interfaces;
using Blog.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class PostsController : ControllerBase
{
    private readonly IPostManager _postManager;
    public PostsController(IPostManager postManager) 
    {
        _postManager = postManager;
    }

    [HttpGet]
    public async Task<IActionResult> GetPosts()
    {
        return Ok(await _postManager.GetPosts());
    }

    [HttpGet("{postId}")]
    public async Task<IActionResult> GetPost(long postId)
    {
        return Ok(await _postManager.GetPost(postId));
    }

    [HttpPost]
    public async Task<IActionResult> AddPost(CreatePostModel createPost)
    {
        await _postManager.CreatePost(createPost);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdatePostModel updatePost)
    {
        await _postManager.UpdatePost(updatePost);
        return Ok();
    }
}
