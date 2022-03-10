using System.Text.Json.Serialization;

namespace Students.WebApp.Models;

public record Student
{
    [JsonPropertyName("id")]
    public int Id { get; init; }
    
    [JsonPropertyName("first_name")]
    public string FirstName { get; init; }
    
    [JsonPropertyName("last_name")]
    public string LastName { get; init; }
    
    [JsonPropertyName("faculty")]
    public string Faculty { get; init; }
}