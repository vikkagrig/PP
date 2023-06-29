using System.ComponentModel.DataAnnotations;

public class Person4
{
    [PersonNameValidator(new[] { "admin" })]
    [Required]
    [StringLength(20, MinimumLength = 2)]
    public string Name { get; set; } = "";
    [Required]
    [Range(1, 110)]
    public int Age { get; set; }
}