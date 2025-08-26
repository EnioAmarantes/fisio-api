using Domain.Enums;
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

public static class EBloodExtensions
{
    public static string ToBloodString(this EBlood blood)
    {
        return blood switch
        {
            EBlood.APositive => "A+",
            EBlood.ANegative => "A-",
            EBlood.BPositive => "B+",
            EBlood.BNegative => "B-",
            EBlood.ABPositive => "AB+",
            EBlood.ABNegative => "AB-",
            EBlood.OPositive => "O+",
            EBlood.ONegative => "O-",
            _ => "Unknown"
        };
    }

    public static EBlood FromBloodString(string bloodString)
    {
        return bloodString switch
        {
            "A+" => EBlood.APositive,
            "A-" => EBlood.ANegative,
            "B+" => EBlood.BPositive,
            "B-" => EBlood.BNegative,
            "AB+" => EBlood.ABPositive,
            "AB-" => EBlood.ABNegative,
            "O+" => EBlood.OPositive,
            "O-" => EBlood.ONegative,
            _ => throw new ArgumentException("Invalid blood type string.", nameof(bloodString))
        };
    }
}