using Domain;

namespace Application.Requests;

public record CustomerRequest
{
    public string Name { get; init; } = string.Empty;
    public ContactInfoRequest ContactInfo { get; init; } = new();
    public DateTime? DateOfBirth { get; init; }
    public AddressRequest Address { get; init; } = new();
    public EMaritalStatus MaritalStatus { get; init; } = EMaritalStatus.Other;
    public EGender Sex { get; init; } = EGender.OTHER;
    public string EnsuranceName { get; init; } = string.Empty;
}