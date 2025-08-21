namespace Domain.Documents;

public class CNPJ : Document
{
    public CNPJ() : base(EPersonType.Organization)
    {
    }

    public CNPJ(string documentCode) : base(EPersonType.Organization)
    {
        DocumentCode = new string(documentCode.Where(char.IsDigit).ToArray());
    }

    protected override bool Validate()
    {
        return !string.IsNullOrEmpty(DocumentCode) && DocumentCode.Length == 14 && DocumentCode.All(char.IsDigit);
    }

    public override string ToString()
    {
        if (Validate())
        {
            return $"{DocumentCode.Substring(0, 2)}.{DocumentCode.Substring(2, 3)}.{DocumentCode.Substring(5, 3)}/{DocumentCode.Substring(8, 4)}-{DocumentCode.Substring(12, 2)}";
        }
        return string.Empty;
    }
}