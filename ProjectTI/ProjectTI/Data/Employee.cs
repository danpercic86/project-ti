using System.ComponentModel.DataAnnotations;

namespace ProjectTI.Data;

public class Employee
{
    [Display(Name = "Nr. crt")] public string Id { get; set; }
    [Display(Name = "Prenume")] public string FirstName { get; set; }
    [Display(Name = "Nume")] public string LastName { get; set; }
    [Display(Name = "Funcție")] public string Position { get; set; }
    [Display(Name = "Salar de bază")] public int Salary { get; set; }
    [Display(Name = "Spor")] public float Boost { get; set; }
    [Display(Name = "Premii brute")] public int Bonuses { get; set; }
    [Display(Name = "Rețineri")] public int Retentions { get; set; }
}
