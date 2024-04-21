using System.ComponentModel.DataAnnotations;

public class Position
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    public ICollection<Worker> Workers { get; set; }
}
