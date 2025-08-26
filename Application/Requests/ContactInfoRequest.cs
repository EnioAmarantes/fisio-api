using System.Text.Json.Serialization;

namespace Application.Requests;

public record ContactInfoRequest
{
    public string Name { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string GuardianName { get; set; } = string.Empty;
    public string GuardianPhone { get; set; } = string.Empty;
}