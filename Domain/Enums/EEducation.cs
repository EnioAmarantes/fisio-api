using System.ComponentModel;

namespace Domain;

public enum EEducation
{
    [Description("None")]
    None = 0,
    [Description("Elementary School")]
    ElementarySchool = 1,
    [Description("High School")]
    HighSchool = 2,
    [Description("Undergraduate")]
    Undergraduate = 3,
    [Description("Postgraduate")]
    Postgraduate = 4,
    [Description("Master's Degree")]
    Masters = 5,
    [Description("Doctorate")]
    Doctorate = 6
}
