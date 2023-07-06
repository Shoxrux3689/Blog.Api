using Blog.Api.Entities;
using Blog.Api.Models;

namespace Blog.Api.Managers.Interfaces;

public interface IPostManager
{
    public Task<PostModel?> GetPost(long postId);
    public Task<List<PostModel>?> GetPosts();
    public Task CreatePost(CreatePostModel createPost);
    public Task UpdatePost(UpdatePostModel updatePost);
    public Task DeletePost(long postId);

}
