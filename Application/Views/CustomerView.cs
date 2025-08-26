using Domain;

namespace Application.Views;

public record CustomerView
{
    public int Id { get; init; }
    public string Code { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string WhatsAppNumber { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public EGender Gender { get; init; }
    public EMaritalStatus MaritalStatus { get; init; }
    public DateTime? BirthDate { get; init; }
    public AddressView Address { get; init; } = new();
    public ContactInfoView ContactInfo { get; init; } = new();
}