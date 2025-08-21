namespace Domain.Documents;

public class CPF : Document
{
    public CPF() : base(EPersonType.Person)
    {
    }

    public CPF(string documentCode) : base(EPersonType.Person)
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
            return $"{DocumentCode.Substring(0, 3)}.{DocumentCode.Substring(3, 3)}.{DocumentCode.Substring(6, 3)}-{DocumentCode.Substring(9, 2)}";
        }
        return String.Empty;
    }
}