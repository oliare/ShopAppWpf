using System.ComponentModel.DataAnnotations;

public class City
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }

    public ICollection<Shop> Shops { get; set; }
}
