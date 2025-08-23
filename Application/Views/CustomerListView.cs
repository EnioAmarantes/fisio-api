namespace Application.Views;

public record CustomerListView
{
    public int Id { get; init; }
    public string Code { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public string Sex { get; init; } = string.Empty;
    public DateTime? DateOfBirth { get; init; }
    public string PhoneNumber { get; init; } = string.Empty;
    public string CPF { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
}