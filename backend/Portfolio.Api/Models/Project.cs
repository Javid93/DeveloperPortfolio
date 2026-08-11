namespace Portfolio.Api.Models;

public class Project
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public String Description { get; set; } = string.Empty;

    public string Technologies { get; set; } = string.Empty;

    public string GithubUrl { get; set; } = string.Empty;

    public string? LiveUrl { get; set; }

    public string? ImageUrl { get; set; }

    public int DisplayOrder { get; set; }

}