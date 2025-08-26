using System.Text.Json.Serialization;
using Domain;

namespace Application.Requests;

public record CustomerRequest
{
    public string Name { get; init; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string WhatsAppNumber { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ContactInfoRequest ContactInfo { get; init; } = new();
    public DateTime? BirthDate { get; init; }
    public AddressRequest Address { get; init; } = new();
    public EMaritalStatus MaritalStatus { get; init; } = EMaritalStatus.Other;
    public EGender Gender { get; init; } = EGender.Other;
    public string EnsuranceName { get; init; } = string.Empty;
}