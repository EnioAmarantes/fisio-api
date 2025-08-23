namespace Application.Views;

public record ContactInfoView
{
    public string CPF { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string PhoneNumber { get; init; } = string.Empty;
    public string WhatsAppNumber { get; init; } = string.Empty;

    public string FatherName { get; init; } = string.Empty;
    public string MotherName { get; init; } = string.Empty;
    public string Education { get; init; } = string.Empty;
}