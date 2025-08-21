namespace Domain.Documents;

public class RG : Document
{
    public RG() : base(EPersonType.Person)
    {
    }

    public RG(string documentCode) : base(EPersonType.Person)
    {
        DocumentCode = new string(documentCode.Where(char.IsDigit).ToArray());
    }

    protected override bool Validate()
    {
        return !string.IsNullOrEmpty(DocumentCode) && DocumentCode.All(char.IsDigit);
    }

    public override string ToString()
    {
        if (Validate())
        {
            return $"{DocumentCode.Substring(0, 2)}.{DocumentCode.Substring(2, 3)}.{DocumentCode.Substring(5, 3)}-{DocumentCode.Substring(8, 1)}";
        }
        return string.Empty;
    }
}