using System.Text.Json.Serialization;

namespace Application.Requests;

public record ContactInfoRequest
{
    [JsonPropertyName("cpf")]
    public string CPF { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string WhatsAppNumber { get; set; } = string.Empty;

    public string FatherName { get; set; } = string.Empty;
    public string MotherName { get; set; } = string.Empty;
    public string Education { get; set; } = string.Empty;

}