namespace Domain;

public abstract class Person
{
    private EPersonType _personType;

    protected Person(EPersonType personType)
    {
        _personType = personType;
    }
    protected Document Document { get; set; }

    public virtual string GetDocumentCode()
    {
        return Document?.ToString() ?? string.Empty;
    }
}