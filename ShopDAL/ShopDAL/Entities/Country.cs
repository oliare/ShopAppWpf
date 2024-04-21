using System.ComponentModel.DataAnnotations;

public class Country
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    public ICollection<City> Cities { get; set; }
}
