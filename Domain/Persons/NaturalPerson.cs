using Domain.Documents;

namespace Domain.Persons;

public class NaturalPerson : Person
{
    public Document? RG { get; set; }

    public NaturalPerson() : base(EPersonType.Person)
    {
        Document = new CPF();
        RG = new RG();
    }
}