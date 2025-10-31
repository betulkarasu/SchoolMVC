namespace projects.Models;

public class SchoolModel
{
    public string StdName { get; set; }

    public string StdLastName { get; set; }

    public bool IsPassed { get; set; }

    public int SectionCount { get; set; }

    public string SectionName { get; set; }

    public string SectionCode { get; set; }

    public string InstructorName { get; set; }

    public bool Assignments { get; set; }

    public string Class { get; set; }

    public int Credit { get; set; }

    public string ProgramDays { get; set; }

    public bool Deadline { get; set; }

    public string LastDeadline { get; set; }

    public double GPA { get; set; }

    public bool IsGraduated { get; set; }

}