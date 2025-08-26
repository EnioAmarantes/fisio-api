namespace Application.Views;

public record ContactInfoView
{
    public string Name { get; init; } = string.Empty;
    public string PhoneNumber { get; init; } = string.Empty;
    public string GuardianName { get; init; } = string.Empty;
    public string GuardianPhone { get; init; } = string.Empty;
}