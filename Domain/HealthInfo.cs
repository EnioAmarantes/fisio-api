namespace Domain;

public class HealthInfo
{
    private EBlood? _bloodType { get; set; }
    public string BloodType
    {
        get => _bloodType?.ToBloodString() ?? "Unknown";
        set => _bloodType = EBloodExtensions.FromBloodString(value);
    }
    public IList<string> Allergies { get; set; }
    public int Height { get; set; } = 0;
    public int Weight { get; set; } = 0;
    public IList<string> Medications { get; set; } = new List<string>();

    public HealthInfo(string bloodType, IList<string> allergies, IList<string> medications)
    {
        BloodType = bloodType;
        Allergies = allergies;
        Medications = medications;
    }
}

public enum EBlood
{
    A_POSITIVE = 1,
    A_NEGATIVE = 2,
    B_POSITIVE = 3,
    B_NEGATIVE = 4,
    AB_POSITIVE = 5,
    AB_NEGATIVE = 6,
    O_POSITIVE = 7,
    O_NEGATIVE = 8
}

public static class EBloodExtensions
{
    public static string ToBloodString(this EBlood blood)
    {
        return blood switch
        {
            EBlood.A_POSITIVE => "A+",
            EBlood.A_NEGATIVE => "A-",
            EBlood.B_POSITIVE => "B+",
            EBlood.B_NEGATIVE => "B-",
            EBlood.AB_POSITIVE => "AB+",
            EBlood.AB_NEGATIVE => "AB-",
            EBlood.O_POSITIVE => "O+",
            EBlood.O_NEGATIVE => "O-",
            _ => "Unknown"
        };
    }

    public static EBlood FromBloodString(string bloodString)
    {
        return bloodString switch
        {
            "A+" => EBlood.A_POSITIVE,
            "A-" => EBlood.A_NEGATIVE,
            "B+" => EBlood.B_POSITIVE,
            "B-" => EBlood.B_NEGATIVE,
            "AB+" => EBlood.AB_POSITIVE,
            "AB-" => EBlood.AB_NEGATIVE,
            "O+" => EBlood.O_POSITIVE,
            "O-" => EBlood.O_NEGATIVE,
            _ => throw new ArgumentException("Invalid blood type string.", nameof(bloodString))
        };
    }
}