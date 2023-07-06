namespace Blog.Api.Models;

public class CreatePostModel
{
    public required string Title { get; set; }
    public required string Content { get; set; }
    public string? FilePath { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    public List<string> Tags { get; set; }
    public int Views { get; set; }
    public Guid UserId { get; set; }
}
