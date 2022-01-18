using System.ComponentModel.DataAnnotations;

namespace ProjectTI.Data;

public class Employee
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public int Salary { get; set; }
    public int Boost { get; set; }
    public int Bonuses { get; set; }
    public int Retentions { get; set; }

    public int TotalSalary => Salary + Salary * Boost / 100;
}
