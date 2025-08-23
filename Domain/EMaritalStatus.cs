using System.ComponentModel;

namespace Domain;

public enum EMaritalStatus
{
    [Description("Single")]
    Single = 1,
    [Description("Married")]
    Married = 2,
    [Description("Divorced")]
    Divorced = 3,
    [Description("Widowed")]
    Widowed = 4,
    [Description("Separated")]
    Separated = 5,
    [Description("Other")]
    Other = 6
}