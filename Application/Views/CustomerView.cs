using Domain;

namespace Application.Views;

public record CustomerView
{
    public int Id { get; init; }
    public string Code { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public EGender Sex { get; init; }
    public EMaritalStatus MaritalStatus { get; init; }
    public DateTime? DateOfBirth { get; init; }
    public AddressView Address { get; init; } = new();
    public ContactInfoView ContactInfo { get; init; } = new();
}