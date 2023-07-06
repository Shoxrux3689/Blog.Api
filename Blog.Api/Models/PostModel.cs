using Blog.Api.Entities;

namespace Blog.Api.Models
{
    public class PostModel
    {
        public long Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public string? FilePath { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public List<string> Tags { get; set; }
        public User? User { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Like>? Likes { get; set; }
        public int Views { get; set; }
    }
}
