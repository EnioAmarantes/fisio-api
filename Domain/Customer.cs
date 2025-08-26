namespace Domain;

public class Customer : Base
{
    public string Name { get; set; } = string.Empty;

    public string CPF { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string WhatsAppNumber { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Guid? ContactInfoCode { get; set; }
    public ContactInfo? ContactInfo { get; set; }

    public EEducation Education { get; set; } = EEducation.None;

    public DateTime? BirthDate { get; set; }
    public Guid? AddressCode { get; set; }
    public Address? Address { get; set; }
    public EMaritalStatus MaritalStatus { get; set; } = EMaritalStatus.Single;
    public EGender Gender { get; set; } = EGender.Other;
    public Guid? EnsuranceCode { get; set; }
    public Ensurance? Ensurance { get; set; }

    public Customer() : base()
    {
        Code = Guid.NewGuid();
    }

    public Customer(string name) : base()
    {
        Code = Guid.NewGuid();
        Name = name;
    }
}