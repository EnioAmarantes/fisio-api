namespace Domain;

public class ContactInfo
{
    public string CPF { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string WhatsAppNumber { get; set; } = string.Empty;

    public string FatherName { get; set; } = string.Empty;
    public string MotherName { get; set; } = string.Empty;
    public string Education { get; set; } = string.Empty;

    public ContactInfo(string email, string phoneNumber, string whatsAppNumber)
    {
        Email = email;
        PhoneNumber = phoneNumber;
        WhatsAppNumber = whatsAppNumber;
    }

    public ContactInfo()
    {
    }
}