
public class Rootobject
{
    public string? name { get; set; }
    public string? slug { get; set; }
    public string? image { get; set; }
    public int? id { get; set; }
    public string? description { get; set; }
    public Experience[]? experiences { get; set; }
}

public class Experience
{
    public string? name { get; set; }
    public string? slug { get; set; }
    public string? image { get; set; }
    public string? description { get; set; }
}

