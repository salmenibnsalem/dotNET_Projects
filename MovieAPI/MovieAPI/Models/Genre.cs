using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Genre
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public byte Id { get; set; }

    [MaxLength(100)]

    public required string Name { get; set; }

}