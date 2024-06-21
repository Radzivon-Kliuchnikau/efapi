namespace efapi.Entities;

public class VideoGame
{
    public string Id { get; set; }

    public required string Name { get; set; }

    public string Genre { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Publisher { get; set; } = string.Empty;

    public float Rating { get; set; }

    public required List<Platform> Platforms { get; set; }
}
