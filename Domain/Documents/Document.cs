namespace Domain;

public abstract class Document
{
    private readonly EPersonType _personType;

    protected Document(EPersonType personType)
    {
        _personType = personType;
    }

    protected string DocumentCode { get; set; } = string.Empty;

    protected virtual bool Validate()
    {
        return !string.IsNullOrEmpty(DocumentCode);
    }

}

public enum EPersonType
{
    Person = 1,
    Organization = 2,
    Government = 3,
    Other = 4
}