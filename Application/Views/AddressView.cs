namespace Application.Views;

public record AddressView
{
    public string Street { get; init; } = string.Empty;
    public string Number { get; init; } = string.Empty;
    public string Complement { get; init; } = string.Empty;
    public string Neighborhood { get; init; } = string.Empty;
    public string City { get; init; } = string.Empty;
    public string State { get; init; } = string.Empty;
    public string ZipCode { get; init; } = string.Empty;
    public string Country { get; init; } = string.Empty;
}