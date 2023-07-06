namespace Blog.Api.Models;

public class UpdatePostModel
{

    public long Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public string? FilePath { get; set; }
    public List<string> Tags { get; set; }
}
