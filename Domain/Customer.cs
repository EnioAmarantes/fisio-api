namespace Domain;

public class Customer : Base
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public ContactInfo ContactInfo { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public Address Address { get; set; }
    public EMaritalStatus MaritalStatus { get; set; } = EMaritalStatus.Single;
    public EGender Sex { get; set; } = EGender.OTHER;
    public Ensurance? Ensurance { get; set; }

    public Customer() : base()
    {
        Code = Guid.NewGuid().ToString();
        Address = new Address();
        ContactInfo = new ContactInfo();
    }

    public Customer(string name) : base()
    {
        Code = Guid.NewGuid().ToString();
        Name = name;
        Address = new Address();
        ContactInfo = new ContactInfo();
    }
}