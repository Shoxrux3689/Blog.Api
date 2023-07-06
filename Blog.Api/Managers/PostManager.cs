using Blog.Api.Entities;
using Blog.Api.Managers.Interfaces;
using Blog.Api.Models;
using Blog.Api.Repositories.Interfaces;
using Mapster;

namespace Blog.Api.Managers
{
    public class PostManager : IPostManager
    {
        private readonly IPostRepository _postRepository;

        public PostManager(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task CreatePost(CreatePostModel createPost)
        {
            var post = createPost.Adapt<Post>();

            await _postRepository.CreatePost(post);
        }

        public async Task DeletePost(long postId)
        {
            var post = await _postRepository.GetPost(postId);

            if (post == null)
                throw new Exception("Post is not found");

            await _postRepository.DeletePost(post);
        }

        public async Task<PostModel?> GetPost(long postId)
        {
            var post = await _postRepository.GetPost(postId);
            var postModel = post?.Adapt<PostModel>();

            return postModel;
        }

        public async Task<List<PostModel>?> GetPosts()
        {
            var posts = await _postRepository.GetPosts();
            var postsModel = posts.Adapt<List<PostModel>>();
            return postsModel;
        }

        public async Task UpdatePost(UpdatePostModel updatePost)
        {
            var post = await _postRepository.GetPost(updatePost.Id);
            post = updatePost.Adapt<Post>();
            await _postRepository.UpdatePost(post);
        }

    }
}
