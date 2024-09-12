using System.ComponentModel.DataAnnotations;

namespace Fantasy.Common.Entities;

public class Country
{
    [Key]
    public int Id { get; set; }

    [MaxLength(100)]
    [Required]
    public string Name { get; set; } = null!;
}

