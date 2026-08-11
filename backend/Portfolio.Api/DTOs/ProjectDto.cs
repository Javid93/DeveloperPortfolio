namespace Portfolio.Api.DTOs;

public class ProjectDto
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Technologies { get; set; } = string.Empty;

    public string GithubUrl { get; set; } = string.Empty;

    public string? LiveUrl { get; set; }

    public string? ImageUrl { get; set; }

    public int DisplayOrder { get; set; }
}