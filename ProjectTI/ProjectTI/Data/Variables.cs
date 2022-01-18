using System.ComponentModel.DataAnnotations;

namespace ProjectTI.Data;

public class Variables
{
    public string Id { get; set; }

    [Required]
    [Range(0, 100, ErrorMessage = "Valoarea poate fi între 0 și 100")]
    public int Cas { get; set; }

    [Required]
    [Range(0, 100, ErrorMessage = "Valoarea poate fi între 0 și 100")]
    public int Cass { get; set; }

    [Required]
    [Range(0, 10000, ErrorMessage = "Valoarea poate fi între 0 și 10000")]
    public int Tax { get; set; }
}
