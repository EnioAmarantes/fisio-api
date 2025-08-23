using Domain.Documents;

namespace Domain.Persons;

public class LegalPerson : Person
{
    public string IE { get; set; } = string.Empty;
    public string IM { get; set; } = string.Empty;

    public LegalPerson() : base(EPersonType.Organization)
    {
        Document = new CNPJ();
        IE = string.Empty;
        IM = string.Empty;
    }

    public LegalPerson(string cnpj, string ie, string im) : base(EPersonType.Organization)
    {
        Document = new CNPJ(cnpj); ;
        IE = ie;
        IM = im;
    }
}